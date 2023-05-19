using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Urbiautos
{
    public partial class RegistroIngreso : Form
    {
        int ID = 0;
        DataConn dc = new DataConn();
        public RegistroIngreso()
        {
            InitializeComponent();
        }
        private void RegistroIngreso_Load(object sender, EventArgs e)
        {
            CustomLoad();
        }
        void CustomLoad()
        {
            lbl_ID.Text = getIngresoID();
            lbl_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            btnIngresar.Enabled = false;
        }
        String getIngresoID()
        {
            String IDIngreso = "";
            IDIngreso = dc.GetNextIngresoID();
            ID = Int32.Parse(IDIngreso);
            return IDIngreso;
        }
        private void PatentemaskedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        void CheckFields()
        {
            btnIngresar.Enabled = true;
            foreach (Control c in Controls)
            {
                if (c is TextBox || c is RichTextBox || c is MaskedTextBox)
                {
                    if (c.Text == "" && c.Enabled == true)
                    {
                        btnIngresar.Enabled = false;
                    }
                }
            }
        }

        private void RegistroIngreso_KeyUp(object sender, KeyEventArgs e)
        {
            CheckFields();
        }

        private void RegistroIngreso_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //DatosIngreso
            //0:patente
            //1:marca
            //2:modelo
            //3:color
            //4:nombre
            //5:telefono
            //6:desc
            //7:pronost
            List<String> DatosIngreso = new List<String>();
            foreach (Control c in Controls.Cast<Control>().OrderBy(c => c.TabIndex))
            {
                if ((c is TextBox || c is RichTextBox || c is MaskedTextBox) && (c.Tag != null && !c.Tag.Equals("IDTXB")))
                {
                    DatosIngreso.Add(c.Text);
                }
            }
            lbl_ID.Text = CustomTools.OnlyNum(lbl_ID.Text);
            dc.RegistrarIngreso(Int32.Parse(lbl_ID.Text), DatosIngreso);
            Controls.Clear();
            InitializeComponent();
            CustomLoad();
        }

        private void lbl_ID_TextChanged(object sender, EventArgs e)
        {
            lbl_ID.Text = CustomTools.OnlyNum(lbl_ID.Text);
            if (lbl_ID.Text.Length != 0)
            {
                ID = Int32.Parse(lbl_ID.Text);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            byte[] pdfBytes = Properties.Resources.FormularioRegistroAutos1;
            String fileTempPath = Application.StartupPath + "\\Formulario" + ".pdf";
            File.WriteAllBytes(fileTempPath, pdfBytes);
            string Filepath = @fileTempPath;

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
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
