using System;
using System.Data;
using System.Data.SqlClient;

namespace AssignmentProg1
{
    class Function
    {
        protected SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data source=.; Initial Catalog=HealthTracker;Integrated Security = True";
            return con;
        }
        public DataSet GetData(String query)
        {
            try
            {
                SqlConnection con = GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                return ds;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public void SetData(String query)
        {
            try
            {
                SqlConnection con = GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
