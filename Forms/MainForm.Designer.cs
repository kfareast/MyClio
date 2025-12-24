namespace LawOfficeManagement
{
    partial class MainForm
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
            panelMenu = new Panel();
            btnDocument = new Button();
            btnClient = new Button();
            btnCaseFile = new Button();
            panelLogo = new Panel();
            panelTitleBar = new Panel();
            lblTitle = new Label();
            panelDesktop = new Panel();
            panelMenu.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btnDocument);
            panelMenu.Controls.Add(btnCaseFile);
            panelMenu.Controls.Add(btnClient);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 681);
            panelMenu.TabIndex = 0;
            // 
            // btnDocument
            // 
            btnDocument.Dock = DockStyle.Top;
            btnDocument.FlatAppearance.BorderSize = 0;
            btnDocument.FlatStyle = FlatStyle.Flat;
            btnDocument.Font = new Font("Segoe UI", 14F);
            btnDocument.Location = new Point(0, 200);
            btnDocument.Name = "btnDocument";
            btnDocument.Size = new Size(220, 60);
            btnDocument.TabIndex = 3;
            btnDocument.Text = "Hồ sơ";
            btnDocument.UseVisualStyleBackColor = true;
            btnDocument.Click += button2_Click;
            // 
            // btnClient
            // 
            btnClient.Dock = DockStyle.Top;
            btnClient.FlatAppearance.BorderSize = 0;
            btnClient.FlatStyle = FlatStyle.Flat;
            btnClient.Font = new Font("Segoe UI", 14F);
            btnClient.Location = new Point(0, 80);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(220, 60);
            btnClient.TabIndex = 1;
            btnClient.Text = "Liên hệ";
            btnClient.UseVisualStyleBackColor = true;
            btnClient.Click += BtnClient_Click;
            // 
            // btnCaseFile
            // 
            btnCaseFile.Dock = DockStyle.Top;
            btnCaseFile.FlatAppearance.BorderSize = 0;
            btnCaseFile.FlatStyle = FlatStyle.Flat;
            btnCaseFile.Font = new Font("Segoe UI", 14F);
            btnCaseFile.ImageAlign = ContentAlignment.MiddleLeft;
            btnCaseFile.Location = new Point(0, 140);
            btnCaseFile.Name = "btnCaseFile";
            btnCaseFile.Size = new Size(220, 60);
            btnCaseFile.TabIndex = 2;
            btnCaseFile.Text = "Vụ việc";
            btnCaseFile.UseVisualStyleBackColor = true;
            btnCaseFile.Click += button1_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.Black;
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.Teal;
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1044, 80);
            panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F);
            lblTitle.Location = new Point(436, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(77, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOME";
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelDesktop.ForeColor = SystemColors.ControlText;
            panelDesktop.Location = new Point(220, 80);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1044, 601);
            panelDesktop.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            ForeColor = Color.Gainsboro;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LawOfficeManagement";
            Load += MainForm_Load;
            panelMenu.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button btnClient;
        private Button btnDocument;
        private Button btnCaseFile;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Panel panelDesktop;
    }
}
