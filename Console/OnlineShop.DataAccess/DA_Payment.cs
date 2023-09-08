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
    {private SqlConnection _connection;
        public DA_Payment()
        {
            _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
        }
        public void InsertPayment()
        {
            string query = "insert into Payment ( ordersid,payamount , paymentMethodid,createon)" +
                " values ()";
            SqlCommand cmd = new SqlCommand(query, _connection);
            _connection.Open();
            int row = cmd.ExecuteNonQuery();
            _connection.Close();
        }
        public void UpdatePayment()
        {
            string query = "update Payments set createon=getdate()  where PaymentId=1003";
            SqlCommand cmd = new SqlCommand(query, _connection);
            _connection.Open();
            cmd.ExecuteNonQuery();
               _connection.Close();
        }
        public void DeletePayment()
        {
            string query = "delete from  Payment where Payments=1003";
            SqlCommand cmd = new SqlCommand(query, _connection);
            _connection.Open();
            cmd.ExecuteNonQuery();
            _connection.Close();
        }
        public void getPayment()
        {
            string query = "select * from Payment";
            SqlCommand cmd = new SqlCommand(query, _connection);
            _connection.Open();

            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                Console.WriteLine("Id:" + r["Paymentid"]  + "ordersid:" + r["ordersid"] + "payamount:" + r["payamount"]);
            }
            _connection.Close();
        }
    }
}
