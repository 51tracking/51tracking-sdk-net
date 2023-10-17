using Newtonsoft.Json;

namespace Tracking51API.Model.Trackings;

public class GetResults
{
    [JsonProperty("success")]
    public List<Trackings> success { get; set; }

    [JsonProperty("rejected")]
    public List<RejectedItem> rejected { get; set; }

}