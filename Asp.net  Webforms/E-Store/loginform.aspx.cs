using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineShop.DataAccess;
namespace E_Store
{
    public partial class loginform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          //  DAusers dAusers = new DAusers();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string useremail=TextBox1.Text;
            string userpass=TextBox2.Text;

            DAusers dAusers = new DAusers();
           

           bool exist =dAusers.Authenticateuser(useremail,userpass,out string validationmessage);
            if (exist)
            {
                Session["usersname"] = useremail;
                Response.Redirect("redirect.aspx");
            }
            else
            {
                errorlable.Text = validationmessage;
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}