using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuix.Request
{
    class Ingest
    {
        public IngestionTarget [] ingestionTargets { get; set; }
        public bool evidenceRepository { get; set; }
        public ParallelProcessingSettings parallelProcessingSettings { get; set; }
        public ProcessorSettings processorSettings { get; set; }
    }
}
