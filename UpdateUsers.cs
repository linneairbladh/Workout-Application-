using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AssignmentProg1
{
    public partial class UpdateUsers : Form
    {
        //Create instance of UserDal and Errorhandling classes
        UserDAL udal = new UserDAL();
        ErrorHandling errorHandling = new ErrorHandling();

        //Constructor
        public UpdateUsers()
        {
            InitializeComponent();
            LoadData();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        //Loads all data from users (through udal) 
        public void LoadData()
        {
            DataSet ds = udal.LoadData();
            dataGridViewUpdateUsers.AutoGenerateColumns = true;
            dataGridViewUpdateUsers.DataSource = ds.Tables[0];
        }

        //This ensure that it is the user that is currently "selected" (blue) that will be updated
        private void dataGridViewUpdateUsers_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewUpdateUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach (DataGridViewRow row in dataGridViewUpdateUsers.SelectedRows)
            {
                //Makes the data in the datagrid into strings (and ints)
                string email = row.Cells[0].Value.ToString();
                string firstName = row.Cells[1].Value.ToString();
                string lastName = row.Cells[2].Value.ToString();
                int age = Convert.ToInt32(row.Cells[3].Value);
                int weight = Convert.ToInt32(row.Cells[4].Value);

                //The strings are places inside the textboxes
                txtEmail.Text = email;
                txtFirstname.Text = firstName;
                txtLastName.Text = lastName;
                txtAge.Text = age.ToString();
                txtWeight.Text = weight.ToString();
            }
        }

        //Update user when clikcing the button
        private void btnUpdateUsers_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstname.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string age = txtAge.Text;
            string weight = txtWeight.Text;
            int parsedValue;

            try
            {
                //Checks so all fields has input
                if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName)
                   || string.IsNullOrWhiteSpace(age) || string.IsNullOrWhiteSpace(weight))

                {
                    MessageBox.Show("Some fields are missing input..");
                }

                //Ensures that age and weigh are numbers
                else if (!int.TryParse(txtAge.Text, out parsedValue) || (!int.TryParse(txtWeight.Text, out parsedValue)))
                {
                    MessageBox.Show("Age and Weight needs to be numbers!");
                    return;
                }

                //Updates user (through udal) with the input in the textboxes
                else
                {
                    udal.UpdateUsers(email, firstName, lastName, age, weight);
                    MessageBox.Show("User with email '" + email + "' has been updated");
                    LoadData();
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

        private void btnGoToUpdateUsers_Click(object sender, EventArgs e)
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

