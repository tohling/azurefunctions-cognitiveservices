#r "Newtonsoft.Json"

using System.Net;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class ImageInfo
{   
    public string ImageUrl { get; set; }
     
    public string ModelName { get; set; }
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
 "ImageUrl" : "http://<mystorageaccount>.blob.core.windows.net/test/satya.jpg",
 "ModelName" : "celebrities"
}

Sample log entry:
Results:{
  "RequestId": "e200ba90-3421-4947-aeab-72554506c77c",
  "Metadata": {
    "Height": 194,
    "Width": 259,
    "Format": "Jpeg"
  },
  "Result": {
    "celebrities": [
      {
        "name": "Satya Nadella",
        "faceRectangle": {
          "left": 76,
          "top": 24,
          "width": 57,
          "height": 57
        },
        "confidence": 0.9999974
      }
    ]
  }
}
*/