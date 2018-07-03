using System;
using System.Data.SqlClient;

namespace ServiceControlUi.Control
{
   public class MssqlPing
    {
        public string ConnectTry(string dateSource, string dbname, string id, string password,string delay)
        {
            var connStr = "Data Source = " + dateSource + ";Initial catalog = " + dbname + ";" +
                             "User id = " + id + "; Password = " + password + ";Connection Timeout="+delay+";";
            try
            {
                string state = null;
                using (var cn = new SqlConnection(connStr))
                {
                    cn.Open();
                   
                    state = cn.State.ToString();
                    cn.Close();
                }

                return state;
            }
            catch (Exception)
            {
               // Console.WriteLine(string.Format("Exception:{0}", ex.Message.ToString()));
                return "null";
            }
        }
    }
}
