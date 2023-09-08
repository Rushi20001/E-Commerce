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
        private SqlConnection _connection;
        public DAusers()
        {
                _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
        }

        public void InsertuserSp()
        {   
            string query = "spUser";
            SqlCommand cmd = new SqlCommand(query, _connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@userid", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = "aman";
            cmd.Parameters.Add("@userpass", SqlDbType.VarChar).Value = "123agup";
            cmd.Parameters.Add("@userEmail", SqlDbType.VarChar).Value = "a@g.com";
            cmd.Parameters.Add("@usersaddress", SqlDbType.VarChar).Value = "Ahd";
            cmd.Parameters.Add("@userPhoneno", SqlDbType.VarChar).Value = "88-00";
            cmd.Parameters.Add("@optype", SqlDbType.VarChar).Value = "i";
          //  cmd.Parameters.Add("@createon", SqlDbType.DateTime).Value = DateTime.Now;
            _connection.Open();
            int row = cmd.ExecuteNonQuery();
            _connection.Close();
        }
        public void UpdateuserSp()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "SpUser";
            SqlCommand cmd = new SqlCommand(query, _connection);
            cmd.Parameters.Add("@usreid", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = "naveen";
            cmd.Parameters.Add("@userpass", SqlDbType.VarChar).Value = "123n";
            cmd.Parameters.Add("@userEmail", SqlDbType.VarChar).Value = "N@g.com";
            cmd.Parameters.Add("@usersaddress", SqlDbType.Int).Value = "Ahd";
            cmd.Parameters.Add("@userPhoneno", SqlDbType.VarChar).Value = "88-44";
            cmd.Parameters.Add("@@optype", SqlDbType.VarChar).Value = "u";
              
            _connection.Open();
            int row = cmd.ExecuteNonQuery();
            _connection.Close();
        }
        public void DeleteCustomerSp()
        {
            string delQuery = "SpUser";
            SqlCommand cmd = new SqlCommand(delQuery, _connection);
            cmd.Parameters.Add("@usreid", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = "naveen";
            cmd.Parameters.Add("@userpass", SqlDbType.VarChar).Value = "123n";
            cmd.Parameters.Add("@userEmail", SqlDbType.VarChar).Value = "N@g.com";
            cmd.Parameters.Add("@usersaddress", SqlDbType.VarChar).Value = "Ahd";
            cmd.Parameters.Add("@userPhoneno", SqlDbType.VarChar).Value = "88-44";
            cmd.Parameters.Add("@optype", SqlDbType.VarChar).Value = "d";
            _connection.Open();
            int row = cmd.ExecuteNonQuery();
                _connection.Close();

        }
        public void GetCustomerSp()
        {
            string GetdataQ = "SpUser";
            SqlCommand cmd = new SqlCommand(GetdataQ, _connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@userid", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = "naveen";
            cmd.Parameters.Add("@usersAddress", SqlDbType.VarChar).Value = "america";
            cmd.Parameters.Add("@userPhoneNo", SqlDbType.VarChar).Value = "000";
            cmd.Parameters.Add("@userEmail", SqlDbType.VarChar).Value = "00";
            cmd.Parameters.Add("@userpass", SqlDbType.VarChar).Value = "88-44";
            cmd.Parameters.Add("@optype", SqlDbType.VarChar).Value = "s";
            _connection.Open();
            int row = cmd.ExecuteNonQuery();
            _connection.Close();
        }

        public void InsertCustomerSp(usersModel customer)
        {
            throw new NotImplementedException();
        }

       

        
        
            public bool Authenticateuser(string useremail, string userpass,out string validationmessage)
            {
            
              
               // SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"]
                   // .ToString());
            string query = "select count(*) from users where useremail=@useremail";
            SqlCommand cmd = new SqlCommand(query, _connection);
            //cmd = new SqlCommand(query, sqlConnection);

            cmd.Parameters.AddWithValue("@useremail", useremail);
            cmd.Parameters.AddWithValue("@userpass", userpass);
            _connection.Open();
            int row = (int)cmd.ExecuteScalar();

           _connection.Close();
            if (row == 0)
            {
                validationmessage = "useremail not exists";
                return false;
            }
            string q = "select count(*) from users where useremail=@useremail and userpass=@userpass";
               // SqlCommand cmd = new SqlCommand(q, sqlConnection);
                 cmd=new SqlCommand(q,_connection);
            
                cmd.Parameters.AddWithValue("@useremail", useremail);
                cmd.Parameters.AddWithValue("@userpass", userpass);
                _connection.Open();
                 row = (int)cmd.ExecuteScalar();
                
                _connection.Close();
            validationmessage = row == 0 ? "credentials not matched" : string.Empty;
              return row>0;
            }
           
           
       
        //public SqlConnection GetConnection()
        //{
        //    string connectionstring = ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString;
        //    return new SqlConnection(connectionstring);
        //}
        
    }   
}
