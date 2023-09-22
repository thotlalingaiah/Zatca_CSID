namespace Zatca_CSID
{
    partial class frmCSID
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCommonName = new TextBox();
            cmbInvoiceType = new ComboBox();
            btnGenerateCSID = new Button();
            txtSlno = new TextBox();
            txtUID = new TextBox();
            txtOrganizationName = new TextBox();
            txtLocation = new TextBox();
            txtIndustry = new TextBox();
            cmbCountry = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtOTP = new TextBox();
            label12 = new Label();
            txtCSR = new TextBox();
            txtPrivate = new TextBox();
            txtSigned = new TextBox();
            txtSecret = new TextBox();
            chkIsProduction = new CheckBox();
            txtUnitName = new TextBox();
            label1 = new Label();
            btnInvoice = new Button();
            label10 = new Label();
            label11 = new Label();
            label13 = new Label();
            label14 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label16 = new Label();
            label15 = new Label();
            label17 = new Label();
            label18 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtCommonName
            // 
            txtCommonName.Location = new Point(207, 90);
            txtCommonName.Name = "txtCommonName";
            txtCommonName.Size = new Size(229, 23);
            txtCommonName.TabIndex = 0;
            txtCommonName.Text = "1-COMPANY-CODES-300000000000003";
            // 
            // cmbInvoiceType
            // 
            cmbInvoiceType.FormattingEnabled = true;
            cmbInvoiceType.Location = new Point(207, 321);
            cmbInvoiceType.Name = "cmbInvoiceType";
            cmbInvoiceType.Size = new Size(231, 23);
            cmbInvoiceType.TabIndex = 1;
            // 
            // btnGenerateCSID
            // 
            btnGenerateCSID.BackColor = Color.FromArgb(7, 50, 67);
            btnGenerateCSID.FlatStyle = FlatStyle.Flat;
            btnGenerateCSID.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerateCSID.ForeColor = Color.White;
            btnGenerateCSID.Location = new Point(207, 410);
            btnGenerateCSID.Name = "btnGenerateCSID";
            btnGenerateCSID.Size = new Size(229, 41);
            btnGenerateCSID.TabIndex = 3;
            btnGenerateCSID.Text = "Generate CSID";
            btnGenerateCSID.UseVisualStyleBackColor = false;
            btnGenerateCSID.Click += btnGenerateCSID_Click;
            // 
            // txtSlno
            // 
            txtSlno.Location = new Point(207, 119);
            txtSlno.Name = "txtSlno";
            txtSlno.Size = new Size(229, 23);
            txtSlno.TabIndex = 0;
            txtSlno.Text = "1-Zatca|2-ZatcaPhaseV1|3-543F0EX9-M299-4CAF-B2B7-AA48DD23AF90";
            // 
            // txtUID
            // 
            txtUID.Location = new Point(207, 147);
            txtUID.Name = "txtUID";
            txtUID.Size = new Size(229, 23);
            txtUID.TabIndex = 0;
            txtUID.Text = "300000000000003";
            // 
            // txtOrganizationName
            // 
            txtOrganizationName.Location = new Point(207, 201);
            txtOrganizationName.Name = "txtOrganizationName";
            txtOrganizationName.Size = new Size(229, 23);
            txtOrganizationName.TabIndex = 0;
            txtOrganizationName.Text = "300000000000003";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(207, 230);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(229, 23);
            txtLocation.TabIndex = 0;
            txtLocation.Text = "Jadah";
            // 
            // txtIndustry
            // 
            txtIndustry.Location = new Point(207, 263);
            txtIndustry.Name = "txtIndustry";
            txtIndustry.Size = new Size(229, 23);
            txtIndustry.TabIndex = 0;
            txtIndustry.Text = "Test";
            // 
            // cmbCountry
            // 
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Location = new Point(207, 292);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(231, 23);
            cmbCountry.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 90);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 2;
            label2.Text = "Common Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 122);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 2;
            label3.Text = "Serial Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(117, 150);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 2;
            label4.Text = "UID/ Identifier:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(104, 204);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 2;
            label5.Text = "Company Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(145, 233);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 2;
            label6.Text = "Location:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(148, 266);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 2;
            label7.Text = "Industry:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(113, 292);
            label8.Name = "label8";
            label8.Size = new Size(88, 15);
            label8.TabIndex = 2;
            label8.Text = "Country Name:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(72, 324);
            label9.Name = "label9";
            label9.Size = new Size(129, 15);
            label9.TabIndex = 2;
            label9.Text = "Common Invoice Type:";
            // 
            // txtOTP
            // 
            txtOTP.Location = new Point(209, 379);
            txtOTP.Name = "txtOTP";
            txtOTP.Size = new Size(229, 23);
            txtOTP.TabIndex = 0;
            txtOTP.Text = "12345";
            txtOTP.UseSystemPasswordChar = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(169, 382);
            label12.Name = "label12";
            label12.Size = new Size(28, 15);
            label12.TabIndex = 2;
            label12.Text = "OTP";
            // 
            // txtCSR
            // 
            txtCSR.Location = new Point(484, 107);
            txtCSR.Multiline = true;
            txtCSR.Name = "txtCSR";
            txtCSR.PlaceholderText = "Certificate Signing Request (CSR)";
            txtCSR.ScrollBars = ScrollBars.Vertical;
            txtCSR.Size = new Size(339, 80);
            txtCSR.TabIndex = 0;
            // 
            // txtPrivate
            // 
            txtPrivate.Location = new Point(484, 208);
            txtPrivate.Multiline = true;
            txtPrivate.Name = "txtPrivate";
            txtPrivate.PlaceholderText = "Private Key";
            txtPrivate.ScrollBars = ScrollBars.Vertical;
            txtPrivate.Size = new Size(339, 80);
            txtPrivate.TabIndex = 0;
            // 
            // txtSigned
            // 
            txtSigned.BackColor = SystemColors.Info;
            txtSigned.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtSigned.Location = new Point(484, 309);
            txtSigned.Multiline = true;
            txtSigned.Name = "txtSigned";
            txtSigned.PlaceholderText = "Signed Certificate";
            txtSigned.ScrollBars = ScrollBars.Vertical;
            txtSigned.Size = new Size(339, 80);
            txtSigned.TabIndex = 0;
            // 
            // txtSecret
            // 
            txtSecret.BackColor = SystemColors.Info;
            txtSecret.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtSecret.Location = new Point(484, 410);
            txtSecret.Multiline = true;
            txtSecret.Name = "txtSecret";
            txtSecret.PlaceholderText = "Secret Key";
            txtSecret.ScrollBars = ScrollBars.Vertical;
            txtSecret.Size = new Size(339, 80);
            txtSecret.TabIndex = 0;
            // 
            // chkIsProduction
            // 
            chkIsProduction.AutoSize = true;
            chkIsProduction.Location = new Point(208, 351);
            chkIsProduction.Name = "chkIsProduction";
            chkIsProduction.Size = new Size(96, 19);
            chkIsProduction.TabIndex = 4;
            chkIsProduction.Text = "Is Production";
            chkIsProduction.UseVisualStyleBackColor = true;
            // 
            // txtUnitName
            // 
            txtUnitName.Location = new Point(209, 174);
            txtUnitName.Name = "txtUnitName";
            txtUnitName.Size = new Size(229, 23);
            txtUnitName.TabIndex = 0;
            txtUnitName.Text = "300000000000003";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 177);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 2;
            label1.Text = "Unit Name";
            // 
            // btnInvoice
            // 
            btnInvoice.Location = new Point(220, 556);
            btnInvoice.Name = "btnInvoice";
            btnInvoice.Size = new Size(227, 35);
            btnInvoice.TabIndex = 5;
            btnInvoice.Text = "Invoice";
            btnInvoice.UseVisualStyleBackColor = true;
            btnInvoice.Click += btnInvoice_Click;
            // 
            // label10
            // 
            label10.BackColor = Color.FromArgb(128, 255, 128);
            label10.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Navy;
            label10.Location = new Point(484, 89);
            label10.Name = "label10";
            label10.Size = new Size(339, 15);
            label10.TabIndex = 2;
            label10.Text = "Certificate Singining Request (CSR)";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.BackColor = Color.FromArgb(128, 255, 128);
            label11.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Navy;
            label11.Location = new Point(484, 190);
            label11.Name = "label11";
            label11.Size = new Size(339, 15);
            label11.TabIndex = 2;
            label11.Text = "Private Key";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.BackColor = Color.FromArgb(128, 255, 128);
            label13.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Navy;
            label13.Location = new Point(484, 291);
            label13.Name = "label13";
            label13.Size = new Size(339, 15);
            label13.TabIndex = 2;
            label13.Text = "Signed Certificate";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.BackColor = Color.FromArgb(128, 255, 128);
            label14.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.Navy;
            label14.Location = new Point(484, 392);
            label14.Name = "label14";
            label14.Size = new Size(339, 15);
            label14.TabIndex = 2;
            label14.Text = "Secret Key";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(828, 144);
            button1.Name = "button1";
            button1.Size = new Size(41, 23);
            button1.TabIndex = 6;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(826, 251);
            button2.Name = "button2";
            button2.Size = new Size(41, 23);
            button2.TabIndex = 6;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(826, 355);
            button3.Name = "button3";
            button3.Size = new Size(41, 23);
            button3.TabIndex = 6;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(826, 460);
            button4.Name = "button4";
            button4.Size = new Size(41, 23);
            button4.TabIndex = 6;
            button4.Text = "Save";
            button4.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.BorderStyle = BorderStyle.Fixed3D;
            label16.Location = new Point(453, 70);
            label16.Name = "label16";
            label16.Size = new Size(4, 423);
            label16.TabIndex = 8;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(7, 50, 67);
            label15.Location = new Point(243, 25);
            label15.Name = "label15";
            label15.Size = new Size(451, 23);
            label15.TabIndex = 15;
            label15.Text = "Generate Cryptographic Stamp Identifier (CSID)";
            // 
            // label17
            // 
            label17.BorderStyle = BorderStyle.Fixed3D;
            label17.Location = new Point(47, 493);
            label17.Name = "label17";
            label17.Size = new Size(847, 4);
            label17.TabIndex = 8;
            // 
            // label18
            // 
            label18.BorderStyle = BorderStyle.Fixed3D;
            label18.Location = new Point(72, 67);
            label18.Name = "label18";
            label18.Size = new Size(847, 4);
            label18.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ZATCA_sm_profile_05;
            pictureBox1.Location = new Point(72, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // frmCSID
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 514);
            Controls.Add(pictureBox1);
            Controls.Add(label15);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnInvoice);
            Controls.Add(chkIsProduction);
            Controls.Add(btnGenerateCSID);
            Controls.Add(label12);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label2);
            Controls.Add(cmbCountry);
            Controls.Add(cmbInvoiceType);
            Controls.Add(txtOTP);
            Controls.Add(txtIndustry);
            Controls.Add(txtLocation);
            Controls.Add(txtOrganizationName);
            Controls.Add(txtUnitName);
            Controls.Add(txtUID);
            Controls.Add(txtSlno);
            Controls.Add(txtSecret);
            Controls.Add(txtSigned);
            Controls.Add(txtPrivate);
            Controls.Add(txtCSR);
            Controls.Add(txtCommonName);
            Name = "frmCSID";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zatca e-Invoicing  CSR AND CSID GENRATE";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCommonName;
        private ComboBox cmbInvoiceType;
        private Button btnGenerateCSID;
        private TextBox txtSlno;
        private TextBox txtUID;
        private TextBox txtOrganizationName;
        private TextBox txtLocation;
        private TextBox txtIndustry;
        private ComboBox cmbCountry;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtOTP;
        private Label label12;
        private TextBox txtCSR;
        private TextBox txtPrivate;
        private TextBox txtSigned;
        private TextBox txtSecret;
        private CheckBox chkIsProduction;
        private TextBox txtUnitName;
        private Label label1;
        private Button btnInvoice;
        private Label label10;
        private Label label11;
        private Label label13;
        private Label label14;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label16;
        private Label label15;
        private Label label17;
        private Label label18;
        private PictureBox pictureBox1;
    }
}