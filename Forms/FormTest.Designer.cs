namespace LawOfficeManagement.Forms
{
    partial class FormTest
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
            txtName = new TextBox();
            txtPhone = new TextBox();
            btnAdd = new Button();
            btnLoad = new Button();
            dgvClients = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(52, 58);
            txtName.Name = "txtName";
            txtName.Size = new Size(170, 23);
            txtName.TabIndex = 0;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(52, 103);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(170, 23);
            txtPhone.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(52, 203);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(52, 232);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(139, 23);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += BtnLoad_Click;
            // 
            // dgvClients
            // 
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Location = new Point(289, 41);
            dgvClients.Name = "dgvClients";
            dgvClients.Size = new Size(452, 352);
            dgvClients.TabIndex = 4;
            // 
            // FormTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvClients);
            Controls.Add(btnLoad);
            Controls.Add(btnAdd);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Name = "FormTest";
            Text = "FormTest";
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtPhone;
        private Button btnAdd;
        private Button btnLoad;
        private DataGridView dgvClients;
    }
}