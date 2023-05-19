using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Urbiautos
{
    public partial class BusquedaPatente : Form
    {
        public BusquedaPatente()
        {
            InitializeComponent();
            PatentemaskedTextBox.InsertKeyMode = InsertKeyMode.Overwrite;
            TopMost = false;
            btnIngresar.Enabled = false;
            btnbuscarRut.Enabled = false;
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            Focus();
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            Registros reg = new Registros();
            if (!reg.error) reg.Show();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ShowRegistrosPatente();
        }
        private void ShowRegistrosPatente()
        {
            Registros reg = new Registros(PatentemaskedTextBox.Text, "Patente");
            if (!reg.error) reg.Show();
        }
        private void PatentemaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PatenteOnlyChars(PatentemaskedTextBox.Text).Length < 6)
            {
                btnIngresar.Enabled = false;
            }
            else
            {
                btnIngresar.Enabled = true;
            }
        }
        String PatenteOnlyChars(String PatenteTxb)
        {
            Regex rgx = new Regex("[^a-zA-Z0-9]");
            String PatenteRgx = rgx.Replace(PatenteTxb, "");
            return PatenteRgx;
        }

        private void BusquedaPatente_FormClosing(object sender, FormClosingEventArgs e)
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

        private void ruttxb_TextChanged(object sender, EventArgs e)
        {
            RutFix();
            if (ruttxb.TextLength == 0)
            {
                btnbuscarRut.Enabled = false;
            }
            else
            {
                btnbuscarRut.Enabled = true;
            }
        }
        void RutFix()
        {
            ruttxb.Text = CustomTools.formatoRut(ruttxb.Text);
            ruttxb.SelectionStart = ruttxb.Text.Length;
            ruttxb.SelectionLength = 0;
        }

        private void btnbuscarRut_Click(object sender, EventArgs e)
        {
            ShowRegistrosRut();
        }
        void ShowRegistrosRut()
        {
            Registros reg = new Registros(ruttxb.Text, "RUT");
            if (!reg.error) reg.Show();
        }

        private void btnbuscarrangofecha_Click(object sender, EventArgs e)
        {
            DateTime fIni = default;
            DateTime fFin = default;
            FechaPicker fp = new FechaPicker();
            var result = fp.ShowDialog();
            if (result == DialogResult.OK)
            {
                fIni = fp.Inicio;
                fFin = fp.Fin;
                String query = fIni.ToString("yyyy-MM-dd") + "' and '" + fFin.AddDays(1).ToString("yyyy-MM-dd") + "'";
                Registros reg = new Registros(query, "Fecha");
                if (!reg.error) reg.Show();
            }
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            RegistroFacturas rf = new RegistroFacturas();
            if (!rf.error) rf.Show();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            ListaIngreso li = new ListaIngreso();
            if (!li.error) li.Show();
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            ListaNotas ln = new ListaNotas();
            if (!ln.error) ln.Show();
        }
    }
}
