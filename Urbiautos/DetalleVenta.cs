using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Urbiautos
{
    public partial class DetalleVenta : Form
    {
        bool error = false;
        public DetalleVenta()
        {
            InitializeComponent();
        }
        public DetalleVenta(String ID)
        {
            InitializeComponent();
            dataGridViewprods.AutoGenerateColumns = false;
            dataGridViewprods.RowHeadersVisible = false;
            dataGridViewprods.Rows.Clear();
            dataGridViewprods.Refresh();
            DataConn DC = new DataConn();
            List<List<String>> DatosVenta = DC.GetVenta(ID);
            if (DatosVenta.Count == 0)
            {
                MessageBox.Show("No se encuentran registros para estos datos",
                          "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                error = true;
            }
            else
            {
                //id,fecha,desc,patente,rut,n,i,t
                lbl_ID.Text = DatosVenta[0][0];
                lbl_Fecha.Text = DatosVenta[0][1];
                richTextBox1.Text = DatosVenta[0][2];
                PatentemaskedTextBox.Text = DatosVenta[0][3];
                ruttxb.Text = DatosVenta[0][4];
                lblNeto.Text = DatosVenta[0][5];
                lbliva.Text = DatosVenta[0][6];
                lbltotal.Text = DatosVenta[0][7];
                lbldescuento.Text = DatosVenta[0][8];
                foreach (List<String> Productos in DatosVenta.Skip(1))
                {
                    dataGridViewprods.Rows.Add(Productos[0], Productos[1]);
                }
            }
        }

        private void DetalleVenta_Load(object sender, EventArgs e)
        {
            if (error)
            {
                Close();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
