using Newtonsoft.Json;

namespace Tracking51API.Model.Trackings;

public class TrackInfo
{
    [JsonProperty("checkpoint_date")]
    public string checkpointDate { get; set; }

    [JsonProperty("checkpoint_delivery_status")]
    public string checkpointDeliveryStatus { get; set; }

    [JsonProperty("checkpoint_delivery_substatus")]
    public string checkpointDeliverySubstatus { get; set; }

    [JsonProperty("tracking_detail")]
    public string trackingDetail { get; set; }

    [JsonProperty("location")]
    public string location { get; set; }

    [JsonProperty("country_iso2")]
    public string countryIso2 { get; set; }

    [JsonProperty("state")]
    public string state { get; set; }

    [JsonProperty("city")]
    public string city { get; set; }

    [JsonProperty("zip")]
    public string zip { get; set; }

    [JsonProperty("raw_status")]
    public string rawStatus { get; set; }

}