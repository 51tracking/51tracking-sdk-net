using Newtonsoft.Json;

namespace Tracking51API.Model.Trackings;

public class Trackings
{
    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("tracking_number")]
    public string trackingNumber { get; set; }

    [JsonProperty("courier_code")]
    public string courierCode { get; set; }

    [JsonProperty("order_number")]
    public string orderNumber { get; set; }

    [JsonProperty("order_date")]
    public string orderDate { get; set; }

    [JsonProperty("created_at")]
    public string createdAt { get; set; }

    [JsonProperty("update_at")]
    public string updateAt { get; set; }

    [JsonProperty("delivery_status")]
    public string deliveryStatus { get; set; }

    [JsonProperty("archived")]
    public string archived { get; set; }

    [JsonProperty("updating")]
    public bool updating { get; set; }

    [JsonProperty("destination_country")]
    public string destinationCountry { get; set; }

    [JsonProperty("destination_state")]
    public string destinationState { get; set; }

    [JsonProperty("destination_city")]
    public string destinationCity { get; set; }

    [JsonProperty("origin_country")]
    public string originCountry { get; set; }

    [JsonProperty("origin_state")]
    public string originState { get; set; }

    [JsonProperty("origin_city")]
    public string originCity { get; set; }

    [JsonProperty("tracking_postal_code")]
    public string trackingPostalCode { get; set; }

    [JsonProperty("tracking_ship_date")]
    public string trackingShipDate { get; set; }

    [JsonProperty("tracking_destination_country")]
    public string trackingDestinationCountry { get; set; }

    [JsonProperty("tracking_origin_country")]
    public string trackingOriginCountry { get; set; }

    [JsonProperty("tracking_key")]
    public string trackingKey { get; set; }

    [JsonProperty("tracking_courier_account")]
    public string trackingCourierAccount { get; set; }

    [JsonProperty("customer_name")]
    public string customerName { get; set; }

    [JsonProperty("customer_email")]
    public string customerEmail { get; set; }

    [JsonProperty("customer_sms")]
    public string customerSms { get; set; }

    [JsonProperty("order_id")]
    public string orderId { get; set; }

    [JsonProperty("recipient_postcode")]
    public string recipientPostcode { get; set; }

    [JsonProperty("title")]
    public string title { get; set; }

    [JsonProperty("logistics_channel")]
    public string logisticsChannel { get; set; }

    [JsonProperty("note")]
    public string note { get; set; }

    [JsonProperty("signed_by")]
    public string signedBy { get; set; }

    [JsonProperty("service_code")]
    public string serviceCode { get; set; }

    [JsonProperty("weight")]
    public string weight { get; set; }

    [JsonProperty("weight_kg")]
    public string weightKg { get; set; }

    [JsonProperty("product_type")]
    public string productType { get; set; }

    [JsonProperty("pieces")]
    public string pieces { get; set; }

    [JsonProperty("dimension")]
    public string dimension { get; set; }

    [JsonProperty("previously")]
    public string previously { get; set; }

    [JsonProperty("destination_track_number")]
    public string destinationTrackNumber { get; set; }

    [JsonProperty("exchange_number")]
    public string exchangeNumber { get; set; }

    [JsonProperty("scheduled_delivery_date")]
    public string scheduledDeliveryDate { get; set; }

    [JsonProperty("scheduled_address")]
    public string scheduledAddress { get; set; }

    [JsonProperty("substatus")]
    public string substatus { get; set; }

    [JsonProperty("status_info")]
    public string statusInfo { get; set; }

    [JsonProperty("latest_event")]
    public string latestEvent { get; set; }

    [JsonProperty("latest_checkpoint_time")]
    public string latestCheckpointTime { get; set; }

    [JsonProperty("transit_time")]
    public int transitTime { get; set; }

    [JsonProperty("origin_info")]
    public OriginInfo originInfo { get; set; }

    [JsonProperty("destination_info")]
    public DestinationInfo destinationInfo { get; set; }

}