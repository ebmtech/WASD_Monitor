using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceControlUi.model
{
   public class ProcessAttribute
    {
        
        public int PID { get; set; }
        public double MemoryUsed { get; set; }
        public DateTime StartTime { get; set; }
        public TimeSpan ProcessTotalTime { get; set; }

    }
}
