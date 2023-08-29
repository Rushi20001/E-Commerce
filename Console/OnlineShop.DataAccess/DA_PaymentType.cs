using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.DataAccess
{
    public class DA_PaymentType
    {
        public void InsertPayment()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "insert into PaymentType ( PaymentTypeId,PaymentTypeName) values ()";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int row = cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void UpdatePayment()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "update PaymentType set PaymentTypeName='visa' where PaymentTypeId=1001";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void DeletePayment()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "delete from  PaymentType where PaymentTypeId=1001";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void getPayment()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "select * from PaymentType";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();

            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                Console.WriteLine("Id:" + r["PaymentTypeid"]  + "PaymentTypeName:" + r["PaymentTypeName"]);
            }
            sqlConnection.Close();
        }
    }
}
