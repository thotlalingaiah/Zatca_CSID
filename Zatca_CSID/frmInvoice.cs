using Newtonsoft.Json;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Zatca_CSID.ApiHelper;
using Zatca_CSID.Models;

namespace Zatca_CSID
{
    public partial class frmInvoice : Form
    {
        private string _cert;

        public string CERT
        {
            get { return _cert; }
            set { _cert = value; }
        }

        private string _signedcert;

        public string SIGNEDCERT
        {
            get { return _signedcert; }
            set { _signedcert = value; }
        }
        private string _privatekey;

        public string PrivateKey
        {
            get { return _privatekey; }
            set { _privatekey = value; }
        }
        private string _otp;

        public string OTP
        {
            get { return _otp; }
            set { _otp = value; }
        }
        private bool _isProduction;

        public bool IsProduction
        {
            get { return _isProduction; }
            set { _isProduction = value; }
        }




        DataTable dtInvoiceHdr = new DataTable();
        DataTable dtInvoiceDtl = new DataTable();


        Dictionary<int, string> _InvoiceType = new Dictionary<int, string>();
        Dictionary<string, string> _VatType = new Dictionary<string, string>();
        Dictionary<string, string> _PaymentCode = new Dictionary<string, string>();
        Dictionary<string, string> _InvoiceTypeCode = new Dictionary<string, string>();
        Dictionary<string, string> _CurCode = new Dictionary<string, string>();
        Dictionary<string, string> _CountryCode = new Dictionary<string, string>();
        Dictionary<string, string> _BusinessCode = new Dictionary<string, string>();



        public frmInvoice()
        {
            InitializeComponent();
            IntialValue();
            IsProduction = false;
            CERT = GlobalVariable.PublicKey;
            PrivateKey = GlobalVariable.PrivateKey;
            SIGNEDCERT = GlobalVariable.SignedKey;
            OTP = "12345";
        }

