using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urbiautos
{
    public partial class Devolucion : Form
    {
        DataConn dc = new DataConn();
        int ID = 0;
        List<List<String>> ListaProductos1 = new List<List<String>>();
        List<List<String>> ListaProductos2 = new List<List<String>>();
        int Total1 = 0;
        int Total2 = 0;
        public Devolucion()
        {
            InitializeComponent();
        }

        private void Devolucion_Load(object sender, EventArgs e)
        {
            CustomLoad();
        }
        void CustomLoad()
        {
            lbl_ID.Text = getDevolucionID();
            lbl_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            PopulateProductos();
            PopulateVentas();
            UpdateProductos();
            btnIngresar.Enabled = false;
            radioButton1.Checked = true;
        }
        String getDevolucionID()
        {
            //TO DO
            String IDVenta = "";
            IDVenta = dc.GetNextDevolucionID();
            ID = Int32.Parse(IDVenta);
            return IDVenta;
        }
        void PopulateVentas()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dc.GetVentas();
            Ventascbx.DataSource = bs;
        }
        void PopulateProductos()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dc.GetProductos();
            cbx_prod.DataSource = bs;
            cbx_prod.SelectedIndex = -1;
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

        private void lbl_ID_TextChanged(object sender, EventArgs e)
        {
            lbl_ID.Text = CustomTools.OnlyNum(lbl_ID.Text);
            if (lbl_ID.Text.Length != 0)
            {
                ID = Int32.Parse(lbl_ID.Text);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AddProducto(radioButton1.Checked);
            UpdateProductos();
            cbx_prod.Focus();
        }
        void AddProducto(bool devolver)
        {
            switch (devolver)
            {
                case true:
                    {
                        List<String> NewProd = dc.GetItem(cbx_prod.Text);
                        if (NewProd.Count > 0)
                        {
                            for (int i = 1; i <= cantidadnumericupdown.Value; i++)
                            {
                                ListaProductos1.Add(NewProd);
                            }
                        }
                        break;
                    }
                case false:
                    {
                        List<String> NewProd = dc.GetItem(cbx_prod.Text);
                        if (NewProd.Count > 0)
                        {
                            for (int i = 1; i <= cantidadnumericupdown.Value; i++)
                            {
                                ListaProductos2.Add(NewProd);
                            }
                        }
                        break;
                    }
            }
        }
        void UpdateProductos()
        {
            dataGridViewprods.Rows.Clear();
            dataGridViewprods.Refresh();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            dataGridViewprods.RowTemplate.Height = 25;
            dataGridView1.RowTemplate.Height = 25;
            int itemcount = 0;
            foreach (List<String> Prod in ListaProductos1)
            {
                Button elim = new Button();
                elim.Tag = itemcount.ToString();
                elim.FlatStyle = FlatStyle.Flat;
                elim.Font = new Font("Calibri", 8.25f);
                elim.Size = new Size(40, 20);
                String Precio = (Int32.Parse(CustomTools.OnlyNum(Prod[2])) + Int32.Parse(CustomTools.OnlyNum(Prod[3]))).ToString();
                dataGridViewprods.Rows.Add(Prod[0], Prod[1], Precio, elim);
                itemcount++;
            }
            foreach (List<String> Prod in ListaProductos2)
            {
                Button elim = new Button();
                elim.Tag = itemcount.ToString();
                elim.FlatStyle = FlatStyle.Flat;
                elim.Font = new Font("Calibri", 8.25f);
                elim.Size = new Size(40, 20);
                String Precio = (Int32.Parse(CustomTools.OnlyNum(Prod[2])) + Int32.Parse(CustomTools.OnlyNum(Prod[3]))).ToString();
                dataGridView1.Rows.Add(Prod[0], Prod[1], Precio, elim);
                itemcount++;
            }
            UpdatePrecio();
            CheckIngresar();
        }
        void UpdatePrecio()
        {
            int T1 = 0;
            foreach (DataGridViewRow row in dataGridViewprods.Rows)
            {
                T1 += Int32.Parse(row.Cells[2].Value.ToString());
            }
            Total1 = T1;
            lbltotal1.Text = "$" + (Total1.ToString("##,##0"));
            int T2 = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                T2 += Int32.Parse(row.Cells[2].Value.ToString());
            }
            Total2 = T2;
            lbltotal2.Text = "$" + (Total2.ToString("##,##0"));
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

        private void Devolucion_KeyUp(object sender, KeyEventArgs e)
        {
            CheckIngresar();
        }

        private void Devolucion_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Ventascbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetFechaVenta();
        }
        void GetFechaVenta()
        {
            fechatxb.Text = dc.GetDatosVenta(Ventascbx.Text)[1].Substring(0,10);
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            DetalleVenta dv = new DetalleVenta(dc.GetDatosVenta(Ventascbx.Text)[0]);
            dv.ShowDialog();
        }
        void UpdateListSort()
        {
            ListaProductos1.Clear();
            foreach (DataGridViewRow dgvr in dataGridViewprods.Rows)
            {
                List<String> newlist = new List<string> { dgvr.Cells[0].Value.ToString(), dgvr.Cells[1].Value.ToString(), dgvr.Cells[2].Value.ToString() };
                ListaProductos1.Add(newlist);
            }
            ListaProductos2.Clear();
            foreach (DataGridViewRow dgvr in dataGridView1.Rows)
            {
                List<String> newlist = new List<string> { dgvr.Cells[0].Value.ToString(), dgvr.Cells[1].Value.ToString(), dgvr.Cells[2].Value.ToString() };
                ListaProductos2.Add(newlist);
            }
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            UpdatePrecio();
            UpdateListSort();
            List<List<String>> ListaIDProductos1 = new List<List<String>>();
            List<List<String>> ListaIDProductos2 = new List<List<String>>();
            foreach (List<String> prod in ListaProductos1)
            {
                ListaIDProductos1.Add(new List<String> { prod[0], prod[2] });
            }
            foreach (List<String> prod in ListaProductos2)
            {
                ListaIDProductos2.Add(new List<String> { prod[0], prod[2] });
            }
            List<String> ListaDatosDevolucion = new List<String>() 
            {
                //ID,IDVenta,Detalles
                ID.ToString(), dc.GetDatosVenta(Ventascbx.Text)[0], detallestxb.Text
            };
            dc.IngresarDevolucion(ListaDatosDevolucion, ListaIDProductos1, ListaIDProductos2, Total1, Total2);
            ListaProductos1.Clear();
            ListaProductos2.Clear();
            Controls.Clear();
            InitializeComponent();
            CustomLoad();
        }

        private void dataGridViewprods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                ListaProductos1.RemoveAt(e.RowIndex);
                UpdateProductos();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                ListaProductos2.RemoveAt(e.RowIndex);
                UpdateProductos();
            }
        }

        private void dataGridViewprods_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ListaProductos1[e.RowIndex][2] = dataGridViewprods.CurrentCell.Value.ToString();
            UpdatePrecio();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ListaProductos2[e.RowIndex][2] = dataGridView1.CurrentCell.Value.ToString();
            UpdatePrecio();
        }
    }
}
