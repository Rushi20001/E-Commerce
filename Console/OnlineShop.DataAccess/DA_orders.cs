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
       


        public void Insertorders()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "insert into orders ( customerid,orderdate,orderstatus,createon) values ()";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int row = cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void Updateorders()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "update orders set status=1 where orderid=501";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void Deleteorders()
        {
            Console.WriteLine( "Enter Id:" );
            int id = Convert.ToInt32(Console.ReadLine());
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "delete from orders where ordersid=@id";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@id", id);  
            sqlConnection.Open();
            cmd.ExecuteScalar();
            sqlConnection.Close();
        }

        public void getorders()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "select top 1 customerid from orders";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            string row = Convert.ToString(cmd.ExecuteScalar());
            sqlConnection.Close();
        }
    }
}
