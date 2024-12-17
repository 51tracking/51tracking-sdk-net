using Newtonsoft.Json;

namespace Tracking51API.Model.Trackings;

public class CreateTrackingParams
{
    [JsonProperty("tracking_number")]
    public string trackingNumber { get; set; }

    [JsonProperty("courier_code")]
    public string courierCode { get; set; }

    [JsonProperty("order_number")]
    public string orderNumber { get; set; }

    [JsonProperty("origin_country_iso2")]
    public string originCountryIso2 { get; set; }

    [JsonProperty("destination_country_iso2")]
    public string destinationCountryIso2 { get; set; }

    [JsonProperty("customer_name")]
    public string customerName { get; set; }

    [JsonProperty("customer_email")]
    public string customerEmail { get; set; }

    [JsonProperty("customer_sms")]
    public string customerSms { get; set; }

    [JsonProperty("recipient_postcode")]
    public string recipientPostcode { get; set; }

    [JsonProperty("title")]
    public string title { get; set; }

    [JsonProperty("logistics_channel")]
    public string logisticsChannel { get; set; }

    [JsonProperty("order_id")]
    public string orderId { get; set; }

    [JsonProperty("order_date")]
    public string orderDate { get; set; }

    [JsonProperty("tracking_courier_account")]
    public string trackingCourierAccount { get; set; }

    [JsonProperty("tracking_postal_code")]
    public string trackingPostalCode { get; set; }

    [JsonProperty("tracking_origin_country")]
    public string trackingOriginCountry { get; set; }

    [JsonProperty("tracking_destination_country")]
    public string trackingDestinationCountry { get; set; }

    [JsonProperty("tracking_ship_date")]
    public string trackingShipDate { get; set; }

    [JsonProperty("tracking_key")]
    public string trackingKey { get; set; }

    [JsonProperty("language")]
    public string language { get; set; }

    [JsonProperty("note")]
    public string note { get; set; }

}