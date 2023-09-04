using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.DataAccess
{
    public class DA_Products
    {
        public void InsertProduct()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "insert into Products ( productname,price,stock,categoryid,sellerid,createon) values ()";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int row = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            if (row > 0) { Console.Write("row inserted"); }
        }

        public void UpdateProducts()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "update products set stock=20 where productsid=53";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void deleteProductTable()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "delete from Products where productsid=";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void retreiveProductTable()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "select * from Products";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            //   string a= Convert.ToString(cmd.ExecuteReader());
            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                Console.WriteLine("Id:" + r["productsid"] + " " + "categoryid:" + r["categoryid"] + "   " + 
                    "sellerid:" + r["sellerid"] +
                    "productname:" + r["productname"] + "price:" + r["price"] +
                    "stock:" + r["stock"]);
            }
            sqlConnection.Close();
        }
    }
}
