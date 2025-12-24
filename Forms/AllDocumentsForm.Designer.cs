namespace LawOfficeManagement.Forms
{
    partial class AllDocumentsForm
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
            treeDocuments = new TreeView();
            panel1 = new Panel();
            btnSearch = new Button();
            label1 = new Label();
            txtSearch = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // treeDocuments
            // 
            treeDocuments.Dock = DockStyle.Fill;
            treeDocuments.Location = new Point(0, 60);
            treeDocuments.Margin = new Padding(3, 4, 3, 4);
            treeDocuments.Name = "treeDocuments";
            treeDocuments.Size = new Size(961, 432);
            treeDocuments.TabIndex = 0;
            treeDocuments.NodeMouseDoubleClick += treeDocuments_NodeMouseDoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(961, 60);
            panel1.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(435, 9);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(87, 40);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 1;
            label1.Text = "Tìm kiếm tài liệu:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(137, 16);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(292, 27);
            txtSearch.TabIndex = 0;
            // 
            // AllDocumentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 492);
            Controls.Add(treeDocuments);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AllDocumentsForm";
            Text = "AllDocumentsForm";
            Load += AllDocumentsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeDocuments;
        private Panel panel1;
        private Label label1;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}