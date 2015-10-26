using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuix.Response
{
    class NewCase
    {
        public string caseId { get; set; }
        public string caseName { get; set; }
        public string casePath { get; set; }
        public string casePathParent { get; set; }
        public string caseDescription { get; set; }
        public string caseInvestigationTimeZone { get; set; }
        public string caseInvestigator { get; set; }
        public string compound { get; set; }
        public string hasExclusions { get; set; }
        public string hasNuixSystemTags { get; set; }
        public string hasProductionSets { get; set; }
        public string hasCalculateAuditSize { get; set; }

        public string ToString()
        {
            return "[caseId=" + caseId 
                 + ",caseName=" + caseName 
                 + ",casePath=" + casePath
                 + ",casePathParent=" + casePathParent
                 + ",caseDescription=" + caseDescription
                 + ",caseInvestigationTimeZone=" + caseInvestigationTimeZone
                 + ",caseInvestigator=" + caseInvestigator
                 + ",compound=" + compound
                 + ",hasExclusions=" + hasExclusions
                 + ",hasNuixSystemTags=" + hasNuixSystemTags
                 + ",hasProductionSets=" + hasProductionSets
                 + ",hasCalculateAuditSize=" + hasCalculateAuditSize 
                 + "]";
        }
    }
}
