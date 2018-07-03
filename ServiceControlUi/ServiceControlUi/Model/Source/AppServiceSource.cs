using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceControlUi.Model
{
     public class AppServiceSource
     {
        public string Sequence { get; set; }
        public string Name { get; set; }
        public string MemoryLimit { get; set; }
        public string Type { get; set; }
        public string FilePath { get; set; }
        public Color StatusColor { get; set; }
        public string Status { get; set; }
        public string PID { get; set; }
        public string MemoryUsed { get; set; }
        public string StartTime { get; set; }
        public string ProcessTotalTime { get; set; }
        public DateTime ShutDownTime { get; set; }
        public string ShowShutDownTime { get; set; }
         public string RestartDay { get; set; }
    }
}
