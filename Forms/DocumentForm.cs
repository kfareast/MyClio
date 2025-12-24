using LawOfficeManagement.Data;
using LawOfficeManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LawOfficeManagement.Forms
{
    public partial class DocumentForm : Form
    {
        private readonly int _caseFileId;
        private readonly string _caseName;
        public DocumentForm(int caseFileId, string caseName)
        {
            InitializeComponent();
            _caseFileId = caseFileId;
            _caseName = caseName;
        }
        private void LoadDocuments()
        {
            using var context = new LawOfficeContext();

            var data = context.Documents
                .Where(d => d.CaseFileId == _caseFileId)
                .Select(d => new
                {
                    d.DocumentId,
                    d.FileName,
                    d.FilePath,
                    d.CreatedAt
                })
                .ToList();

            dgvDocuments.DataSource = data;

            lblCase.Text = _caseName;
        }

        private void DocumentForm_Load(object sender, EventArgs e)
        {
            LoadDocuments();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog();

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            var sourcePath = dialog.FileName;
            var fileName = Path.GetFileName(sourcePath);

            var root = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Documents");
            var caseFolder = Path.Combine(root, $"HoSoVuViec_{_caseFileId}");

            Directory.CreateDirectory(caseFolder);

            var destPath = Path.Combine(caseFolder, fileName);
            File.Copy(sourcePath, destPath, overwrite: true);

            var document = new Document
            {
                CaseFileId = _caseFileId,
                FileName = fileName,
                FilePath = destPath,
                CreatedAt = DateTime.Now
            };

            using var context = new LawOfficeContext();
            context.Documents.Add(document);
            context.SaveChanges();

            LoadDocuments();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (dgvDocuments.CurrentRow == null)
                return;

            var path = dgvDocuments.CurrentRow.Cells["FilePath"].Value.ToString();

            if (!File.Exists(path))
            {
                MessageBox.Show("File không tồn tại.");
                return;
            }

            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = path,
                UseShellExecute = true
            });
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDocuments.CurrentRow == null)
                return;

            var result = MessageBox.Show($"Bạn có chắc chắn muốn xóa?","Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            int id = (int)dgvDocuments.CurrentRow.Cells["DocumentId"].Value;

            using var context = new LawOfficeContext();
            var doc = context.Documents.Find(id);
            if (doc == null)
                return;

            if (File.Exists(doc.FilePath))
                File.Delete(doc.FilePath);

            context.Documents.Remove(doc);
            context.SaveChanges();

            LoadDocuments();
        }
    }
}
