
using System.Drawing;

namespace ServiceControlUi.Model.Source
{
   public class DiskSource
    {
        public string Name { get; set; }
        public string Format { get; set; }
        public string TotalSize { get; set; }
        public string AvailableSpace { get; set; }
        public string Usage { get; set; }
        public Color StatusColor { get; set; }
        public int limitPercentage { get; set; }
    }
}
