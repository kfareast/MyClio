namespace LawOfficeManagement
{
    public partial class MainForm : Form
    {
        private Button currentButton;
        private Form activeForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(85, 85, 128);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI", 15.5F);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Segoe UI", 14F);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void BtnClient_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Khách hàng";
            OpenChildForm(new Forms.ClientForm(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Danh sách vụ việc";
            OpenChildForm(new Forms.CaseFileForm(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Forms.DocumentForm(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormTest(), sender);
        }
    }
}
