using System;
using System.Windows.Forms;

namespace AssignmentProg1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblCreateUser_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "Semla" && password == "Password123")
            {
                Dashboard dh = new Dashboard();
                dh.Show();
            }
            else
            {
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))

                {
                    MessageBox.Show("Some fields are missing input..");
                }

            }
        }
    }

}
