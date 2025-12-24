namespace LawOfficeManagement.Forms
{
    partial class DocumentForm
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
            components = new System.ComponentModel.Container();
            dgvDocuments = new DataGridView();
            DocumentId = new DataGridViewTextBoxColumn();
            fileNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            FilePath = new DataGridViewTextBoxColumn();
            createdAtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            caseFileIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            caseFileDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            documentBindingSource = new BindingSource(components);
            btnAdd = new Button();
            btnDelete = new Button();
            btnOpenFile = new Button();
            panel1 = new Panel();
            lblCase = new Label();
            clientBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvDocuments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)documentBindingSource).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvDocuments
            // 
            dgvDocuments.AutoGenerateColumns = false;
            dgvDocuments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDocuments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocuments.Columns.AddRange(new DataGridViewColumn[] { DocumentId, fileNameDataGridViewTextBoxColumn, FilePath, createdAtDataGridViewTextBoxColumn, caseFileIdDataGridViewTextBoxColumn, caseFileDataGridViewTextBoxColumn });
            dgvDocuments.DataSource = documentBindingSource;
            dgvDocuments.Dock = DockStyle.Fill;
            dgvDocuments.Location = new Point(0, 58);
            dgvDocuments.Margin = new Padding(3, 4, 3, 4);
            dgvDocuments.Name = "dgvDocuments";
            dgvDocuments.Size = new Size(733, 303);
            dgvDocuments.TabIndex = 0;
            // 
            // DocumentId
            // 
            DocumentId.DataPropertyName = "DocumentId";
            DocumentId.HeaderText = "DocumentId";
            DocumentId.Name = "DocumentId";
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            fileNameDataGridViewTextBoxColumn.HeaderText = "FileName";
            fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            // 
            // FilePath
            // 
            FilePath.DataPropertyName = "FilePath";
            FilePath.HeaderText = "FilePath";
            FilePath.Name = "FilePath";
            FilePath.Visible = false;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            createdAtDataGridViewTextBoxColumn.HeaderText = "CreatedAt";
            createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            // 
            // caseFileIdDataGridViewTextBoxColumn
            // 
            caseFileIdDataGridViewTextBoxColumn.DataPropertyName = "CaseFileId";
            caseFileIdDataGridViewTextBoxColumn.HeaderText = "CaseFileId";
            caseFileIdDataGridViewTextBoxColumn.Name = "caseFileIdDataGridViewTextBoxColumn";
            caseFileIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // caseFileDataGridViewTextBoxColumn
            // 
            caseFileDataGridViewTextBoxColumn.DataPropertyName = "CaseFile";
            caseFileDataGridViewTextBoxColumn.HeaderText = "CaseFile";
            caseFileDataGridViewTextBoxColumn.Name = "caseFileDataGridViewTextBoxColumn";
            caseFileDataGridViewTextBoxColumn.Visible = false;
            // 
            // documentBindingSource
            // 
            documentBindingSource.DataSource = typeof(Models.Document);
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(546, 13);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 31);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(638, 13);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(454, 13);
            btnOpenFile.Margin = new Padding(3, 4, 3, 4);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(86, 31);
            btnOpenFile.TabIndex = 3;
            btnOpenFile.Text = "Open";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblCase);
            panel1.Controls.Add(btnOpenFile);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnAdd);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(733, 58);
            panel1.TabIndex = 4;
            // 
            // lblCase
            // 
            lblCase.AutoSize = true;
            lblCase.Location = new Point(12, 18);
            lblCase.Name = "lblCase";
            lblCase.Size = new Size(50, 20);
            lblCase.TabIndex = 4;
            lblCase.Text = "label1";
            // 
            // clientBindingSource
            // 
            clientBindingSource.DataSource = typeof(Models.Client);
            // 
            // DocumentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 361);
            Controls.Add(dgvDocuments);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "DocumentForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Danh sách hồ sơ";
            Load += DocumentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDocuments).EndInit();
            ((System.ComponentModel.ISupportInitialize)documentBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDocuments;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnOpenFile;
        private Panel panel1;
        private BindingSource documentBindingSource;
        private BindingSource clientBindingSource;
        private DataGridViewTextBoxColumn DocumentId;
        private DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn FilePath;
        private DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn caseFileIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn caseFileDataGridViewTextBoxColumn;
        private Label lblCase;
    }
}