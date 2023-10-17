using Tracking51API;
using Tracking51API.Model.Couriers;

namespace Test;

public class CourierTest
{

    public Tracking51 tracking51;

    public CourierTest(){
        string apiKey = "you api key";
        this.tracking51 = new Tracking51(apiKey);
    }

    [Fact]
    public void TestGetAllCouriers()
    {

        var response = tracking51.Courier.GetAllCouriers();

        Assert.NotNull(response);
    }

    [Fact]
    public void TestDetectMethodWithValidTrackingNumber()
    {
        var detectParams = new DetectParams
        {
            trackingNumber = "9261290306531704519171" 
        };

        var response = tracking51.Courier.detect(detectParams);
        
        Assert.NotNull(response);
    }

    [Fact]
    public void TestDetectMethodWithMissingTrackingNumber()
    {
        var detectParams = new DetectParams
        {
            trackingNumber = null
        };

        var exception = Assert.Throws<Tracking51Exception>(() => tracking51.Courier.detect(detectParams));

        Assert.Equal(Enums.ErrMissingTrackingNumber, exception.Message); 
    }

}