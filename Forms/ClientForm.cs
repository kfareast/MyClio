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

namespace LawOfficeManagement.Forms
{
    public partial class ClientForm : Form
    {
        private readonly LawOfficeContext _context = new LawOfficeContext();
        public ClientForm()
        {
            InitializeComponent();
        }

        private void LoadClients(string search = "")
        {
            using var context = new LawOfficeContext();
            var query = context.Clients.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(c => c.FullName.Contains(search) || c.Phone.Contains(search));
            }

            dgvClients.DataSource = query
                .OrderBy(c => c.FullName)
                .ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var form = new ClientEditForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                using var context = new LawOfficeContext();
                context.Clients.Add(form.CurrentClient);
                context.SaveChanges();
                LoadClients();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvClients.CurrentRow == null) return;

            var client = dgvClients.CurrentRow.DataBoundItem as Client;
            using var form = new ClientEditForm(client);
            if (form.ShowDialog() == DialogResult.OK)
            {
                using var context = new LawOfficeContext();
                context.Clients.Update(form.CurrentClient);
                context.SaveChanges();
                LoadClients();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvClients.CurrentRow == null) return;

            var client = dgvClients.CurrentRow.DataBoundItem as Client;
            if (MessageBox.Show($"Xóa khách hàng {client.FullName}?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using var context = new LawOfficeContext();
                context.Clients.Remove(client);
                context.SaveChanges();
                LoadClients();
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadClients(txtSearch.Text.Trim());
        }
        private void ClientForm_Load(object sender, EventArgs e)
        {
            LoadClients();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
