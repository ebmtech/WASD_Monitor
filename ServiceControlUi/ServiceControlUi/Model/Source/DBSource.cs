using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceControlUi.Model
{
    public class DBSource
    {
        public string Sequence { get; set; }
        public string IP { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConnectionStatus { get; set; }
        public Color StatusColor { get; set; }

    }
}
