using Newtonsoft.Json;

namespace Tracking51API.Model.AirWaybills;

public class AirlineInfo
{
    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("url")]
    public string url { get; set; }

    [JsonProperty("track_url")]
    public string trackUrl { get; set; }

    [JsonProperty("trackpage_url")]
    public string trackpageUrl { get; set; }

}