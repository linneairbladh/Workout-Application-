using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace AssignmentProg1
{
    public partial class UpdateWorkout : Form
    {
        //Create instance of wdal and errorhandling classes
        WorkoutDAL wdal = new WorkoutDAL();
        ErrorHandling errorHandling = new ErrorHandling();

        //Constructor
        public UpdateWorkout()
        {
            InitializeComponent();
            LoadData();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        //Loads data into gridview
        public void LoadData()
        {
            DataSet ds = wdal.LoadData();
            dataGridViewUpdateWorkout.AutoGenerateColumns = true;
            dataGridViewUpdateWorkout.DataSource = ds.Tables[0];
        }

        //Ensures that it is the selected workout that gets updated
        private void dataGridViewUpdateWorkout_SelectionChanged_1(object sender, EventArgs e)
        {
            dataGridViewUpdateWorkout.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach (DataGridViewRow row in dataGridViewUpdateWorkout.SelectedRows)
            {
                int workoutID = Convert.ToInt32(row.Cells[0].Value);
                string workoutType = row.Cells[1].Value.ToString();
                int sets = Convert.ToInt32(row.Cells[2].Value);
                int reps = Convert.ToInt32(row.Cells[3].Value);
                string email = row.Cells[4].Value.ToString();

                txtWorkoutID.Text = workoutID.ToString();
                txtWorkoutType.Text = workoutType;
                txtSets.Text = sets.ToString();
                txtReps.Text = reps.ToString();
                txtEmail.Text = email;
            }
        }
        //Updates though wdal
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int workoutID = Int32.Parse(txtWorkoutID.Text);
            string workoutType = txtWorkoutType.Text;
            string sets = txtSets.Text;
            string reps = txtReps.Text;
            string email = txtEmail.Text;
            int parsedValue;

            try
            {

                if (string.IsNullOrWhiteSpace(workoutType) || string.IsNullOrWhiteSpace(sets)
                    || string.IsNullOrWhiteSpace(reps))
                {
                    MessageBox.Show("Some fields are missing input..");
                }
                else if (!int.TryParse(txtSets.Text, out parsedValue) || (!int.TryParse(txtReps.Text, out parsedValue)))
                {
                    MessageBox.Show("Reps and Sets needs to be whole numbers!");
                    return;
                }
                else
                {
                    MessageBox.Show("Workout with email '" + email + "' has been updated");
                    wdal.UpdateWorkoutSchedule(workoutID, workoutType, sets, reps, email);
                    LoadData();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(errorHandling.MessageFailureCode(ex.Number));
            }

        }
        #region Buttons
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
