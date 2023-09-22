using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Text;
using Zatca_CSID.ApiHelper;
using Zatca_CSID.Models;

namespace Zatca_CSID
{
    public partial class frmCSID : Form
    {

        Dictionary<string, string> _country = new Dictionary<string, string>();
        Dictionary<string, string> _invoiceType = new Dictionary<string, string>();
        public frmCSID()
        {

            InitializeComponent();

            _invoiceType.Add("1000", "Standard Documents(B2B)");
            _invoiceType.Add("0100", "Simplified Documents(B2C)");
            _invoiceType.Add("1100", "Both Standard and Simplified(B2B && B2C)");
            _country.Add("SA", "Kingdom of Saudi Arabia");

            cmbCountry.DataSource = new BindingSource(_country, null);
            cmbCountry.DisplayMember = "value";
            cmbCountry.ValueMember = "key";
            cmbCountry.SelectedIndex = 0;

            cmbInvoiceType.DataSource = new BindingSource(_invoiceType, null);
            cmbInvoiceType.ValueMember = "key";
            cmbInvoiceType.DisplayMember = "value";
            cmbInvoiceType.SelectedIndex = 0;
        }

        private void btnGenerateCSID_Click(object sender, EventArgs e)
        {
            var InvoiceTypeselectedItem = (KeyValuePair<string, string>)cmbInvoiceType.SelectedItem;
            var CountryselectedItem = (KeyValuePair<string, string>)cmbCountry.SelectedItem;

            CompanyInfo companyInfo = new CompanyInfo();
            companyInfo.zatcaCSR.CommonName = txtCommonName.Text;
            companyInfo.zatcaCSR.SerialNumber = txtSlno.Text;
            companyInfo.zatcaCSR.UniqueID = txtUID.Text;
            companyInfo.zatcaCSR.UnitName = txtUnitName.Text;
            companyInfo.zatcaCSR.OrganizationName = txtOrganizationName.Text;
            companyInfo.zatcaCSR.Location = txtLocation.Text;
            companyInfo.zatcaCSR.CountryName = CountryselectedItem.Key;
            companyInfo.zatcaCSR.InvoiceType = InvoiceTypeselectedItem.Key.ToUpper();
            companyInfo.zatcaCSR.Industry = txtIndustry.Text;
            companyInfo.ZatcaCsid.OTP = txtOTP.Text;
            if (chkIsProduction.Checked) companyInfo.zatcaCSR.IsProduction = true;
            companyInfo = ApiRequest.GenerateCSID(companyInfo);
          

            // Get Response
            txtCSR.Text = companyInfo.zatcaCSR.csr_csr;
            txtPrivate.Text = companyInfo.zatcaCSR.Key_pem;
            txtSecret.Text = companyInfo.ZatcaCsid.secret;
            txtSigned.Text = companyInfo.ZatcaCsid.cert_pem;

            GlobalVariable.PublicKey = txtCSR.Text;
            GlobalVariable.PrivateKey = txtPrivate.Text;
            GlobalVariable.SecretKey = txtSecret.Text;
            GlobalVariable.SignedKey = txtSigned.Text;

        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            frmInvoice frminvoice = new frmInvoice();
            frminvoice.CERT = txtCSR.Text;
            frminvoice.SIGNEDCERT = txtSigned.Text;
            frminvoice.PrivateKey = txtPrivate.Text;
            frminvoice.OTP = txtOTP.Text;
            frminvoice.IsProduction = chkIsProduction.Checked;

            frminvoice.ShowDialog();
        }
    }
}