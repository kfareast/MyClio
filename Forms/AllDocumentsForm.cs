using LawOfficeManagement.Data;
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
    public partial class AllDocumentsForm : Form
    {
        public AllDocumentsForm()
        {
            InitializeComponent();
        }

        private void AllDocumentsForm_Load(object sender, EventArgs e)
        {
            LoadDocumentsTree();
        }

        private void LoadDocumentsTree()
        {
            string rootPath = Path.Combine(
                AppContext.BaseDirectory,
                "Documents"
            );

            if (!Directory.Exists(rootPath))
                return;

            treeDocuments.Nodes.Clear();

            Dictionary<int, string> caseTitles;
            using (var context = new LawOfficeContext())
            {
                caseTitles = context.CaseFiles
                    .ToDictionary(c => c.CaseFileId, c => c.Title);
            }

            TreeNode rootNode = new TreeNode("Documents");
            rootNode.Tag = rootPath;
            treeDocuments.Nodes.Add(rootNode);

            foreach (var caseDir in Directory.GetDirectories(rootPath))
            {
                string folderName = Path.GetFileName(caseDir);
                int caseId = ParseCaseId(folderName);
                if (caseId == -1)
                    continue;

                string caseTitle = caseTitles.ContainsKey(caseId)
                    ? caseTitles[caseId]
                    : "(Không tìm thấy hồ sơ)";

                TreeNode caseNode = new TreeNode($"[{caseId}] {caseTitle}");
                caseNode.Tag = caseDir;

                rootNode.Nodes.Add(caseNode);

                LoadFiles(caseNode, caseDir);
            }

            rootNode.Expand();
            treeDocuments.ExpandAll();
        }

        private void LoadFiles(TreeNode parentNode, string folderPath)
        {
            foreach (var file in Directory.GetFiles(folderPath))
            {
                TreeNode fileNode = new TreeNode(Path.GetFileName(file));
                fileNode.Tag = file;
                parentNode.Nodes.Add(fileNode);
            }
        }

        private int ParseCaseId(string folderName)
        {
            if (!folderName.StartsWith("HoSoVuViec_"))
                return -1;

            if (int.TryParse(folderName.Replace("HoSoVuViec_", ""), out int id))
                return id;

            return -1;
        }
        private void treeDocuments_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node?.Tag == null)
                return;

            string path = e.Node.Tag.ToString();

            if (File.Exists(path))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = path,
                    UseShellExecute = true
                });
            }
        }
        //private bool FindFileNode(TreeNode node, string keyword)
        //{
        //    if (node.Tag != null &&
        //        File.Exists(node.Tag.ToString()) &&
        //        node.Text.ToLower().Contains(keyword))
        //    {
        //        treeDocuments.SelectedNode = node;
        //        node.BackColor = Color.Yellow;
        //        node.EnsureVisible();
        //        return true;
        //    }

        //    foreach (TreeNode child in node.Nodes)
        //    {
        //        if (FindFileNode(child, keyword))
        //        {
        //            node.Expand();
        //            return true;
        //        }
        //    }

        //    return false;
        //}

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
                return;

            ClearHighlight(treeDocuments.Nodes);
            treeDocuments.CollapseAll();

            foreach (TreeNode node in treeDocuments.Nodes)
            {
                HighlightMatches(node, keyword);
            }
        }
        private bool HighlightMatches(TreeNode node, string keyword)
        {
            bool hasMatchInChildren = false;

            foreach (TreeNode child in node.Nodes)
            {
                if (HighlightMatches(child, keyword))
                    hasMatchInChildren = true;
            }

            if (node.Tag != null &&
                File.Exists(node.Tag.ToString()) &&
                node.Text.ToLower().Contains(keyword))
            {
                node.BackColor = Color.Yellow;
                node.EnsureVisible();
                return true;
            }

            if (hasMatchInChildren)
            {
                node.Expand();
                return true;
            }

            return false;
        }
        private void ClearHighlight(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                node.BackColor = treeDocuments.BackColor;
                if (node.Nodes.Count > 0)
                    ClearHighlight(node.Nodes);
            }
        }
    }
}
