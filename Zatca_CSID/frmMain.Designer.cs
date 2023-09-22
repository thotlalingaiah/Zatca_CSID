namespace Zatca_CSID
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            transactionsToolStripMenuItem = new ToolStripMenuItem();
            certificateToolStripMenuItem = new ToolStripMenuItem();
            createInvoiceToolStripMenuItem = new ToolStripMenuItem();
            onBoardingInvoiceToolStripMenuItem = new ToolStripMenuItem();
            getNewTokenToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, transactionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1026, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // transactionsToolStripMenuItem
            // 
            transactionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { certificateToolStripMenuItem, createInvoiceToolStripMenuItem, onBoardingInvoiceToolStripMenuItem, getNewTokenToolStripMenuItem });
            transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            transactionsToolStripMenuItem.Size = new Size(84, 20);
            transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // certificateToolStripMenuItem
            // 
            certificateToolStripMenuItem.Name = "certificateToolStripMenuItem";
            certificateToolStripMenuItem.Size = new Size(182, 22);
            certificateToolStripMenuItem.Text = "Certificate Generate";
            certificateToolStripMenuItem.Click += certificateToolStripMenuItem_Click;
            // 
            // createInvoiceToolStripMenuItem
            // 
            createInvoiceToolStripMenuItem.Name = "createInvoiceToolStripMenuItem";
            createInvoiceToolStripMenuItem.Size = new Size(182, 22);
            createInvoiceToolStripMenuItem.Text = "Create Invoice";
            createInvoiceToolStripMenuItem.Click += createInvoiceToolStripMenuItem_Click;
            // 
            // onBoardingInvoiceToolStripMenuItem
            // 
            onBoardingInvoiceToolStripMenuItem.Name = "onBoardingInvoiceToolStripMenuItem";
            onBoardingInvoiceToolStripMenuItem.Size = new Size(182, 22);
            onBoardingInvoiceToolStripMenuItem.Text = "On Boarding Invoice";
            onBoardingInvoiceToolStripMenuItem.Click += onBoardingInvoiceToolStripMenuItem_Click;
            // 
            // getNewTokenToolStripMenuItem
            // 
            getNewTokenToolStripMenuItem.Name = "getNewTokenToolStripMenuItem";
            getNewTokenToolStripMenuItem.Size = new Size(182, 22);
            getNewTokenToolStripMenuItem.Text = "Get New Token";
            getNewTokenToolStripMenuItem.Click += getNewTokenToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 521);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-Invoice Zatca";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem transactionsToolStripMenuItem;
        private ToolStripMenuItem certificateToolStripMenuItem;
        private ToolStripMenuItem createInvoiceToolStripMenuItem;
        private ToolStripMenuItem onBoardingInvoiceToolStripMenuItem;
        private ToolStripMenuItem getNewTokenToolStripMenuItem;
    }
}