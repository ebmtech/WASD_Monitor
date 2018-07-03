using System;
using System.Collections.Generic;
using System.ServiceModel.Dispatcher;
using System.Xml.Linq;
using ServiceControlUi.Model;
using ServiceControlUi.Model.Source;

namespace ServiceControlUi.Control
{
    public class XmlLoader
    {
        public void GetAllListFromXML(out List<string> jsonUrlList ,out List<string> contactList, out List<WebSource> webSources, out List<DBSource> dbSources, out List<AppServiceSource> appServiceSources, out List<DiskSource> diskSources )
        {
            //System.Diagnostics.Debug.WriteLine("Enter GetAllListFormXml");   
            jsonUrlList = new List<string>();
            contactList = new List<string>();

            webSources = new List<WebSource>();
            dbSources = new List<DBSource>();
            appServiceSources = new List<AppServiceSource>();
            diskSources = new List<DiskSource>();


            var xmlFileDocument = XDocument.Load("MonitorList.xml");

            //Web
            var web = xmlFileDocument.Root.Element("WebList").Elements("Web");
            foreach (var item in web)
            {           
                webSources.Add(new WebSource()
                {
                    Name = item.Attribute("Name").Value,
                    Url = item.Element("Url").Value,
                });
            }

            //DB
            var db = xmlFileDocument.Root.Element("DBList").Elements("DB");
            foreach (var item in db)
            {
                dbSources.Add(new DBSource()
                {
                    IP = item.Element("IP").Value,
                    Name = item.Attribute("Name").Value,
                    Username = item.Element("Username").Value,
                    Password = item.Element("Password").Value,
                });
            }

            //Service
            var service = xmlFileDocument.Root.Element("ServiceList").Elements("Service");
            foreach (var item in service)
            {
                appServiceSources.Add(new AppServiceSource()
                {
                    Name = item.Attribute("Name").Value,
                    MemoryLimit = item.Element("MemoryLimit").Value,
                    RestartDay = item.Element("RestartDay").Value,
                    ShutDownTime = DateTime.Today.AddHours(3).AddDays(double.Parse(item.Element("RestartDay").Value)),
                    Type = "S",
                    FilePath = "",
                });
            }

            //App
            var app = xmlFileDocument.Root.Element("ApplicationList").Elements("App");
            foreach (var item in app)
            {
                appServiceSources.Add(new AppServiceSource()
                {
                Name = item.Attribute("Name").Value,
                MemoryLimit = item.Element("MemoryLimit").Value,
                RestartDay = item.Element("RestartDay").Value,
                ShutDownTime = DateTime.Today.AddHours(3).AddDays(double.Parse(item.Element("RestartDay").Value)),
                Type = "A",
                FilePath = item.Element("Path").Value,
            });
            }

            //Web
            var json = xmlFileDocument.Root.Element("JsonList").Elements("Url");
            foreach (var item in json)
            {
                jsonUrlList.Add(item.Value);
            }
            //SMS
            var SMS = xmlFileDocument.Root.Element("ContactList").Elements("Phone");
            foreach (var item in SMS)
            {
                contactList.Add(item.Value);
            }

            //Disk
            var Disk = xmlFileDocument.Root.Element("DiskList").Elements("Disk");
            foreach (var item in Disk)
            {
                diskSources.Add(new DiskSource()
                {
                    Name = item.Attribute("Name").Value,
                    limitPercentage = Int32.Parse(item.Element("LimitPercentage").Value),
                });
            }

        }
    }
}