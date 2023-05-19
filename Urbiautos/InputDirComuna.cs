using System;
using System.Windows.Forms;

namespace Urbiautos
{
    public partial class InputDirComuna : Form
    {
        public String Direccion { get; set; }
        public String Comuna { get; set; }
        DataConn dc = new DataConn();
        public InputDirComuna()
        {
            InitializeComponent();
        }

        private void InputDirComuna_Load(object sender, EventArgs e)
        {
            PopulateComunas();
        }
        void PopulateComunas()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dc.GetComunas();
            comunacbx.DataSource = bs;
            comunacbx.SelectedIndex = -1;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Direccion = Direcciontxb.Text;
            Comuna = comunacbx.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
