using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Urbiautos
{
    public partial class IngresoVenta : Form
    {
        int ID = 0;
        DataConn dc = new DataConn();
        List<List<String>> ListaProductos = new List<List<String>>();
        int Total = 0;
        int pdescuento = 0;
        int totaldescuento = 0;
        public IngresoVenta()
        {
            InitializeComponent();
        }

        private void IngresoVenta_Load(object sender, EventArgs e)
        {
            CustomLoad();
        }
        void CustomLoad()
        {
            DoubleBuffered = true;
            lbl_ID.Text = getVentaID();
            PopulateMarcas();
            lbl_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txb_anno.MaxLength = 4;
            PopulateProductos();
            UpdateProductos();
            btnIngresar.Enabled = false;
            descuentolabel.Text = "0";
            chkbxpormano.Checked = true;
            checkBox1.Checked = true;
        }
        void CheckIngresar()
        {
            if (dataGridViewprods.RowCount >= 1)
            {
                btnIngresar.Enabled = true;
                CheckFields();
            }
            else
            {
                btnIngresar.Enabled = false;
            }
        }
        void PopulateMarcas()
        {
            marcacbx.Text = "";
            BindingSource bs = new BindingSource();
            marcacbx.SelectedIndex = -1;
            bs.DataSource = dc.GetMarcas();
            marcacbx.DataSource = bs;
            marcacbx.ResetText();
            marcacbx.SelectedIndex = -1;
        }
        void PopulateModelos()
        {
            if (marcacbx.SelectedIndex == -1 || marcacbx.Text.Equals(""))
            { return; }
            else
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dc.GetModelobyMarca(marcacbx.Text);
                modelocbx.DataSource = bs;
            }
            //modelocbx.ResetText();
            //modelocbx.SelectedIndex = -1;
        }
        void PopulateProductos()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dc.GetProductos();
            cbx_prod.DataSource = bs;
            cbx_prod.SelectedIndex = -1;
        }
        private void IngresoVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "VentanaMain")
                {
                    frm.Show();
                }
            }
            TopMost = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CheckIngresar();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void modelocbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckIngresar();
        }

        private void PatentemaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void PatentemaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            PatentemaskedTextBox.Text = CustomTools.OnlyChars(PatentemaskedTextBox.Text);
            if (PatentemaskedTextBox.Text.Length < 6)
            {
                btnIngresar.Enabled = false;
            }
            else
            {
                btnIngresar.Enabled = true;
            }
            CheckIngresar();
        }

        String getVentaID()
        {
            String IDVenta = "";
            IDVenta = dc.GetNextVentaID();
            ID = Int32.Parse(IDVenta);
            return IDVenta;
        }

        private void ruttxb_TextChanged(object sender, EventArgs e)
        {
            RutFix();
            CheckIngresar();
        }

        private void ruttxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            RutFix();
        }
        void RutFix()
        {
            ruttxb.Text = CustomTools.formatoRut(ruttxb.Text);
            ruttxb.SelectionStart = ruttxb.Text.Length;
            ruttxb.SelectionLength = 0;
        }

        private void marcacbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateModelos();
            CheckIngresar();
        }

        private void txb_anno_TextChanged(object sender, EventArgs e)
        {
            txb_anno.Text = CustomTools.OnlyNum(txb_anno.Text);
            CheckIngresar();
        }

        private void cbx_prod_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbx_prod_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cbx_prod_Enter(object sender, EventArgs e)
        {
            //cbx_prod.DroppedDown = true;
        }

        private void cbx_prod_Leave(object sender, EventArgs e)
        {
            //cbx_prod.DroppedDown = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AddProducto();
            UpdateProductos();
            cbx_prod.Focus();
        }
        void AddProducto()
        {
            List<String> NewProd = dc.GetItem(cbx_prod.Text);
            if (NewProd.Count > 0)
            {
                for (int i = 1; i <= cantidadnumericupdown.Value; i++)
                {
                    ListaProductos.Add(NewProd);
                }
            }
        }
        void UpdateProductos()
        {
            dataGridViewprods.Rows.Clear();
            dataGridViewprods.Refresh();
            dataGridViewprods.RowTemplate.Height = 25;
            int itemcount = 0;
            foreach (List<String> Prod in ListaProductos)
            {
                Button elim = new Button();
                elim.Tag = itemcount.ToString();
                elim.FlatStyle = FlatStyle.Flat;
                elim.Font = new Font("Calibri", 8.25f);
                elim.Size = new Size(40, 20);
                String Precio = "";
                switch (chkbxpormano.Checked)
                {
                    case true: { Precio = Prod[2]; break; }
                    case false: { Precio = (Int32.Parse(CustomTools.OnlyNum(Prod[2])) + Int32.Parse(CustomTools.OnlyNum(Prod[3]))).ToString(); break; }
                }
                dataGridViewprods.Rows.Add(Prod[0], Prod[1], Precio, elim);
                itemcount++;
            }
            UpdatePrecio();
            CheckIngresar();
        }
        void UpdatePrecio()
        {
            int PrecioTotal = 0;
            int PrecioNeto = 0;
            int PrecioIva = 0;
            foreach (DataGridViewRow row in dataGridViewprods.Rows)
            {
                PrecioTotal += Int32.Parse(row.Cells[2].Value.ToString());
            }
            PrecioNeto = PrecioTotal * 100 / 119;
            PrecioIva = PrecioTotal - PrecioNeto;
            totaldescuento = PrecioTotal * pdescuento / 100;
            PrecioTotal = PrecioTotal - totaldescuento;
            Total = PrecioTotal;
            lbltotal.Text = "$" + (PrecioTotal.ToString("##,##0"));
            lblNeto.Text = "$" + (PrecioNeto.ToString("##,##0"));
            lbliva.Text = "$" + (PrecioIva.ToString("##,##0"));
        }
        private void dataGridViewprods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                ListaProductos.RemoveAt(e.RowIndex);
                UpdateProductos();
            }
        }

        private void dataGridViewprods_Sorted(object sender, EventArgs e)
        {
            UpdateListSort();
            UpdateProductos();
        }
        void UpdateListSort()
        {
            ListaProductos.Clear();
            foreach (DataGridViewRow dgvr in dataGridViewprods.Rows)
            {
                List<String> newlist = new List<string> { dgvr.Cells[0].Value.ToString(), dgvr.Cells[1].Value.ToString(), dgvr.Cells[2].Value.ToString() };
                ListaProductos.Add(newlist);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            UpdatePrecio();
            UpdateListSort();
            List<List<String>> ListaIDProductos = new List<List<String>>();
            foreach (List<String> prod in ListaProductos)
            {
                ListaIDProductos.Add(new List<String> { prod[0], prod[2] });
            }
            List<String> ListaDatosVenta = new List<String>();
            foreach (Control c in Controls)
            {
                if ((c is TextBox || c is ComboBox || c is MaskedTextBox || c is RichTextBox) && !(c.Name.Equals("cbx_prod")))
                {
                    ListaDatosVenta.Add(c.Text);
                    /*MessageBox.Show("Agregado: " + c.Name+" , "+c.Text, "Info",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information);*/
                }
            }
            if (chkbxpormano.Checked)
            {
                dc.IngresarVenta(ListaDatosVenta, ListaIDProductos, Total, ID, "sincliente");
            }
            else if (checkBox1.Checked)
            {
                dc.IngresarVenta(ListaDatosVenta, ListaIDProductos, Total, ID, "sinvehiculo");
            }
            else
            {
                dc.IngresarVenta(ListaDatosVenta, ListaIDProductos, Total, ID, "normal");
            }
            ListaProductos.Clear();
            Controls.Clear();
            InitializeComponent();
            CustomLoad();
        }


        void CheckFields()
        {
            btnIngresar.Enabled = true;
            foreach (Control c in Controls)
            {
                if ((c is TextBox || c is ComboBox || c is MaskedTextBox) && !(c.Name.Equals("cbx_prod")))
                {
                    if (c.Text == "" && c.Enabled == true)
                    {
                        btnIngresar.Enabled = false;
                    }
                }
            }

        }

        private void modelocbx_TextChanged(object sender, EventArgs e)
        {
            CheckIngresar();
        }

        private void marcacbx_TextChanged(object sender, EventArgs e)
        {
            CheckIngresar();
        }

        private void nombreclientetxb_TextChanged(object sender, EventArgs e)
        {
            CheckIngresar();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxTelefono_TextChanged(object sender, EventArgs e)
        {
            //maskedTextBoxTelefono.Text = CustomTools.OnlyNum(maskedTextBoxTelefono.Text);
            CheckIngresar();
        }

        private void correotxb_TextChanged(object sender, EventArgs e)
        {
            CheckIngresar();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            CheckIngresar();
        }

        private void PatentemaskedTextBox_Leave(object sender, EventArgs e)
        {
            List<String> VehiculoFill = dc.GetVehiculo(PatentemaskedTextBox.Text);
            if (!VehiculoFill[0].Equals(""))
            {
                marcacbx.Text = VehiculoFill[0];
                modelocbx.Text = VehiculoFill[1];
                txb_anno.Text = VehiculoFill[2];
                ruttxb.Focus();
            }
        }

        private void ruttxb_Leave(object sender, EventArgs e)
        {
            List<String> ClienteFill = dc.GetCliente(ruttxb.Text);
            if (!ClienteFill[0].Equals(""))
            {
                nombreclientetxb.Text = ClienteFill[0];
                maskedTextBoxTelefono.Text = ClienteFill[1];
                correotxb.Text = ClienteFill[2];
                cbx_prod.Focus();
            }
        }

        private void btn_ExplorarItems_Click(object sender, EventArgs e)
        {
            InventarioSearch invs = new InventarioSearch();
            var result = invs.ShowDialog();
            if (result == DialogResult.OK)
            {
                cbx_prod.Text = invs.SelectedItem;
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void lbliva_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewprods_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ListaProductos[e.RowIndex][2] = dataGridViewprods.CurrentCell.Value.ToString();
            UpdatePrecio();
        }

        private void txbdcto_TextChanged(object sender, EventArgs e)
        {
            txbdcto.Text = CustomTools.OnlyNum(txbdcto.Text);
            if (!txbdcto.Text.Equals(""))
            {
                if (Int32.Parse(txbdcto.Text) > 100)
                {
                    txbdcto.Text = "100";
                }
                pdescuento = Int32.Parse(txbdcto.Text);
            }
            else
            {
                pdescuento = 0;
            }
            UpdatePrecio();
            descuentolabel.Text = totaldescuento.ToString();
            CheckIngresar();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void txbdcto_Leave(object sender, EventArgs e)
        {
            if (txbdcto.Text.Equals(""))
            {
                txbdcto.Text = "0";
            }
            CheckIngresar();
        }
        private void chkbxpormano_CheckedChanged(object sender, EventArgs e)
        {
            CxbChanged();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CxbChanged();
        }
        void CxbChanged()
        {
            if (checkBox1.Checked)
            {
                foreach (Control c in Controls)
                {
                    if (!(c.Tag == null || c.Tag.Equals("Perma") || c.Tag.Equals("Cliente")))
                    {
                        c.Enabled = false;
                    }
                }
                CheckIngresar();
            }
            else
            {
                foreach (Control c in Controls)
                {
                    if (c.Tag == null || c.Tag.Equals("Vehiculo"))
                    {
                        c.Enabled = true;
                    }
                }
                CheckIngresar();
            }
            if (chkbxpormano.Checked)
            {
                foreach (Control c in Controls)
                {
                    if (!(c.Tag == null || c.Tag.Equals("Perma") || c.Tag.Equals("Vehiculo")))
                    {
                        c.Enabled = false;
                    }
                }
                CheckIngresar();
            }
            else
            {
                foreach (Control c in Controls)
                {
                    if (c.Tag == null || c.Tag.Equals("Cliente"))
                    {
                        c.Enabled = true;
                    }
                }
                CheckIngresar();
            }
            UpdateProductos();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckIngresar();
        }
    }
}
