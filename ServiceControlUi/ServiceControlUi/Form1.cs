using ServiceControlUi.model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ServiceControlUi.Control;
using ServiceControlUi.Mobile;
using ServiceControlUi.Model;
using ServiceControlUi.Model.Source;
using ServiceControlUi.Web;

namespace ServiceControlUi
{
    public partial class Form1 : Form
    {
        private string _isNeedSendJson = ConfigurationManager.AppSettings["Send_Json"];
        private WebHttp _webHttp = new WebHttp();
        private Details _details = new Details();

        //Loading File Check
        private bool _isLoadingAppService;
        //Loading File Check_DB
        private bool _isLoadingDb;
        //Loading File Check_Web
        private bool _isLoadingWeb;
        //Loading File Check_Disk
        private bool _isLoadingDisk;

        private List<string> _jsonUrlList = new List<string>();
        private List<string> _contactlList = new List<string>();

        private List<WebSource> _webSource = new List<WebSource>();
        private List<DBSource> _dbSource = new List<DBSource>();
        private List<AppServiceSource> _appServiceSource = new List<AppServiceSource>();
        private  List<DiskSource> _diskSource = new List<DiskSource>();



        //預設是沒寄出
        private bool _isWebSendSms = false;
        private bool _isDbSendSms = false;
        private bool _isDiskSendSms = false;

        private Log _lg = new Log();
        private OptionsAttribute _optionsAttribute = new OptionsAttribute();
        private OptionsAttribute _optionsAttributeTemp = new OptionsAttribute();

        //SMS
        private SMS _sms = new SMS();

       
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Form.CheckForIllegalCrossThreadCalls = false;
            OptionsValueTempInital();
            OptionsValueSettingCheck();

            List<Thread> threads = new  List<Thread>();

            Thread A = new Thread(Service_mission) {IsBackground = true};
            threads.Add(A);

            Thread B = new Thread(DB_mission) { IsBackground = true };
            threads.Add(B);

            Thread C = new Thread(Web_mission) { IsBackground = true };
            threads.Add(C);

            if (_isNeedSendJson.Equals("1"))
            {
                Thread D = new Thread(MakeSendString2JSON) { IsBackground = true };
                threads.Add(D);
            }

            Thread E = new Thread(Disk_mission) { IsBackground = true };
            threads.Add(E);

            foreach (var thread in threads)
            {
                thread.Start();
            }

            Initial_ListLoading();
        }

        private void MakeSendString2JSON()
        {
            try
            {
                while (true)
                {
                    MakeJSON mj = new MakeJSON();
                    string temp = mj.GetJson(_appServiceSource, _dbSource, _webSource,_diskSource);
                    ShowText(temp);

                    //Send to WebAPI
                    foreach (var item in _jsonUrlList)
                    {
                        var res = _webHttp.SendJson(item, temp);
                        ShowText("HttpRequest Says: " + item + "=>>>" + res);
                    }

                    Thread.Sleep(_optionsAttribute.JsonTheadSleep * 1000);
                }
            }
            catch (Exception e)
            {
                _lg.Start("Thread MakeSendString2JSON:" + e.Message.ToString());
            }
        }

        private void Disk_mission()
        {
            string serverName = ConfigurationManager.AppSettings["ServerName"];
            List<string> diskAbnormalList;
            try
            {
                while (true)
                {
                    if (_isLoadingDisk)
                    {
                        diskAbnormalList = new List<string>();

                        ShowTime(UpdateClock_Disk);
                        _diskSource = _details.Disk_Info(_diskSource);
                        ResultShowDiskList(_diskSource);

                        foreach (var item in _diskSource)
                        {
                            if (item.StatusColor.Equals(Color.Red))
                            {
                                diskAbnormalList.Add(item.Name);
                            }
                        }

                        if (diskAbnormalList.Count > 0 && !_isDiskSendSms)
                        {
                            foreach (string item in diskAbnormalList)
                            {
                                _sms.Send(_contactlList, "請注意! "+ serverName+""+"系統磁碟機" + item + " 空間已接近上限!");
                            }
                            _isDiskSendSms = true;
                        }

                        else if (diskAbnormalList.Count == 0 && _isDiskSendSms)
                        {
                            _sms.Send(_contactlList, serverName + "" + "系統磁碟機空間皆已釋放，系統已恢復正常!");
                            _isDiskSendSms = false;
                        }
                    }

                    Thread.Sleep(_optionsAttribute.DiskTheadSleep * 1000);
                }
            }
            catch (Exception e)
            {
                _lg.Start("Thread Disk_mission:" + e.Message.ToString());
            }
        }


