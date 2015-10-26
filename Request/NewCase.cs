using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuix.Request
{
    class NewCase
    {
        public string name { get; set; }
        public string description { get; set; }
        public string location { get; set; }
        public bool compound { get; set; }
        public string investigator { get; set; }
    }
}
