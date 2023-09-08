using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.DataAccess
{
    public class DAseller
    {
        private readonly SqlConnection _connection;
        public DAseller()
        {
            _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
        }
        public void insert_seller()
        {        
         
           //SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "insert into seller ( sellerName,sellerAddress,sellerPhone,sellerEmail,sellerpass,CreatedON) values " +
                "('sony','gurgaon','555-88','sony@g.com','sony1',getdate())";
        
            SqlCommand cmd = new SqlCommand(query, _connection);
            _connection.Open();
            int row = cmd.ExecuteNonQuery();
            _connection.Close();
        }
        public void update_seller()
        {
            
            string query = "update seller set sellername='sony' where sellerid=1 ";
            SqlCommand cmd = new SqlCommand(query, _connection);
            _connection.Open();
            int row = cmd.ExecuteNonQuery();
            _connection.Close();
        }
        public void delete_seller()
        {
            string query = "delete from seller where sellerid=51";
            SqlCommand cmd = new SqlCommand(query, _connection);
            _connection.Open();
            int row = cmd.ExecuteNonQuery();
            _connection.Close();
        }
        public void getSeller()
        {
            string query = "select top 1 sellerid from seller";
            SqlCommand cmd = new SqlCommand(query, _connection);
            _connection.Open();
            string row = Convert.ToString(cmd.ExecuteScalar());
            _connection.Close();
        }
    }
}