        private void Web_mission()
        {
            List<string> webAbnormalList;

            try
            {
                while (true)
                {
                    if (_isLoadingWeb)
                    {
                        webAbnormalList = new List<string>();

                        foreach (var item in _webSource)
                        {
                            if (item.StatusColor.Equals(Color.Red))
                            {
                                webAbnormalList.Add(item.Name);
                            }                  
                        }

                            if (webAbnormalList.Count > 0 && !_isWebSendSms)
                            {
                                foreach (string ip in webAbnormalList)
                                {
                                    _sms.Send(_contactlList, "系統異常通知Web Server IP：" + ip + "。");
                                }
                                _isWebSendSms = true;
                            }

                            else if (webAbnormalList.Count == 0 && _isWebSendSms)
                            {
                                _sms.Send(_contactlList, "系統已恢復正常!");
                                _isWebSendSms = false;
                            }

                        ShowTime(UpdateClock_Web);
                        _webSource = _details.GetWebExternalInfo(_webSource, _optionsAttributeTemp.WebDelayTime);
                        ResultShowWebList(_webSource);
                    }               
   
                    Thread.Sleep(_optionsAttribute.WebTheadSleep * 1000);
                }
            }
            catch (Exception e)
            {
                _lg.Start("Thread Web_mission:" + e.Message.ToString());
            }
        }

        private void Service_mission()
        {
            try
            {
                while (true)
                {
                    if (_isLoadingAppService)
                    {            
                        //stop => start
                        if (_optionsAttribute.chkAutoRestart_flag)
                        {
                            foreach (var sourceitem in _appServiceSource)
                            {
                                if (sourceitem.StatusColor == Color.Red && sourceitem.Type.Equals("S"))
                                {
                                    _details.ServiceStart(sourceitem.Name);
                                    _lg.Start(sourceitem.Name + " was restarted.");
                                }
                                else if (sourceitem.StatusColor == Color.Red && sourceitem.Type.Equals("A"))
                                {
                                    _details.AppStart(sourceitem.FilePath);
                                    _lg.Start(sourceitem.Name + " was restarted.");
                                }
                            }
                        }

                        //Memory start => stop
                        if (_optionsAttribute.chkAutoRestart_Memory_flag)
                        {
                            foreach (var sourceitem in _appServiceSource)
                            {
                                if (sourceitem.StatusColor == Color.LightGreen)
                                {
                                    if (Double.Parse(sourceitem.MemoryUsed) > Double.Parse(sourceitem.MemoryLimit) && sourceitem.Type.Equals("S"))
                                    {
                                        _lg.Start(sourceitem.Name + " is out of the memory limit range! It will be stopped.");
                                        _details.ServiceStop(sourceitem.Name);                                        
                                    }
                                    else if (Double.Parse(sourceitem.MemoryUsed) > Double.Parse(sourceitem.MemoryLimit) && sourceitem.Type.Equals("A"))
                                    {
                                        _lg.Start(sourceitem.Name + " is out of the memory limit range! It will be stopped.");
                                        _details.AppStop(sourceitem.Name);                           
                                    }
                                }
                                
                            }
                        }


                        //ShutdownTime start => stop
                        if (_optionsAttribute.chkAutoShutdown_flag)
                        {
                            foreach (var sourceitem in _appServiceSource)
                            {
                                if (sourceitem.StatusColor == Color.LightGreen)
                                {
                                    if ((DateTime.Compare(DateTime.Now, sourceitem.ShutDownTime)>0) && sourceitem.Type.Equals("S"))
                                    {
                                        _lg.Start(sourceitem.Name + " is time to be stopped.");
                                        _details.ServiceStop(sourceitem.Name);
                                        
                                        //Next Time
                                        sourceitem.ShutDownTime =  sourceitem.ShutDownTime.AddDays(double.Parse(sourceitem.RestartDay));
                                    }
                                    else if ((DateTime.Compare(DateTime.Now, sourceitem.ShutDownTime) > 0) && sourceitem.Type.Equals("A"))
                                    {
                                        _lg.Start(sourceitem.Name + " is time to be stopped.");
                                        _details.AppStop(sourceitem.Name);
                                       
                                        //Next Time
                                        sourceitem.ShutDownTime = sourceitem.ShutDownTime.AddDays(double.Parse(sourceitem.RestartDay));
                                    }
                                }

                            }
                        }

                        ShowTime(UpdateClock_Service);
                        var completeWebSource = _details.GetAppServiceExternalInfoAppServiceSources(_appServiceSource);
                        _appServiceSource = completeWebSource;
                        ResultShowAppServiceList(_appServiceSource);
                    }
                    Thread.Sleep(_optionsAttribute.serviceThreadSleep * 1000);
                }
            }
            catch (Exception e)
            {
                _lg.Start("Thread Service_mission:" + e.Message.ToString());
            }
        }

