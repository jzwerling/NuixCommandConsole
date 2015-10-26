using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuix.Request
{
    class ProcessorSettings
    {
        public bool addCommunicationDateToEmailDigests { get; set; }
        public bool carveFileSystemUnallocatedSpace { get; set; }
        public int maxDigestSize { get; set; }
        public bool stopWords { get; set; }
        public bool processText { get; set; }
        public bool stemming { get; set; }
        public bool storeBinary { get; set; }
        public string [] digests { get; set; }
        public bool addBccToEmailDigests { get; set; }
        public bool enableExactQueries { get; set; }
        public bool reuseEvidenceStores { get; set; }
        public bool extractFromSlackSpace { get; set; }
        public bool calculateAuditedSize { get; set; }
        public bool extractShingles { get; set; }
        public string analysisLanguage { get; set; }
        public bool processTextSummaries { get; set; }
        public bool carveUnidentifiedData { get; set; }
        public bool skinToneAnalysis { get; set; }
        public string reportProcessingStatus { get; set; }
        public int maxStoredBinarySize { get; set; }
        public bool extractNamedEntities { get; set; }
        public bool identifyPhysicalFiles { get; set; }
        public bool processFamilyFields { get; set; }
        public bool createThumbnails { get; set; }
        public bool processLooseFileContents { get; set; }
        public bool hideEmbeddedImmaterialData { get; set; }
        public bool processForensicImages { get; set; }
        public bool recoverDeletedFiles { get; set; }
    }
}
