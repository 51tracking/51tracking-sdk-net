using Newtonsoft.Json;

namespace Tracking51API.Model.Trackings;

public class BatchResults
{
    [JsonProperty("success")]
    public List<BatchItem> success { get; set; }

    [JsonProperty("error")]
    public List<BatchItem> error { get; set; }

}