using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AssignmentProg1
{
    public partial class Metadata : Form
    {
        //Create an instance of the errorhandling class and the MetadataDal
        ErrorHandling errorHandling = new ErrorHandling();
        MetadataDal mdal = new MetadataDal();

        public Metadata()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        //This method is called upon when you click the button. It calls upon the GetMedaDataColumnName from metadatadal
        //and puts the results inside of the datagridview
        private void btnColumnNames_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = mdal.GetMetaDataColumnName();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(errorHandling.MessageFailureCode(ex.Number));
            }
        }

        //This method is called upon when you click the button. It calls upon the GetMedaDataRowsfrom metadatadal
        //and puts the results inside of the datagridview
        private void btnNumberOfRows_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = mdal.GetMetaDataNbrRows();
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
