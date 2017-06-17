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

Sample log entry:
Results:{
  "RequestId": "9361dace-5a9f-43b3-adc0-954d2d328a78",
  "Metadata": {
    "Height": 148,
    "Width": 340,
    "Format": "Jpeg"
  },
  "ImageType": {
    "ClipArtType": 0,
    "LineDrawingType": 0
  },
  "Color": {
    "AccentColor": "534B80",
    "DominantColorForeground": "Brown",
    "DominantColorBackground": "White",
    "DominantColors": [
      "White",
      "Black",
      "Brown"
    ],
    "IsBWImg": false
  },
  "Adult": {
    "IsAdultContent": false,
    "IsRacyContent": false,
    "AdultScore": 0.037166990339756012,
    "RacyScore": 0.026894155889749527
  },
  "Categories": [
    {
      "Detail": null,
      "Name": "people_young",
      "Score": 0.5859375
    }
  ],
  "Faces": [
    {
      "Age": 8,
      "Gender": "Female",
      "FaceRectangle": {
        "Width": 110,
        "Height": 110,
        "Left": 65,
        "Top": 13
      }
    },
    {
      "Age": 13,
      "Gender": "Female",
      "FaceRectangle": {
        "Width": 108,
        "Height": 108,
        "Left": 187,
        "Top": 27
      }
    }
  ],
  "Tags": [
    {
      "Name": "smiling",
      "Confidence": 0.96207082271575928,
      "Hint": null
    },
    {
      "Name": "person",
      "Confidence": 0.92840635776519775,
      "Hint": null
    },
    {
      "Name": "posing",
      "Confidence": 0.80987560749053955,
      "Hint": null
    },
    {
      "Name": "close",
      "Confidence": 0.28250253200531006,
      "Hint": null
    }
  ],
  "Description": {
    "Tags": [
      "smiling",
      "person",
      "posing",
      "young",
      "girl",
      "little",
      "child",
      "camera",
      "close",
      "boy",
      "food",
      "white",
      "woman",
      "standing",
      "holding",
      "man",
      "blue"
    ],
    "Captions": [
      {
        "Text": "a close up of a child smiling at the camera",
        "Confidence": 0.81039390780671627
      }
    ]
  }
}
*/