using Microsoft.VisualBasic.Devices;
using System;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Urbiautos
{
    internal static class Program
    {

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new ThreadExceptionEventHandler(ThroH);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(ThroUH);
            Application.Run(new Contenedor());
            void ThroH(object sender, ThreadExceptionEventArgs e)
            {
                /*if (e.Exception is MySqlException || e.Exception is NotSupportedException
                    || e.Exception is IOException)
                {
                    Environment.Exit(0);
                }
                else
                {*/
                crashhan(e.Exception.ToString(), e.Exception.GetType().ToString());
                /*}*/
            }
            void ThroUH(object sender, UnhandledExceptionEventArgs e)
            {
                /*/if (e.ExceptionObject is MySqlException || e.ExceptionObject is NotSupportedException
                    || e.ExceptionObject is IOException)
                {
                    Environment.Exit(0);
                }*/
                /*else
                {*/
                crashhan(e.ExceptionObject.ToString(), e.ExceptionObject.GetType().ToString());
                /*}*/
            }
            void crashhan(String e, String t)
            {
                foreach (Form frm in Application.OpenForms)
                {
                    //iterate through
                    if (frm.Name == "VentanaMain")
                    {
                        frm.Hide();
                    }
                }
                ErrorMsj crash = new ErrorMsj(e.ToString(), t);
                crash.LogError();
                MessageBox.Show("Ha ocurrido un error inesperado, el error ha sido guardado en ErrorLog.txt", "Exception",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

    }
    public class ErrorMsj
    {
        public String ErrorStr;
        public String ExType;
        public ErrorMsj(String s, string exType)
        {
            int segs = Contenedor.segundos;
            TimeSpan TiempoTranscurrido = TimeSpan.FromSeconds(segs);
            String TiempoFormat = String.Format("{0:D2}:{1:D2}:{2:D2}", TiempoTranscurrido.Hours, TiempoTranscurrido.Minutes, TiempoTranscurrido.Seconds);
            ErrorStr = "Date: " + DateTime.Now
                        + "\tRuntime: " + TiempoFormat
                        + "\nOS: " + new ComputerInfo().OSFullName + " (" + CultureInfo.InstalledUICulture.Name + ")"
                        + "\nCLR Version: " + Environment.Version
                        + "\nExit code: " + Environment.ExitCode
                        + "\nException: " + exType + "\n" + s;
            ExType = exType;
        }
        public void LogError()
        {
            File.WriteAllText("ErrorLog.txt", ErrorStr);
        }
    }
}
