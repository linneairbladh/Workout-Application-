using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AssignmentProg1
{
    public class MetadataDal
    {
        //This is the connectionstring that holds information about "where" the database is. 
        private string SqlConnectionString = ("Data Source=uwdb18.srv.lu.se\\icssql001;Initial Catalog=SYSA14_PK_ProgAssignment2;User ID=sysa14reader;Password=INFreader1");
        SqlConnection conn;

        //The connect-method allows us to reuse code that we use multiple time (in all methods below). It creates and opens the SQLConnection. 
        public void Connect()
        {
            try
            {
                conn = new SqlConnection(SqlConnectionString);
                conn.Open();
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine(sqlex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //This method returns a list of all elements inside the TableOfInterest-tables
        public List<String> GetTablesOfInterest()
        {
            //Create a empty list that holds string values called result where we will put our results later on
            List<String> Result = new List<string>();

            try
            {
                //Open the connection to the database
                Connect();
                //The SQL Command allows us to query or database using the query we wrote and the SQLConnection
                SqlCommand cmd = new SqlCommand("SELECT * FROM TablesOfInterest", conn);
                //The Execute Reader lets us view the result of the query by returning a dataReader-object. 
                SqlDataReader dR = cmd.ExecuteReader();

                //While the DataReader is reading we add the strings it is reading to the result list. 
                while (dR.Read())
                {
                    Result.Add(dR.GetString(0));
                }

                //We close our SQLConnection and the DataReader
                conn.Close();
                dR.Close();

                //We return our list with strings (Result) 
                return Result;
            }

            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
                throw ex;
            }
            catch (System.InvalidOperationException ioe)
            {
                Console.WriteLine(ioe.ToString());
                Console.ReadLine();
                throw ioe;
            }

        }

        //This method returns the column names of each table that is currently inside the TableOfInterest-table. 
        public DataTable GetMetaDataColumnName()
        {
            //Open connection 
            Connect();
            //We create an empty dataTable that we will put our results in later
            DataTable dt = new DataTable();
            //Creating a "empty" (kinda) string
            string query = "";
            //Looping through all of the strings that the GetTablesOfInterest-method returns to us
            foreach (string s in GetTablesOfInterest())
            {
                //For each string it adds on the following query to the querystring
                query = query + "SELECT COLUMN_NAME AS 'All Column Names', '" + s + "' AS 'Table Name' FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + s + "'UNION ALL ";
            }
            //Since the querystring will end with UNION ALL and that will cause an error we remove that part of the string. 
            query = query.Substring(0, query.Length - 10);

            //The SQL Command allows us to query or database using the query we wrote and the SQLConnection
            SqlCommand sqlCommand = new SqlCommand(query, conn);

            //Create data adapter that will "translate" the results from the query into the datatable we created earlier
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            da.Fill(dt);
            //Close conncetion and Dispose DataAdapter
            conn.Close();
            da.Dispose();

            //return the datatable
            return dt;

        }

        //This method returns the number of rows inside of each of the specific tables mentioned in TablesOfInterest
        public DataTable GetMetaDataNbrRows()
        {
            //Open connection 
            Connect();
            //We create an empty dataTable that we will put our results in later
            DataTable dt = new DataTable();
            //Creating a "empty" (kinda) string
            string query = "";
            //Looping through all of the strings that the GetTablesOfInterest-method returns to us
            foreach (string s in GetTablesOfInterest())
            {
                //For each string it adds on the following query to the querystring
                query = query + "SELECT COUNT (*) AS 'Number of Rows', '" + s + "' AS 'Table Name' FROM " + s + " UNION ALL ";
            }
            //Since the querystring will end with UNION ALL and that will cause an error we remove that part of the string. 
            query = query.Substring(0, query.Length - 10);

            //The SQL Command allows us to query or database using the query we wrote and the SQLConnection
            SqlCommand sqlCommand = new SqlCommand(query, conn);

            //Create data adapter that will "translate" the results from the query into the datatable we created earlier
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            da.Fill(dt);

            //Close conncetion and Dispose DataAdapter
            conn.Close();
            da.Dispose();

            //return the datatable
            return dt;
        }
    }
}


