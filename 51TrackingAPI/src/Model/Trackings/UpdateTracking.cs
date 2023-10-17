using Newtonsoft.Json;

namespace Tracking51API.Model.Trackings;

public class UpdateTracking
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("tracking_number")]
    public string trackingNumber { get; set; }

    [JsonProperty("courier_code")]
    public string courierCode { get; set; }

    [JsonProperty("courier_code_new")]
    public string courierCodeNew { get; set; }

    [JsonProperty("order_number")]
    public string orderNumber { get; set; }

    [JsonProperty("order_date")]
    public string orderDate { get; set; }

    [JsonProperty("order_id")]
    public string orderId { get; set; }

    [JsonProperty("destination_country")]
    public string destinationCountry { get; set; }

    [JsonProperty("origin_country")]
    public string originCountry { get; set; }

    [JsonProperty("tracking_postal_code")]
    public string trackingPostalCode { get; set; }

    [JsonProperty("tracking_ship_date")]
    public string trackingShipDate { get; set; }

    [JsonProperty("tracking_courier_account")]
    public string trackingCourierAccount { get; set; }

    [JsonProperty("tracking_destination_country")]
    public string trackingDestinationCountry { get; set; }

    [JsonProperty("tracking_origin_country")]
    public string trackingOriginCountry { get; set; }

    [JsonProperty("tracking_key")]
    public string trackingKey { get; set; }

    [JsonProperty("customer_name")]
    public string customerName { get; set; }

    [JsonProperty("customer_email")]
    public string customerEmail { get; set; }

    [JsonProperty("customer_sms")]
    public string customerSms { get; set; }

    [JsonProperty("title")]
    public string title { get; set; }

    [JsonProperty("logistics_channel")]
    public string logisticsChannel { get; set; }

    [JsonProperty("note")]
    public string note { get; set; }

}