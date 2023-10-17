using Newtonsoft.Json;

namespace Tracking51API.Model.AirWaybills;

public class AirWaybillParams
{
    [JsonProperty("awb_number")]
    public string awbNumber { get; set; }

}