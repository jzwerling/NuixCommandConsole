using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuix.Request
{
    class LoadFileOptions
    {
        public string metadataProfile { get; set; }
        public string encoding { get; set; }
        public string lineSeparator { get; set; }
        public string pathSeparator { get; set; }
        public string loadFileEntryLimit { get; set; }
        public string laodFileByteLimit { get; set; }
        public string version { get; set; }
        public string inheritDates { get; set; }
        public string removeCommas { get; set; }
        public string directParent { get; set; }
        public string useDocumentId { get; set; }
        public string useNativePageCount { get; set; }
        public string mappingLocation { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string workspaceId { get; set; }
        public string folderId { get; set; }
        public string accessibleDirectory { get; set; }
        public string kweLocation { get; set; }
        public string nrmMappingLocation { get; set; }
        public string nrmSettingsLocation { get; set; }
        public string url { get; set; }
        public string certValue { get; set; }
        public string endpointType { get; set; }
    }
}
