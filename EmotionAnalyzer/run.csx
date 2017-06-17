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
 "ImageUrl" : "http://<mystorageaccount>.blob.core.windows.net/test/angry.jpg"
}

Sample log entry:
Results:[
  {
    "FaceRectangle": {
      "Left": 105,
      "Top": 50,
      "Width": 62,
      "Height": 62
    },
    "Scores": {
      "Anger": 0.9683205,
      "Contempt": 7.700097E-08,
      "Disgust": 0.000118727796,
      "Fear": 0.008646037,
      "Happiness": 1.392538E-06,
      "Neutral": 2.625743E-05,
      "Sadness": 5.195878E-07,
      "Surprise": 0.022886496
    }
  }
]
*/