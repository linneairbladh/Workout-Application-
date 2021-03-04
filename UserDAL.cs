using System;
using System.Data;
using System.Data.SqlClient;

namespace AssignmentProg1
{
    class UserDAL
    {
        //The function class had the connection to the database. Now we instance it so we can use it. 
        Function fn = new Function();
        //Create empty string query that we use later
        String query;


        public void CreateUser(string email, string firstName, string lastName, string age, string weight)
        {
            string query = "INSERT INTO Users VALUES('" + email + "','" + firstName + "','" + lastName + "','" + weight + "','" + age + "')";
            fn.SetData(query);
        }

        //This method loads all the data about Users into a dataset that is used in the DeleteUsers class 
        public DataSet LoadData()
        {
            //Create empty new dataset
            DataSet ds = new DataSet();
            try
            {
                //Write query that returns all our Users
                query = "SELECT * FROM Users";
                //We use the function instance to call upon the setData in the function class that actually conncets to the db and executes the query 
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
            //Return the dataset
            return ds;
        }

        //This method deletes a user from the database, also it deletes all workouts connceted to that user (but that is due to on delete cascade in the db. 
        //The method has an inparameter "email" that comes from the deleteuser class 
        public void DeleteUser(string email)
        {
            try
            {
                //We insert the email inparameter into this query that will detete user from db 
                query = "DELETE FROM Users WHERE email = '" + email + "'";
                //We use the function instance to call upon the setData in the function class that actually conncets to the db and executes the query 
                fn.SetData(query);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("An error ( {0} )has occured, the problem is {1})", ex.Number, ex.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine("An error has occured, the problem is {0})", x.Message);
            }
        }
        //This method is used to update information about a user in the database
        public void UpdateUsers(string email, string firstName, string lastName, string age, string weight)
        {
            //Write query that will update the user
            query = "UPDATE Users SET firstName= '" + firstName + "', lastName ='" + lastName + "', age = '" + age + "', weight = '" + weight + "' WHERE email =  '" + email + "'";
            //We use the function instance to call upon the setData in the function class that actually conncets to the db and executes the query 
            fn.SetData(query);
        }
    }
}
