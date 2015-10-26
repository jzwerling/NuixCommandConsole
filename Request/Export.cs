using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuix.Request
{
    class Export
    {
        public string path { get; set; }
        public string exportType { get; set; }
        public ExportOptions exportOptions { get; set; }
        public string [] productTypes { get; set; }
        public string [] loadFileTypes { get; set; }
        public string [] productionSets { get; set; }
        public string [] queries { get; set; }
    }
}
