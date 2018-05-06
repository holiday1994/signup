using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace dbtest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=fhgamesdatabase.database.windows.net;Initial Catalog=dbconnect;Integrated Security=False;User ID=holiday1994@fhgamesdatabase.database.windows.net;Password=Tonkatoy816037;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                con.Open();

                String insert = "insert into dbo.userinfo (username) values (@username)";

                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.Parameters.AddWithValue("@username", TextBox1.Text);
                cmd.ExecuteNonQuery();
                Response.Redirect("home.aspx");

                con.Close();
            }
            catch(Exception ex)
            {
                Response.Write(ex);
            }
        }
    }
}