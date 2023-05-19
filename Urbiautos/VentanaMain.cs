using System;
using System.Windows.Forms;

namespace Urbiautos
{
    public partial class VentanaMain : Form
    {
        public VentanaMain()
        {
            InitializeComponent();
            DoubleBuffered = true;
            TopMost = true;
        }
        private void btnConultar_Click(object sender, EventArgs e)
        {
            ShowBusquedaPatente();
            Hide();
        }
        public static void ShowBusquedaPatente()
        {
            FormCollection fc = Application.OpenForms;
            bool bFormNameOpen = false;
            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "BusquedaPatente")
                {
                    bFormNameOpen = true;
                }
            }
            if (!bFormNameOpen)
            {
                BusquedaPatente vp = new BusquedaPatente();
                vp.Show();

            }

        }
        //
        private void VentanaMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            TopMost = false;
        }

        private void VentanaMain_Load(object sender, EventArgs e)
        {
            Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            ShowIngresarVenta();
            Hide();
        }
        public static void ShowIngresarVenta()
        {
            FormCollection fc = Application.OpenForms;
            bool bFormNameOpen = false;
            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "IngresoVenta")
                {
                    bFormNameOpen = true;
                }
            }
            if (!bFormNameOpen)
            {
                IngresoVenta iv = new IngresoVenta();
                iv.Show();
            }

        }

        private void btnInv_Click(object sender, EventArgs e)
        {
            ShowMantenedorInv();
            Hide();
        }
        public static void ShowMantenedorInv()
        {
            FormCollection fc = Application.OpenForms;
            bool bFormNameOpen = false;
            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "Inventario")
                {
                    bFormNameOpen = true;
                }
            }
            if (!bFormNameOpen)
            {
                Inventario vp = new Inventario();
                vp.Show();

            }

        }

        private void btnIngresarFactura_Click(object sender, EventArgs e)
        {
            ShowIngresarFactura();
            Hide();
        }
        public static void ShowIngresarFactura()
        {
            FormCollection fc = Application.OpenForms;
            bool bFormNameOpen = false;
            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "IngresoFactura")
                {
                    bFormNameOpen = true;
                }
            }
            if (!bFormNameOpen)
            {
                IngresoFactura ifa = new IngresoFactura();
                ifa.Show();

            }

        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            ShowRegistrarIngreso();
            Hide();
        }
        public static void ShowRegistrarIngreso()
        {
            FormCollection fc = Application.OpenForms;
            bool bFormNameOpen = false;
            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "RegistroIngreso")
                {
                    bFormNameOpen = true;
                }
            }
            if (!bFormNameOpen)
            {
                RegistroIngreso ri = new RegistroIngreso();
                ri.Show();

            }

        }

        private void btnNotaCredito_Click(object sender, EventArgs e)
        {
            ShowNotaCredito();
            Hide();
        }
        public static void ShowNotaCredito()
        {
            FormCollection fc = Application.OpenForms;
            bool bFormNameOpen = false;
            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "NotaCredito")
                {
                    bFormNameOpen = true;
                }
            }
            if (!bFormNameOpen)
            {
                NotaCredito nc = new NotaCredito();
                nc.Show();

            }
        }

        private void bntDevolucion_Click(object sender, EventArgs e)
        {
            ShowDevolucion();
            Hide();
        }
        public static void ShowDevolucion()
        {
            FormCollection fc = Application.OpenForms;
            bool bFormNameOpen = false;
            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "Devolucion")
                {
                    bFormNameOpen = true;
                }
            }
            if (!bFormNameOpen)
            {
                Devolucion de = new Devolucion();
                de.Show();

            }
        }
    }
}
