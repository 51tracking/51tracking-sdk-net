using Tracking51API;
using Tracking51API.Model.AirWaybills;

namespace Test;

public class AirWaybillTest
{

    public Tracking51 tracking51;

    public AirWaybillTest(){
        string apiKey = "you api key";
        this.tracking51 = new Tracking51(apiKey);
    }

    [Fact]
    public void TestCreateAnAirWayBillWithMissingAwbNumber()
    {
        var airWaybillParams = new AirWaybillParams
        {
            awbNumber = null 
        };


        var exception = Assert.Throws<Tracking51Exception>(() => tracking51.AirWaybill.CreateAnAirWayBill(airWaybillParams));

        Assert.Equal(Enums.ErrMissingAwbNumber, exception.Message);
    }

    [Fact]
    public void TestCreateAnAirWayBillWithInvalidAwbNumberFormat()
    {
        var airWaybillParams = new AirWaybillParams
        {
            awbNumber = "123456" 
        };

        var exception = Assert.Throws<Tracking51Exception>(() => tracking51.AirWaybill.CreateAnAirWayBill(airWaybillParams));

        Assert.Equal(Enums.ErrInvalidAirWaybillFormat, exception.Message);
    }

    [Fact]
    public void TestCreateAnAirWayBillWithValidAwbNumber()
    {
        var airWaybillParams = new AirWaybillParams
        {
            awbNumber = "235-69030430"
        };

        var response = tracking51.AirWaybill.CreateAnAirWayBill(airWaybillParams);

        Assert.NotNull(response);

    }

}