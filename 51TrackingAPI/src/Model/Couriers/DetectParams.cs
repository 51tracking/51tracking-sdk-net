using Newtonsoft.Json;

namespace Tracking51API.Model.Couriers;

public class DetectParams
{
    [JsonProperty("tracking_number")]
    public string trackingNumber { get; set; } = "";

}