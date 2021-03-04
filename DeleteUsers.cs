using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AssignmentProg1
{
    public partial class DeleteUsers : Form
    {
        //Create instance of errorhandling and UserDal classes
        UserDAL uDal = new UserDAL();
        ErrorHandling errorHandling = new ErrorHandling();

        //Constructor that for example is being used when using navigation panel
        public DeleteUsers()
        {
            InitializeComponent();
            LoadData();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        //This method loads the data from the U-Dal into the datagrid
        public void LoadData()
        {
            //Bring the data returned from the method load data in the User Dal into a dataset
            DataSet ds = uDal.LoadData();
            //Autogenerate columns
            dataGridViewDelete.AutoGenerateColumns = true;
            //Bring the dataset inte the gridview
            dataGridViewDelete.DataSource = ds.Tables[0];
        }

        //This method deletes the User when you double click the cell he/she/it is in
        private void dataGridViewDelete_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Create empty variable string email
            string email;
            try
            {
                //Make sure the user acually wants to delete the user by sending a messagebox where she can press yes/no if she/he wants to delete
                DialogResult result = MessageBox.Show("Are you sure you want to delete User?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //"Translates" the value of the cell into a string
                    email = dataGridViewDelete.Rows[e.RowIndex].Cells[0].Value.ToString();
                    //That string is being sent into the Delete User method in the User Dal
                    uDal.DeleteUser(email);
                    //Load the table again (now that the user is gone)
                    LoadData();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(errorHandling.MessageFailureCode(ex.Number));
            }

            catch (FormatException)
            {
                MessageBox.Show("You can only delete existing Users");
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
