using System;
using OnlineMobileShop.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace OnlineMobileShop.DAL
{
    public class ProductRepository
    {
        public string sqlConnection = ConfigurationManager.ConnectionStrings["OnlineMobileShop"].ConnectionString;

        public bool GetProduct(Product product)
        {
            try
            {
                using (SqlConnection myConnection = new SqlConnection(sqlConnection))
                {
                    myConnection.Open();
                    string sql = "SP_InsertData";
                    SqlCommand sqlCommand = new SqlCommand(sql, myConnection);
                    sqlCommand.Parameters.AddWithValue("@Brand", product.Brand);
                    sqlCommand.Parameters.AddWithValue("@Model", product.Model);
                    sqlCommand.Parameters.AddWithValue("@Battery", product.Battery);
                    sqlCommand.Parameters.AddWithValue("@RAM", product.RAM);
                    sqlCommand.Parameters.AddWithValue("@ROM", product.ROM);
                    sqlCommand.Parameters.AddWithValue("@Price", product.Price);
                    int limit = sqlCommand.ExecuteNonQuery();
                    if (limit >= 1)
                    {
                        return true;

                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }


        public DataTable ToBind()
        {
            DataTable dataTable = new DataTable();
           
                using (SqlConnection myConnection = new SqlConnection(sqlConnection))
                {
                    myConnection.Open();
                    string sql = "SP_GetData";
                    SqlCommand sqlCommand = new SqlCommand(sql, myConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dataTable);
                    return dataTable;
                }
           
        }
        public bool UpdateCustomerDetails(Product product)
        {
            try
            {
                using (SqlConnection myConnection = new SqlConnection(sqlConnection))
                {
                    myConnection.Open();
                    string sql = "SP_UpdateData";
                    SqlCommand sqlCommand = new SqlCommand(sql, myConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Brand", product.Brand);
                    sqlCommand.Parameters.AddWithValue("@Model", product.Model);
                    sqlCommand.Parameters.AddWithValue("@Battery", product.Battery);
                    sqlCommand.Parameters.AddWithValue("@RAM", product.RAM);
                    sqlCommand.Parameters.AddWithValue("@ROM", product.ROM);
                    sqlCommand.Parameters.AddWithValue("@Price", product.Price);
                    sqlCommand.Parameters.AddWithValue("@MobileID", product.MobileID);
                    int limit = sqlCommand.ExecuteNonQuery();
                    if (limit >= 1)
                    {
                        return true;

                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool DeleteCustomer(Product product)
        {
            try
            {
                using (SqlConnection myConnection = new SqlConnection(sqlConnection))
                {
                    myConnection.Open();
                    string sql = "SP_Delete";
                    SqlCommand sqlCommand = new SqlCommand(sql, myConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@MobileID", product.MobileID);
                    int limit = sqlCommand.ExecuteNonQuery();
                    if (limit >= 1)
                    {
                        return true;

                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
            catch(Exception)
            {
                return false;
            }
          
        }
    }
}
