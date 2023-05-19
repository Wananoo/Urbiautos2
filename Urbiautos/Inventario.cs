using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Urbiautos
{
    public partial class Inventario : Form
    {
        public bool error = false;
        public int total = 0;
        DataConn dc = new DataConn();
        public Inventario()
        {
            InitializeComponent();
            CustomLoad();
        }
        void CustomLoad()
        {
            total = 0;
            DoubleBuffered = true;
            dataGridView1.DoubleBuffered(true);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            List<List<String>> FullItemsList = dc.GetFullProductos(" where Familia != 'Servicios' order by Stock DESC");
            List<String> FullItemsStats = dc.GetFullProductosStats(" where Familia != 'Servicios'");
            if (FullItemsList.Count == 0)
            {
                MessageBox.Show("No se encuentran registros para esta Patente",
                          "Patente no Registrada",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                error = true;
            }
            else
            {
                foreach (List<String> Item in FullItemsList)
                {
                    int PrecioInstalado = Int32.Parse(CustomTools.OnlyNum(Item[2])) + Int32.Parse(CustomTools.OnlyNum(Item[5]));
                    dataGridView1.Rows.Add(Item[0], Item[1], Item[4], Item[2], PrecioInstalado.ToString(), Item[3]);
                    total++;
                }
                lblcantidad.Text = total.ToString();
                lblcompra.Text = "$" + FullItemsStats[0];
                lblventa.Text = "$" + FullItemsStats[1];
            }

        }
        void EditInventarioNum(String Item, String Modified, String Cant)
        {
            int cantidad = Int32.Parse(CustomTools.OnlyNum(Cant));
            dc.EditInventarioNum(Item, Modified, cantidad);
        }
        void EditInventarioString(String Item, String Modified, String Cant)
        {
            dc.EditInventarioString(Item, Modified, Cant);
        }
        private void Inventario_Load(object sender, EventArgs e)
        {
            if (error)
            {
                Close();
            }
            else
            {
                lblcantidad.Text = total.ToString();
            }
        }

        private void Inventario_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bntaddprod_Click(object sender, EventArgs e)
        {
            NuevoProducto np = new NuevoProducto();
            np.ShowDialog();
            Controls.Clear();
            InitializeComponent();
            CustomLoad();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Name.Equals("Stock")
                || dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Name.Equals("PrecioCompra")
                || dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Name.Equals("PrecioVenta")
                || dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Name.Equals("Instalacion"))
            {
                EditInventarioNum
                (
                dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString(),//cod
                dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Name,//mod
                dataGridView1.CurrentCell.Value.ToString()//valor
                );
            }
            else
            {
                EditInventarioString
                (
                dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString(),//cod
                dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Name,//mod
                dataGridView1.CurrentCell.Value.ToString()//valor
                );
            }

        }

        private void filtroTxb_TextChanged(object sender, EventArgs e)
        {
            if (filtroTxb.Text != string.Empty)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (checkSequence(row.Cells[1].Value.ToString().ToLower().Trim(), filtroTxb.Text.ToLower().Trim()))
                    {
                        row.Visible = true;
                    }
                    else
                        row.Visible = false;
                }
            }
        }
        bool checkSequence(string a, string b)
        {
            if (b.Length == 0)
                return true;
            if (a.Length == 0)
                return false;
            if (a[0] == b[0])
                return checkSequence(a.Substring(1), b.Substring(1));
            else
                return checkSequence(a.Substring(1), b);
        }
    }
}
