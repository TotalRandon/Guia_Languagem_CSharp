using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visualizador02
{
    public partial class ListsForm : Form
    {
        public ListsForm()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            int intIndex;
            intIndex = lstPinkFloydAlbums.Items.Add("The Division Bell");
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            lstPinkFloydAlbums.Items.Remove("The Division Bell");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstPinkFloydAlbums.Items.Clear();
        }

        private void btnShowiten_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You selected " +lstPinkFloydAlbums.SelectedItem + "which has an index of" 
            +lstPinkFloydAlbums.SelectedIndex);
        }

        private void cboColors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose02_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
