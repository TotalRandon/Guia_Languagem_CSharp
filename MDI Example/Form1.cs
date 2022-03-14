using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Example
{
    public partial class MDIParentForm : Form
    {
        public MDIParentForm()
        {
            InitializeComponent();
        }

        private void MDIParentForm_Load(object sender, EventArgs e)
        {
            Child1Form objChild = new Child1Form(); objChild.MdiParent = this;
            objChild.Show();
        }

        private void btnShowChild2_Click(object sender, EventArgs e)
        {
            Child2Form objChild = new Child2Form();
            objChild.MdiParent = this.MdiParent;
            objChild.Show();
        }
    }
}
