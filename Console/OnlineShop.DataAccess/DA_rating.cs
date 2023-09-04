using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.DataAccess
{
    public class DA_rating
    {
        public void insertRating()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "insert into RATING (  productid, customerid, rating ) values ()";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int row = cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void updateRating()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "update rating set rating=3 where ratingid=201";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int row = cmd.ExecuteNonQuery();
            sqlConnection.Close();

        }
        public void deleteRating()
        {

            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "delete from rating where ratingid=201";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int row = cmd.ExecuteNonQuery();
            sqlConnection.Close();

        }
        public void GetRating()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
            string query = "select top 1 ratingid from rating";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            string row = Convert.ToString(cmd.ExecuteScalar());
            sqlConnection.Close();
        }
    }
}
