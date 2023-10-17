using Newtonsoft.Json;

namespace Tracking51API.Model.AirWaybills;

public class FlightInfoNew
{
    [JsonProperty("flight_number")]
    public string flightNumber { get; set; }

    [JsonProperty("depart_station")]
    public string departStation { get; set; }

    [JsonProperty("arrival_station")]
    public string arrivalStation { get; set; }

    [JsonProperty("plan_depart_time")]
    public string planDepartTime { get; set; }

    [JsonProperty("depart_time")]
    public string departTime { get; set; }

    [JsonProperty("plan_arrival_time")]
    public string planArrivalTime { get; set; }

    [JsonProperty("arrival_time")]
    public string arrivalTime { get; set; }

    [JsonProperty("piece")]
    public string piece { get; set; }

    [JsonProperty("weight")]
    public string weight { get; set; }

    [JsonProperty("status")]
    public string status { get; set; }
}