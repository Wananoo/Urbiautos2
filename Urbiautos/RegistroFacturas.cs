using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Urbiautos
{
    public partial class RegistroFacturas : Form
    {
        public bool error = false;
        int total = 0;
        int cuenta = 0;
        public RegistroFacturas()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataConn DC = new DataConn();
            List<List<String>> FacturasList = DC.ConsultaFacturas();
            if (FacturasList.Count == 0)
            {
                MessageBox.Show("No se encuentran registros",
                          "Error al cargar",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                error = true;
            }
            else
            {
                foreach (List<String> Factura in FacturasList)
                {
                    //0: ID
                    //1: NFP
                    //2: NombreProv
                    //3: Fecha
                    //4: Descripcion
                    //5: Neto
                    //6: IVA
                    //7: Total
                    Button detalles = new Button();
                    detalles.Tag = Factura[0].ToString();
                    detalles.FlatStyle = FlatStyle.Flat;
                    detalles.Font = new Font("Calibri", 8.25f);
                    detalles.Size = new Size(40, 20);
                    dataGridView1.Rows.Add(Factura[0], Factura[1], Factura[2], Factura[3], Factura[4], Factura[5], Factura[6], Factura[7], detalles);
                    cuenta++;
                    total += Int32.Parse(CustomTools.OnlyNum(Factura[7]));
                }
            }
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegistroFacturas_Load(object sender, EventArgs e)
        {
            if (error)
            {
                Close();
            }
            else
            {
                lblnumero.Text = cuenta.ToString();
                lbltotal.Text = "$" + total.ToString("##,##0");
            }
        }

        private void Registros_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            Parent = null;
            e.Cancel = true;
        }

        private void RegistroFacturas_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                DetalleFactura df = new DetalleFactura(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                df.ShowDialog();
            }
        }
    }
}
