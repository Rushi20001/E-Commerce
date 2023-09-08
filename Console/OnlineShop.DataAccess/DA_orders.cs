using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.DataAccess
{
    public class DA_orders
    {
        private SqlConnection _connection;
        public DA_orders()
        {
            _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
        }

        public void Insertorders()
        {
           
            string query = "insert into orders ( customerid,orderdate,orderstatus,createon) values ()";
            SqlCommand cmd = new SqlCommand(query, _connection);
            _connection.Open();
            int row = cmd.ExecuteNonQuery();
            _connection.Close();
        }
        public void Updateorders()
        {
            string query = "update orders set status=1 where orderid=501";
            SqlCommand cmd = new SqlCommand(query, _connection);
            _connection.Open();
            cmd.ExecuteNonQuery();
            _connection.Close();
        }
        public void Deleteorders()
        {
            Console.WriteLine( "Enter Id:" );
            int id = Convert.ToInt32(Console.ReadLine());
            string query = "delete from orders where ordersid=@id";
            SqlCommand cmd = new SqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@id", id);  
            _connection.Open();
            cmd.ExecuteScalar();
            _connection.Close();
        }

        public void getorders()
        {
            string query = "select top 1 customerid from orders";
            SqlCommand cmd = new SqlCommand(query, _connection);
            _connection.Open();
            string row = Convert.ToString(cmd.ExecuteScalar());
            _connection.Close();
        }
    }
}
