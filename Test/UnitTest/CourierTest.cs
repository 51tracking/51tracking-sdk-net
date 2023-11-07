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

}