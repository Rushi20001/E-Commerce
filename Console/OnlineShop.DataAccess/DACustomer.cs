using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using OnlineShop.Models;

namespace OnlineShop.DataAccess
{
    public class DA_Customer
    {

        public void InsertCustomerSp()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "customername";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@customerid", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@customername", SqlDbType.VarChar).Value = "naitik";
            cmd.Parameters.Add("@customeradd", SqlDbType.VarChar).Value = "AHD";
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = "878589";
            cmd.Parameters.Add("@walletpoints", SqlDbType.Int).Value = 30;
            cmd.Parameters.Add("@optype", SqlDbType.VarChar).Value = "i";
            sqlConnection.Open();
            int row = cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void UpdateCustomerSp()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "customername";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@customerid", SqlDbType.Int).Value = 8;
            cmd.Parameters.Add("@customername", SqlDbType.VarChar).Value = "Robert";
            cmd.Parameters.Add("@customeradd", SqlDbType.VarChar).Value = "AHD";
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = "878589";
            cmd.Parameters.Add("@walletpoints", SqlDbType.Int).Value = 30;
            cmd.Parameters.Add("@optype", SqlDbType.VarChar).Value = "u";
            cmd.Parameters.Add("@createon",SqlDbType.DateTime).Value= DateTime.Now;   
            sqlConnection.Open();
            int row = cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void DeleteCustomerSp()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string delQuery = "customername";
            SqlCommand cmd = new SqlCommand(delQuery, sqlConnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@customerid", SqlDbType.Int).Value = 7;
            cmd.Parameters.Add("@customername", SqlDbType.VarChar).Value = "Robert";
            cmd.Parameters.Add("@customeradd", SqlDbType.VarChar).Value = "AHD";
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = "878589";
            cmd.Parameters.Add("@walletpoints", SqlDbType.Int).Value = 30;
            cmd.Parameters.Add("@optype", SqlDbType.VarChar).Value = "d";
            sqlConnection.Open();
            int row = cmd.ExecuteNonQuery();
            sqlConnection.Close();

        }
        public void GetCustomerSp()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string GetdataQ = "customername";
            SqlCommand cmd = new SqlCommand(GetdataQ, sqlConnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@customerid", SqlDbType.Int).Value = 7;
            cmd.Parameters.Add("@customername", SqlDbType.VarChar).Value = "Robert";
            cmd.Parameters.Add("@customeradd", SqlDbType.VarChar).Value = "AHD";
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = "878589";
            cmd.Parameters.Add("@walletpoints", SqlDbType.Int).Value = 30;
            cmd.Parameters.Add("@optype", SqlDbType.VarChar).Value = "s";
            sqlConnection.Open();
            int row = cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void InsertCustomerSp(Customer customer)
        {
            throw new NotImplementedException();
        }
    }   
}
