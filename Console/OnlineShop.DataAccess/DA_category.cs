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
        public void Insertcategory()
        {
     
            SqlConnection sqlConnetion = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ToString());

         
            string query = "Insert into category values ('books')";
          
            SqlCommand cmd = new SqlCommand(query, sqlConnetion);
        
            sqlConnetion.Open();
            int rowaffected = cmd.ExecuteNonQuery();

            sqlConnetion.Close();
        }
        public void Retreivecategory()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "select top 1 categoryName from category";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            string row = Convert.ToString(cmd.ExecuteScalar());
            sqlConnection.Close();
        }
        public void Updatecategory()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "update category set categoryName='home appliances' where categoryId=106";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int row = cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void Deletecategory()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ToString());
            string query = "delete from category where categoryId=108 ";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int row = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            if (row > 0)
            {
                Console.WriteLine("record deleted");
            }
        }
    }
}
