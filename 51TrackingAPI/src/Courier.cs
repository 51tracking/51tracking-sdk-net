using Newtonsoft.Json;
using Tracking51API.Model;
using Tracking51API.Model.Couriers;

namespace Tracking51API;

public class Courier : Base
{

    private string _apiModule = "couriers";

    public ApiResponse<List<Couriers>> GetAllCouriers(){
        
        HttpMethod method = HttpMethod.Get;
        var responseData = request.MakeRequest(_apiModule + "/all", method);

        ApiResponse<List<Couriers>> response = JsonConvert.DeserializeObject<ApiResponse<List<Couriers>>>(responseData);
        return response;
      
    }

    public ApiResponse<List<Couriers>> detect(DetectParams detectParams){
        if (string.IsNullOrEmpty(detectParams.trackingNumber))
        {
            throw new Tracking51Exception(Enums.ErrMissingTrackingNumber);
        }
        HttpMethod method = HttpMethod.Post;
        var responseData = request.MakeRequest(_apiModule + "/detect", method, detectParams);

        ApiResponse<List<Couriers>> response = JsonConvert.DeserializeObject<ApiResponse<List<Couriers>>>(responseData);
        return response;
        
    }

}