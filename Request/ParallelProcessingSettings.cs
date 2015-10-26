using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuix.Request
{
    class ParallelProcessingSettings
    {
        public bool embedBroker { get; set; }
        public int workerMemory { get; set; }
        public int workerCount { get; set; }
    }
}
