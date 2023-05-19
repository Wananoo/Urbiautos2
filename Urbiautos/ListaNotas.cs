using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Urbiautos
{
    public partial class ListaNotas : Form
    {
        public bool error = false;
        public ListaNotas()
        {
            InitializeComponent();
            DoubleBuffered = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataConn DC = new DataConn();
            List<List<String>> NotasList = DC.ConsultaNotas();
            if (NotasList.Count == 0)
            {
                MessageBox.Show("No se encuentran registros para estos datos",
                          "No hay Registros",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                error = true;
            }
            else
            {
                foreach (List<String> Nota in NotasList)
                {
                    //0 ID
                    //1 FACT
                    //2 CFP
                    //3 Monto
                    //4 Fecha
                    //5 Desc
                    Button detalles = new Button();
                    detalles.Tag = Nota[0].ToString();
                    detalles.FlatStyle = FlatStyle.Flat;
                    detalles.Font = new Font("Calibri", 8.25f);
                    detalles.Size = new Size(40, 20);
                    dataGridView1.Rows.Add(Nota[0], Nota[1], Nota[2], Nota[3],
                        Nota[4], Nota[5], detalles);
                }
            }
        }

        private void ListaNotas_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                DetallesNota dn = new DetallesNota(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                dn.ShowDialog();
            }
        }

        private void ListaNotas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            Parent = null;
            e.Cancel = true;
        }
    }
}
