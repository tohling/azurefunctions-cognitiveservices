#r "Newtonsoft.Json"

using System.Net;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class ImageInfo
{
    public string ImageUrl { get; set; }
}

public static HttpResponseMessage Run(HttpRequestMessage req, ImageInfo info, JObject results, TraceWriter log)
{
  log.Info("Results:" + results);

  return req.CreateResponse(HttpStatusCode.OK, results);
}

/*
Method: POST
Request body:
{
 "ImageUrl" : "http://<mystorageaccount>.blob.core.windows.net/test/photo.png"
}

Results:{
  "Language": "en",
  "TextAngle": -1.2000000000000337,
  "Orientation": "Up",
  "Regions": [
    {
      "BoundingBox": "11,2,123,168",
      "Lines": [
        {
          "BoundingBox": "77,2,29,17",
          "Words": [
            {
              "BoundingBox": "77,2,29,17",
              "Text": "DO"
            }
          ]
        },
        {
          "BoundingBox": "30,29,104,18",
          "Words": [
            {
              "BoundingBox": "30,29,62,18",
              "Text": "WATCH"
            },
            {
              "BoundingBox": "98,31,36,16",
              "Text": "THE"
            }
          ]
        },
        {
          "BoundingBox": "63,58,70,19",
          "Words": [
            {
              "BoundingBox": "63,58,70,19",
              "Text": "CLOCK;"
            }
          ]
        },
        {
          "BoundingBox": "43,85,90,18",
          "Words": [
            {
              "BoundingBox": "43,85,29,17",
              "Text": "DO"
            },
            {
              "BoundingBox": "79,86,54,17",
              "Text": "WHAT"
            }
          ]
        },
        {
          "BoundingBox": "55,114,77,18",
          "Words": [
            {
              "BoundingBox": "55,114,16,16",
              "Text": "IT"
            },
            {
              "BoundingBox": "77,115,55,17",
              "Text": "DOES."
            }
          ]
        },
        {
          "BoundingBox": "11,142,120,18",
          "Words": [
            {
              "BoundingBox": "11,142,44,16",
              "Text": "KEEP"
            },
            {
              "BoundingBox": "61,142,70,18",
              "Text": "GOING."
            }
          ]
        },
        {
          "BoundingBox": "68,161,17,9",
          "Words": [
            {
              "BoundingBox": "68,161,17,9",
              "Text": "SAM"
            }
          ]
        }
      ]
    }
  ]
}
*/