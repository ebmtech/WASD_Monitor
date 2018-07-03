using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceControlUi.model;
using ServiceControlUi.Model;
using ServiceControlUi.Model.Source;
using ServiceControlUi.Web;

namespace ServiceControlUi.Control
{
    public class Details
    {
        private Log _lg = new Log();

        public List<WebSource> GetWebExternalInfo(List<WebSource> webSources, int webDelayTime)
        {
            WebHttp _webHttp = new WebHttp();
            int i = 0;

            //status
            foreach (var sourceItem in webSources)
            {
                i++;
                sourceItem.Sequence = "W" + i;
                sourceItem.ConnectionStatus = (_webHttp.GetStatus(sourceItem.Url, webDelayTime));

                if (sourceItem.ConnectionStatus.Equals("200"))
                {
                    sourceItem.StatusColor = Color.LightGreen;
                }
                else
                {
                    sourceItem.StatusColor = Color.Red;
                }
            }
            return webSources;
        }

        public List<DBSource> GetDBExternalInfo(List<DBSource> dbSources, string dbDelayTime)
        {
            int i = 0;
            MssqlPing mssqlPing = new MssqlPing();

            //status
            foreach (var sourceItem in dbSources)
            {
                i++;
                sourceItem.Sequence = "D" + i;
                sourceItem.ConnectionStatus = mssqlPing.ConnectTry(sourceItem.IP, sourceItem.Name, sourceItem.Username,
                    sourceItem.Password, dbDelayTime);

                if (sourceItem.ConnectionStatus.Equals(System.Data.ConnectionState.Open.ToString()))
                {
                    sourceItem.StatusColor = Color.LightGreen;
                }
                else
                {
                    sourceItem.StatusColor = Color.Red;
                }
            }

            return dbSources;
        }

        public List<AppServiceSource> GetAppServiceExternalInfoAppServiceSources(List<AppServiceSource> appServiceSources)
        {
            int Scount = 0;
            int Acount = 0;

            foreach (var sourceItem in appServiceSources)
            {
                if (sourceItem.Type.Equals("S"))
                {
                    Scount++;
                    sourceItem.Sequence = "S" + Scount;
                    var service = GetServiceStatus(sourceItem.Name);
                    //service exist
                    if (service != null)
                    {
                        sourceItem.Status = service.Status.ToString();
                       
                        if (service.Status == ServiceControllerStatus.Running)
                        {
                            sourceItem.StatusColor = Color.LightGreen;
                            var details = GetServiceInfo(service);
                            sourceItem.PID = details.PID.ToString();
                            sourceItem.MemoryUsed = details.MemoryUsed.ToString();
                            sourceItem.StartTime = details.StartTime.ToString();
                            sourceItem.ProcessTotalTime = details.ProcessTotalTime.ToString();
                            sourceItem.ShowShutDownTime = sourceItem.ShutDownTime.ToString();
                        }
                        else
                        {
                            sourceItem.StatusColor = Color.Red;
                        }
                    }
                    //service not exist
                    else
                    {
                        sourceItem.Status = "Not Exist";
                        sourceItem.StatusColor = Color.DarkTurquoise;
                    }

                }

                //application
                else
                {
                    Acount++;
                    sourceItem.Sequence = "A" + Acount;
                    var process = GetProcess(sourceItem.Name);
                    //Process exist
                    if (process != null)
                    {
                        sourceItem.Status = "Running";
                        sourceItem.StatusColor = Color.LightGreen;
                        sourceItem.PID = process.PID.ToString();
                        sourceItem.MemoryUsed = process.MemoryUsed.ToString();
                        sourceItem.StartTime = process.StartTime.ToString();
                        sourceItem.ProcessTotalTime = process.ProcessTotalTime.ToString();                       
                        sourceItem.ShowShutDownTime = sourceItem.ShutDownTime.ToString();
                    }
                    //process not exist
                    else
                    {
                        sourceItem.Status = "Not Running";
                        sourceItem.StatusColor = Color.Red;
                    }
                }
            }
            return appServiceSources;
        }

        private ProcessAttribute GetProcess(string processName)
        {
            ProcessAttribute pp = new ProcessAttribute();
            Process[] processes = Process.GetProcessesByName(processName);

            //exist
            if (processes.Length > 0)
            {
                foreach (Process p in processes)
                {

                    pp.PID = p.Id;
                    PerformanceCounter ramUse = new PerformanceCounter("Process", "Working Set - Private", p.ProcessName);
                    pp.MemoryUsed = Math.Round(ramUse.NextValue()/1024/1024, 1);
                    pp.StartTime = p.StartTime;
                    pp.ProcessTotalTime = p.TotalProcessorTime;
                }

                return pp;
            }
            //not exist
            else
            {
                return null;
            }
        }

