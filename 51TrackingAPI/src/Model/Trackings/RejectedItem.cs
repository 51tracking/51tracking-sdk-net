using Newtonsoft.Json;

namespace Tracking51API.Model.Trackings;

public class RejectedItem
{

    [JsonProperty("tracking_number")]
    public string trackingNumber { get; set; }

    [JsonProperty("rejectedCode")]
    public int? rejectedCode { get; set; }

    [JsonProperty("rejectedMessage")]
    public string rejectedMessage { get; set; }

}