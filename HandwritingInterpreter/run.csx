#r "Newtonsoft.Json"

using System.Net;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class ImageInfo
{   
    public string ImageUrl { get; set; }
}

public static HttpResponseMessage Run(HttpRequestMessage req, ImageInfo info, string results, TraceWriter log)
{
    log.Info("Results:" + results);

    return req.CreateResponse(HttpStatusCode.OK, results);
}

/*
Method: POST
Request body:
{
 "ImageUrl" : "http://<mystorageaccount>.blob.core.windows.net/test/letter3.jpg"
}
*/