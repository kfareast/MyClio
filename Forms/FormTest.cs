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
using System.Xml.Linq;

namespace LawOfficeManagement.Forms
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using var context = new LawOfficeContext();

            var client = new Client
            {
                FullName = txtName.Text.Trim(),
                Phone = txtPhone.Text.Trim()
            };

            context.Clients.Add(client);
            context.SaveChanges();

            MessageBox.Show("Đã thêm khách hàng");
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            using var context = new LawOfficeContext();

            var data = context.Clients
                .Select(c => new
                {
                    c.ClientId,
                    c.FullName,
                    c.Phone
                })
                .ToList();

            dgvClients.DataSource = data;
        }

    }
}
