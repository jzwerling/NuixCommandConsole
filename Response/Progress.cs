using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuix.Response
{
    class Progress
    {
        public bool done { get; set; }
        public long progress { get; set; }
        public long total { get; set; }
    }
}
