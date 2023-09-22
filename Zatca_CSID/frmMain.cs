using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zatca_CSID
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void certificateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCSID frmCSID = new frmCSID();
            frmCSID.Show();
            frmCSID.MdiParent = this;
        }

        private void onBoardingInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInvoiceOnBoarding frm = new frmInvoiceOnBoarding();
            frm.MdiParent = this;
            frm.Show();
        }

        private void createInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInvoice frmInvoice = new frmInvoice();
            frmInvoice.MdiParent = this;
            frmInvoice.Show();
        }

        private void getNewTokenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmToken frmToken = new frmToken();
            frmToken.MdiParent = this;
            frmToken.Show();
        }
    }
}
