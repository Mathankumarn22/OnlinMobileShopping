using OnlineMobileShop.Entity;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Web.DynamicData;
using System.Web.UI.WebControls;
using System;

namespace OnlineMobileShop.DAL
{
    public class UserRespository
    {
        static SqlConnection sqlConnection = UserRespository.GetDBConnection();
        private static readonly object password;
        public static object mailID { get; private set; }
        public bool SignUp(UserManager userManager)
        {
            string insertQuery = "SP_SignUp";
            try
            {

                using (SqlCommand sqlCommand = new SqlCommand(insertQuery, sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@name";
                    param.Value = userManager.name;
                    param.SqlDbType = SqlDbType.VarChar;
                    sqlCommand.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@number";
                    param.Value = userManager.number;
                    param.SqlDbType = SqlDbType.VarChar;
                    sqlCommand.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@mailID";
                    param.Value = userManager.mailID;
                    param.SqlDbType = SqlDbType.VarChar;
                    sqlCommand.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@password";
                    param.Value = userManager.password;
                    param.SqlDbType = SqlDbType.VarChar;
                    sqlCommand.Parameters.Add(param);

                    sqlConnection.Open();
                    int row = sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    if (row >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }

            }
            catch
            {
                return false;
            }



        }


        public bool LogIn(int userID, string password)
        {
            string insertQuery = "SP_LogIn";
            try
            {
                using (SqlCommand sqlCommand = new SqlCommand(insertQuery, sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@userId";
                    param.Value = userID;
                    param.SqlDbType = SqlDbType.Int;
                    sqlCommand.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@password";
                    param.Value = password;
                    param.SqlDbType = SqlDbType.VarChar;
                    sqlCommand.Parameters.Add(param);

                    sqlConnection.Open();
                    string flag = sqlCommand.ExecuteScalar().ToString();

                    if (flag == "true")
                    {
                        sqlConnection.Close();
                        return true;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public static SqlConnection GetDBConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["OnlineMobileShop"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;
        }
     
       
      
       
        
    }
}