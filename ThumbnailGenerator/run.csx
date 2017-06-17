#r "Newtonsoft.Json"

using System.Net;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class ImageInfo
{   
    public string ImageUrl { get; set; }

    public string Width { get; set; }

    public string Height { get; set; }

    public string SmartCropping { get; set; }

    public string BlobContainerName { get; set; }

    public string BlobName { get; set; }
}

public static HttpResponseMessage Run(HttpRequestMessage req, ImageInfo info, string results, TraceWriter log)
{
    log.Info("Results:" + results);

    return req.CreateResponse(HttpStatusCode.OK, results);
}

/*
Method : POST
Request body:
{
    "ImageUrl": "http://<mystorageccount>.blob.core.windows.net/test/satya.jpg",
    "Width" : "300",
    "Height" : "500",
    "SmartCropping" : "true",
    "BlobContainerName" : "thumbnail",
    "BlobName" : "satya_3by5.jpg"
}

Sample log entry:
Results:https://<mystorageaccount>.blob.core.windows.net/thumbnail/satya_3by5.jpg
*/