using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Urbiautos
{
    public partial class Registros : Form
    {
        public bool error = false;
        int total = 0;
        int totalcash = 0;
        int cuenta = 0;
        public Registros()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataConn DC = new DataConn();
            List<List<String>> VentasList = DC.ConsultaPatente("");
            if (VentasList.Count == 0)
            {
                MessageBox.Show("No se encuentran registros para estos datos",
                          "No hay Registros",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                error = true;
            }
            else
            {
                foreach (List<String> Venta in VentasList)
                {
                    Button detalles = new Button();
                    detalles.Tag = Venta[0].ToString();
                    detalles.FlatStyle = FlatStyle.Flat;
                    detalles.Font = new Font("Calibri", 8.25f);
                    detalles.Size = new Size(40, 20);
                    dataGridView1.Rows.Add(Venta[0], Venta[1], Venta[2], Venta[3], Venta[4], Venta[5], Venta[6], Venta[7], Venta[8], Venta[9], detalles);
                    cuenta++;
                    total += Int32.Parse(CustomTools.OnlyNum(Venta[7]));
                    if (Venta[9].Equals("Efectivo"))
                    {
                        totalcash += Int32.Parse(CustomTools.OnlyNum(Venta[7]));
                    }
                }
            }
        }
        public Registros(String Query, String Tipo)
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            DataConn DC = new DataConn();
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            List<List<String>> VentasList = new List<List<string>>();
            if (Tipo.Equals("Patente"))
            {
                VentasList = DC.ConsultaPatente(" where Patente = '" + Query + "'");
            }
            else if (Tipo.Equals("RUT"))
            {
                VentasList = DC.ConsultaPatente(" where RUT = '" + Query + "'");
            }
            else if (Tipo.Equals("Fecha"))
            {
                VentasList = DC.ConsultaPatente(" where Fecha BETWEEN '" + Query);
            }
            if (VentasList.Count == 0)
            {
                MessageBox.Show("No se encuentran registros para estos datos",
                          "No hay Registros",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                error = true;
            }
            else
            {
                foreach (List<String> Venta in VentasList)
                {
                    Button detalles = new Button();
                    detalles.Tag = Venta[0].ToString();
                    detalles.FlatStyle = FlatStyle.Flat;
                    detalles.Font = new Font("Calibri", 8.25f);
                    detalles.Size = new Size(40, 30);
                    detalles.Text = "Detalles";
                    dataGridView1.Rows.Add(Venta[0], Venta[1], Venta[2], Venta[3], Venta[4], Venta[5], Venta[6], Venta[7], Venta[8], Venta[9], detalles);
                    cuenta++;
                    total += Int32.Parse(CustomTools.OnlyNum(Venta[7]));
                    if (Venta[9].Equals("Efectivo"))
                    {
                        totalcash += Int32.Parse(CustomTools.OnlyNum(Venta[7]));
                    }
                }
            }
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            /*var list = new BindingList<List<String>>(VentaiciosList);
            dataGridView1.DataSource = list;*/
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Registros_Load(object sender, EventArgs e)
        {
            if (error)
            {
                Close();
            }
            else
            {
                lblnumero.Text = cuenta.ToString();
                lbltotal.Text = "$" + total.ToString("##,##0");
                lblcash.Text = "(Efectivo: $" + totalcash.ToString("##,##0") + ")";
            }
        }

        private void Registros_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            Parent = null;
            e.Cancel = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                DetalleVenta dv = new DetalleVenta(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                dv.ShowDialog();
            }
        }
    }
}
