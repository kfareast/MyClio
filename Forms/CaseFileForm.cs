using LawOfficeManagement.Data;
using LawOfficeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LawOfficeManagement.Forms
{
    public partial class CaseFileForm : Form
    {
        public CaseFileForm()
        {
            //InitializeComponent();
            InitializeDataGridView();
        }
        private void InitializeDataGridView()
        {
            InitializeComponent();
            dgvCaseFiles.AutoGenerateColumns = false;
            dgvCaseFiles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCaseFiles.MultiSelect = false;
            dgvCaseFiles.AllowUserToAddRows = false;
            dgvCaseFiles.RowHeadersVisible = false;

            dgvCaseFiles.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CaseFileId",
                DataPropertyName = "CaseFileId",
                Visible = false
            });
            dgvCaseFiles.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Title",
                DataPropertyName = "Title",
                HeaderText = "Tiêu đề",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvCaseFiles.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ClientName",
                DataPropertyName = "ClientName",
                HeaderText = "Khách hàng",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dgvCaseFiles.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Status",
                DataPropertyName = "Status",
                HeaderText = "Trạng thái",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            dgvCaseFiles.CellFormatting += DgvCaseFiles_CellFormatting;

            LoadCaseFiles();
        }
        private void LoadCaseFiles()
        {
            using var context = new LawOfficeContext();

            var data = context.CaseFiles
                .Include(c => c.Client)
                .OrderBy(c => c.ReceivedDate)
                .Select(c => new
                {
                    c.CaseFileId,
                    c.Title,
                    ClientName = c.Client.FullName,
                    c.Status,
                    c.ReceivedDate
                })
                .ToList();

            dgvCaseFiles.DataSource = data;
        }

        private void CaseFileForm_Load(object sender, EventArgs e)
        {
            dgvCaseFiles.AutoGenerateColumns = true;
            dgvCaseFiles.ReadOnly = true;
            dgvCaseFiles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCaseFiles.MultiSelect = false;

            LoadCaseFiles();
        }
        private void DgvCaseFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.RowIndex >= dgvCaseFiles.Rows.Count)
                return;

            var column = dgvCaseFiles.Columns[e.ColumnIndex];
            if (column is DataGridViewButtonColumn)
            {
                string? buttonText = dgvCaseFiles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
                int caseFileId = (int)dgvCaseFiles.Rows[e.RowIndex].Cells["CaseFileId"].Value;

                if (buttonText == "Edit")
                    EditCaseFile(caseFileId);
                else if (buttonText == "Delete")
                    DeleteCaseFile(caseFileId);
            }
        }
        private void DgvCaseFiles_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCaseFiles.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                var val = (CaseStatus)e.Value;
                e.Value = EnumHelper.GetDescription(val);
                e.FormattingApplied = true;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var form = new CaseFileEditForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                using var context = new LawOfficeContext();
                context.CaseFiles.Add(form.CurrentCaseFile);
                context.SaveChanges();

                LoadCaseFiles();
            }
        }
        private void EditCaseFile(int caseFileId)
        {
            using var context = new LawOfficeContext();
            var caseFile = context.CaseFiles.Find(caseFileId);
            if (caseFile == null) return;

            using var form = new CaseFileEditForm(caseFile);
            if (form.ShowDialog() == DialogResult.OK)
            {
                context.SaveChanges();
                LoadCaseFiles();
            }
        }

        private void DeleteCaseFile(int caseFileId)
        {
            var confirm = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa hồ sơ này?\nDữ liệu liên quan cũng sẽ bị xóa.",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            using var context = new LawOfficeContext();
            var caseFile = context.CaseFiles
                .Include(c => c.Documents)
                .FirstOrDefault(c => c.CaseFileId == caseFileId);

            if (caseFile == null) return;

            context.CaseFiles.Remove(caseFile);
            context.SaveChanges();
            LoadCaseFiles();
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            if (dgvCaseFiles.CurrentRow == null)
                return;

            int caseFileId = (int)dgvCaseFiles.CurrentRow.Cells["CaseFileId"].Value;
            string caseName = dgvCaseFiles.CurrentRow.Cells["Title"].Value.ToString();

            using var form = new DocumentForm(caseFileId, caseName);
            form.ShowDialog();
        }
        private void dgvCaseFiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
