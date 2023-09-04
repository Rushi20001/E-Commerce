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
    public class DAusers
    {

        public void InsertuserSp()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "spUser";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@usersid", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = "aman";
            cmd.Parameters.Add("@userpass", SqlDbType.VarChar).Value = "123agup";
            cmd.Parameters.Add("@userEmail", SqlDbType.VarChar).Value = "a@g.com";
            cmd.Parameters.Add("@useraddress", SqlDbType.VarChar).Value = "Ahd";
            cmd.Parameters.Add("@userPhone", SqlDbType.VarChar).Value = "88-00";
            cmd.Parameters.Add("@optype", SqlDbType.VarChar).Value = "i";
          //  cmd.Parameters.Add("@createon", SqlDbType.DateTime).Value = DateTime.Now;
            sqlConnection.Open();
            int row = cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void UpdateuserSp()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "SpUser";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.Add("@usresid", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = "naveen";
            cmd.Parameters.Add("@userpass", SqlDbType.VarChar).Value = "123n";
            cmd.Parameters.Add("@userEmail", SqlDbType.VarChar).Value = "N@g.com";
            cmd.Parameters.Add("@useraddress", SqlDbType.Int).Value = "Ahd";
            cmd.Parameters.Add("@userPhone", SqlDbType.VarChar).Value = "88-44";
            cmd.Parameters.Add("@@optype", SqlDbType.VarChar).Value = "u";
              
            sqlConnection.Open();
            int row = cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void DeleteCustomerSp()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string delQuery = "SpUser";
            SqlCommand cmd = new SqlCommand(delQuery, sqlConnection);
            cmd.Parameters.Add("@usresid", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = "naveen";
            cmd.Parameters.Add("@userpass", SqlDbType.VarChar).Value = "123n";
            cmd.Parameters.Add("@userEmail", SqlDbType.VarChar).Value = "N@g.com";
            cmd.Parameters.Add("@useraddress", SqlDbType.Int).Value = "Ahd";
            cmd.Parameters.Add("@userPhone", SqlDbType.VarChar).Value = "88-44";
            cmd.Parameters.Add("@optype", SqlDbType.VarChar).Value = "d";
            sqlConnection.Open();
            int row = cmd.ExecuteNonQuery();
            sqlConnection.Close();

        }
        public void GetCustomerSp()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string GetdataQ = "SpUser";
            SqlCommand cmd = new SqlCommand(GetdataQ, sqlConnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@userid", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = "naveen";
            cmd.Parameters.Add("@usersAddress", SqlDbType.VarChar).Value = "america";
            cmd.Parameters.Add("@userPhoneNo", SqlDbType.VarChar).Value = "000";
            cmd.Parameters.Add("@userEmail", SqlDbType.VarChar).Value = "00";
            cmd.Parameters.Add("@userpass", SqlDbType.VarChar).Value = "88-44";
            cmd.Parameters.Add("@optype", SqlDbType.VarChar).Value = "s";
            sqlConnection.Open();
            int row = cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void InsertCustomerSp(usersModel customer)
        {
            throw new NotImplementedException();
        }
    }   
}