        private void DB_mission()
        {
            List<string> dbAbnormalList;

            try
            {
                while (true)
                {
                    if (_isLoadingDb)
                    {
                        dbAbnormalList = new List<string>();

                        foreach (var item in _dbSource)
                        {
                            if (item.StatusColor.Equals(Color.Red))
                            {
                                dbAbnormalList.Add(item.IP);
                            }
                        }

                        if (dbAbnormalList.Count > 0 && !_isDbSendSms)
                        {
                            foreach (string ip in dbAbnormalList)
                            {
                                _sms.Send(_contactlList, "資料庫異常通知DB Server IP：" + ip + "。");
                            }
                            _isDbSendSms = true;

                        }

                        else if (dbAbnormalList.Count == 0 && _isDbSendSms)
                        {

                            _sms.Send(_contactlList, "資料庫已恢復正常!");

                            _isDbSendSms = false;
                        }

                        ShowTime(UpdateClock_DB);
                        _dbSource = _details.GetDBExternalInfo(_dbSource, _optionsAttributeTemp.DBDelayTime);
                        ResultShowDBList(_dbSource);
                    }

                    Thread.Sleep(_optionsAttribute.DBTheadSleep * 1000);
                }
            }
            catch (Exception e)
            {
                _lg.Start("Thread DB_mission:" + e.Message.ToString());
            }
        }

        private void ShowText(string str)
        {
            if (InvokeRequired)
            {
                this.BeginInvoke(new Action<string>(ShowText), new object[] { str });
                return;
            }

            tbMessage.AppendText($"{DateTime.Now} {str}\r\n");
        }

        private void ShowTime(Label a)
        {
            a.Text = ($"LastUpdateTime:{DateTime.Now}\r\n");
        }

        private void ResultShowDiskList(List<DiskSource> diskSources)
        {
            DiskView.BeginUpdate();
            DiskView.Items.Clear();

            foreach (var sourceItem in diskSources)
            {
                //1st
                var lvi = new ListViewItem(sourceItem.Name);
                lvi.UseItemStyleForSubItems = false;
                //2nd
                lvi.SubItems.Add(sourceItem.Format);
                //3rd
                lvi.SubItems.Add(sourceItem.AvailableSpace);
                //4th
                lvi.SubItems.Add(sourceItem.TotalSize);
                //5th
                lvi.SubItems.Add(sourceItem.Usage);
                lvi.SubItems[4].BackColor = sourceItem.StatusColor;
                //5th
                lvi.SubItems.Add(sourceItem.limitPercentage.ToString());
                DiskView.Items.Add(lvi);
            }
            DiskView.EndUpdate();
            DiskView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            DiskView.GridLines = Enabled;
        }

        private void ResultShowWebList(List<WebSource> webSources)
        {               
            WebView.BeginUpdate();
            WebView.Items.Clear();

            foreach (var sourceItem in webSources)
            {         
                //1st
                var lvi = new ListViewItem(sourceItem.Sequence);
                lvi.UseItemStyleForSubItems = false;
                //2nd
                lvi.SubItems.Add(sourceItem.Url);
                //3rd
                lvi.SubItems.Add(sourceItem.ConnectionStatus);           
                lvi.SubItems[2].BackColor = sourceItem.StatusColor;                
                WebView.Items.Add(lvi);
            }
            WebView.EndUpdate();
            WebView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            WebView.GridLines = Enabled;
        }

        private void ResultShowDBList(List<DBSource> dbSources)
        {        
            DBView.BeginUpdate();
            DBView.Items.Clear();

            foreach (var sourceItem in dbSources)
            {                           
                //1st
                var lvi = new ListViewItem(sourceItem.Sequence);
                lvi.UseItemStyleForSubItems = false;            
                //2nd
                lvi.SubItems.Add(sourceItem.IP);           
                //3rd
                lvi.SubItems.Add(sourceItem.Name);       
                //4th
                lvi.SubItems.Add(sourceItem.ConnectionStatus);
                lvi.SubItems[3].BackColor = sourceItem.StatusColor;
                
                DBView.Items.Add(lvi);
            }

            DBView.EndUpdate();
            DBView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            DBView.GridLines = Enabled;
        }

