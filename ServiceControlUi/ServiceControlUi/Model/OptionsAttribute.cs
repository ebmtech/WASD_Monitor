using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceControlUi.model
{
   public class OptionsAttribute
    {
        //Services Thread Sleep
        public int serviceThreadSleep ;
        //DBConnections Thread Sleep
        public int DBTheadSleep ;
        //WebConnections Thread Sleep
        public int WebTheadSleep ;
        //JsonConnections Thread Sleep
        public int JsonTheadSleep;
        //DiskConnections Thread Sleep
        public int DiskTheadSleep;

        //DBconnection Delay Time
        public string DBDelayTime;
        //Webconnection Delay Time
        public int WebDelayTime ;

        //chkAutoRestart
        public bool chkAutoRestart_flag = false;
        //chkAutoRestart_Memory
        public bool chkAutoRestart_Memory_flag = false;
        //chkAutoRestart_Memory
        public bool chkAutoShutdown_flag = false;

    }
}
