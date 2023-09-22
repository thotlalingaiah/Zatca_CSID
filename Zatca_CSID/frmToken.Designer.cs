namespace Zatca_CSID
{
    partial class frmToken
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
            txtToken = new TextBox();
            label1 = new Label();
            btnTokenGenerate = new Button();
            btnSavetoDisk = new Button();
            SuspendLayout();
            // 
            // txtToken
            // 
            txtToken.Location = new Point(44, 57);
            txtToken.Multiline = true;
            txtToken.Name = "txtToken";
            txtToken.ScrollBars = ScrollBars.Vertical;
            txtToken.Size = new Size(632, 183);
            txtToken.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(46, 31);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 1;
            label1.Text = "JWT Token";
            // 
            // btnTokenGenerate
            // 
            btnTokenGenerate.BackColor = Color.FromArgb(128, 255, 128);
            btnTokenGenerate.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTokenGenerate.Location = new Point(156, 261);
            btnTokenGenerate.Name = "btnTokenGenerate";
            btnTokenGenerate.Size = new Size(179, 58);
            btnTokenGenerate.TabIndex = 2;
            btnTokenGenerate.Text = "Generate Token";
            btnTokenGenerate.UseVisualStyleBackColor = false;
            btnTokenGenerate.Click += btnTokenGenerate_Click;
            // 
            // btnSavetoDisk
            // 
            btnSavetoDisk.BackColor = Color.FromArgb(128, 255, 255);
            btnSavetoDisk.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSavetoDisk.Location = new Point(356, 261);
            btnSavetoDisk.Name = "btnSavetoDisk";
            btnSavetoDisk.Size = new Size(179, 58);
            btnSavetoDisk.TabIndex = 2;
            btnSavetoDisk.Text = "Save To Disk";
            btnSavetoDisk.UseVisualStyleBackColor = false;
            btnSavetoDisk.Click += btnSavetoDisk_Click;
            // 
            // frmToken
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 401);
            Controls.Add(btnSavetoDisk);
            Controls.Add(btnTokenGenerate);
            Controls.Add(label1);
            Controls.Add(txtToken);
            Name = "frmToken";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Token Generate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtToken;
        private Label label1;
        private Button btnTokenGenerate;
        private Button btnSavetoDisk;
    }
}