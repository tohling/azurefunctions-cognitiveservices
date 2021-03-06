#r "Newtonsoft.Json"

using System.Net;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class AudioInfo
{   
    public string AudioUrl { get; set; }
}

public static HttpResponseMessage Run(HttpRequestMessage req, AudioInfo info, string results, TraceWriter log)
{
    log.Info("Result: " + results);

    return req.CreateResponse(HttpStatusCode.OK, results);
}

/*
Method: POST
Request body:
{
 "AudioUrl" : "http://<mystorageaccount>.blob.core.windows.net/test/amy.wav"
}

{
 "AudioUrl" : "http://<mystorageaccount>.blob.core.windows.net/test/whatstheweatherlike.wav"
}

Sample log entry:
Result: ********* Final n-BEST Results *********
[0] Text="What's the weather like?"
*/