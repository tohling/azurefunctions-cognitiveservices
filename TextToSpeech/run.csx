#r "Newtonsoft.Json"

using System.Net;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class TextInfo
{   
    public string Text { get; set; }
     
    public string VoiceType { get; set; }

    public string Locale { get; set; }

    public string BlobContainerName { get; set; }

    public string BlobName { get; set; }
}

public static HttpResponseMessage Run(HttpRequestMessage req, TextInfo info, string results, TraceWriter log)
{
    log.Info("Results:" + results);
    
    return req.CreateResponse(HttpStatusCode.OK, results);
}

/*
Method : POST
Request body:
{
    "Text": "Hello, welcome to Azure Functions!",
    "VoiceType" : "male",
    "Locale" : "en-US",
    "BlobContainerName" : "speech",
    "BlobName" : "greeting-male.wav"
}
*/