using Tracking51API.Model.Couriers;
using Tracking51API.Model.AirWaybills;
using Tracking51API.Model.Trackings;
using Tracking51API.Model;

namespace Tracking51API;

public class Test
{

      static void Main(string[] args)
      {

        try
        {
            string apiKey = "you api key";
            Tracking51 tracking51 = new Tracking51(apiKey);

            var apiResponse = tracking51.Courier.GetAllCouriers();
            Console.WriteLine(apiResponse.meta.code);
            foreach (var item in apiResponse.data)
            {
                Console.WriteLine("courierName: " + item.courierName);
                Console.WriteLine("courierCode: " + item.courierCode);
                Console.WriteLine();
            }
            
            // DetectParams detectParams = new DetectParams();
            // detectParams.trackingNumber = "9261290306531704519171";
            // var apiResponse = tracking51.Courier.detect(detectParams);
            // Console.WriteLine(apiResponse.meta.code);
            // foreach (var item in apiResponse.data)
            // {
            //     Console.WriteLine("courierName: " + item.courierName);
            //     Console.WriteLine("courierCode: " + item.courierCode);
                
            //     Console.WriteLine();
            // }

            // AirWaybillParams airWaybillParams = new AirWaybillParams();
            // airWaybillParams.awbNumber = "235-69030430";
            // var apiResponse = tracking51.AirWaybill.CreateAnAirWayBill(airWaybillParams);
            // Console.WriteLine(apiResponse.meta.code);
            // Console.WriteLine(apiResponse.data.awbNumber);
            // Console.WriteLine(apiResponse.data.flightInfoNew[0].flightNumber);
            // Console.WriteLine(apiResponse.data.flightInfo["TK0721"].departStation);

            // CreateTrackingParams createTrackingParams = new CreateTrackingParams();
            // createTrackingParams.trackingNumber = "9261290306531714519953";
            // createTrackingParams.courierCode = "usps";
            // var apiResponse = tracking51.Tracking.CreateTracking(createTrackingParams);
            // Console.WriteLine(apiResponse.meta.code);
            // Console.WriteLine(apiResponse.meta.message);
            // if(apiResponse.data != null){
            //    Console.WriteLine(apiResponse.data.trackingNumber);
            //    Console.WriteLine(apiResponse.data.courierCode);
            // }

            // GetTrackingResultsParams getTrackingResultsParams = new GetTrackingResultsParams();
            // getTrackingResultsParams.trackingNumbers = "9261290306531704519171,92612903029511573030094547";
            // getTrackingResultsParams.courierCode = "usps";
            // getTrackingResultsParams.createdDateMin = "2023-08-09T06:00:00+00:00";
            // getTrackingResultsParams.createdDateMax = "2023-10-10T13:45:00+00:00";
            // var apiResponse = tracking51.Tracking.GetTrackingResults(getTrackingResultsParams);
            // Console.WriteLine(apiResponse.meta.code);
            // foreach (var item in apiResponse.data.success)
            // {
            //     Console.WriteLine("id: " + item.id);
            //     Console.WriteLine("trackingNumber: " + item.trackingNumber);
            //     Console.WriteLine("courierCode: " + item.courierCode);
                
            //     Console.WriteLine();
            // }

            // foreach (var item in apiResponse.data.rejected)
            // {
            //     Console.WriteLine("trackingNumber: " + item.trackingNumber);
            //     Console.WriteLine("rejectedCode: " + item.rejectedCode);
            //     Console.WriteLine("rejectedMessage: " + item.rejectedMessage);
                
            //     Console.WriteLine();
            // }

            // List<CreateTrackingParams> trackingParamsList = new List<CreateTrackingParams>();

            // CreateTrackingParams trackingParams1 = new CreateTrackingParams
            // {
            //     trackingNumber = "9261290306531704519172",
            //     courierCode = "usps"
            // };

            // trackingParamsList.Add(trackingParams1);

            // CreateTrackingParams trackingParams2 = new CreateTrackingParams
            // {
            //     trackingNumber = "9261290306531704519174",
            //     courierCode = "usps"
            // };

            // trackingParamsList.Add(trackingParams2);
            // var apiResponse = tracking51.Tracking.BatchCreateTrackings(trackingParamsList);
            // Console.WriteLine(apiResponse.meta.code);
            // foreach (var item in apiResponse.data.success)
            // {
            //     Console.WriteLine("trackingNumber: " + item.trackingNumber);
            //     Console.WriteLine("courierCode: " + item.courierCode);
                
            //     Console.WriteLine();
            // }

            // foreach (var item in apiResponse.data.error)
            // {
            //     Console.WriteLine("trackingNumber: " + item.trackingNumber);
            //     Console.WriteLine("courierCode: " + item.courierCode);
                
            //     Console.WriteLine();
            // }

            // UpdateTrackingParams updateTrackingParams = new UpdateTrackingParams();
            // updateTrackingParams.customerName = "New name";
            // updateTrackingParams.note = "New tests order note";
            // string idString = "99f561f1b7ac827fd4f9578b95558116";
            // var apiResponse = tracking51.Tracking.UpdateTrackingByID(idString, updateTrackingParams);
            // Console.WriteLine(apiResponse.meta.code);
            // if(apiResponse.data != null){
            //     Console.WriteLine(apiResponse.data.trackingNumber);
            //     Console.WriteLine(apiResponse.data.courierCode);
            //     Console.WriteLine(apiResponse.data.customerName);
            //     Console.WriteLine(apiResponse.data.note);
            // }

            // string idString = "99f561f1b7ac827fd4f9578b95558116";
            // var apiResponse = tracking51.Tracking.DeleteTrackingByID(idString);
            // Console.WriteLine(apiResponse.meta.code);
            // if(apiResponse.data != null){
            //     Console.WriteLine(apiResponse.data.trackingNumber);
            //     Console.WriteLine(apiResponse.data.courierCode);
            // }

           
            // string idString = "99f561f1b7ac827fd4f9578b95558116";
            // var apiResponse = tracking51.Tracking.RetrackTrackingByID(idString);
            // Console.WriteLine(apiResponse.meta.code);
            // if(apiResponse.data != null){
            //     Console.WriteLine(apiResponse.data.trackingNumber);
            //     Console.WriteLine(apiResponse.data.courierCode);
            // }
           

        }
        catch (Tracking51Exception ex)
        {
            Console.WriteLine("Catch custom exceptions：" + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Catch other exceptions:" + ex.Message);
        }

      }

}