using System;
using System.Windows.Forms;

namespace Urbiautos
{
    public partial class FechaPicker : Form
    {
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public FechaPicker()
        {
            InitializeComponent();
        }

        private void FechaPicker_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Inicio = fechainiciopicker.Value;
            Fin = fechafinpicker.Value;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnSemana_Click(object sender, EventArgs e)
        {
            Inicio = DateTime.Now.AddDays(-7);
            Fin = DateTime.Now;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnMes_Click(object sender, EventArgs e)
        {
            Inicio = DateTime.Now.AddMonths(-1);
            Fin = DateTime.Now;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAnno_Click(object sender, EventArgs e)
        {
            Inicio = DateTime.Now.AddYears(-1);
            Fin = DateTime.Now;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void fechafinpicker_ValueChanged(object sender, EventArgs e)
        {
            if (fechafinpicker.Value.CompareTo(fechainiciopicker.Value) < 0)
            {
                fechafinpicker.Value = fechainiciopicker.Value;
            }
        }

        private void fechainiciopicker_ValueChanged(object sender, EventArgs e)
        {
            if (fechainiciopicker.Value.CompareTo(fechafinpicker.Value) > 0)
            {
                fechainiciopicker.Value = fechafinpicker.Value;
            }
        }

        private void FechaPicker_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
