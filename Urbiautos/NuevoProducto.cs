using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Urbiautos
{
    public partial class NuevoProducto : Form
    {
        DataConn dc = new DataConn();
        bool ok = false;
        public NuevoProducto()
        {
            InitializeComponent();
            mtbx_instalacion.Text = "20000";
        }

        private void txbCod_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }
        void CheckFields()
        {
            btnIngresar.Enabled = true;
            foreach (Control c in Controls)
            {
                if (c is TextBox || c is ComboBox || c is MaskedTextBox || c is RichTextBox)
                {
                    if (c.Tag.Equals("Precio") && CustomTools.OnlyNum(c.Text).Equals(""))
                    {
                        btnIngresar.Enabled = false;
                    }
                    else if (c.Tag.Equals("Text") && c.Text.Equals(""))
                    {
                        btnIngresar.Enabled = false;
                    }
                }
            }
        }
        private void richTextBoxdesc_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void NuevoProducto_KeyUp(object sender, KeyEventArgs e)
        {
            CheckFields();
        }

        private void mtbx_pcompra_TextChanged(object sender, EventArgs e)
        {
            mtbx_pciva.Text = ((int)(CustomTools.OnlyNumInt(mtbx_pcompra.Text) * 1.19)).ToString();
        }

        private void mtbx_pciva_TextChanged(object sender, EventArgs e)
        {
            mtbx_pventa.Text = (CustomTools.OnlyNumInt(mtbx_pciva.Text) * 2).ToString();
        }

        private void mtbx_pventa_TextChanged(object sender, EventArgs e)
        {
            mtbx_pinstalado.Text = (CustomTools.OnlyNumInt(mtbx_pventa.Text) + CustomTools.OnlyNumInt(mtbx_instalacion.Text)).ToString();
        }

        private void mtbx_instalacion_TextChanged(object sender, EventArgs e)
        {
            mtbx_pinstalado.Text = (CustomTools.OnlyNumInt(mtbx_pventa.Text) + CustomTools.OnlyNumInt(mtbx_instalacion.Text)).ToString();
        }

        private void NuevoProducto_Load(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            List<String> nuevoItem = new List<String>();
            nuevoItem.Add(txbCod.Text);//cod
            nuevoItem.Add(richTextBoxdesc.Text);//desc
            nuevoItem.Add(numericupdownstock.Value.ToString());//stock
            nuevoItem.Add(CustomTools.OnlyNum(mtbx_pventa.Text));//precio
            nuevoItem.Add(CustomTools.OnlyNum(mtbx_pcompra.Text));//pcompra
            nuevoItem.Add(CustomTools.OnlyNum(mtbx_instalacion.Text));//instalacion
            nuevoItem.Add(txb_familia.Text);//familia
            ok = dc.AddItem(nuevoItem);
            if (ok)
            {
                MessageBox.Show("Item ID " + txbCod.Text + " añadido exitosamente", "Exito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Controls.Clear();
                InitializeComponent();
                txbCod.Focus();
            }
        }
    }
}
