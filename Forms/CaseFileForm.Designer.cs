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
            dgvCaseFiles.Location = new Point(0, 60);
            dgvCaseFiles.Name = "dgvCaseFiles";
            dgvCaseFiles.Size = new Size(850, 404);
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
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 60);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 6;
            label1.Text = "Tìm kiếm:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(90, 13);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(330, 29);
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
            btnAdd.Location = new Point(599, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(128, 31);
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
            btnDocuments.Location = new Point(733, 12);
            btnDocuments.Name = "btnDocuments";
            btnDocuments.Size = new Size(106, 31);
            btnDocuments.TabIndex = 4;
            btnDocuments.Text = " Xem hồ sơ";
            btnDocuments.UseVisualStyleBackColor = false;
            btnDocuments.Click += btnDocuments_Click;
            // 
            // CaseFileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 464);
            Controls.Add(dgvCaseFiles);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
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