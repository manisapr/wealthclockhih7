using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Newtonsoft.Json;
using WealthClock_25_11_2019_NEW.Controllers;

namespace WealthClock_25_11_2019_NEW.CodeFile
{
    public class myAccountCode
    {
        string ConStr = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        public int InsertRequstCallBackData(string Name, string Email, string Mobile, string PrefDate, string PrefTime, string Message)
        {
            int rowsEffected = 0;
            SqlConnection con = new SqlConnection(ConStr);
            try
            {

                SqlCommand cmd = new SqlCommand("InsertRequstCallBackDatas", con);
            
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Mobile", Mobile);
                cmd.Parameters.AddWithValue("@PrefDate", PrefDate);
                cmd.Parameters.AddWithValue("@PrefTime", PrefTime);
                cmd.Parameters.AddWithValue("@Message", Message);
                cmd.CommandType = CommandType.StoredProcedure;
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                rowsEffected = cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                rowsEffected = 0;
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
            return rowsEffected;
        }
    }
}