        private ProcessAttribute GetServiceInfo(ServiceController scTemp)
        {
            ProcessAttribute pp = new ProcessAttribute();

            ManagementObject service = new ManagementObject(@"Win32_service.Name='" + scTemp.ServiceName + "'");
            object o = service.GetPropertyValue("ProcessId");
            int processId = (int) ((UInt32) o);
            pp.PID = processId;

            //Services -> Process
            Process toMonitor = Process.GetProcessById(processId);
            PerformanceCounter ramUse = new PerformanceCounter("Process", "Working Set - Private", toMonitor.ProcessName);
            pp.MemoryUsed = Math.Round(ramUse.NextValue()/1024/1024, 1);


            pp.StartTime = toMonitor.StartTime;
            pp.ProcessTotalTime = toMonitor.TotalProcessorTime;

            return pp;
        }

        private ServiceController GetServiceStatus(string serviceName)
        {
            var s = ServiceController.GetServices()
                .Where(p => p.ServiceName == serviceName)
                .FirstOrDefault();

            return s;
        }

        public void ServiceStart(string aaa)
        {
            try
            {
                var s = GetServiceStatus(aaa);

                if (s != null)
                {
                    _lg.Start($"[ServiceStart]Prepare to start \"{aaa}\".");
                    if (s.Status != ServiceControllerStatus.Running)
                    {
                        s.Start();
                        s.WaitForStatus(ServiceControllerStatus.Running);
                    }
                    _lg.Start($"[ServiceStart]\"{aaa}\" is already started.");
                }
                else
                {
                    _lg.Start($"[ServiceStart]This Service of \"{aaa}\" is not found!");
                }
            }
            catch (Exception e)
            {
                _lg.Start($"[Error]\"{e.Message.ToString()}\" .");
            }
        }

        public void AppStop(string name)
        {
            try
            {
                _lg.Start($"[AppStop]Prepare to stop \"{name}\".");
                Process[] processes = Process.GetProcessesByName(name);

                foreach (Process p in processes)
                {
                    
                    //p.Close();
                    //p.WaitForExit(5000);

                        p.Kill();
                    
                }
                _lg.Start($"[AppStop]\"{name}\" is already stopped.");
            }
            catch (Exception e)
            {
                _lg.Start($"[Error]\"{e.Message.ToString()}\" .");
            }
        }

        public void AppStart(string path)
        {
            try
            {
                _lg.Start($"[AppStart]Prepare to start \"{path}\".");
                Process process = new Process();
                // FileName or Path
                process.StartInfo.FileName = path;
                process.Start();
                _lg.Start($"[AppStart]\"{path}\" is already started.");
            }
            catch (Exception e)
            {
                _lg.Start($"[Error]\"{e.Message.ToString()}\" .");
            }
        }

        public void ServiceStop(string aaa)
        {
            try
            {
                var s = GetServiceStatus(aaa);

                if (s != null)
                {
                    _lg.Start($"[ServiceStop]Prepare to stop \"{aaa}\".");
                    if (s.Status == ServiceControllerStatus.Running)
                    {
                        s.Stop();
                        s.WaitForStatus(ServiceControllerStatus.Stopped);
                    }
                    _lg.Start($"[ServiceStop]\"{aaa}\" is already stopped.");
                }
                else
                {
                    _lg.Start($"[ServiceStop]This Service of \"{aaa}\" is not found!");
                }
            }
            catch (Exception e)
            {
                _lg.Start($"[Error]\"{e.Message.ToString()}\" .");
            }
        }

        public List<DiskSource> Disk_Info(List<DiskSource> diskSource)
        {
            //取得所有磁碟機的DriveInfo類別
            DriveInfo[] ListDrivesInfo = DriveInfo.GetDrives();
            try
            {
                foreach (DriveInfo vListDrivesInfo in ListDrivesInfo)
                {
                    foreach (DiskSource vDiskSource in diskSource)
                    {
                        if (vListDrivesInfo.IsReady && vListDrivesInfo.Name.Equals(vDiskSource.Name))
                        {
                            vDiskSource.Format = vListDrivesInfo.DriveFormat;
                            vDiskSource.TotalSize = vListDrivesInfo.TotalSize.ToString("#,#");  // 千分位顯示
                            vDiskSource.AvailableSpace = vListDrivesInfo.AvailableFreeSpace.ToString("#,#");
                            vDiskSource.Usage = (((vListDrivesInfo.TotalSize - vListDrivesInfo.AvailableFreeSpace) * 100) / vListDrivesInfo.TotalSize).ToString();

                            if (Int32.Parse(vDiskSource.Usage) >= vDiskSource.limitPercentage)
                            {
                                vDiskSource.StatusColor = Color.Red;
                            }
                            else
                            {
                                vDiskSource.StatusColor = Color.LightGreen;
                            }
                        }
                    }                
                }
            }
            catch (Exception ex)
            {
                _lg.Start($"[Error]\"{ex.Message.ToString()}\" .");
            }

            return diskSource;
        }

    }

}
