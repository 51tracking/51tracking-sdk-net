using Newtonsoft.Json;
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
        if (airWaybillParams.awbNumber.Length != 12)
        {
            throw new Tracking51Exception(Enums.ErrInvalidAirWaybillFormat);
        }
        HttpMethod method = HttpMethod.Post;
        var responseData = request.MakeRequest("awb", method, airWaybillParams);

        ApiResponse<AirWaybills> response = JsonConvert.DeserializeObject<ApiResponse<AirWaybills>>(responseData);
        return response;
        
    }

}