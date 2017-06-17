#r "Newtonsoft.Json"

using System.Net;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class ImageInfo
{   
    public string ImageUrl { get; set; }
     
    public string MaxCandidates { get; set; }
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
 "MaxCandidates" : "3"
}

Sample log entry:
 Results:{
  "RequestId": "1175e47c-e970-4df0-bfc8-7faa048b1bb0",
  "Metadata": {
    "Height": 194,
    "Width": 259,
    "Format": "Jpeg"
  },
  "ImageType": null,
  "Color": null,
  "Adult": null,
  "Categories": null,
  "Faces": null,
  "Tags": null,
  "Description": {
    "Tags": [
      "person",
      "man",
      "suit",
      "clothing",
      "standing",
      "holding",
      "front",
      "wearing",
      "looking",
      "hand",
      "giving",
      "posing",
      "dressed",
      "sign",
      "street",
      "white",
      "people"
    ],
    "Captions": [
      {
        "Text": "Satya Nadella wearing a suit and tie",
        "Confidence": 0.98516277474104608
      },
      {
        "Text": "Satya Nadella in a suit and tie",
        "Confidence": 0.98416277474104608
      },
      {
        "Text": "Satya Nadella wearing a suit",
        "Confidence": 0.97795070471468526
      }
    ]
  }
}
*/