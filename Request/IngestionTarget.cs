using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuix.Request
{
    class IngestionTarget
    {
        public string timeZone { get; set; }
        public string encoding { get; set; }
        public string type { get; set; }
        public string path { get; set; }
        public string evidenceContainer { get; set; }
        public CustomMetadata customMetadata { get; set; }
        public string custodian { get; set; }
    }
}
