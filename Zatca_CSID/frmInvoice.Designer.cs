namespace Zatca_CSID
{
    partial class frmInvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            txtInvoiceNo = new TextBox();
            label1 = new Label();
            cmbInvoiceType = new ComboBox();
            dtInvoiceDt = new DateTimePicker();
            txtUUID = new TextBox();
            txtBillRef = new TextBox();
            txtRefUUID = new TextBox();
            txtRefNotes = new TextBox();
            cmbVatType = new ComboBox();
            cmbPayCode = new ComboBox();
            cmbInvoiceTypeCode = new ComboBox();
            cmbCurCode = new ComboBox();
            cmbTaxCurCode = new ComboBox();
            cmbRefPaymode = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            cmbCustomerID = new ComboBox();
            cmbSupplierID = new ComboBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            btnNew = new Button();
            btnSave = new Button();
            btnSubmit = new Button();
            btnClose = new Button();
            picQr = new PictureBox();
            txtInvoiceHash = new TextBox();
            txtSignedXML = new TextBox();
            txtEncodeInvoice = new TextBox();
            txtQr = new TextBox();
            txtPIH = new TextBox();
            txtXMLFileName = new TextBox();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            txtCleared = new TextBox();
            txtReported = new TextBox();
            txtError = new TextBox();
            txtItemCode = new TextBox();
            txtItemName = new TextBox();
            txtUnit = new TextBox();
            txtPrice = new TextBox();
            txtQty = new TextBox();
            txtTotal = new TextBox();
            cmbTaxCode = new ComboBox();
            btnAdd = new Button();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            btnClear = new Button();
            groupBox1 = new GroupBox();
            label27 = new Label();
            label20 = new Label();
            dtpSubmitDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picQr).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 273);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1097, 269);
            dataGridView1.TabIndex = 0;
            // 
            // txtInvoiceNo
            // 
            txtInvoiceNo.Location = new Point(125, 56);
            txtInvoiceNo.Name = "txtInvoiceNo";
            txtInvoiceNo.PlaceholderText = "Invoice Number";
            txtInvoiceNo.Size = new Size(146, 23);
            txtInvoiceNo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 59);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 2;
            label1.Text = "Invoice Number:";
            // 
            // cmbInvoiceType
            // 
            cmbInvoiceType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbInvoiceType.FormattingEnabled = true;
            cmbInvoiceType.ItemHeight = 15;
            cmbInvoiceType.Location = new Point(697, 51);
            cmbInvoiceType.Name = "cmbInvoiceType";
            cmbInvoiceType.Size = new Size(132, 23);
            cmbInvoiceType.TabIndex = 3;
            // 
            // dtInvoiceDt
            // 
            dtInvoiceDt.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtInvoiceDt.Format = DateTimePickerFormat.Custom;
            dtInvoiceDt.Location = new Point(125, 112);
            dtInvoiceDt.Name = "dtInvoiceDt";
            dtInvoiceDt.Size = new Size(146, 23);
            dtInvoiceDt.TabIndex = 3;
            // 
            // txtUUID
            // 
            txtUUID.Enabled = false;
            txtUUID.Location = new Point(125, 85);
            txtUUID.Name = "txtUUID";
            txtUUID.PlaceholderText = "UUID";
            txtUUID.Size = new Size(146, 23);
            txtUUID.TabIndex = 2;
            // 
            // txtBillRef
            // 
            txtBillRef.Location = new Point(419, 54);
            txtBillRef.Name = "txtBillRef";
            txtBillRef.PlaceholderText = "Bill Reference";
            txtBillRef.Size = new Size(160, 23);
            txtBillRef.TabIndex = 6;
            // 
            // txtRefUUID
            // 
            txtRefUUID.Location = new Point(419, 83);
            txtRefUUID.Name = "txtRefUUID";
            txtRefUUID.PlaceholderText = "Ref. UUID - Counter";
            txtRefUUID.Size = new Size(160, 23);
            txtRefUUID.TabIndex = 7;
            // 
            // txtRefNotes
            // 
            txtRefNotes.Location = new Point(419, 112);
            txtRefNotes.Name = "txtRefNotes";
            txtRefNotes.PlaceholderText = "Notes";
            txtRefNotes.Size = new Size(160, 23);
            txtRefNotes.TabIndex = 8;
            // 
            // cmbVatType
            // 
            cmbVatType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVatType.FormattingEnabled = true;
            cmbVatType.ItemHeight = 15;
            cmbVatType.Location = new Point(697, 80);
            cmbVatType.Name = "cmbVatType";
            cmbVatType.Size = new Size(132, 23);
            cmbVatType.TabIndex = 3;
            // 
            // cmbPayCode
            // 
            cmbPayCode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPayCode.FormattingEnabled = true;
            cmbPayCode.ItemHeight = 15;
            cmbPayCode.Location = new Point(697, 109);
            cmbPayCode.Name = "cmbPayCode";
            cmbPayCode.Size = new Size(132, 23);
            cmbPayCode.TabIndex = 3;
            // 
            // cmbInvoiceTypeCode
            // 
            cmbInvoiceTypeCode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbInvoiceTypeCode.FormattingEnabled = true;
            cmbInvoiceTypeCode.ItemHeight = 15;
            cmbInvoiceTypeCode.Location = new Point(697, 138);
            cmbInvoiceTypeCode.Name = "cmbInvoiceTypeCode";
            cmbInvoiceTypeCode.Size = new Size(132, 23);
            cmbInvoiceTypeCode.TabIndex = 3;
            // 
            // cmbCurCode
            // 
            cmbCurCode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCurCode.FormattingEnabled = true;
            cmbCurCode.ItemHeight = 15;
            cmbCurCode.Location = new Point(697, 167);
            cmbCurCode.Name = "cmbCurCode";
            cmbCurCode.Size = new Size(132, 23);
            cmbCurCode.TabIndex = 3;
            // 
            // cmbTaxCurCode
            // 
            cmbTaxCurCode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTaxCurCode.FormattingEnabled = true;
            cmbTaxCurCode.Location = new Point(697, 196);
            cmbTaxCurCode.Name = "cmbTaxCurCode";
            cmbTaxCurCode.Size = new Size(132, 23);
            cmbTaxCurCode.TabIndex = 3;
            // 
            // cmbRefPaymode
            // 
            cmbRefPaymode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRefPaymode.FormattingEnabled = true;
            cmbRefPaymode.ItemHeight = 15;
            cmbRefPaymode.Location = new Point(419, 141);
            cmbRefPaymode.Name = "cmbRefPaymode";
            cmbRefPaymode.Size = new Size(160, 23);
            cmbRefPaymode.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 88);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 2;
            label2.Text = "UUID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(333, 60);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 2;
            label3.Text = "Bill Reference";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(333, 89);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 2;
            label4.Text = "Bill Ref. UUID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(333, 115);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 2;
            label5.Text = "Bill Ref. Notes:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(613, 54);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 2;
            label6.Text = "Invoice Type";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(613, 85);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 2;
            label7.Text = "VAT Type";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(603, 117);
            label8.Name = "label8";
            label8.Size = new Size(88, 15);
            label8.TabIndex = 2;
            label8.Text = "Payment Code:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(585, 146);
            label9.Name = "label9";
            label9.Size = new Size(106, 15);
            label9.TabIndex = 2;
            label9.Text = "Invoice Type Code:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(585, 175);
            label10.Name = "label10";
            label10.Size = new Size(89, 15);
            label10.TabIndex = 2;
            label10.Text = "Currency Code:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(585, 204);
            label11.Name = "label11";
            label11.Size = new Size(111, 15);
            label11.TabIndex = 2;
            label11.Text = "VAT Currency Code:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(283, 141);
            label12.Name = "label12";
            label12.Size = new Size(133, 15);
            label12.TabIndex = 2;
            label12.Text = "Bill Ref. Payment Mode:";
            // 
            // cmbCustomerID
            // 
            cmbCustomerID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomerID.FormattingEnabled = true;
            cmbCustomerID.Location = new Point(92, 12);
            cmbCustomerID.Name = "cmbCustomerID";
            cmbCustomerID.Size = new Size(132, 23);
            cmbCustomerID.TabIndex = 3;
            // 
            // cmbSupplierID
            // 
            cmbSupplierID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSupplierID.FormattingEnabled = true;
            cmbSupplierID.Location = new Point(303, 12);
            cmbSupplierID.Name = "cmbSupplierID";
            cmbSupplierID.Size = new Size(132, 23);
            cmbSupplierID.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(10, 15);
            label13.Name = "label13";
            label13.Size = new Size(76, 15);
            label13.TabIndex = 2;
            label13.Text = "Customer ID:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(231, 15);
            label14.Name = "label14";
            label14.Size = new Size(66, 15);
            label14.TabIndex = 2;
            label14.Text = "Supplier Id:";
            // 
            // label15
            // 
            label15.BackColor = SystemColors.ActiveBorder;
            label15.BorderStyle = BorderStyle.Fixed3D;
            label15.Location = new Point(12, 44);
            label15.Name = "label15";
            label15.Size = new Size(1063, 3);
            label15.TabIndex = 2;
            // 
            // label16
            // 
            label16.BackColor = SystemColors.ActiveBorder;
            label16.BorderStyle = BorderStyle.Fixed3D;
            label16.Location = new Point(12, 239);
            label16.Name = "label16";
            label16.Size = new Size(1063, 3);
            label16.TabIndex = 2;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.FromArgb(7, 50, 67);
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(12, 548);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 37);
            btnNew.TabIndex = 5;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(7, 50, 67);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(93, 548);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(204, 37);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save && Encode Invoice";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(7, 50, 67);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(613, 548);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(315, 37);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "On Board Invoice Report / Clear  ";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(7, 50, 67);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(957, 548);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 37);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // picQr
            // 
            picQr.Location = new Point(883, 47);
            picQr.Name = "picQr";
            picQr.Size = new Size(192, 186);
            picQr.SizeMode = PictureBoxSizeMode.StretchImage;
            picQr.TabIndex = 6;
            picQr.TabStop = false;
            picQr.Visible = false;
            // 
            // txtInvoiceHash
            // 
            txtInvoiceHash.BackColor = SystemColors.Info;
            txtInvoiceHash.Location = new Point(12, 591);
            txtInvoiceHash.Multiline = true;
            txtInvoiceHash.Name = "txtInvoiceHash";
            txtInvoiceHash.PlaceholderText = "Invoice Hash";
            txtInvoiceHash.ScrollBars = ScrollBars.Vertical;
            txtInvoiceHash.Size = new Size(251, 58);
            txtInvoiceHash.TabIndex = 1;
            // 
            // txtSignedXML
            // 
            txtSignedXML.BackColor = SystemColors.Info;
            txtSignedXML.Location = new Point(283, 591);
            txtSignedXML.Multiline = true;
            txtSignedXML.Name = "txtSignedXML";
            txtSignedXML.PlaceholderText = "Signed XML";
            txtSignedXML.ScrollBars = ScrollBars.Vertical;
            txtSignedXML.Size = new Size(251, 58);
            txtSignedXML.TabIndex = 1;
            // 
            // txtEncodeInvoice
            // 
            txtEncodeInvoice.BackColor = SystemColors.Info;
            txtEncodeInvoice.Location = new Point(552, 591);
            txtEncodeInvoice.Multiline = true;
            txtEncodeInvoice.Name = "txtEncodeInvoice";
            txtEncodeInvoice.PlaceholderText = "Encoded Invoice";
            txtEncodeInvoice.ScrollBars = ScrollBars.Vertical;
            txtEncodeInvoice.Size = new Size(251, 58);
            txtEncodeInvoice.TabIndex = 1;
            // 
            // txtQr
            // 
            txtQr.BackColor = SystemColors.Info;
            txtQr.Location = new Point(818, 591);
            txtQr.Multiline = true;
            txtQr.Name = "txtQr";
            txtQr.PlaceholderText = "QR Code";
            txtQr.ScrollBars = ScrollBars.Vertical;
            txtQr.Size = new Size(251, 58);
            txtQr.TabIndex = 1;
            // 
            // txtPIH
            // 
            txtPIH.Enabled = false;
            txtPIH.Location = new Point(125, 138);
            txtPIH.Name = "txtPIH";
            txtPIH.PlaceholderText = "Previous Invoice HASH";
            txtPIH.Size = new Size(146, 23);
            txtPIH.TabIndex = 4;
            // 
            // txtXMLFileName
            // 
            txtXMLFileName.Enabled = false;
            txtXMLFileName.Location = new Point(125, 167);
            txtXMLFileName.Name = "txtXMLFileName";
            txtXMLFileName.PlaceholderText = "XML File Name";
            txtXMLFileName.Size = new Size(146, 23);
            txtXMLFileName.TabIndex = 5;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(44, 115);
            label17.Name = "label17";
            label17.Size = new Size(75, 15);
            label17.TabIndex = 2;
            label17.Text = "Invoice Date:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(44, 141);
            label18.Name = "label18";
            label18.Size = new Size(78, 15);
            label18.TabIndex = 2;
            label18.Text = "Invoice Hash:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(44, 170);
            label19.Name = "label19";
            label19.Size = new Size(75, 15);
            label19.TabIndex = 2;
            label19.Text = "Invoice XML:";
            // 
            // txtCleared
            // 
            txtCleared.BackColor = Color.FromArgb(128, 255, 128);
            txtCleared.Location = new Point(144, 14);
            txtCleared.Name = "txtCleared";
            txtCleared.PlaceholderText = "Clearence Status";
            txtCleared.Size = new Size(100, 25);
            txtCleared.TabIndex = 1;
            // 
            // txtReported
            // 
            txtReported.BackColor = Color.FromArgb(128, 255, 128);
            txtReported.Location = new Point(256, 13);
            txtReported.Name = "txtReported";
            txtReported.PlaceholderText = "Reported Status";
            txtReported.Size = new Size(100, 25);
            txtReported.TabIndex = 1;
            // 
            // txtError
            // 
            txtError.Location = new Point(894, 57);
            txtError.Multiline = true;
            txtError.Name = "txtError";
            txtError.ScrollBars = ScrollBars.Vertical;
            txtError.Size = new Size(164, 151);
            txtError.TabIndex = 7;
            txtError.Visible = false;
            // 
            // txtItemCode
            // 
            txtItemCode.BackColor = Color.FromArgb(255, 255, 192);
            txtItemCode.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtItemCode.Location = new Point(78, 244);
            txtItemCode.Name = "txtItemCode";
            txtItemCode.Size = new Size(120, 23);
            txtItemCode.TabIndex = 16;
            txtItemCode.TextAlign = HorizontalAlignment.Center;
            // 
            // txtItemName
            // 
            txtItemName.BackColor = Color.FromArgb(255, 255, 192);
            txtItemName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtItemName.Location = new Point(243, 244);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(100, 23);
            txtItemName.TabIndex = 17;
            txtItemName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtUnit
            // 
            txtUnit.BackColor = Color.FromArgb(255, 255, 192);
            txtUnit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtUnit.Location = new Point(382, 244);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(100, 23);
            txtUnit.TabIndex = 18;
            txtUnit.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.FromArgb(255, 255, 192);
            txtPrice.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrice.Location = new Point(523, 245);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 19;
            txtPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // txtQty
            // 
            txtQty.BackColor = Color.FromArgb(255, 255, 192);
            txtQty.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtQty.Location = new Point(661, 243);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(71, 23);
            txtQty.TabIndex = 20;
            txtQty.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.FromArgb(255, 255, 192);
            txtTotal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotal.Location = new Point(795, 243);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 21;
            txtTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbTaxCode
            // 
            cmbTaxCode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTaxCode.FormattingEnabled = true;
            cmbTaxCode.ItemHeight = 15;
            cmbTaxCode.Location = new Point(901, 243);
            cmbTaxCode.Name = "cmbTaxCode";
            cmbTaxCode.Size = new Size(102, 23);
            cmbTaxCode.TabIndex = 22;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Green;
            btnAdd.Location = new Point(1006, 242);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(52, 23);
            btnAdd.TabIndex = 23;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(198, 247);
            label21.Name = "label21";
            label21.Size = new Size(42, 15);
            label21.TabIndex = 2;
            label21.Text = "Name:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(10, 247);
            label22.Name = "label22";
            label22.Size = new Size(65, 15);
            label22.TabIndex = 2;
            label22.Text = "Item Code:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(347, 247);
            label23.Name = "label23";
            label23.Size = new Size(32, 15);
            label23.TabIndex = 2;
            label23.Text = "Unit:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(488, 248);
            label24.Name = "label24";
            label24.Size = new Size(33, 15);
            label24.TabIndex = 2;
            label24.Text = "Price";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(629, 248);
            label25.Name = "label25";
            label25.Size = new Size(26, 15);
            label25.TabIndex = 2;
            label25.Text = "Qty";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(738, 246);
            label26.Name = "label26";
            label26.Size = new Size(51, 15);
            label26.TabIndex = 2;
            label26.Text = "Amount";
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.Red;
            btnClear.Location = new Point(1063, 242);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(47, 23);
            btnClear.TabIndex = 24;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnAdd_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(128, 255, 255);
            groupBox1.Controls.Add(label27);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(dtpSubmitDate);
            groupBox1.Controls.Add(txtCleared);
            groupBox1.Controls.Add(txtReported);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(441, -3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(668, 43);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Visible = false;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(8, 19);
            label27.Name = "label27";
            label27.Size = new Size(130, 17);
            label27.TabIndex = 26;
            label27.Text = "On Boarding Status:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(369, 16);
            label20.Name = "label20";
            label20.Size = new Size(85, 17);
            label20.TabIndex = 26;
            label20.Text = "Date && Time:";
            // 
            // dtpSubmitDate
            // 
            dtpSubmitDate.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpSubmitDate.Format = DateTimePickerFormat.Custom;
            dtpSubmitDate.Location = new Point(460, 13);
            dtpSubmitDate.Name = "dtpSubmitDate";
            dtpSubmitDate.Size = new Size(161, 25);
            dtpSubmitDate.TabIndex = 2;
            // 
            // frmInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 653);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(txtTotal);
            Controls.Add(txtQty);
            Controls.Add(txtPrice);
            Controls.Add(txtUnit);
            Controls.Add(txtItemName);
            Controls.Add(txtItemCode);
            Controls.Add(txtError);
            Controls.Add(picQr);
            Controls.Add(btnClose);
            Controls.Add(btnSubmit);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(dtInvoiceDt);
            Controls.Add(cmbTaxCode);
            Controls.Add(cmbRefPaymode);
            Controls.Add(cmbCustomerID);
            Controls.Add(cmbSupplierID);
            Controls.Add(cmbTaxCurCode);
            Controls.Add(cmbCurCode);
            Controls.Add(cmbInvoiceTypeCode);
            Controls.Add(cmbPayCode);
            Controls.Add(cmbVatType);
            Controls.Add(cmbInvoiceType);
            Controls.Add(label12);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label14);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label22);
            Controls.Add(label26);
            Controls.Add(label25);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(label21);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtRefNotes);
            Controls.Add(txtRefUUID);
            Controls.Add(txtBillRef);
            Controls.Add(txtUUID);
            Controls.Add(txtQr);
            Controls.Add(txtEncodeInvoice);
            Controls.Add(txtSignedXML);
            Controls.Add(txtInvoiceHash);
            Controls.Add(txtXMLFileName);
            Controls.Add(txtPIH);
            Controls.Add(txtInvoiceNo);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "frmInvoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zatca e-Invoice";
            Load += frmInvoice_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picQr).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtInvoiceNo;
        private Label label1;
        private ComboBox cmbInvoiceType;
        private DateTimePicker dtInvoiceDt;
        private TextBox txtUUID;
        private TextBox txtBillRef;
        private TextBox txtRefUUID;
        private TextBox txtRefNotes;
        private ComboBox cmbVatType;
        private ComboBox cmbPayCode;
        private ComboBox cmbInvoiceTypeCode;
        private ComboBox cmbCurCode;
        private ComboBox cmbTaxCurCode;
        private ComboBox cmbRefPaymode;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private ComboBox cmbCustomerID;
        private ComboBox cmbSupplierID;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Button btnNew;
        private Button btnSave;
        private Button btnSubmit;
        private Button btnClose;
        private PictureBox picQr;
        private TextBox txtInvoiceHash;
        private TextBox txtSignedXML;
        private TextBox txtEncodeInvoice;
        private TextBox txtQr;
        private TextBox txtPIH;
        private TextBox txtXMLFileName;
        private Label label17;
        private Label label18;
        private Label label19;
        private TextBox txtCleared;
        private TextBox txtReported;
        private TextBox txtError;
        private TextBox txtItemCode;
        private TextBox txtItemName;
        private TextBox txtUnit;
        private TextBox txtPrice;
        private TextBox txtQty;
        private TextBox txtTotal;
        private ComboBox cmbTaxCode;
        private Button btnAdd;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Button btnClear;
        private GroupBox groupBox1;
        private DateTimePicker dtpSubmitDate;
        private Label label20;
        private Label label27;
    }
}