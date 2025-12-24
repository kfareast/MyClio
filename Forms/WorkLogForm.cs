using LawOfficeManagement.Data;
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
    public partial class WorkLogForm : Form
    {
        private readonly int _caseFileId;
        private BindingSource _bindingSource = new BindingSource();
        public WorkLogForm(int caseFileId)
        {
            InitializeComponent();
            _caseFileId = caseFileId;
        }
        private void WorkLogForm_Load(object sender, EventArgs e)
        {
            dgvWorkLogs.AutoGenerateColumns = false; // Tự tạo cột
            InitializeDataGridViewColumns();
            LoadWorkLogs();
        }

        private void InitializeDataGridViewColumns()
        {
            dgvWorkLogs.Columns.Clear();

            dgvWorkLogs.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "WorkLogId",
                DataPropertyName = "WorkLogId",
                HeaderText = "ID",
                Visible = false
            });

            dgvWorkLogs.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Title",
                HeaderText = "Tiêu đề"
            });

            dgvWorkLogs.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Date",
                HeaderText = "Ngày",
                DefaultCellStyle = { Format = "dd/MM/yyyy" }
            });

            dgvWorkLogs.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StatusText",
                HeaderText = "Trạng thái"
            });

            dgvWorkLogs.DataSource = _bindingSource;
        }

        private void LoadWorkLogs()
        {
            using var context = new LawOfficeContext();

            var data = context.WorkLogs
                .Where(w => w.CaseFileId == _caseFileId)
                .OrderByDescending(w => w.Date)
                .Select(w => new
                {
                    w.WorkLogId,
                    w.Title,
                    w.Date,
                    StatusText = EnumHelper.GetDescription(w.Status)
                })
                .ToList();

            _bindingSource.DataSource = data;
        }    

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var form = new WorkLogEditForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                form.CurrentWorkLog.CaseFileId = _caseFileId;

                using var context = new LawOfficeContext();
                context.WorkLogs.Add(form.CurrentWorkLog);
                context.SaveChanges();

                LoadWorkLogs();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvWorkLogs.CurrentRow == null)
                return;

            int id = (int)dgvWorkLogs.CurrentRow.Cells["WorkLogId"].Value;

            using var context = new LawOfficeContext();
            var workLog = context.WorkLogs.Find(id);
            if (workLog == null)
                return;

            using var form = new WorkLogEditForm(workLog);

            if (form.ShowDialog() == DialogResult.OK)
            {
                context.SaveChanges();
                LoadWorkLogs();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvWorkLogs.CurrentRow == null)
                return;

            int id = (int)dgvWorkLogs.CurrentRow.Cells["WorkLogId"].Value;

            using var context = new LawOfficeContext();
            var workLog = context.WorkLogs.Find(id);
            if (workLog == null)
                return;

            context.WorkLogs.Remove(workLog);
            context.SaveChanges();

            LoadWorkLogs();
        }
    }
}
