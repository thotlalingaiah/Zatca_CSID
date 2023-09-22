using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zatca_CSID.ApiHelper;
using Zatca_CSID.Models;

namespace Zatca_CSID
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister frm = new frmRegister();
            frm.ShowDialog();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel();
            user.UserName = txtUserName.Text;
            user.userpassword = txtPassword.Text;
            user = ApiRequest.Login(user);
            if (user != null && user.IsActive == 1)
            {
                GlobalVariable.UserName = txtUserName.Text;
                GlobalVariable.Password = txtPassword.Text;
                this.Close();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("ERROR");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            frmRegister frm = new frmRegister();
            frm.ShowDialog();
        }
    }
}
