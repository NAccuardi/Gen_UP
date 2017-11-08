using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;



namespace SQLCLASS
{
    public class SQLConnClass
    {
        SqlConnection SQLConn = new SqlConnection();
        public DataTable SQLTable = new DataTable();

        public SQLConnClass()
        {
            SQLConn.ConnectionString = ConfigurationManager.ConnectionStrings["myConnString"].ConnectionString;
        }
        //use for SELECT
        public void retreiveData(string command)
        {
            try
            {
                SQLConn.Open();
                SqlDataAdapter da = new SqlDataAdapter(command, SQLConn);
                da.Fill(SQLTable);
            }
            catch(Exception e)
            {
                HttpContext.Current.Response.Write("<script>alert('Something went wrong connecting to DB, ERROR: '" + e.Message + ");</script>");
            }
            finally
            {
                SQLConn.Close();
            }
        }
        //use for INSERT, UPDATE, DELETE
        public void commandExecute(string command)
        {
            try
            {
                SQLConn.Open();
                SqlCommand sqlcomm = new SqlCommand(command, SQLConn);
                int rowInfected = sqlcomm.ExecuteNonQuery();

                if(rowInfected > 0)
                {
                    HttpContext.Current.Response.Write("<script>alert('Your command DONE.');</script>");

                }
                else
                {
                    HttpContext.Current.Response.Write("<script>alert('Something went wrong with executing command.');</script>");

                }
            }
            catch(Exception e)
            {
                HttpContext.Current.Response.Write("<script>alert('Something went wrong connecting to DB, ERROR: '" + e.Message + ");</script>");

            }
            finally
            {
                SQLConn.Close();
            }
        }
    }
}