        private void ResetForm()
        {
            txtInvoiceNo.Text = string.Empty;
            txtUUID.Text = string.Empty;
            txtPIH.Text = string.Empty;
            txtXMLFileName.Text = string.Empty;
            txtBillRef.Text = string.Empty;
            txtRefUUID.Text = string.Empty;
            txtRefNotes.Text = string.Empty;
            txtInvoiceHash.Text = string.Empty;
            txtSignedXML.Text = string.Empty;
            txtEncodeInvoice.Text = string.Empty;
            txtQr.Text = string.Empty;

            dtInvoiceDt.Value = DateTime.Now;
            cmbRefPaymode.SelectedIndex = -1;
            cmbInvoiceType.SelectedIndex = -1;
            cmbVatType.SelectedIndex = -1;
            cmbPayCode.SelectedIndex = -1;
            cmbInvoiceTypeCode.SelectedIndex = -1;
            cmbCurCode.SelectedIndex = -1;
            cmbTaxCurCode.SelectedIndex = -1;
            picQr.Image = null;
            txtError.Visible = false;
            groupBox1.Visible = false;

        }
        private void IntialValue()
        {

            //adding Columns
            DataColumn idColumn = new DataColumn();
            idColumn.DataType = System.Type.GetType("System.Int32");
            idColumn.ColumnName = "colSlno";
            idColumn.AutoIncrement = true;
            idColumn.AutoIncrementSeed = 1;
            dtInvoiceDtl.Columns.Add(idColumn);

            //dtInvoiceDtl.Columns.Add("colSlno", typeof(int));
            dtInvoiceDtl.Columns.Add("colItemCode", typeof(string));
            dtInvoiceDtl.Columns.Add("colItemName", typeof(string));
            dtInvoiceDtl.Columns.Add("colUnit", typeof(string));
            dtInvoiceDtl.Columns.Add("colPrice", typeof(decimal));
            dtInvoiceDtl.Columns.Add("colQty", typeof(decimal));
            dtInvoiceDtl.Columns.Add("colTotal", typeof(decimal));

            dtInvoiceDtl.Columns.Add("colTaxID", typeof(string));
            dtInvoiceDtl.Columns.Add("colTaxPecent", typeof(decimal));
            dtInvoiceDtl.Columns.Add("collineTotal", typeof(decimal));



            // Invoice Type
            _InvoiceType.Clear();
            _InvoiceType.Add(388, "Invoice");
            _InvoiceType.Add(383, "Debit");
            _InvoiceType.Add(381, "Credit");
            // Vat Type or Information
            _VatType.Clear();
            _VatType.Add("0", "Not subject to VAT");
            _VatType.Add("E", "exempt from Value Added Tax");
            _VatType.Add("S", "Value Added Tax");
            _VatType.Add("Z", "Zero rated goods");




            /* PaymentMeansCode */
            _PaymentCode.Clear();
            _PaymentCode.Add("1", "Instrument not defined(Free text");
            _PaymentCode.Add("48", "Bank card");
            _PaymentCode.Add("40", "Payment to bank account"); /* Doubt */
            _PaymentCode.Add("30", "Credit");
            _PaymentCode.Add("10", "In cash");
            _PaymentCode.Add("42", "Optional");

            /* Invoice Type Code Name */

            _InvoiceTypeCode.Clear();

            _InvoiceTypeCode.Add("01", "Ordinary Invoice");
            _InvoiceTypeCode.Add("02", "Simplified Invoice");

            /*
            _dicCmd.Add("On - In the case of an invoice for a third party", "1");
            _dicCmd.Add("Off - In the case of an invoice for a third party", "0");

            _dicCmd.Add("On -In the case of a nominal bill", "1");
            _dicCmd.Add("Off -In the case of a nominal bill", "0");
            _dicCmd.Add("On - In the case of an invoice for exports", "1");
            _dicCmd.Add("Off - In the case of an invoice for exports", "0");
            _dicCmd.Add("On - In the case of a summary invoice", "1");
            _dicCmd.Add("Off In the case of a summary invoice", "0");
            _dicCmd.Add("On - In the case of a self-invoicing", "1");
            _dicCmd.Add("Off - In the case of a self-invoicing", "0");
            _dicCmd.Add("On - If the invoice is export", "1");// the invoice cannot be self = 1
            */

            /* Currency */
            _CurCode.Clear();
            _CurCode.Add("SAR", "SAR");
            _CurCode.Add("AED", "AED");
            _CurCode.Add("AUD", "AUD");
            _CurCode.Add("BGN", "BGN");
            _CurCode.Add("BRL", "BRL");
            _CurCode.Add("CAD", "CAD");
            _CurCode.Add("CHF", "CHF");
            _CurCode.Add("CNY", "CNY");
            _CurCode.Add("CZK", "CZK");
            _CurCode.Add("DKK", "DKK");
            _CurCode.Add("EUR", "EUR");
            _CurCode.Add("GBP", "GBP");
            _CurCode.Add("HKD", "HKD");
            _CurCode.Add("HRK", "HRK");
            _CurCode.Add("HUF", "HUF");
            _CurCode.Add("IDR", "IDR");
            _CurCode.Add("ILS", "ILS");
            _CurCode.Add("INR", "INR");
            _CurCode.Add("ISK", "ISK");
            _CurCode.Add("JPY", "JPY");
            _CurCode.Add("KRW", "KRW");
            _CurCode.Add("MXN", "MXN");
            _CurCode.Add("MYR", "MYR");
            _CurCode.Add("NOK", "NOK");
            _CurCode.Add("NZD", "NZD");
            _CurCode.Add("PHP", "PHP");
            _CurCode.Add("PLN", "PLN");
            _CurCode.Add("RON", "RON");
            _CurCode.Add("RUB", "RUB");
            _CurCode.Add("SEK", "SEK");
            _CurCode.Add("SGD", "SGD");
            _CurCode.Add("THB", "THB");
            _CurCode.Add("TRY", "TRY");
            _CurCode.Add("USD", "USD");
            _CurCode.Add("ZAR", "ZAR");

            /* TranscationID*/
            _BusinessCode.Clear();
            _BusinessCode.Add("NAT", "NAT");
            _BusinessCode.Add("IQA", "IQA");
            _BusinessCode.Add("PAS", "PAS");
            _BusinessCode.Add("CRN", "CRN");
            _BusinessCode.Add("MOM", "MOM");
            _BusinessCode.Add("MLS", "MLS");
            _BusinessCode.Add("SAG", "SAG");
            _BusinessCode.Add("GCC", "GCC");
            _BusinessCode.Add("OTH", "OTH");

            /* Countries */
            _CountryCode.Clear();
            _CountryCode.Add("KSA", "SA");
            _CountryCode.Add("UAE", "UAE");

            /* Assign to DropDownList */

            cmbRefPaymode.DataSource = new BindingSource(_PaymentCode, null);
            cmbInvoiceType.DataSource = new BindingSource(_InvoiceType, null);
            cmbVatType.DataSource = new BindingSource(_VatType, null);
            cmbPayCode.DataSource = new BindingSource(_PaymentCode, null);
            cmbCurCode.DataSource = new BindingSource(_CurCode, null);
            cmbTaxCurCode.DataSource = new BindingSource(_CurCode, null);
            cmbInvoiceTypeCode.DataSource = new BindingSource(_InvoiceTypeCode, null);
            cmbTaxCode.DataSource = new BindingSource(_VatType, null);

            cmbRefPaymode.ValueMember = "key";
            cmbInvoiceType.ValueMember = "key";
            cmbVatType.ValueMember = "key";
            cmbPayCode.ValueMember = "key";
            cmbCurCode.ValueMember = "key";
            cmbTaxCurCode.ValueMember = "key";
            cmbInvoiceTypeCode.ValueMember = "key";
            cmbTaxCode.ValueMember = "key";

            cmbRefPaymode.DisplayMember = "value";
            cmbInvoiceType.DisplayMember = "value";
            cmbVatType.DisplayMember = "value";
            cmbPayCode.DisplayMember = "value";
            cmbCurCode.DisplayMember = "value";
            cmbTaxCurCode.DisplayMember = "value";
            cmbInvoiceTypeCode.DisplayMember = "value";
            cmbTaxCode.DisplayMember = "value";

            cmbRefPaymode.SelectedIndex = 4;
            cmbInvoiceType.SelectedIndex = 0;
            cmbVatType.SelectedIndex = 2;
            cmbPayCode.SelectedIndex = 4;
            cmbCurCode.SelectedIndex = 0;
            cmbTaxCurCode.SelectedIndex = 0;
            cmbInvoiceTypeCode.SelectedIndex = 0;
            cmbTaxCode.SelectedIndex = 2;


            dataGridView1.DataSource = dtInvoiceDtl;
            dataGridView1.Columns[0].HeaderText = "SlNo";
            dataGridView1.Columns[1].HeaderText = "Item Code";
            dataGridView1.Columns[2].HeaderText = "Item Name";
            dataGridView1.Columns[3].HeaderText = "Unit";
            dataGridView1.Columns[4].HeaderText = "Price";
            dataGridView1.Columns[5].HeaderText = "Qty";
            dataGridView1.Columns[6].HeaderText = "Total";
            dataGridView1.Columns[7].HeaderText = "Tax ID";
            dataGridView1.Columns[8].HeaderText = "Tax Percent";
            dataGridView1.Columns[9].HeaderText = "Line Amount";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ResetForm();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {


            var SelectedInvoiceType = (KeyValuePair<int, string>)cmbInvoiceType.SelectedItem;
            var SelectedInvoiceTypeCode = (KeyValuePair<string, string>)cmbInvoiceTypeCode.SelectedItem;
            var SelectedCurCode = (KeyValuePair<string, string>)cmbCurCode.SelectedItem;
            var SelectedTaxCurCode = (KeyValuePair<string, string>)cmbTaxCurCode.SelectedItem;

            _ZInvoice zatcaInvoice = new _ZInvoice();
            zatcaInvoice.ID = txtInvoiceNo.Text;
            zatcaInvoice.IssueDate = DateTime.UtcNow.ToString("yyyy-MM-dd"); // dtInvoiceDt.Value.ToString("yyyy-MM-dd");
            zatcaInvoice.IssueTime = DateTime.UtcNow.ToString("HH:mm:ss");// dtInvoiceDt.Value.ToString("HH:mm:ss");
            zatcaInvoice.InvoiceTypeCode = SelectedInvoiceType.Key;
            zatcaInvoice.InvoiceTypeCodeName = SelectedInvoiceTypeCode.Key;
            zatcaInvoice.Cur_Code = SelectedCurCode.Key;
            zatcaInvoice.Tax_Cur_Code = SelectedTaxCurCode.Key;


            zatcaInvoice.Doc_Ref_ID = string.IsNullOrEmpty(txtBillRef.Text) ? "" : txtBillRef.Text;
            zatcaInvoice.PaymentNotes = string.IsNullOrEmpty(txtRefNotes.Text) ? "" : txtRefNotes.Text;


            if (!string.IsNullOrEmpty(txtRefUUID.Text)) zatcaInvoice.Adtl_Ref_UUID = Convert.ToInt32(txtRefUUID.Text);
            if (SelectedInvoiceTypeCode.Key == "02")
            {
                zatcaInvoice.DeliveryDate = dtInvoiceDt.Value.ToString("yyyy-MM-dd");
                zatcaInvoice.Actual_DeliveryDate = dtInvoiceDt.Value.ToString("yyyy-MM-dd");
            }

            // Supplier & Customer 
            
            zatcaInvoice.supplier.ID = "123456";
            zatcaInvoice.supplier.SchemaID = "CRN";//commercial registration number
            zatcaInvoice.supplier.StreeName = "Test Street,";// mandatory
            zatcaInvoice.supplier.Building_Num = "3724"; // Mandatory
            zatcaInvoice.supplier.PlotNum = "1234";//Optional
            zatcaInvoice.supplier.City = "Jeddah";
            zatcaInvoice.supplier.Pincode = "15555";

            zatcaInvoice.supplier.SubDivision = "Alfalah";
            zatcaInvoice.supplier.Country = "SA";
            zatcaInvoice.supplier.RegistrationName = "The My Company";
            zatcaInvoice.supplier.TaxID = "310175397400003";


            // Customer data is mandatory
            zatcaInvoice.customer.ID = "123456";//commercial registration number
            zatcaInvoice.customer.SchemaID = "CRN";
            zatcaInvoice.customer.StreeName = "Test Street,";// mandatory

            zatcaInvoice.customer.Building_Num = "0024"; // Mandatory
            zatcaInvoice.customer.PlotNum = "1234";//Optional
            zatcaInvoice.customer.City = "Jeddah";
            zatcaInvoice.customer.Pincode = "15555";

            zatcaInvoice.customer.SubDivision = "Alfalah";
            zatcaInvoice.customer.Country = "SA";
            zatcaInvoice.customer.RegistrationName = "Customer Company";
            zatcaInvoice.customer.TaxID = "300000000000003";

            // DataGridview Read
            IList<_InvoiceLine> invlineItems = new List<_InvoiceLine>();
            foreach (DataRow dr in dtInvoiceDtl.Rows)
            {
                _InvoiceLine _InvoiceLine = new _InvoiceLine();
                _InvoiceLine.ItemName = dr["colItemName"].ToString();
                _InvoiceLine.Qty = Convert.ToDecimal(dr["colQty"]);
                _InvoiceLine.Price = Convert.ToDecimal(dr["colPrice"]);
                _InvoiceLine.Tax_ID = dr["colTaxID"].ToString();
                _InvoiceLine.Taxper = Convert.ToDecimal(dr["colTaxPecent"]);
                _InvoiceLine.ExcludeVat = false;
                _InvoiceLine.Discount_Amt = 0;
                _InvoiceLine.Discount_Reason = "";
                _InvoiceLine.Tax_Excempt_ReasonCode = "0";
                _InvoiceLine.Tax_Excempt_reason = "0";
                invlineItems.Add(_InvoiceLine);
            }


            zatcaInvoice.invline = invlineItems;
            zatcaInvoice.authKey.Cer = SIGNEDCERT;
            zatcaInvoice.authKey.Key = PrivateKey;
            zatcaInvoice.authKey.Pih = "";// "MoTj3Ohw44+99MzK/dnB6Y1ZxFfZ6IiWjhCKJ+Mn8gY=";
            Result result1 = new Result();

            result1 = ApiRequest.EncodeInvoice(zatcaInvoice);


            if (!string.IsNullOrEmpty(result1.ErrorMessage))
            {
                ErrorDisplay(result1.ErrorMessage);
                return;
            }
            txtSignedXML.Text = result1.SingedXML;
            txtUUID.Text = result1.UUID;
            txtInvoiceHash.Text = result1.InvoiceHash;
            txtQr.Text = result1.QRCode;
            txtEncodeInvoice.Text = result1.EncodedInvoice;
            txtXMLFileName.Text = result1.SingedXMLFileName;
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(result1.QRCode, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            qrCode.GetGraphic(20).Save(Path.Combine(Directory.GetCurrentDirectory(), @"InvoiceQR.png"), System.Drawing.Imaging.ImageFormat.Png);
            picQr.Image = qrCode.GetGraphic(20);
            picQr.Visible = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var SelectedInvoiceType = (KeyValuePair<int, string>)cmbInvoiceType.SelectedItem;
            InvoiceReportingResponse response = new InvoiceReportingResponse();
            EncodedInvoiceModel invoice = new EncodedInvoiceModel();
            invoice.InvoiceHash = txtInvoiceHash.Text;
            invoice.UUID = txtUUID.Text;
            invoice.IsProduction = IsProduction;
            invoice.EncodedInvoice = txtEncodeInvoice.Text;
            invoice.InvoiceTypeCode = SelectedInvoiceType.Key;
            invoice.OTP = OTP;
            invoice.Cer = CERT;
            response = ApiRequest.SubmitInvoice(invoice);

            //using (HttpClient client = new HttpClient())
            //{

            //    client.BaseAddress = (new Uri(GlobalVariable.BaseURL));
            //    client.DefaultRequestHeaders.Accept.Clear();
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //    StringContent content = new StringContent(JsonConvert.SerializeObject(invoice), Encoding.UTF8, "application/json");
            //    HttpResponseMessage result = client.PostAsync("ZatcaInvoice/Submit2Zatca", content).Result;
            //    string str2 = result.Content.ReadAsStringAsync().Result;
            //    if (result.IsSuccessStatusCode)
            //    {
            //        response = JsonConvert.DeserializeObject<InvoiceReportingResponse>(str2);
            //    }

            //}
            if (!string.IsNullOrEmpty(response.ErrorMessage))
            {
                ErrorDisplay(response.ErrorMessage);
            }
            else
            {
                txtCleared.Text = response.ClearanceStatus;
                txtReported.Text = response.ReportingStatus;
                dtpSubmitDate.Value = DateTime.Now;
                groupBox1.Visible = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ErrorDisplay(string message)
        {
            MessageBox.Show(message, "Error");
            txtError.Text = message;
            txtError.Visible = true;
            picQr.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double taxPer = 0, qty = 0, price = 0, total = 0, linetotal = 0;

            var cmbTaxCodeSelectedItem = (KeyValuePair<string, string>)(cmbTaxCode.SelectedItem);
            DataRow dataRow;
            dataRow = dtInvoiceDtl.NewRow();


            price = Convert.ToDouble(txtPrice.Text);
            qty = Convert.ToDouble(txtQty.Text);
            total = price * qty;



            dataRow["colItemCode"] = txtItemCode.Text;
            dataRow["colItemName"] = txtItemName.Text;
            dataRow["colUnit"] = txtUnit.Text;
            dataRow["colPrice"] = price.ToString("0.##");// 
            dataRow["colQty"] = qty.ToString("#.00");
            dataRow["colTotal"] = total.ToString("#.00");

            if (cmbTaxCodeSelectedItem.Key == "S") taxPer = 15.00;

            dataRow["colTaxID"] = cmbTaxCodeSelectedItem.Key;
            dataRow["colTaxPecent"] = taxPer;

            linetotal = total + (total * taxPer / 100);
            dataRow["collineTotal"] = linetotal.ToString("#.00");
            dtInvoiceDtl.Rows.Add(dataRow);
            txtItemCode.Focus();
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {

        }
    }
}
