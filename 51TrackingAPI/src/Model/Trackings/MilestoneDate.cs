using Newtonsoft.Json;

namespace Tracking51API.Model.Trackings;

public class MilestoneDate
{
    [JsonProperty("inforeceived_date")]
    public string inforeceivedDate { get; set; }

    [JsonProperty("pickup_date")]
    public string pickupDate { get; set; }

    [JsonProperty("outfordelivery_date")]
    public string outfordeliveryDate { get; set; }

    [JsonProperty("delivery_date")]
    public string deliveryDate { get; set; }

    [JsonProperty("returning_date")]
    public string returningDate { get; set; }

    [JsonProperty("returned_date")]
    public string returnedDate { get; set; }

}