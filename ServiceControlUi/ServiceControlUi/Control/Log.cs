using System;
using System.IO;

namespace ServiceControlUi.Control
{
    public class Log
    {
        public void Start(string a)
        {
            
            //今日日期
            DateTime date = DateTime.Now;
            string todyMillisecond = date.ToString("yyyy-MM-dd HH:mm:ss");
            string tody = date.ToString("yyyy-MM-dd");

            //如果此路徑沒有資料夾
            if (!Directory.Exists("LogFile"))
            {
                //新增資料夾
                Directory.CreateDirectory("LogFile");
            }

            //把內容寫到目的檔案，若檔案存在則附加在原本內容之後(換行)
            File.AppendAllText("LogFile\\" + tody + ".txt", "\r\n" + todyMillisecond + "：" + a);
        }
    }
}
