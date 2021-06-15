using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;

namespace WebApplication1.Models
{
    public class Class1
    {
        public static bool SIGN_UP(string Name, string Email, string Password)
        {
            string connectionString = @"data source=DESKTOP-1R5IIUA; Initial Catalog=ONLINE_TECH_STORE;User=Abdul_Rehman; Password=123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand cmd;
            int result = 0;


            try
            {
                connection.Open();
                cmd = new SqlCommand("SIGN_UP", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@C_Email", SqlDbType.NVarChar, 50).Value = Email;
                cmd.Parameters.Add("@C_Password", SqlDbType.NVarChar, 50).Value = Password;
                cmd.Parameters.Add("@C_Name", SqlDbType.NVarChar, 50).Value = Name;
                cmd.Parameters.Add("@Status", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@Status"].Value);

                if (result == 1)
                    return true;
                else
                    return false;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public static bool SIGN_IN(string Email, string Password)
        {
            string connectionString = @"data source=DESKTOP-1R5IIUA; Initial Catalog=ONLINE_TECH_STORE;User=Abdul_Rehman; Password=123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand cmd;
            int result = 0;

            try
            {
                connection.Open();
                cmd = new SqlCommand("LOG_IN", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@C_Email", SqlDbType.NVarChar, 50).Value = Email;
                cmd.Parameters.Add("@C_Password", SqlDbType.NVarChar, 50).Value = Password;
                cmd.Parameters.Add("@Status", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@Status"].Value);

                if (result == 1)
                    return true;
                else
                    return false;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public static bool AddToCart(string ProductName)
        {
            string connectionString = @"data source=DESKTOP-1R5IIUA; Initial Catalog=ONLINE_TECH_STORE;User=Abdul_Rehman; Password=123456;";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand cmd;
            int result = 0;


            try
            {
                connection.Open();
                cmd = new SqlCommand("ADDTOCART", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@P_Name", SqlDbType.NVarChar, 50).Value = ProductName;
                cmd.Parameters.Add("@Status", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@Status"].Value);

                if (result == 1)
                    return true;
                else
                    return false;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }
       
    }

}