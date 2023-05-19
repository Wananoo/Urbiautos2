using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace Urbiautos
{
    public partial class DetallesNota : Form
    {
        String CurrentID = "";
        public bool error = false;
        public DetallesNota()
        {
            InitializeComponent();
        }
        public DetallesNota(String ID)
        {
            CurrentID = ID;
            InitializeComponent();
            dataGridViewprods.AutoGenerateColumns = false;
            dataGridViewprods.RowHeadersVisible = false;
            dataGridViewprods.Rows.Clear();
            dataGridViewprods.Refresh();
            DataConn DC = new DataConn();
            List<List<String>> DatosNota = DC.GetNota(ID);
            if (DatosNota.Count == 0)
            {
                MessageBox.Show("No se encuentran registros para estos datos",
                          "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                error = true;
            }
            else
            {
                //0 ID
                //1 FACT
                //2 CFP
                //3 Monto
                //4 Fecha
                //5 Desc
                lbl_ID.Text = DatosNota[0][0];
                txbFactura.Text = DatosNota[0][1];
                nfptxb.Text = DatosNota[0][2];
                fechatxb.Text = DatosNota[0][4];
                detallestxb.Text = DatosNota[0][5];
                lblNeto.Text = DatosNota[0][3]; ;
                foreach (List<String> Productos in DatosNota.Skip(1))
                {
                    dataGridViewprods.Rows.Add(Productos[0], Productos[1]);
                }
            }
        }
        private void DetallesNota_Load(object sender, EventArgs e)
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
        Bitmap bmp;
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //this.BackColor = Color.White;
            Print();
            ToCSV();
            //this.BackColor = Color.FromArgb(SystemColors.ControlDark.R, SystemColors.ControlDark.G, SystemColors.ControlDark.B);
        }
        void ToCSV()
        {
            //crear DT
            DataTable table = new DataTable();
            //columns  
            table.Columns.Add("Nota de credito", typeof(string));
            table.Columns.Add("Urbiautos", typeof(string));

            //data  
            table.Rows.Add("ID: ", CurrentID);
            table.Rows.Add("Factura: ", txbFactura.Text);
            table.Rows.Add("Fecha: ", fechatxb.Text);
            table.Rows.Add("Numero Factura: ", nfptxb.Text);
            table.Rows.Add("Detalles: ", detallestxb.Text);
            table.Rows.Add("Productos: ", "");
            table.Rows.Add("Codigo: ", "Neto");
            foreach (DataGridViewRow r in dataGridViewprods.Rows)
            {
                table.Rows.Add(r.Cells[0].Value, r.Cells[1].Value);
            }
            table.ToCSV(Application.StartupPath + "\\NotaCredito-ID" + lbl_ID.Text + ".csv");
        }
        void Print()
        {

            //Open print preview dialog
            Graphics g = CreateGraphics();
            bmp = new Bitmap(Size.Width, Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(Location.X + 6, Location.Y + 6, 0, 0, new Size(Size.Width - 12, Size.Height - 12));
            String Filepath = Application.StartupPath + "\\NotaCredito-ID" + lbl_ID.Text + ".png";
            bmp.Save(Filepath, ImageFormat.Png);
            ProcessStartInfo printProcessInfo = new ProcessStartInfo()
            {
                Verb = "",
                CreateNoWindow = true,
                FileName = Filepath,
                WindowStyle = ProcessWindowStyle.Hidden
            };

            Process printProcess = new Process();
            printProcess.StartInfo = printProcessInfo;
            printProcess.Start();
            //printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void DetallesNota_BackColorChanged(object sender, EventArgs e)
        {

        }
    }
}
