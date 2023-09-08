using OnlineShop.Models;
using OnlineShop.Models.Entity;
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
        private readonly SqlConnection _connection;
        public DA_orderdetails()
        {

            _connection = new SqlConnection (ConfigurationManager.ConnectionStrings["sqlconnection"].ToString()) ;

        }
        public void Insertorderdetails()
        {
            //SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "insert into orderdetails ( ordersid,productID,quantity,price_per_unit,totalprice,createon) values ()";
            SqlCommand cmd = new SqlCommand(query, _connection);
            _connection.Open();
            int row = cmd.ExecuteNonQuery();
            _connection.Close();
        }
        public void Updateorderdetails()
        {
           // SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "update orderitems set createon=getdate() where orderitemId=1";
            SqlCommand cmd = new SqlCommand(query, _connection);
            _connection.Open();
            cmd.ExecuteNonQuery();
            _connection.Close();
        }
        public void Deleteorderdetails()
        {
           //SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "delete from  orderitems where orderitemId=1";
            SqlCommand cmd = new SqlCommand(query, _connection);
            _connection.Open();
            cmd.ExecuteNonQuery();
            _connection.Close();
        }
        public void getorderdetails()
        {
           //SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "select * from orderdetails";
            SqlCommand cmd = new SqlCommand(query, _connection);
            _connection.Open();

            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                Console.WriteLine("Id:" + r["orderdetailsId"] + " " + "orderid:" + r["ordersid"] + "   " 
                    + "productID:" + r["productID"]
                    + "quantity:" + r["quantity"] + "price:" + r["price_per_unit"] 

                    );
            }
            _connection.Close();
        }
        public int Getstockvalue(int productid)
        {
            //SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"]
            //    .ToString());
            string query = "select stock from products where productsid=@productsid";
            SqlCommand cmd=new SqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@productsid",productid);
            _connection.Open ();
            int stock= (int)cmd.ExecuteScalar();
            _connection.Close ();

          return stock;
        }
        public void InsertOp(int productid,int quantity,out string msg)
        {
           
            //SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"]
            //   .ToString());
            _connection.Open();
            int stock = Getstockvalue(productid);
            
            if (stock<quantity)
            {
                msg = "Sorry...Stock is less than quantity";
                return;          
            }
            SqlCommand cmd=new SqlCommand ("insert into orderdetails(ordersid,productid,quantity,price_per_unit," +
                "totalprice,createdon)values(12,@productid,@quantity,45000,0,getdate())" , _connection);
           // cmd.Parameters.AddWithValue("@ordersid",ordersid);
            cmd.Parameters.AddWithValue("@productid",productid);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            //cmd.Parameters.AddWithValue("@price_per_unit",price_per_unit);
            //cmd.Parameters.AddWithValue("@totalprice", totalprice);
            //cmd.Parameters.AddWithValue("@createon", createOn);
            cmd.ExecuteNonQuery ();
            _connection.Close ();
            msg = "order inserted";
        }
    }
}
