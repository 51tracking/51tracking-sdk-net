using Newtonsoft.Json;

namespace Tracking51API.Model.Trackings;

public class DestinationInfo
{
    [JsonProperty("courier_code")]
    public string courierCode { get; set; }

    [JsonProperty("courier_phone")]
    public string courierPhone { get; set; }

    [JsonProperty("weblink")]
    public string weblink { get; set; }

    [JsonProperty("reference_number")]
    public string referenceNumber { get; set; }

    [JsonProperty("milestone_date")]
    public MilestoneDate milestoneDate { get; set; }

    [JsonProperty("pickup_date")]
    public string pickupDate { get; set; }

    [JsonProperty("departed_airport_date")]
    public string departedAirportDate { get; set; }

    [JsonProperty("arrived_abroad_date")]
    public string arrivedAbroadDate { get; set; }

    [JsonProperty("customs_received_date")]
    public string customsReceivedDate { get; set; }

    [JsonProperty("arrived_destination_date")]
    public string arrivedDestinationDate { get; set; }

    [JsonProperty("trackinfo")]
    public List<TrackInfo> trackinfo { get; set; }

}