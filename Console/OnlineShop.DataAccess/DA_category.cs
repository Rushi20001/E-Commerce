using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.DataAccess
{
    public class DA_category
    {
        private  SqlConnection sqlconnection;

        public DA_category()
        {
            //string connectionString = ConfigurationManager.ConnectionStrings["sqlConnection"].ToString();
             sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ToString());
        }
        public void Insertcategory()
        {
     
           // SqlConnection sqlConnetion = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ToString());

         
            string query = "Insert into category values ('AC')";
          
            SqlCommand cmd = new SqlCommand(query, sqlconnection);
        
            sqlconnection.Open();
            int rowaffected = cmd.ExecuteNonQuery();

            sqlconnection.Close();
        }
        public void Retreivecategory()
        {
          //  SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "select top 1 categoryName from category";
            SqlCommand cmd = new SqlCommand(query, sqlconnection);
            sqlconnection.Open();
            string row = Convert.ToString(cmd.ExecuteScalar());
            sqlconnection.Close();
        }
        public void Updatecategory()
        {
           // SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "update category set categoryName='home appliances' where categoryId=106";
            SqlCommand cmd = new SqlCommand(query, sqlconnection);
            sqlconnection.Open();
            int row = cmd.ExecuteNonQuery();
            sqlconnection.Close();
        }
        public void Deletecategory()
        {
            //SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ToString());
            string query = "delete from category where categoryId=108 ";
            SqlCommand cmd = new SqlCommand(query, sqlconnection);
            sqlconnection.Open();
            int row = cmd.ExecuteNonQuery();
            sqlconnection.Close();
            if (row > 0)
            {
                Console.WriteLine("record deleted");
            }
        }
    }
}
