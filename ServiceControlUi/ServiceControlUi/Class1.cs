using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceControlUi
{
    class Class1
    {
        private dgLog _log;

        public delegate void dgLog(string msg);

        public Class1(dgLog callbackLog)
        {
            _log = callbackLog;
        }

       public void processssssss()
        {
            _log?.Invoke("sdfsfsdfsdfsdf");
        }
    }
}
