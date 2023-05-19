using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Urbiautos
{
    public partial class NotaCredito : Form
    {
        DataConn dc = new DataConn();
        int ID = 0;
        List<List<String>> ListaProductos = new List<List<String>>();
        int Neto = 0;
        public NotaCredito()
        {
            InitializeComponent();
        }
        private void NotaCredito_Load(object sender, EventArgs e)
        {

            CustomLoad();
        }
        void CustomLoad()
        {
            lbl_ID.Text = getNotaID();
            lbl_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            PopulateProductos();
            PopulateFacturas();
            UpdateProductos();
            btnIngresar.Enabled = false;
        }
        String getNotaID()
        {
            String IDVenta = "";
            IDVenta = dc.GetNextNotaID();
            ID = Int32.Parse(IDVenta);
            return IDVenta;
        }
        void PopulateFacturas()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dc.GetFacturas();
            facturasCbx.DataSource = bs;
        }
        void PopulateProductos()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dc.GetProductos();
            cbx_prod.DataSource = bs;
            cbx_prod.SelectedIndex = -1;
        }
        private void lbl_ID_TextChanged(object sender, EventArgs e)
        {
            lbl_ID.Text = CustomTools.OnlyNum(lbl_ID.Text);
            if (lbl_ID.Text.Length != 0)
            {
                ID = Int32.Parse(lbl_ID.Text);
            }
        }

        private void dataGridViewprods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                ListaProductos.RemoveAt(e.RowIndex);
                UpdateProductos();
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
            int PrecioNeto = 0;
            foreach (DataGridViewRow row in dataGridViewprods.Rows)
            {
                PrecioNeto += Int32.Parse(row.Cells[2].Value.ToString());
            }
            Neto = PrecioNeto;
            lblNeto.Text = "$" + (PrecioNeto.ToString("##,##0"));
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
                if ((c is TextBox || c is ComboBox || c is RichTextBox) && !(c.Name.Equals("cbx_prod")))
                {
                    ListaDatosVenta.Add(c.Text);
                }
            }
            dc.IngresarNota(ID, ListaDatosVenta, ListaIDProductos, Neto);
            ListaProductos.Clear();
            Controls.Clear();
            InitializeComponent();
            CustomLoad();
        }

        private void NotaCredito_KeyUp(object sender, KeyEventArgs e)
        {
            CheckIngresar();
        }

        private void NotaCredito_FormClosing(object sender, FormClosingEventArgs e)
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

        private void facturasCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<String> DatosProv = dc.GetDatosFactura(facturasCbx.Text);
            if (DatosProv.Count > 0)
            {
                nfptxb.Text = DatosProv[0];
                fechatxb.Text = DatosProv[1];
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
    }
}
