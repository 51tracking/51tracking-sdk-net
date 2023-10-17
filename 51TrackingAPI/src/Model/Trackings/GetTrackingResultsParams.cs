using Newtonsoft.Json;

namespace Tracking51API.Model.Trackings;

public class GetTrackingResultsParams
{
    [JsonProperty("archived_status")]
    public string archivedStatus { get; set; }

    [JsonProperty("courier_code")]
    public string courierCode { get; set; }

    [JsonProperty("created_date_max")]
    public string createdDateMax { get; set; }

    [JsonProperty("created_date_min")]
    public string createdDateMin { get; set; }

    [JsonProperty("delivery_status")]
    public string deliveryStatus { get; set; }

    [JsonProperty("items_amount")]
    public int itemsAmount { get; set; }

    [JsonProperty("lang")]
    public string lang { get; set; }

    [JsonProperty("pages_amount")]
    public int pagesAmount { get; set; }

    [JsonProperty("tracking_numbers")]
    public string trackingNumbers { get; set; }

    [JsonProperty("updated_date_max")]
    public string updatedDateMax { get; set; }

    [JsonProperty("updated_date_min")]
    public string updatedDateMin { get; set; }

}