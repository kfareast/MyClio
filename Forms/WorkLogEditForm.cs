using LawOfficeManagement.Models;
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
    public partial class WorkLogEditForm : Form
    {
        public WorkLog CurrentWorkLog { get; set; }

        public WorkLogEditForm(WorkLog? workLog = null)
        {
            InitializeComponent();

            CurrentWorkLog = workLog ?? new WorkLog
            {
                Date = DateTime.Today,
                Status = Models.TaskStatus.Pending
            };

            // Bind ComboBox hiển thị Description
            var statusList = Enum.GetValues(typeof(Models.TaskStatus))
                .Cast<Models.TaskStatus>()
                .Select(s => new { Value = s, Text = EnumHelper.GetDescription(s) })
                .ToList();

            cboStatus.DisplayMember = "Text";
            cboStatus.ValueMember = "Value";
            cboStatus.DataSource = statusList;

            if (workLog != null)
            {
                txtTitle.Text = workLog.Title;
                dtpWorkDate.Value = workLog.Date;
                cboStatus.SelectedValue = workLog.Status;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Tiêu đề không được để trống.");
                return;
            }

            CurrentWorkLog.Title = txtTitle.Text.Trim();
            CurrentWorkLog.Date = dtpWorkDate.Value;
            CurrentWorkLog.Status = (Models.TaskStatus)cboStatus.SelectedValue;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
