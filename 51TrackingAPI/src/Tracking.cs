using Newtonsoft.Json;
using Tracking51API.Model;
using Tracking51API.Model.Trackings;



namespace Tracking51API;

public class Tracking : Base
{

    private string _apiModule = "trackings";

    public ApiResponse<Trackings> CreateTracking(CreateTrackingParams createTrackingParams){
        if (string.IsNullOrEmpty(createTrackingParams.trackingNumber))
        {
            throw new Tracking51Exception(Enums.ErrMissingTrackingNumber);
        }

        if (string.IsNullOrEmpty(createTrackingParams.courierCode))
        {
            throw new Tracking51Exception(Enums.ErrMissingCourierCode);
        }

        HttpMethod method = HttpMethod.Post;
        var responseData = request.MakeRequest(_apiModule + "/create", method, createTrackingParams);

        ApiResponse<Trackings> response = JsonConvert.DeserializeObject<ApiResponse<Trackings>>(responseData);
        return response;
        
    }

    public ApiResponse<GetResults> GetTrackingResults(GetTrackingResultsParams getTrackingResultsParams){

        HttpMethod method = HttpMethod.Get;
        var responseData = request.MakeRequest(_apiModule + "/get", method, getTrackingResultsParams);

        ApiResponse<GetResults> response = JsonConvert.DeserializeObject<ApiResponse<GetResults>>(responseData);
        return response;
        
    }

    public ApiResponse<BatchResults> BatchCreateTrackings(List<CreateTrackingParams> trackingParamsList){
        if (trackingParamsList.Count > 40)
        {
            throw new Tracking51Exception(Enums.ErrMaxTrackingNumbersExceeded);
        }

        foreach (var item in trackingParamsList)
        {
            if (string.IsNullOrEmpty(item.trackingNumber)){
                throw new Tracking51Exception(Enums.ErrMissingTrackingNumber);
            }

            if (string.IsNullOrEmpty(item.courierCode)){
                throw new Tracking51Exception(Enums.ErrMissingCourierCode);
            }
        }

        HttpMethod method = HttpMethod.Post;
        var responseData = request.MakeRequest(_apiModule + "/batch", method, trackingParamsList);

        ApiResponse<BatchResults> response = JsonConvert.DeserializeObject<ApiResponse<BatchResults>>(responseData);
        return response;
        
    }

    public ApiResponse<UpdateTracking> UpdateTrackingByID(string idString,UpdateTrackingParams updateTrackingParams){
        if (string.IsNullOrEmpty(idString))
        {
            throw new Tracking51Exception(Enums.ErrEmptyId);
        }

        HttpMethod method = HttpMethod.Put;
        var responseData = request.MakeRequest(_apiModule + "/update/" + idString, method, updateTrackingParams);

        ApiResponse<UpdateTracking> response = JsonConvert.DeserializeObject<ApiResponse<UpdateTracking>>(responseData);
        return response;
        
    }

    public ApiResponse<Trackings> DeleteTrackingByID(string idString){
        if (string.IsNullOrEmpty(idString))
        {
            throw new Tracking51Exception(Enums.ErrEmptyId);
        }

        HttpMethod method = HttpMethod.Delete;
        var responseData = request.MakeRequest(_apiModule + "/delete/" + idString, method, null);

        ApiResponse<Trackings> response = JsonConvert.DeserializeObject<ApiResponse<Trackings>>(responseData);
        return response;
        
    }

    public ApiResponse<Trackings> RetrackTrackingByID(string idString){
        if (string.IsNullOrEmpty(idString))
        {
            throw new Tracking51Exception(Enums.ErrEmptyId);
        }

        HttpMethod method = HttpMethod.Post;
        var responseData = request.MakeRequest(_apiModule + "/retrack/" + idString, method, null);

        ApiResponse<Trackings> response = JsonConvert.DeserializeObject<ApiResponse<Trackings>>(responseData);
        return response;
        
    }

}