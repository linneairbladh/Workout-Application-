using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AssignmentProg1
{
    public partial class CreateUser : Form
    {
        //Create an instance of the UserDal and Errhandling class
        UserDAL udal = new UserDAL();
        ErrorHandling errorHandling = new ErrorHandling();

        //Constructor
        public CreateUser()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        //This method creates a User
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string age = txtAge.Text;
            string weight = txtWeight.Text;
            int parsedValue;

            try
            {
                //Ensure that all fields are filled in
                if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName)
                    || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(age)
                    || string.IsNullOrWhiteSpace(weight))
                {
                    MessageBox.Show("Some fields are missing input..");
                }
                //Ensure Age and Weight are numbers
                else if (!int.TryParse(txtAge.Text, out parsedValue) || (!int.TryParse(txtWeight.Text, out parsedValue)))
                {
                    MessageBox.Show("Age and Weight needs to be numbers!");
                    return;
                }
                //Ensure email is valid by checking if it contains @ and . 
                else if (!this.txtEmail.Text.Contains('@') || !this.txtEmail.Text.Contains('.'))
                {
                    MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //If all above are ok it creates a user by sending these parameters to udalmethod create user. 
                else
                {
                    udal.CreateUser(email, firstName, lastName, age, weight);
                    MessageBox.Show("User with email: " + email + " has been added!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(errorHandling.MessageFailureCode(ex.Number));
            }
        }
        #region Buttons Region

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dh = new Dashboard();
            this.Hide();
            dh.Show();
        }

        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            CreateUser cu = new CreateUser();
            this.Hide();
            cu.Show();
        }

        private void btnUpdateUsers_Click(object sender, EventArgs e)
        {

            UpdateUsers uu = new UpdateUsers();
            this.Hide();
            uu.Show();

        }

        private void btnDeleteUsers_Click(object sender, EventArgs e)
        {
            DeleteUsers du = new DeleteUsers();
            this.Hide();
            du.Show();
        }

        private void btnAddWorkout_Click(object sender, EventArgs e)
        {
            Workout w = new Workout();
            w.Show();
            this.Hide();
        }

        private void btnUpdateWorkout_Click(object sender, EventArgs e)
        {
            UpdateWorkout uw = new UpdateWorkout();
            uw.Show();
            this.Hide();
        }

        private void btnDeleteWorkout_Click(object sender, EventArgs e)
        {
            DeleteWorkout dw = new DeleteWorkout();
            this.Hide();
            dw.Show();
        }

        private void btnMetadata_Click(object sender, EventArgs e)
        {
            Metadata md = new Metadata();
            this.Hide();
            md.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #endregion
    }
}
