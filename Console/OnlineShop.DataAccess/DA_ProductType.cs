using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.DataAccess
{
    public class DA_ProductType
    {
        public void InsertProductType()
        {
            // Create connection string and assing to class
            SqlConnection sqlConnetion = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ToString());

            // Generate Query
            string query = "Insert into ProductType values ('books')";
            // string query = "insertlookuptype";
            //Create Command
            SqlCommand cmd = new SqlCommand(query, sqlConnetion);
            //cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.Parameters.Add("@lookupTypename", SqlDbType.VarChar).Value = "Added By SP";
            sqlConnetion.Open();
            int rowaffected = cmd.ExecuteNonQuery();

            sqlConnetion.Close();
        }
        public void RetreiveProductType()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "select top 1 TypeName from ProductType";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            string row = Convert.ToString(cmd.ExecuteScalar());
            sqlConnection.Close();
        }
        public void UpdateProductType()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "update ProductType set TypeName='home appliances' where ProductTypeId=106";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int row = cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void DeleteProductType()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ToString());
            string query = "delete from ProductType where ProductTypeId=108 ";
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
