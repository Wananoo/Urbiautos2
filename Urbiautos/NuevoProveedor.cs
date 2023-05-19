using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Urbiautos
{
    public partial class NuevoProveedor : Form
    {
        DataConn dc = new DataConn();
        public NuevoProveedor()
        {
            InitializeComponent();
        }
        bool ok = false;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NuevoProveedor_Load(object sender, EventArgs e)
        {

        }

        private void ruttxb_TextChanged(object sender, EventArgs e)
        {
            RutFix();
            CheckIngresar();
        }
        void CheckIngresar()
        {
            CheckFields();
        }
        void CheckFields()
        {
            btnIngresar.Enabled = true;
            foreach (Control c in Controls)
            {
                if ((c is TextBox || c is ComboBox || c is MaskedTextBox))
                {
                    if (c.Text == "" && c.Enabled == true)
                    {
                        btnIngresar.Enabled = false;
                    }
                }
            }
        }
        void RutFix()
        {
            ruttxb.Text = CustomTools.formatoRut(ruttxb.Text);
            ruttxb.SelectionStart = ruttxb.Text.Length;
            ruttxb.SelectionLength = 0;
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            List<String> nuevoProv = new List<String>();
            nuevoProv.Add(ruttxb.Text);//rut
            nuevoProv.Add(nombretxb.Text);//nombre
            nuevoProv.Add(direcciontxb.Text);//dir
            nuevoProv.Add(maskedTextBoxTelefono.Text);//tel
            nuevoProv.Add(correotxb.Text);//correo
            ok = dc.AddProveedor(nuevoProv);
            if (ok)
            {
                MessageBox.Show("Proveedor añadido exitosamente", "Exito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Controls.Clear();
                InitializeComponent();
            }
        }

        private void NuevoProveedor_KeyUp(object sender, KeyEventArgs e)
        {
            CheckIngresar();
        }
    }
}
