using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using Newtonsoft.Json;
using ServiceControlUi.model;
using ServiceControlUi.Model;
using ServiceControlUi.Model.Source;

namespace ServiceControlUi.Web
{
    public class MakeJSON
    {
        public string GetJson(List<AppServiceSource> appServiceSources,List<DBSource> dbSources,List<WebSource> webSources, List<DiskSource> diskSources)
        {
            WebHttp webHttp = new WebHttp();

            //準備資料
            string ip = webHttp.GetLocalIP();
            string type = ConfigurationManager.AppSettings["Type"];
            string doamin = ConfigurationManager.AppSettings["Doamin"];
            string serverName = ConfigurationManager.AppSettings["ServerName"];
            string description = ConfigurationManager.AppSettings["Description"];
            string sendDateTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");


            //要輸出的變數
            StringWriter sw = new StringWriter();
            //建立JsonTextWriter
            JsonTextWriter writer = new JsonTextWriter(sw);
        
            writer.WriteStartObject();
            writer.WritePropertyName("IP"); writer.WriteValue(ip);
            writer.WritePropertyName("Type"); writer.WriteValue(type);
            writer.WritePropertyName("Doamin"); writer.WriteValue(doamin);
            writer.WritePropertyName("ServerName"); writer.WriteValue(serverName);
            writer.WritePropertyName("Description"); writer.WriteValue(description);
            writer.WritePropertyName("SendDateTime"); writer.WriteValue(sendDateTime);

            if (appServiceSources != null)
            {
                writer.WritePropertyName("Applications");
                writer.WriteStartArray();

                foreach (var item in appServiceSources)
                {
                    if (item.Type.Equals("A"))
                    {
                        writer.WriteStartObject();
                        writer.WritePropertyName("AppNo"); writer.WriteValue(item.Sequence);
                        writer.WritePropertyName("AppName"); writer.WriteValue(item.Name);
                        writer.WritePropertyName("Status"); writer.WriteValue(item.Status);
                        writer.WritePropertyName("Memory"); writer.WriteValue(item.MemoryUsed + "(MB)");
                        writer.WriteEndObject();
                    }
                }

                writer.WriteEndArray();


                writer.WritePropertyName("Services");
                writer.WriteStartArray();

                foreach (var item in appServiceSources)
                {
                    if (item.Type.Equals("S"))
                    {
                        writer.WriteStartObject();
                        writer.WritePropertyName("ServiceNo"); writer.WriteValue(item.Sequence);
                        writer.WritePropertyName("ServiceName"); writer.WriteValue(item.Name);
                        writer.WritePropertyName("Status"); writer.WriteValue(item.Status);
                        writer.WritePropertyName("Memory"); writer.WriteValue(item.MemoryUsed + "(MB)");
                        writer.WriteEndObject();
                    }
                }

                writer.WriteEndArray();
            }

            if (dbSources != null)
            {
                writer.WritePropertyName("Databases");
                writer.WriteStartArray();
                foreach (var item in dbSources)
                {
                    //List < object > +object.attibute
                    writer.WriteStartObject();
                    writer.WritePropertyName("DBNo"); writer.WriteValue(item.Sequence);
                    writer.WritePropertyName("DBName"); writer.WriteValue(item.Name);
                    writer.WritePropertyName("DBIP"); writer.WriteValue(item.IP);
                    writer.WritePropertyName("Status"); writer.WriteValue(item.ConnectionStatus);
                    writer.WriteEndObject();
                }
                writer.WriteEndArray();
            }

            if (webSources != null)
            {
                writer.WritePropertyName("Webs");
                writer.WriteStartArray();

                foreach (var item in webSources)
                {
                    //List < object > +object.attibute
                    writer.WriteStartObject();
                    writer.WritePropertyName("WebNo"); writer.WriteValue(item.Sequence);
                    writer.WritePropertyName("WebUrl"); writer.WriteValue(item.Url);
                    writer.WritePropertyName("Status"); writer.WriteValue(item.ConnectionStatus);
                    writer.WriteEndObject();
                }
                writer.WriteEndArray();
            }

            if (diskSources != null)
            {
                writer.WritePropertyName("Disks");
                writer.WriteStartArray();

                foreach (var item in diskSources)
                {
                    //List < object > +object.attibute
                    writer.WriteStartObject();
                    writer.WritePropertyName("Name"); writer.WriteValue(item.Name);
                    writer.WritePropertyName("Format"); writer.WriteValue(item.Format);
                    writer.WritePropertyName("AvailableSpace"); writer.WriteValue(item.AvailableSpace+"(B)");
                    writer.WritePropertyName("TotalSize"); writer.WriteValue(item.TotalSize+"(B)");
                    writer.WritePropertyName("Usage"); writer.WriteValue(item.Usage+"%");
                    writer.WriteEndObject();
                }
                writer.WriteEndArray();
            }

            string t = sw.ToString();
            //輸出結果
            return t ;
        }
    }
}
