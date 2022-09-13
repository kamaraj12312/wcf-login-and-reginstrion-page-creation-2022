using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace WcfServiceReg
{
    public class Register
    {


        TestDBEntities1 ME = new TestDBEntities1();
        public string vusername;
        public string vpassword;

        public string Username
        {
            get { return vusername; }
            set { vusername = value; }
        }

        public string Password
        {
            get { return vpassword; }
            set { vpassword = value; }
        }


        public string RegisterInsert()
        { try
            {
                using (SqlConnection con = new SqlConnection("Data Source=10.50.51.117;Initial Catalog=TestDB;User ID=bms0176;Password=Welcome@123"))
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO userdata (USERNAME, PASSWORD) VALUES (@Username, @Password)"))
                    {
                        cmd.Parameters.AddWithValue("@UserName", Username);
                        cmd.Parameters.AddWithValue("@Password", Password);
                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new FaultException<string>
                        (ex.Message);
            }
           
            return "true";
        }
















    }
}