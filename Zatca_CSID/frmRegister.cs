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
    public partial class frmRegister : Form
    {
        Dictionary<int, string> LicenceDays = new Dictionary<int, string>();
        public frmRegister()
        {
            InitializeComponent();
            LicenceDays.Clear();
            LicenceDays.Add(30, "1 Month");
            LicenceDays.Add(60, "2 Months");
            LicenceDays.Add(90, "3 Months");
            LicenceDays.Add(180, "6 Months");
            LicenceDays.Add(365, "1 Year");
            cmbLicense.DataSource = new BindingSource(LicenceDays, null);
            cmbLicense.ValueMember = "Key";
            cmbLicense.DisplayMember = "Value";
            cmbLicense.SelectedIndex = 4;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var SelectedLincense = (KeyValuePair<int, string>)cmbLicense.SelectedItem;
            UserModel user = new UserModel();
            user.FullName = txtFullname.Text;
            user.Email = txtEmail.Text;
            user.userpassword = txtPwd.Text;
            user.c_userpassword = txtCPwd.Text;
            user.MobNo = txtMobile.Text;
            user.LicenceDays = SelectedLincense.Key;
            user.UserName = txtUserName.Text;
            var response = ApiRequest.Register(user);
            if (response != null && response.ToLower().Contains("ok"))
            {
                MessageBox.Show("Registration Success. Please Click a link from your registered email.");
                this.Close();
            }
            else
            {
                MessageBox.Show(response);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
