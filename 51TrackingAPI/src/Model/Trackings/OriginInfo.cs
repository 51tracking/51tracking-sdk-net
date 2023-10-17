using Newtonsoft.Json;

namespace Tracking51API.Model.Trackings;

public class OriginInfo
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

    [JsonProperty("pickup_date (Lagacy)")]
    public string pickupDateLagacy { get; set; }

    [JsonProperty("departed_airport_date (Lagacy)")]
    public string departedAirportDateLagacy { get; set; }

    [JsonProperty("arrived_abroad_date (Lagacy)")]
    public string arrivedAbroadDateLagacy { get; set; }

    [JsonProperty("customs_received_date (Lagacy)")]
    public string customsReceivedDateLagacy { get; set; }

    [JsonProperty("arrived_destination_date (Lagacy)")]
    public string arrivedDestinationDateLagacy { get; set; }

    [JsonProperty("trackinfo")]
    public List<TrackInfo> trackinfo { get; set; }

}