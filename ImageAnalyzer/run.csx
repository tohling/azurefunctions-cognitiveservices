#r "Newtonsoft.Json"

using System.Net;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class ImageInfo
{   
    public string ImageUrl { get; set; }
     
    public string VisualFeatures { get; set; }
}

public static HttpResponseMessage Run(HttpRequestMessage req, ImageInfo info, JObject results, TraceWriter log)
{
    log.Info("Results:" + results);
 
    var list = results["Description"]["Captions"];
    string outstr = null;
    foreach (var item in list)
    {
        outstr += item["Text"].ToString() + ",";
    }
 
    return req.CreateResponse(HttpStatusCode.OK, outstr);
}

/*
Method: POST
Request body:
{
 "ImageUrl" : "http://<mystorageaccount>.blob.core.windows.net/test/happy.jpg",
 "VisualFeatures" : "Adult,Categories,Color,Description,Faces,ImageType,Tags"
}
*/