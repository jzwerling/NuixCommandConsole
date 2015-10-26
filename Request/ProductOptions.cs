using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuix.Request
{
    class ProductOptions
    {
        public string naming { get; set; }
        public string path { get; set; }
        public string suffix { get; set; }
        public string mailFormat { get; set; }
        public bool includeAtachments { get; set; }
        public bool regenerateStored { get; set; }
        public int wrapLines { get; set; }
        public bool perPage { get; set; }
        public string lineSeparator { get; set; }
        public string encoding { get; set; }
        public bool multiPageTiff { get; set; }
        public int tiffDpi { get; set; }
        public string[] tiffFormat { get; set; }
    }
}
