using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.DataAccess
{
    public class DA_orderdetails
    {
        public void Insertorderdetails()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "insert into orderdetails ( ordersid,productID,quantity,price_per_unit,totalprice,createon) values ()";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int row = cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void Updateorderdetails()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "update orderitems set createon=getdate() where orderitemId=1";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void Deletecart()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "delete from  orderitems where orderitemId=1";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void getCarthistory()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "select * from orderdetails";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();

            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                Console.WriteLine("Id:" + r["orderdetailsId"] + " " + "orderid:" + r["ordersid"] + "   " 
                    + "productID:" + r["productID"]
                    + "quantity:" + r["quantity"] + "price:" + r["price_per_unit"] 

                    );
            }
            sqlConnection.Close();
        }
    }
}
