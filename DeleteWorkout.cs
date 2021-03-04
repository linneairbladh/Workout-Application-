using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AssignmentProg1
{
    public partial class DeleteWorkout : Form
    {
        //Create instance of wdal and errorhandling class
        WorkoutDAL wdal = new WorkoutDAL();
        ErrorHandling errorHandling = new ErrorHandling();

        //Constructor
        public DeleteWorkout()
        {
            InitializeComponent();
            LoadData();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        //Loads data into delete
        public void LoadData()
        {
            DataSet ds = wdal.LoadData();
            dataGridViewDelete.AutoGenerateColumns = true;
            dataGridViewDelete.DataSource = ds.Tables[0];
        }

        //Detele Workout
        private void dataGridViewDelete_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int workoutID;
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete Workout?", "Warining", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    workoutID = int.Parse(dataGridViewDelete.Rows[e.RowIndex].Cells[0].Value.ToString());
                    wdal.DeleteWorkoutSchedule(workoutID);
                    LoadData();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(errorHandling.MessageFailureCode(ex.Number));
            }
            catch (FormatException)
            {
                MessageBox.Show("You can only delete existing Workouts");
            }
        }

        private void lblDeleteInstruction_Click(object sender, EventArgs e)
        {
            lblDeleteInstruction.Text = "Double-click to delete selected WorkoutSchedule";
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
