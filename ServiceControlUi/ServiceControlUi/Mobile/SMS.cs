using System;
using System.Collections.Generic;
using ServiceControlUi.Control;
using ServiceControlUi.model;

namespace ServiceControlUi.Mobile
{
    public class SMS
    {
        public bool Send(List<string> phones,string msg )
        {
            Log lg = new Log();
            try
            {
                // http://10.200.1.79/EricWS/EricWebServices.asmx

                foreach (string phone in phones)
                {
                    var SMSSvc = new SMS_API.EricWebServicesSoapClient();
                    var SMSClass = new SMS_API.SendSMSClass();

                    if (phone.Length > 2 && phone.Substring(0, 2) != "09")
                    {
                        SMSClass = new SMS_API.SendSMSClass
                        {
                            full_phs = "",
                            phs = phone, //"54778"
                            send_text = msg, 
                            send_unit = "E.M.R",
                            system_name = "E.M.R"
                        };
                    }
                    else
                    {
                        SMSClass = new SMS_API.SendSMSClass
                        {
                            full_phs = phone,
                            phs = "",
                            send_text = msg, 
                            send_unit = "E.M.R",
                            system_name = "E.M.R"
                        };
                    }
                    var result = SMSSvc.SendSMS(SMSClass);

                    if (result != "success")
                    {
                        string errormsg = $"發送簡訊失敗,電話{phone}";
                        lg.Start($"[Error]\"{errormsg}\" .");
                       
                    }
                    else
                    {
                        lg.Start($"[SMS]\"{"對" + phone + ":"+ msg + "(發送簡訊完成)"}\" .");                      
                    }

                    

                }


                return true;
            }
            catch (Exception e)
            {
                lg.Start($"[Error]\"{"發送簡訊失敗"+e.Message.ToString()}\" .");
                return false;
            }

          

           
        }
       
    }
}