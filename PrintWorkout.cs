
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentProg1
{
    public partial class PrintWorkout : Form
    {
        Function fn = new Function();
        WorkoutDAL wdal = new WorkoutDAL();
        
        public PrintWorkout()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            DataSet ds = wdal.LoadData();

            dataGridViewPrint.AutoGenerateColumns = true;

            dataGridViewPrint.DataSource = ds.Tables[0];



        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
