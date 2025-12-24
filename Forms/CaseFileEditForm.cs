using LawOfficeManagement.Data;
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
using System.Windows.Forms.VisualStyles;

namespace LawOfficeManagement.Forms
{
    public partial class CaseFileEditForm : Form
    {
        public CaseFile CurrentCaseFile { get; set; }
        public CaseFileEditForm(CaseFile? caseFile = null)
        {
            InitializeComponent();

            CurrentCaseFile = caseFile ?? new CaseFile
            {
                ReceivedDate = DateTime.Today,
                Status = CaseStatus.Open
            };

            using var context = new LawOfficeContext();

            // Client
            cboClient.DataSource = context.Clients
                .OrderBy(c => c.FullName)
                .ToList();
            cboClient.DisplayMember = "FullName";
            cboClient.ValueMember = "ClientId";

            // Status (enum)
            var statusList = Enum.GetValues(typeof(CaseStatus))
                .Cast<CaseStatus>()
                .Select(x => new { Id = (int)x, Name = EnumHelper.GetDescription(x) })
                .ToList();

            cboStatus.DataSource = statusList;
            cboStatus.DisplayMember = "Name";
            cboStatus.ValueMember = "Id";

            // Edit
            if (caseFile != null)
            {
                txtTitle.Text = caseFile.Title;
                dtpReceivedDate.Value = caseFile.ReceivedDate;
                cboClient.SelectedValue = caseFile.ClientId;
                cboStatus.SelectedValue = (int)caseFile.Status;
            }
            else
            {
                cboStatus.SelectedValue = (int)CaseStatus.Open;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Tiêu đề hồ sơ không được để trống.");
                return;
            }

            CurrentCaseFile.Title = txtTitle.Text.Trim();
            CurrentCaseFile.ReceivedDate = dtpReceivedDate.Value;

            var selectedValue = cboClient.SelectedValue;

            if (selectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng hợp lệ từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboClient.Focus();
                return;
            }
            CurrentCaseFile.ClientId = Convert.ToInt32(selectedValue);

            CurrentCaseFile.Status = (CaseStatus)(int)cboStatus.SelectedValue;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void CaseFileEditForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
