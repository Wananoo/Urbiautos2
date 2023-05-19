using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urbiautos
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

        private void Config_Load(object sender, EventArgs e)
        {
            txbdir.Text = Properties.Settings.Default.IPDB;
            txbuser.Text = Properties.Settings.Default.DBUSER;
            txbpass.Text = Properties.Settings.Default.DBPASS;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.IPDB = txbdir.Text;
            Properties.Settings.Default.DBUSER = txbuser.Text;
            Properties.Settings.Default.DBPASS = txbpass.Text;
            Properties.Settings.Default.Save();
            Close();
        }
    }
}