        private void ResultShowAppServiceList(List<AppServiceSource> appServiceSource)
        {
            AppServiceView.BeginUpdate();
            AppServiceView.Items.Clear();

            foreach (var sourceitem in appServiceSource)
            {             
                //1st
                var lvi = new ListViewItem(sourceitem.Sequence);
                lvi.UseItemStyleForSubItems = false;
                //2nd
                lvi.SubItems.Add(sourceitem.Name);
                //3rd
                lvi.SubItems.Add(sourceitem.Status);
                lvi.SubItems[2].BackColor = sourceitem.StatusColor;
                //4rd
                lvi.SubItems.Add(sourceitem.PID);
                //5th
                lvi.SubItems.Add(sourceitem.MemoryUsed);
                //6th
                lvi.SubItems.Add(sourceitem.StartTime);
                //7th
                lvi.SubItems.Add(sourceitem.ProcessTotalTime);
                //8th
                lvi.SubItems.Add(sourceitem.MemoryLimit);
                //9th
                lvi.SubItems.Add(sourceitem.FilePath);
                //10th
                lvi.SubItems.Add(sourceitem.ShowShutDownTime);
                AppServiceView.Items.Add(lvi);
                }
            
            AppServiceView.EndUpdate();
            AppServiceView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            AppServiceView.GridLines = Enabled;
        }
        private void Initial_ListLoading()
        {
            XmlLoader xmlLoader = new XmlLoader();
            xmlLoader.GetAllListFromXML(out _jsonUrlList, out _contactlList,out _webSource,out _dbSource,out _appServiceSource, out _diskSource);
            if (_webSource.Count > 0)
            {
                _isLoadingWeb = true;
            }

            if (_dbSource.Count > 0)
            {
                _isLoadingDb = true;
            }

            if (_appServiceSource.Count > 0)
            {
                _isLoadingAppService = true;
            }

            if (_diskSource.Count > 0)
            {
                _isLoadingDisk = true;
            }
        }

        private void OptionsValueSettingCheck()
        {
            _optionsAttribute = _optionsAttributeTemp;
        }

        private void OptionsValueTempInital()
        {
            //ServicesSetting
            _optionsAttributeTemp.serviceThreadSleep = Textbox2Int(Automs);
            _optionsAttributeTemp.chkAutoRestart_Memory_flag = chkAutoRestart_Memory.Checked;
            _optionsAttributeTemp.chkAutoShutdown_flag = chkAutoShutdown.Checked;
            _optionsAttributeTemp.chkAutoRestart_flag = chkAutoRestart.Checked;

            //DBConnectionsSetting
            _optionsAttributeTemp.DBTheadSleep = Textbox2Int(Automs_DB);
            _optionsAttributeTemp.DBDelayTime = Delayms_DB.Text;

            //WebConnectionsSetting
            _optionsAttributeTemp.WebTheadSleep = Textbox2Int(Automs_Web);
            _optionsAttributeTemp.WebDelayTime = Textbox2Int(Delayms_Web);

            //SendJSONSetting
            _optionsAttributeTemp.JsonTheadSleep = Textbox2Int(Automs_JSON);

            //DiskConnectionsSetting
            _optionsAttributeTemp.DiskTheadSleep = Textbox2Int(Automs_Disk);
        }

        private int Textbox2Int(TextBox apple)
        {
            int res;
            if (Int32.TryParse(apple.Text, out res))
            {
                return res;
            }
            else
            {
                return 0;
            }
        }

        private void btn_Reset_Click_1(object sender, EventArgs e)
        {
            OptionsValueTempInital();
            OptionsValueSettingCheck();
            SaveStatus.Text = "Status : Save Complete!" + DateTime.Now;
        }

        private void Form_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void Start_btn_Click_1(object sender, EventArgs e)
        {
            //Initial_ListLoading();
            Start_btn.Enabled = false;
            Stop_btn.Enabled = true;
            _isLoadingWeb = true;
            _isLoadingDb = true;
            _isLoadingAppService = true;
            _isLoadingDisk = true;

        }

        private void Stop_btn_Click_1(object sender, EventArgs e)
        {
            Start_btn.Enabled = true;
            Stop_btn.Enabled = false;
            _isLoadingWeb = false;
            _isLoadingDb = false;
            _isLoadingAppService = false;
            _isLoadingDisk = false;
        }
    }
}