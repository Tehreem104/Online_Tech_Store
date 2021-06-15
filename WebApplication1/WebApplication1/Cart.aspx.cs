using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Cart : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = @"data source=DESKTOP-1R5IIUA; Initial Catalog=ONLINE_TECH_STORE;User=Abdul_Rehman; Password=123456;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd;
            cmd = new SqlCommand("SELECT [P_Name]  ,[C_Email] FROM[dbo].[Cart]", connection);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = connection;

            string temp = "";

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                temp += reader["P_Name"].ToString();
                temp += " ";
                temp += reader["C_Email"].ToString();
                temp += "<br/>";
            }
            connection.Close();
            AddtoCart.Text = temp;

        }
    }
}