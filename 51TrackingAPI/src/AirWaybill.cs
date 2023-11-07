using Newtonsoft.Json;
using System.Text.RegularExpressions;
using Tracking51API.Model;
using Tracking51API.Model.AirWaybills;

namespace Tracking51API;

public class AirWaybill : Base
{

    public ApiResponse<AirWaybills> CreateAnAirWayBill(AirWaybillParams airWaybillParams){
        if (string.IsNullOrEmpty(airWaybillParams.awbNumber))
        {
            throw new Tracking51Exception(Enums.ErrMissingAwbNumber);
        }
        if (!Regex.IsMatch(airWaybillParams.awbNumber, @"^\d{3}[ -]?(\d{8})$"))
        {
            throw new Tracking51Exception(Enums.ErrInvalidAirWaybillFormat);
        }
        HttpMethod method = HttpMethod.Post;
        var responseData = request.MakeRequest("awb", method, airWaybillParams);

        ApiResponse<AirWaybills> response = JsonConvert.DeserializeObject<ApiResponse<AirWaybills>>(responseData);
        return response;
        
    }

}