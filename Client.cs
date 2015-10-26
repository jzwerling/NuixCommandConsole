using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Nuix
{
    class Client
    {
        private string contentType = "application/json";
        private string url;
        private string port;

        public Client(string url, string port) 
        {
            this.url = url;
            this.port = port;
        }

        public Response.Authentication Authenticate(string username, string password, string licenceDescription)
        {
            string service = "http://" + url + ":" + port + "/nuix-restful-service/svc/v1/authenticatedUsers/login";
            string method = "PUT";
            //string data = "{\"password\": \"" + password + "\",\"username\": \"" + username + "\",\"licenceDescription\": \"" + licenceDescription + "\"}";
            Request.Authentication authentication = new Request.Authentication();
            authentication.username = username;
            authentication.password = password;
            authentication.licenceDescription = licenceDescription;
            string data = JsonConvert.SerializeObject(authentication);
            return JsonConvert.DeserializeObject<Response.Authentication>(Call(service, method, data, false));
        }

        public Response.NewCase CreateCase(string name, string description, string location, bool compound, string investigator, string token)
        {
            string service = "http://" + url + ":" + port + "/nuix-restful-service/svc/v1/cases?token=" + token;
            string method = "POST";
            Request.NewCase newCase = new Request.NewCase();
            newCase.name = name;
            newCase.description = description;
            newCase.location = location;
            newCase.compound = compound;
            newCase.investigator = investigator;
            string data = JsonConvert.SerializeObject(newCase);
            return JsonConvert.DeserializeObject<Response.NewCase>(Call(service, method, data, true));
        }

        public Response.Ingest Ingestion(bool addBccToEmailDigests, bool addCommunicationDateToEmailDigests, string analysisLanguage, bool calculateAuditedSize, bool carveFileSystemUnallocatedSpace, bool carveUnidentifiedData, bool createThumbnails, string [] digests, bool enableExactQueries, bool extractFromSlackSpace, bool extractNamedEntities, bool extractShingles, bool hideEmbeddedImmaterialData, bool identifyPhysicalFiles, int maxDigestSize, int maxStoredBinarySize, bool processFamilyFields, bool processForensicImages, bool processLooseFileContents, bool processText, bool processTextSummaries, bool recoverDeletedFiles, string reportProcessingStatus, bool reuseEvidenceStores, bool skinToneAnalysis, bool stemming, bool stopWords, bool storeBinary, Request.CustomMetadata customMetadata, string encoding, string path, string type, string custodian,string evidenceContainer, bool embedBroker, int workerCount, int workerMemory, bool evidenceRepository, string caseId, string token)
        {
            string service = "http://" + url + ":" + port + "/nuix-restful-service/svc/v1/cases/" + caseId + "/data?token=" + token;
            string method = "POST";

            Request.ParallelProcessingSettings parallelProcessingSettings = new Request.ParallelProcessingSettings();
            parallelProcessingSettings.embedBroker = embedBroker;
            parallelProcessingSettings.workerCount = workerCount;
            parallelProcessingSettings.workerMemory = workerMemory;

            Request.ProcessorSettings processorSettings = new Request.ProcessorSettings();
            processorSettings.addBccToEmailDigests = addBccToEmailDigests;
            processorSettings.addCommunicationDateToEmailDigests = addCommunicationDateToEmailDigests;
            processorSettings.analysisLanguage = analysisLanguage;
            processorSettings.calculateAuditedSize = calculateAuditedSize;
            processorSettings.carveFileSystemUnallocatedSpace = carveFileSystemUnallocatedSpace;
            processorSettings.carveUnidentifiedData = carveUnidentifiedData;
            processorSettings.createThumbnails = createThumbnails;
            processorSettings.digests = digests;
            processorSettings.enableExactQueries = enableExactQueries;
            processorSettings.extractFromSlackSpace = extractFromSlackSpace;
            processorSettings.extractNamedEntities = extractNamedEntities;
            processorSettings.extractShingles = extractShingles;
            processorSettings.hideEmbeddedImmaterialData = hideEmbeddedImmaterialData;
            processorSettings.identifyPhysicalFiles = identifyPhysicalFiles;
            processorSettings.maxDigestSize = maxDigestSize;
            processorSettings.maxStoredBinarySize = maxStoredBinarySize;
            processorSettings.processFamilyFields = processFamilyFields;
            processorSettings.processForensicImages = processForensicImages;
            processorSettings.processLooseFileContents = processLooseFileContents;
            processorSettings.processText = processText;
            processorSettings.processTextSummaries = processTextSummaries;
            processorSettings.recoverDeletedFiles = recoverDeletedFiles;
            processorSettings.reportProcessingStatus = reportProcessingStatus;
            processorSettings.reuseEvidenceStores = reuseEvidenceStores;
            processorSettings.skinToneAnalysis = skinToneAnalysis;
            processorSettings.stemming = stemming;
            processorSettings.stopWords = stopWords;
            processorSettings.storeBinary = storeBinary;

            Request.IngestionTarget ingestionTarget = new Request.IngestionTarget();
            ingestionTarget.custodian = custodian;
            ingestionTarget.customMetadata = customMetadata;
            ingestionTarget.encoding = encoding;
            ingestionTarget.evidenceContainer = evidenceContainer;
            ingestionTarget.path = path;
            ingestionTarget.type = type;

            Request.Ingest ingest = new Request.Ingest();
            ingest.ingestionTargets = new Request.IngestionTarget [] { ingestionTarget };
            ingest.parallelProcessingSettings = parallelProcessingSettings;
            ingest.processorSettings = processorSettings;
            ingest.evidenceRepository = evidenceRepository;
            string data = JsonConvert.SerializeObject(ingest);
            return JsonConvert.DeserializeObject<Response.Ingest>(Call(service, method, data, true));
        }

        public Response.Progress Monitor(string function, string token)
        {
            string service = "http://" + url + ":" + port + "/nuix-restful-service/svc/v1/asyncFunctions/" + function + "?token=" + token;
            string method = "GET";
            string response = Call(service, method, null, true);
            try
            {
                return JsonConvert.DeserializeObject<Response.Progress>(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed attempting to serialize the following JSON:");
                Console.WriteLine(response);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            Response.Progress fail = new Response.Progress();
            fail.progress = -1;
            fail.done = false;
            fail.total = -1;
            return fail;
        }

        public string [] GetPropertyValues(string propertyName, string query, bool distinct, string caseId, string token)
        {
            string service = "http://" + url + ":" + port + "/nuix-restful-service/svc/v1/cases/" + caseId + "/itemProperties/" + propertyName + "?token=" + token;
            string method = "POST";
            Request.Properties properties = new Request.Properties();
            properties.distinct = distinct;
            properties.query = query;
            string data = JsonConvert.SerializeObject(properties);
            string response = Call(service, method, data, true);
            try
            {
                return JsonConvert.DeserializeObject<string[]>(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed attempting to serialize the following JSON:");
                Console.WriteLine(response); 
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return new string [] { ex.Message, ex.StackTrace};
            }
        }

        public Response.Export Export(string path, string [] queries, string exportType, string [] productTypes, string mailFormat, string naming, string caseId, string token)
        {
            string service = "http://" + url + ":" + port + "/nuix-restful-service/svc/v1/cases/" + caseId + "/export?token=" + token;
            string method = "PUT";
            Request.Export export = new Request.Export();
            export.path = path;
            export.queries = queries;
            export.exportType = exportType;
            export.productTypes = productTypes;
            Request.ExportOptions exportOptions = new Request.ExportOptions();
            Request.ProductOptions productOptions = new Request.ProductOptions();
            productOptions.mailFormat = mailFormat;
            productOptions.naming = naming;
            exportOptions.productOptions = productOptions;
            export.exportOptions = exportOptions;
            string data = JsonConvert.SerializeObject(export);
            Console.WriteLine("Invoking Export Endpoint (" + method + ") with the following payload: " + service);
            Console.WriteLine(data);
            string response = Call(service, method, data, true);
            return JsonConvert.DeserializeObject<Response.Export>(response);
        }

        private string Call(string service, string method, string data, bool echo)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(service);
                request.Method = method;
                request.ContentType = contentType;
                if (echo)
                {
                    Console.WriteLine(method + ">" + service);
                    Console.WriteLine(data);
                }
                if (data != null)
                {
                    StreamWriter writer = null;
                    try
                    {
                        writer = new StreamWriter(request.GetRequestStream(), System.Text.Encoding.ASCII);
                        writer.Write(data);
                    }
                    finally
                    {
                        if (writer != null)
                            writer.Close();
                    }
                }
                
                StreamReader reader = null;
                try
                {
                    WebResponse response = request.GetResponse();
                    reader = new StreamReader(response.GetResponseStream());
                    string ret = reader.ReadToEnd();
                    if (echo)
                    {
                        Console.WriteLine(ret);
                    }
                    return ret;
                }
                finally
                {
                    if (reader != null)
                        reader.Close();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            return null;
        }
    }
}
