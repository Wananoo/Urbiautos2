using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Urbiautos
{
    public partial class IngresoFactura : Form
    {
        DataConn dc = new DataConn();
        int ID = 0;
        List<List<String>> ListaProductos = new List<List<String>>();
        int Total = 0;
        public IngresoFactura()
        {
            InitializeComponent();
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
                //String Precio = "";
                dataGridViewprods.Rows.Add(Prod[0], Prod[1], Prod[4], elim);
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
            PrecioNeto = PrecioTotal;
            PrecioIva = (int)(PrecioNeto * 0.19f);
            Total = PrecioNeto + PrecioIva;
            lbltotal.Text = "$" + (Total.ToString("##,##0"));
            lblNeto.Text = "$" + (PrecioNeto.ToString("##,##0"));
            lbliva.Text = "$" + (PrecioIva.ToString("##,##0"));
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

        private void IngresoFactura_Load(object sender, EventArgs e)
        {
            CustomLoad();
        }
        void CustomLoad()
        {
            lbl_ID.Text = getFacturaID();
            lbl_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            PopulateProductos();
            PopulateProveedores();
            UpdateProductos();
            btnIngresar.Enabled = false;
            descuentolabel.Text = "0";
        }
        void PopulateProveedores()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dc.GetProveedores();
            ProvCbx.DataSource = bs;
        }
        String getFacturaID()
        {
            String IDVenta = "";
            IDVenta = dc.GetNextFacturaID();
            ID = Int32.Parse(IDVenta);
            return IDVenta;
        }
        void PopulateProductos()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dc.GetProductos();
            cbx_prod.DataSource = bs;
            cbx_prod.SelectedIndex = -1;
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
                }
            }
            dc.IngresarFactura(ID, ListaDatosVenta, ListaIDProductos, Total);
            ListaProductos.Clear();
            Controls.Clear();
            InitializeComponent();
            CustomLoad();
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

        private void IngresoFactura_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dataGridViewprods_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ListaProductos[e.RowIndex][2] = dataGridViewprods.CurrentCell.Value.ToString();
            UpdatePrecio();
        }

        private void IngresoFactura_KeyUp(object sender, KeyEventArgs e)
        {
            CheckIngresar();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void rutProvCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<String> DatosProv = dc.GetDatosProveedor(ProvCbx.Text);
            if (DatosProv.Count > 0)
            {
                ruttxb.Text = DatosProv[0];
                maskedTextBoxTelefono.Text = DatosProv[1];
                correotxb.Text = DatosProv[2];
            }

        }

        private void ruttxb_TextChanged(object sender, EventArgs e)
        {
            RutFix();
            CheckIngresar();
        }
        void RutFix()
        {
            ruttxb.Text = CustomTools.formatoRut(ruttxb.Text);
            ruttxb.SelectionStart = ruttxb.Text.Length;
            ruttxb.SelectionLength = 0;
        }


        private void btnAddProv_Click(object sender, EventArgs e)
        {
            NuevoProveedor np = new NuevoProveedor();
            var result = np.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Close();
                IngresoFactura ifa = new IngresoFactura();
                ifa.Show();
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ID_TextChanged(object sender, EventArgs e)
        {
            lbl_ID.Text = CustomTools.OnlyNum(lbl_ID.Text);
            if (lbl_ID.Text.Length != 0)
            {
                ID = Int32.Parse(lbl_ID.Text);
            }
        }
    }
}
