using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentProg1
{

    class WorkoutDAL
    {
        Function fn = new Function();
        string query;

        public DataSet LoadData()
        {
            DataSet ds = new DataSet();
            try 
            { 
                query = "SELECT * FROM Workout";
                ds = fn.GetData(query);
                
            }
            catch (SqlException ex)
            {
                Console.WriteLine("An error ( {0} )has occured, the problem is {1})", ex.Number, ex.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine("An error has occured, the problem is {0})", x.Message);

            }
            return ds;
            

        }
        
        //MVC
        public void AddWorkoutSchedule(string workoutType, string sets, string reps, string email)
        {
            string query = "INSERT INTO Workout VALUES ('" + workoutType + "', '" + sets + "',  '" + reps + "',  '" + email + "')";
                
            fn.SetData(query);
              
        }

        public void WorkoutType(string workoutType)
        {
            try
            {
                query = "SELECT workoutType FROM Workout WHERE workoutType = '" + workoutType + "'";
                fn.GetData(query);
                
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception x)
            {
                throw x;
            }
            
        }
        public void UpdateWorkoutSchedule(int workoutID, string workoutType, string sets, string reps, string email)
        {
            query = "UPDATE Workout SET workoutType = '" + workoutType + "', sets = '" + sets + "', reps = '" + reps + "', email = '" + email + "' WHERE workoutID = " + workoutID+"";
            fn.SetData(query);
        }
        
        public void DeleteWorkoutSchedule(int workoutID)
        { 
           
            query = "DELETE FROM Workout WHERE workoutID = " + workoutID + "";
            fn.SetData(query);
           
        }


        public DataSet GetUserEmail()
        {
            DataSet ds = new DataSet();
            try
            {
                query = "SELECT email FROM Workout";
                
            }
            catch (SqlException ex)
            {
                Console.WriteLine("An error ( {0} )has occured, the problem is {1})", ex.Number, ex.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine("An error has occured, the problem is {0})", x.Message);

            }
            return ds;
        }
    }
}
