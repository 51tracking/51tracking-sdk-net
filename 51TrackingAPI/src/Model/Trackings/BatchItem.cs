using Newtonsoft.Json;

namespace Tracking51API.Model.Trackings;

public class BatchItem
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("tracking_number")]
    public string trackingNumber { get; set; }

    [JsonProperty("courier_code")]
    public string courierCode { get; set; }

    [JsonProperty("errorCode")]
    public int? errorCode { get; set; }

    [JsonProperty("errorMessage")]
    public string errorMessage { get; set; }

}