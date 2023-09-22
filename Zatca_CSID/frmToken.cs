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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Zatca_CSID
{
    public partial class frmToken : Form
    {
        public frmToken()
        {
            InitializeComponent();
        }

        private void btnTokenGenerate_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel();
            user.UserName = GlobalVariable.UserName;
            user.userpassword = GlobalVariable.Password;

            var tokenString = ApiRequest.GetToken(user);
            if (tokenString != null)
            {
                txtToken.Text = tokenString.ToString().Replace("\"", "");
                GlobalVariable.TokenString = tokenString.ToString().Replace("\"", "");
            }
        }

        private void btnSavetoDisk_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {

                InitialDirectory = @"C:\",
                Title = "Save text Files",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "txt",
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName,txtToken.Text);  
            }
            
        }
    }
}
