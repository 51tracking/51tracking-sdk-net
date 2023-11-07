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

}