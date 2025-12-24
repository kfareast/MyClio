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
            btnAdd = new Button();
            btnWorkLogs = new Button();
            btnDocuments = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCaseFiles).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCaseFiles
            // 
            dgvCaseFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCaseFiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCaseFiles.Columns.AddRange(new DataGridViewColumn[] { editCol, Delete });
            dgvCaseFiles.Dock = DockStyle.Fill;
            dgvCaseFiles.Location = new Point(0, 50);
            dgvCaseFiles.Name = "dgvCaseFiles";
            dgvCaseFiles.Size = new Size(850, 414);
            dgvCaseFiles.TabIndex = 0;
            dgvCaseFiles.CellClick += DgvCaseFiles_CellClick;
            dgvCaseFiles.CellContentClick += dgvCaseFiles_CellContentClick;
            // 
            // editCol
            // 
            editCol.FillWeight = 25F;
            editCol.FlatStyle = FlatStyle.Flat;
            editCol.HeaderText = "";
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
            Delete.Name = "Delete";
            Delete.Resizable = DataGridViewTriState.False;
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnWorkLogs);
            panel1.Controls.Add(btnDocuments);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 50);
            panel1.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Control;
            btnAdd.FlatAppearance.BorderColor = Color.White;
            btnAdd.Font = new Font("Segoe UI", 9F);
            btnAdd.ForeColor = SystemColors.ControlText;
            btnAdd.Location = new Point(12, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(95, 26);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Thêm vụ việc";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnWorkLogs
            // 
            btnWorkLogs.Location = new Point(214, 12);
            btnWorkLogs.Name = "btnWorkLogs";
            btnWorkLogs.Size = new Size(95, 26);
            btnWorkLogs.TabIndex = 5;
            btnWorkLogs.Text = "work log";
            btnWorkLogs.UseVisualStyleBackColor = true;
            btnWorkLogs.Visible = false;
            btnWorkLogs.Click += btnWorkLogs_Click;
            // 
            // btnDocuments
            // 
            btnDocuments.BackColor = SystemColors.Control;
            btnDocuments.FlatAppearance.BorderColor = Color.White;
            btnDocuments.Font = new Font("Segoe UI", 9F);
            btnDocuments.ForeColor = SystemColors.ControlText;
            btnDocuments.Location = new Point(113, 12);
            btnDocuments.Name = "btnDocuments";
            btnDocuments.Size = new Size(95, 26);
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
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCaseFiles;
        private Panel panel1;
        private DataGridViewButtonColumn editCol;
        private DataGridViewButtonColumn Delete;
        private Button btnAdd;
        private Button btnWorkLogs;
        private Button btnDocuments;
    }
}