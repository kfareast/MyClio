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
    public partial class ClientEditForm : Form
    {
        public Client CurrentClient { get; set; }

        public ClientEditForm(Client? client = null)
        {
            InitializeComponent();
            CurrentClient = client ?? new Client();
            if (client != null)
            {
                txtName.Text = client.FullName;
                txtPhone.Text = client.Phone;
                txtNote.Text = client.Note;
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Tên khách hàng không được để trống.");
                return;
            }

            CurrentClient.FullName = txtName.Text.Trim();
            CurrentClient.Phone = txtPhone.Text.Trim();
            CurrentClient.Note = txtNote.Text.Trim();
            DialogResult = DialogResult.OK;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
