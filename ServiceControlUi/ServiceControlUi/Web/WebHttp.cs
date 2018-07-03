using System;
using System.IO;
using System.Net;

namespace ServiceControlUi.Web
{
   public class WebHttp
    {
      public string GetStatus(string url,int delayTime)
        {
            try
            {
                //Default method is Get.
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
                webRequest.AllowAutoRedirect = false;
                webRequest.Timeout = delayTime * 1000;
                HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();
                response.Close();
                return ((int)response.StatusCode).ToString();
            }
            catch (Exception e)
            {
                return e.Message;
            }
           
        }

        public string GetLocalIP()
        {
            //本機名稱
            string strHostName = Dns.GetHostName();
            // 取得本機的IpHostEntry類別實體，用這個會提示已過時
            //IPHostEntry iphostentry = Dns.GetHostByName(strHostName);

            // 取得本機的IpHostEntry類別實體，MSDN建議新的用法
            IPHostEntry iphostentry = Dns.GetHostEntry(strHostName);

            // 取得所有 IP 位址
            foreach (IPAddress ipaddress in iphostentry.AddressList)
            {
                // 只取得IP V4的Address
                if (ipaddress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return ipaddress.ToString();
                }
            }
            return "NO IP";
        }

        public string SendJson(string url,string jsonMsg)
        {
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(jsonMsg);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                httpResponse.Close();
                return httpResponse.StatusCode.ToString();
                //using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                //{
                //    var result = streamReader.ReadToEnd();
                //}

            }
            catch (Exception e)
            {
                return e.Message.ToString();
            }

           
        }
    }
}
