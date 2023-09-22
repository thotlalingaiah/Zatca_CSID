namespace Zatca_CSID
{
    partial class frmLogin
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
            txtUserName = new TextBox();
            label1 = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnClose = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnNewUser = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            linkLabel1 = new LinkLabel();
            label11 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(432, 176);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Username";
            txtUserName.Size = new Size(218, 23);
            txtUserName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(358, 179);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 2;
            label1.Text = "User Name:";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(7, 50, 67);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(432, 254);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(99, 35);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(432, 205);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(218, 23);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(358, 208);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(7, 50, 67);
            label3.Location = new Point(432, 115);
            label3.Name = "label3";
            label3.Size = new Size(209, 23);
            label3.TabIndex = 2;
            label3.Text = "Login to your account";
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.FromArgb(7, 50, 67);
            btnClose.Location = new Point(537, 254);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(113, 23);
            btnClose.TabIndex = 3;
            btnClose.Text = "Forgot password?";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 50, 67);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(254, 436);
            panel1.TabIndex = 5;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(224, 224, 224);
            label7.Location = new Point(142, 369);
            label7.Name = "label7";
            label7.Size = new Size(103, 17);
            label7.TabIndex = 2;
            label7.Text = "e-Technologies";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Underline, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(148, 344);
            label6.Name = "label6";
            label6.Size = new Size(97, 17);
            label6.TabIndex = 2;
            label6.Text = "Developed By";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(45, 177);
            label5.Name = "label5";
            label5.Size = new Size(194, 22);
            label5.TabIndex = 2;
            label5.Text = "Phase -2 Integration";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 133);
            label4.Name = "label4";
            label4.Size = new Size(227, 22);
            label4.TabIndex = 2;
            label4.Text = "Welcome to e-Invoicing";
            // 
            // btnNewUser
            // 
            btnNewUser.FlatAppearance.BorderSize = 0;
            btnNewUser.FlatStyle = FlatStyle.Flat;
            btnNewUser.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewUser.ForeColor = Color.FromArgb(7, 50, 67);
            btnNewUser.Location = new Point(579, 283);
            btnNewUser.Name = "btnNewUser";
            btnNewUser.Size = new Size(71, 21);
            btnNewUser.TabIndex = 3;
            btnNewUser.Text = "New User?";
            btnNewUser.UseVisualStyleBackColor = true;
            btnNewUser.Click += btnNewUser_Click;
            // 
            // label8
            // 
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(286, 380);
            label8.Name = "label8";
            label8.Size = new Size(53, 17);
            label8.TabIndex = 2;
            label8.Text = "Support";
            // 
            // label9
            // 
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(286, 397);
            label9.Name = "label9";
            label9.Size = new Size(291, 18);
            label9.TabIndex = 2;
            label9.Text = "To obtain access this App or any questions about it";
            // 
            // label10
            // 
            label10.ForeColor = Color.Gray;
            label10.Location = new Point(286, 415);
            label10.Name = "label10";
            label10.Size = new Size(166, 18);
            label10.TabIndex = 2;
            label10.Text = "submit an email messsage to";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(7, 50, 67);
            linkLabel1.Location = new Point(443, 415);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(148, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "thotlalingaiah@gmail.com";
            // 
            // label11
            // 
            label11.BorderStyle = BorderStyle.Fixed3D;
            label11.Location = new Point(255, 375);
            label11.Name = "label11";
            label11.Size = new Size(541, 3);
            label11.TabIndex = 7;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 436);
            Controls.Add(label11);
            Controls.Add(linkLabel1);
            Controls.Add(panel1);
            Controls.Add(btnNewUser);
            Controls.Add(btnClose);
            Controls.Add(btnLogin);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private Label label1;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label label2;
        private Label label3;
        private Button btnClose;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label6;
        private Button btnNewUser;
        private Label label8;
        private Label label9;
        private Label label10;
        private LinkLabel linkLabel1;
        private Label label11;
    }
}