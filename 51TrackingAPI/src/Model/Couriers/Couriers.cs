using Newtonsoft.Json;

namespace Tracking51API.Model.Couriers;

public class Couriers
{
    [JsonProperty("courier_name")]
    public string courierName { get; set; }

    [JsonProperty("courier_code")]
    public string courierCode { get; set; }

    [JsonProperty("courier_country_iso2")]
    public string courierCountryIso2 { get; set; }

    [JsonProperty("courier_url")]
    public string courierUrl { get; set; }

    [JsonProperty("courier_phone")]
    public string courierPhone { get; set; }

    [JsonProperty("courier_type")]
    public string courierType { get; set; }

    [JsonProperty("tracking_required_fields")]
    public object trackingRequiredFields { get; set; }

    [JsonProperty("optional_fields")]
    public object optionalFields { get; set; }

    [JsonProperty("default_language")]
    public string defaultLanguage { get; set; }

    [JsonProperty("courier_logo")]
    public string courierLogo { get; set; }

    [JsonProperty("support_language")]
    public string[] supportLanguage { get; set; }

}