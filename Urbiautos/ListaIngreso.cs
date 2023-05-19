using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Urbiautos
{
    public partial class ListaIngreso : Form
    {
        public bool error = false;
        public ListaIngreso()
        {
            InitializeComponent();
            DoubleBuffered = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataConn DC = new DataConn();
            List<List<String>> IngresosList = DC.GetRegistros();
            if (IngresosList.Count == 0)
            {
                MessageBox.Show("No se encuentran registros para estos datos",
                          "No hay Registros",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                error = true;
            }
            else
            {
                foreach (List<String> Venta in IngresosList)
                {
                    Button detalles = new Button();
                    detalles.Tag = Venta[0].ToString();
                    detalles.FlatStyle = FlatStyle.Flat;
                    detalles.Font = new Font("Calibri", 8.25f);
                    detalles.Size = new Size(40, 30);
                    detalles.Text = "Detalles";
                    dataGridView1.Rows.Add(Venta[0], Venta[1], Venta[2], Venta[3],
                        Venta[4], Venta[5], Venta[6], Venta[7], Venta[8], Venta[9]);
                }
            }
        }

        private void ListaIngreso_Load(object sender, EventArgs e)
        {
            if (error)
            {
                Close();
            }
        }

        private void ListaIngreso_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            Parent = null;
            e.Cancel = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                DetallesNota dv = new DetallesNota(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                dv.ShowDialog();
            }
        }
    }
}
