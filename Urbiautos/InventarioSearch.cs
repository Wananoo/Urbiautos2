using System;
using System.Windows.Forms;

namespace Urbiautos
{
    public partial class InventarioSearch : Form
    {
        int mscd = 0;
        public String SelectedItem { get; set; }
        DataConn dc = new DataConn();
        public InventarioSearch()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void txbsearch_TextChanged(object sender, EventArgs e)
        {
            mscd = 0;
            pbx_loading.Enabled = true;
            pbx_loading.Visible = true;
        }
        void PopulateResults()
        {
            listboxinventario.DataSource = dc.GetItembySearch(txbsearch.Text);
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            SelectedItem = listboxinventario.SelectedItem.ToString();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void InventarioSearch_Load(object sender, EventArgs e)
        {
            PopulateResults();
        }

        private void txbsearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (!(listboxinventario.SelectedIndex == listboxinventario.Items.Count - 1))
                {
                    listboxinventario.SelectedIndex++;
                    txbsearch.SelectionStart = txbsearch.Text.Length;
                    txbsearch.SelectionLength = 0;
                }
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (!(listboxinventario.SelectedIndex == 0))
                {
                    listboxinventario.SelectedIndex--;
                    txbsearch.SelectionStart = txbsearch.Text.Length + 1;
                    txbsearch.SelectionLength = 0;
                }
                e.Handled = true;
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            NuevoProducto np = new NuevoProducto();
            np.ShowDialog();
            PopulateResults();
        }

        private void countdown_Tick(object sender, EventArgs e)
        {
            mscd++;
            if (mscd == 10)
            {
                pbx_loading.Enabled = false;
                pbx_loading.Visible = false;
                PopulateResults();
            }
        }

        private void listboxinventario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
