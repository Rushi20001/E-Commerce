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
    public class DA_orderDetails
    {
       


        public void InsertorderDetails()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "insert into orderDetails ( CustomerId,productId,PaymentMethod,PaymentDate,totalbill) values ()";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int row = cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void UpdateorderDetails()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "update orderDetails set quantity=1";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void DeleteorderDetails()
        {
            Console.WriteLine( "Enter Id:" );
            int id = Convert.ToInt32(Console.ReadLine());
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "delete from orderDetails where orderDetailsid=@id";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@id", id);  
            sqlConnection.Open();
            cmd.ExecuteScalar();
            sqlConnection.Close();
        }

        public void getorderDetails()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "select top 1 totalbill from orderDetails";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            string row = Convert.ToString(cmd.ExecuteScalar());
            sqlConnection.Close();
        }
    }
}
