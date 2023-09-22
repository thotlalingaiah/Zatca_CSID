namespace Zatca_CSID
{
    partial class frmRegister
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
            txtFullname = new TextBox();
            label1 = new Label();
            cmbLicense = new ComboBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMobile = new TextBox();
            txtPwd = new TextBox();
            label6 = new Label();
            txtCPwd = new TextBox();
            txtUserName = new TextBox();
            label8 = new Label();
            label11 = new Label();
            linkLabel1 = new LinkLabel();
            btnLogin = new Button();
            label10 = new Label();
            label9 = new Label();
            label12 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            panel1 = new Panel();
            btnSubmit = new Button();
            btnClose = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(458, 64);
            txtFullname.Name = "txtFullname";
            txtFullname.PlaceholderText = "First name and last name";
            txtFullname.Size = new Size(239, 23);
            txtFullname.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(7, 50, 67);
            label1.Location = new Point(324, 65);
            label1.Name = "label1";
            label1.Size = new Size(128, 23);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbLicense
            // 
            cmbLicense.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLicense.FormattingEnabled = true;
            cmbLicense.Location = new Point(458, 238);
            cmbLicense.Name = "cmbLicense";
            cmbLicense.Size = new Size(239, 23);
            cmbLicense.TabIndex = 7;
            cmbLicense.Visible = false;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(7, 50, 67);
            label2.Location = new Point(360, 97);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 2;
            label2.Text = "Email Address:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(458, 91);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email will sent for Verification";
            txtEmail.Size = new Size(239, 23);
            txtEmail.TabIndex = 2;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(7, 50, 67);
            label3.Location = new Point(277, 119);
            label3.Name = "label3";
            label3.Size = new Size(175, 20);
            label3.TabIndex = 2;
            label3.Text = "Mobile Number:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(7, 50, 67);
            label4.Location = new Point(364, 182);
            label4.Name = "label4";
            label4.Size = new Size(88, 19);
            label4.TabIndex = 2;
            label4.Text = "Password:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(7, 50, 67);
            label5.Location = new Point(317, 242);
            label5.Name = "label5";
            label5.Size = new Size(135, 15);
            label5.TabIndex = 2;
            label5.Text = "Subscription:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            label5.Visible = false;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(458, 119);
            txtMobile.Name = "txtMobile";
            txtMobile.PlaceholderText = "Mobile Number Ex: +971527442889";
            txtMobile.Size = new Size(239, 23);
            txtMobile.TabIndex = 3;
            // 
            // txtPwd
            // 
            txtPwd.BackColor = SystemColors.Info;
            txtPwd.Location = new Point(458, 178);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(239, 23);
            txtPwd.TabIndex = 5;
            txtPwd.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(7, 50, 67);
            label6.Location = new Point(317, 212);
            label6.Name = "label6";
            label6.Size = new Size(135, 15);
            label6.TabIndex = 2;
            label6.Text = "Confirm Password:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCPwd
            // 
            txtCPwd.BackColor = SystemColors.Info;
            txtCPwd.Location = new Point(458, 209);
            txtCPwd.Name = "txtCPwd";
            txtCPwd.Size = new Size(239, 23);
            txtCPwd.TabIndex = 6;
            txtCPwd.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.Info;
            txtUserName.Location = new Point(458, 149);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "UserName";
            txtUserName.Size = new Size(239, 23);
            txtUserName.TabIndex = 4;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(7, 50, 67);
            label8.Location = new Point(340, 153);
            label8.Name = "label8";
            label8.Size = new Size(112, 19);
            label8.TabIndex = 2;
            label8.Text = "User Name:";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.BorderStyle = BorderStyle.Fixed3D;
            label11.Location = new Point(260, 364);
            label11.Name = "label11";
            label11.Size = new Size(541, 3);
            label11.TabIndex = 23;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(7, 50, 67);
            linkLabel1.Location = new Point(434, 417);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(148, 15);
            linkLabel1.TabIndex = 22;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "thotlalingaiah@gmail.com";
            // 
            // btnLogin
            // 
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.FromArgb(7, 50, 67);
            btnLogin.Location = new Point(627, 336);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(50, 21);
            btnLogin.TabIndex = 18;
            btnLogin.Text = "Login?";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label10
            // 
            label10.ForeColor = Color.Gray;
            label10.Location = new Point(277, 417);
            label10.Name = "label10";
            label10.Size = new Size(166, 18);
            label10.TabIndex = 11;
            label10.Text = "submit an email messsage to";
            // 
            // label9
            // 
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(277, 399);
            label9.Name = "label9";
            label9.Size = new Size(291, 18);
            label9.TabIndex = 12;
            label9.Text = "To obtain access this App or any questions about it";
            // 
            // label12
            // 
            label12.ForeColor = Color.Gray;
            label12.Location = new Point(277, 382);
            label12.Name = "label12";
            label12.Size = new Size(53, 17);
            label12.TabIndex = 13;
            label12.Text = "Support";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ZATCA_sm_profile_051;
            pictureBox2.Location = new Point(12, 219);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(81, 85);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.ZATCA_sm_profile_05;
            pictureBox1.Image = Properties.Resources._723cd694;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(7, 50, 67);
            button1.Location = new Point(575, 315);
            button1.Name = "button1";
            button1.Size = new Size(113, 23);
            button1.TabIndex = 19;
            button1.Text = "Forgot password?";
            button1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(7, 50, 67);
            label13.Location = new Point(458, 27);
            label13.Name = "label13";
            label13.Size = new Size(210, 23);
            label13.TabIndex = 14;
            label13.Text = "Register your account";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(224, 224, 224);
            label14.Location = new Point(142, 369);
            label14.Name = "label14";
            label14.Size = new Size(103, 17);
            label14.TabIndex = 2;
            label14.Text = "e-Technologies";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 9.75F, FontStyle.Underline, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(224, 224, 224);
            label15.Location = new Point(148, 344);
            label15.Name = "label15";
            label15.Size = new Size(97, 17);
            label15.TabIndex = 2;
            label15.Text = "Developed By";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(45, 177);
            label16.Name = "label16";
            label16.Size = new Size(194, 22);
            label16.TabIndex = 2;
            label16.Text = "Phase -2 Integration";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.White;
            label17.Location = new Point(12, 133);
            label17.Name = "label17";
            label17.Size = new Size(227, 22);
            label17.TabIndex = 2;
            label17.Text = "Welcome to e-Invoicing";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 50, 67);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label17);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(254, 436);
            panel1.TabIndex = 21;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(7, 50, 67);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(464, 274);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(99, 35);
            btnSubmit.TabIndex = 20;
            btnSubmit.Text = "Register";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(569, 274);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(99, 35);
            btnClose.TabIndex = 20;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(224, 224, 224);
            label7.Location = new Point(360, 237);
            label7.Name = "label7";
            label7.Size = new Size(381, 26);
            label7.TabIndex = 24;
            label7.Text = "RESPONSE STATUS";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.Visible = false;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 436);
            Controls.Add(label7);
            Controls.Add(label11);
            Controls.Add(linkLabel1);
            Controls.Add(btnLogin);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label12);
            Controls.Add(button1);
            Controls.Add(label13);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(btnSubmit);
            Controls.Add(txtUserName);
            Controls.Add(txtMobile);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(cmbLicense);
            Controls.Add(txtFullname);
            Controls.Add(label5);
            Controls.Add(txtCPwd);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtPwd);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Registeration";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtFullname;
        private Label label1;
        private ComboBox cmbLicense;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMobile;
        private TextBox txtPwd;
        private Label label6;
        private TextBox txtCPwd;
        private TextBox txtUserName;
        private Label label8;
        private Label label11;
        private LinkLabel linkLabel1;
        private Button btnLogin;
        private Label label10;
        private Label label9;
        private Label label12;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Panel panel1;
        private Button btnSubmit;
        private Button btnClose;
        private Label label7;
    }
}