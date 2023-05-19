using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urbiautos
{
    public partial class Contenedor : Form
    {
        DataConn dc = new DataConn();
        public static int segundos = 0;
        //BusquedaPatente vp = new BusquedaPatente();
        public Contenedor()
        {
            InitializeComponent();
            DoubleBuffered = true;
            MinimumSize = new Size(Screen.FromControl(this).WorkingArea.Width,
                Screen.FromControl(this).WorkingArea.Height);
            ShowVentanaMain();
            maintimer.Start();
            UpdateTiempo();
            //simularErrorToolStripMenuItem.Enabled = false;
            //simularErrorToolStripMenuItem.Visible = false;
            //this.ControlBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnLabel();
        }
        void ConnLabel()
        {
            switch (CheckConn())
            {
                case true: { ConexText.Text = "Urbiautos V0.5 Conectado"; ConexText.ForeColor = Color.GreenYellow; break; }
                case false: { ConexText.Text = "Urbiautos V0.5 No hay conexion"; ConexText.ForeColor = Color.DarkRed; break; }
                default: { break; }
            }
        }
        private void Contenedor_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        private void Contenedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == "Contenedor")
                {
                    continue;
                }
                frm.Hide();
            }
            const string message = "Desea cerrar el programa?";
            const string caption = "Atencion";
            if (MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question,
                                         MessageBoxDefaultButton.Button1,
                                         (MessageBoxOptions)0x40000) == DialogResult.No)
            {
                e.Cancel = true;
                foreach (Form frm in fc)
                {
                    frm.Show();
                }
            }
            else
            {
                Environment.Exit(Environment.ExitCode);
            }
        }
        bool CheckConn()
        {
            try
            {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                return false;
            }
        }
        /*protected override void OnFormClosing(FormClosingEventArgs e)
        {
            const string message = "Desea cerrar el programa?";
            const string caption = "Atencion";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question,
                                         MessageBoxDefaultButton.Button1,
                                         MessageBoxOptions.DefaultDesktopOnly);

            e.Cancel = (result == DialogResult.No);
            //this.Focus();
        }*/
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
        public static void ShowVentanaMain()
        {
            FormCollection fc = Application.OpenForms;
            bool bFormNameOpen = false;
            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "VentanaMain")
                {
                    frm.Show();
                    frm.Focus();
                    bFormNameOpen = true;
                }
            }
            if (!bFormNameOpen)
            {
                VentanaMain vm = new VentanaMain();
                vm.Show();
                vm.Focus();
            }
        }
        public static bool CloseCancel()
        {
            return true;
        }

        private void abrirBusquedaPatenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowBusquedaPatente();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void administrarClientesAutosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirVentanaPrincipalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowVentanaMain();
        }

        private void maintimer_Tick(object sender, EventArgs e)
        {
            segundos++;
            UpdateTiempo();
        }
        void UpdateTiempo()
        {
            TimeSpan transcurrido = TimeSpan.FromSeconds(segundos);
            timerlabel.Text = "Tiempo de sesion actual: " + String.Format("{0:D2}:{1:D2}:{2:D2}", transcurrido.Hours, transcurrido.Minutes, transcurrido.Seconds);
            ConnLabel();
            if (segundos - 900 % 2700 == 0)
            {
                backupAsync();
            }
        }
        async void backupAsync()
        {
            await Task.Run(() => Backup());
            if (segundos > 100)
            {
                new Thread(() =>
                {
                    MessageBox.Show("BDD respaldada", "Respaldo",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information,
                             MessageBoxDefaultButton.Button1,
                             MessageBoxOptions.DefaultDesktopOnly);
                }).Start();
            }
        }
        void Backup()
        {
            dc.Backup();
        }

        private void ConexText_Click(object sender, EventArgs e)
        {
            ConnLabel();
        }

        private void mantenedorInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMantenedorInv();
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

        private void Contenedor_Enter(object sender, EventArgs e)
        {

        }

        private void Contenedor_MouseDown(object sender, MouseEventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                //iterate through
                if (!frm.Name.Equals("Contenedor"))
                {
                    frm.Focus();
                }
            }
        }

        private void ingresarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowIngresarFactura();
        }
        public static void ShowIngresarFactura()
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

        private void respaldarBDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backupAsync();
        }

        private void Contenedor_Move(object sender, EventArgs e)
        {

        }

        private void Contenedor_Resize(object sender, EventArgs e)
        {
            //FixContenedor();
        }

        void FixContenedor()
        {
            CenterToScreen();
            //this.Location = new Point(0, 0);
        }

        private void Contenedor_DragDrop(object sender, DragEventArgs e)
        {
            FixContenedor();
        }

        private void Contenedor_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            FixContenedor();
        }

        private void Contenedor_Move_1(object sender, EventArgs e)
        {
            FixContenedor();
        }

        private void simularErrorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exception ex = new Exception();
            throw (ex);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void configurarConexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowConfig();
        }
        public static void ShowConfig()
        {
            FormCollection fc = Application.OpenForms;
            bool bFormNameOpen = false;
            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "Config")
                {
                    bFormNameOpen = true;
                }
            }
            if (!bFormNameOpen)
            {
                Config cf = new Config();
                cf.Show();

            }

        }
    }
}
