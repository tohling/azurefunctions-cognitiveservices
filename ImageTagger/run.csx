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
 "ImageUrl" : "http://<mystorageaccount>.blob.core.windows.net/test/meeting.jpg"
}

Sample log entry:
Results:{
  "RequestId": "a1cb2627-4dbb-48bd-97ad-a51f9410d869",
  "Metadata": {
    "Height": 168,
    "Width": 299,
    "Format": "Jpeg"
  },
  "ImageType": null,
  "Color": null,
  "Adult": null,
  "Categories": null,
  "Faces": null,
  "Tags": [
    {
      "Name": "indoor",
      "Confidence": 0.94062989950180054,
      "Hint": null
    },
    {
      "Name": "person",
      "Confidence": 0.92286473512649536,
      "Hint": null
    },
    {
      "Name": "business",
      "Confidence": 0.87129694223403931,
      "Hint": null
    },
    {
      "Name": "office",
      "Confidence": 0.76969295740127563,
      "Hint": null
    },
    {
      "Name": "group",
      "Confidence": 0.63064700365066528,
      "Hint": null
    },
    {
      "Name": "table",
      "Confidence": 0.50402849912643433,
      "Hint": null
    },
    {
      "Name": "conference room",
      "Confidence": 0.26147258281707764,
      "Hint": null
    },
    {
      "Name": "dining table",
      "Confidence": 0.063473597168922424,
      "Hint": null
    }
  ],
  "Description": null
}
*/