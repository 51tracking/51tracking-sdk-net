using Newtonsoft.Json;

namespace Tracking51API.Model.AirWaybills;

public class TrackInfo
{
    [JsonProperty("plan_date")]
    public string planDate { get; set; }

    [JsonProperty("actual_date")]
    public string actualDate { get; set; }

    [JsonProperty("event")]
    public string events { get; set; }

    [JsonProperty("station")]
    public string station { get; set; }

    [JsonProperty("flight_number")]
    public string flightNumber { get; set; }

    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("piece")]
    public string piece { get; set; }

    [JsonProperty("weight")]
    public string weight { get; set; }

    [JsonProperty("checkpoint_status")]
    public string checkpointStatus { get; set; }

    [JsonProperty("checkpoint_substatus")]
    public string checkpointSubstatus { get; set; }
}