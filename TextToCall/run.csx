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

    public string CallerNumber { get; set; }

    public string CalleeNumber { get; set; }

    public string UseTemplate { get; set; }
    
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
    "Text": "Greeting1",
    "VoiceType" : "female",
    "Locale" : "en-US",
    "BlobContainerName" : "speech",
    "BlobName" : "Greeting1.wav",
    "CallerNumber" : "+12061112222",
    "CalleeNumber" : "+14253334444",
    "UseTemplate" : "true"
}

{
    "Text": "Greeting2",
    "VoiceType" : "female",
    "Locale" : "en-US",
    "BlobContainerName" : "speech",
    "BlobName" : "Greeting2.wav",
    "CallerNumber" : "+12061112222",
    "CalleeNumber" : "+14253334444",
    "UseTemplate" : "true"
}

{
    "Text": "I am very happy to be speaking in a demo for Azure Functions at the 2017 Pro-Dev Hackathon.",
    "VoiceType" : "female",
    "Locale" : "en-US",
    "BlobContainerName" : "speech",
    "BlobName" : "byob.wav",
    "CallerNumber" : "+12061112222",
    "CalleeNumber" : "+14253334444",
    "UseTemplate" : "false"
}

Sample log entry:
Results:http://<mystorageaccount>.blob.core.windows.net/speech/happygreeting.wav
*/