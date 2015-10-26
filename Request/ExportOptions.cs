using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuix.Request
{
    class ExportOptions
    {
        public Request.ProductOptions productOptions { get; set; }
        public Request.LoadFileOptions loadFileOptions { get; set; }
        public Request.ImagingOptions imagingOptions { get; set; }
        public Request.NumberingOptions numberingOptions { get; set; }
        public Request.StampingOptions stampingOptions { get; set; }
        public Request.TraversalOptions traversalOptions { get; set; }
    }
}
