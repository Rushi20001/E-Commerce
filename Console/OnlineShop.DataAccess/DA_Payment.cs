using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.DataAccess
{
    public class DA_Payment
    {
        public void InsertPayment()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "insert into Payment ( ordersid,payamount , paymentMethodid,createon)" +
                " values ()";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int row = cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void UpdatePayment()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "update Payments set createon=getdate()  where PaymentId=1003";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void DeletePayment()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "delete from  Payment where Payments=1003";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void getPayment()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "select * from Payment";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();

            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                Console.WriteLine("Id:" + r["Paymentid"]  + "ordersid:" + r["ordersid"] + "payamount:" + r["payamount"]);
            }
            sqlConnection.Close();
        }
    }
}
