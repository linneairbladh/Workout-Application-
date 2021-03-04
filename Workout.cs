using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AssignmentProg1
{
    public partial class Workout : Form
    {
        //Creat instances
        WorkoutDAL wdal = new WorkoutDAL();
        ErrorHandling errorHandling = new ErrorHandling();
        UserDAL udal = new UserDAL();

        protected int n;

        //Constuctor
        public Workout()
        {
            InitializeComponent();
            GetUserEmail();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        //Gets data and places all emails in combobox
        public void GetUserEmail()
        {
            DataSet ds = udal.LoadData();
            comboBoxEmail.DataSource = ds.Tables[0];
            comboBoxEmail.DisplayMember = "email";
        }

        //This method allows us to place our workouts into a datagrid to ultimately make a whole workouprogram
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string workoutType = txtWorkout.Text;
            string sets = txtSets.Text;
            string reps = txtReps.Text;
            string email = comboBoxEmail.Text;
            int parsedValue;

            //Checks so all textfields has value
            if (string.IsNullOrWhiteSpace(workoutType) || string.IsNullOrWhiteSpace(sets)
                || string.IsNullOrWhiteSpace(reps) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Some fields are missing input..");
            }
            //Checks so Reps and sets are numbers
            else if (!int.TryParse(txtSets.Text, out parsedValue) || (!int.TryParse(txtReps.Text, out parsedValue)))
            {
                MessageBox.Show("Reps and Sets needs to be whole numbers!");
                return;
            }
            //Add the workout to the datagrid
            else
            {
                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = txtWorkout.Text;
                dataGridView1.Rows[n].Cells[1].Value = txtSets.Text;
                dataGridView1.Rows[n].Cells[2].Value = txtReps.Text;
                dataGridView1.Rows[n].Cells[3].Value = comboBoxEmail.Text;
            }
        }

        //This takes all of the data in the gridview and adds it to workoutsdatabase
        private void btnAddWorkout_Click(object sender, EventArgs e)
        {
            //For every row in datagrid...
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string workoutType = dataGridView1.Rows[i].Cells[0].Value.ToString();
                string sets = dataGridView1.Rows[i].Cells[1].Value.ToString();
                string reps = dataGridView1.Rows[i].Cells[2].Value.ToString();
                string email = dataGridView1.Rows[i].Cells[3].Value.ToString();

                try
                {
                    //See if empty
                    if (string.IsNullOrWhiteSpace(workoutType) || string.IsNullOrWhiteSpace(sets)
                    || string.IsNullOrWhiteSpace(reps) || string.IsNullOrWhiteSpace(email))
                    {
                        MessageBox.Show("Some fields are missing input..");
                    }
                    //Add to db through wdal
                    else
                    {
                        wdal.AddWorkoutSchedule(workoutType, sets, reps, email);
                        MessageBox.Show("Workout with email: " + email + " has been added!");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(errorHandling.MessageFailureCode(ex.Number));
                }
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

        private void btnGoToAddWorkout_Click(object sender, EventArgs e)
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
