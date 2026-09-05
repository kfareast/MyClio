namespace LawOfficeManagement.Forms
{
    partial class CaseFileForm
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
            dgvCaseFiles = new DataGridView();
            editCol = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            panel1 = new Panel();
            label1 = new Label();
            txtSearch = new TextBox();
            btnAdd = new Button();
            btnDocuments = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCaseFiles).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCaseFiles
            // 
            dgvCaseFiles.AllowUserToResizeRows = false;
            dgvCaseFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCaseFiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCaseFiles.Columns.AddRange(new DataGridViewColumn[] { editCol, Delete });
            dgvCaseFiles.Dock = DockStyle.Fill;
            dgvCaseFiles.Location = new Point(0, 100);
            dgvCaseFiles.Margin = new Padding(4, 5, 4, 5);
            dgvCaseFiles.Name = "dgvCaseFiles";
            dgvCaseFiles.RowHeadersWidth = 62;
            dgvCaseFiles.Size = new Size(1214, 673);
            dgvCaseFiles.TabIndex = 0;
            dgvCaseFiles.CellClick += DgvCaseFiles_CellClick;
            dgvCaseFiles.CellContentClick += dgvCaseFiles_CellContentClick;
            // 
            // editCol
            // 
            editCol.FillWeight = 25F;
            editCol.FlatStyle = FlatStyle.Flat;
            editCol.HeaderText = "";
            editCol.MinimumWidth = 50;
            editCol.Name = "editCol";
            editCol.Resizable = DataGridViewTriState.False;
            editCol.Text = "Edit";
            editCol.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            Delete.FillWeight = 25F;
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.HeaderText = "";
            Delete.MinimumWidth = 50;
            Delete.Name = "Delete";
            Delete.Resizable = DataGridViewTriState.False;
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnDocuments);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1214, 100);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(17, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 32);
            label1.TabIndex = 6;
            label1.Text = "Tìm kiếm:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(143, 24);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(470, 39);
            txtSearch.TabIndex = 5;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = SystemColors.Control;
            btnAdd.FlatAppearance.BorderColor = Color.White;
            btnAdd.Font = new Font("Segoe UI", 11.25F);
            btnAdd.ForeColor = SystemColors.ControlText;
            btnAdd.Location = new Point(856, 20);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(183, 52);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Thêm vụ việc";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDocuments
            // 
            btnDocuments.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDocuments.BackColor = SystemColors.Control;
            btnDocuments.FlatAppearance.BorderColor = Color.White;
            btnDocuments.Font = new Font("Segoe UI", 11.25F);
            btnDocuments.ForeColor = SystemColors.ControlText;
            btnDocuments.Location = new Point(1047, 20);
            btnDocuments.Margin = new Padding(4, 5, 4, 5);
            btnDocuments.Name = "btnDocuments";
            btnDocuments.Size = new Size(151, 52);
            btnDocuments.TabIndex = 4;
            btnDocuments.Text = " Xem hồ sơ";
            btnDocuments.UseVisualStyleBackColor = false;
            btnDocuments.Click += btnDocuments_Click;
            // 
            // CaseFileForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 773);
            Controls.Add(dgvCaseFiles);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4, 5, 4, 5);
            Name = "CaseFileForm";
            Text = "CaseFileForm";
            Load += CaseFileForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCaseFiles).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCaseFiles;
        private Panel panel1;
        private Button btnAdd;
        private Button btnDocuments;
        private Label label1;
        private TextBox txtSearch;
        private DataGridViewButtonColumn editCol;
        private DataGridViewButtonColumn Delete;
    }
}