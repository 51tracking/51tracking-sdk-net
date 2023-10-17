using Tracking51API;
using Tracking51API.Model.Trackings;

namespace Test;

public class TrackingTest
{

    public Tracking51 tracking51;

    public TrackingTest(){
        string apiKey = "you api key";
        this.tracking51 = new Tracking51(apiKey);
    }

     [Fact]
    public void TestCreateTrackingWithMissingTrackingNumber()
    {
        var createTrackingParams = new CreateTrackingParams
        {
            trackingNumber = null,
            courierCode = "usps"
        };

        var exception = Assert.Throws<Tracking51Exception>(() => tracking51.Tracking.CreateTracking(createTrackingParams));

        Assert.Equal(Enums.ErrMissingTrackingNumber, exception.Message); 
    }

    [Fact]
    public void TestCreateTrackingWithMissingCourierCode()
    {
        var createTrackingParams = new CreateTrackingParams
        {
            trackingNumber = "9261290306531704519171", 
            courierCode = null 
        };

        var exception = Assert.Throws<Tracking51Exception>(() => tracking51.Tracking.CreateTracking(createTrackingParams));

        Assert.Equal(Enums.ErrMissingCourierCode, exception.Message);
    }

    [Fact]
    public void TestCreateTrackingWithValidParams()
    {
        var createTrackingParams = new CreateTrackingParams
        {
            trackingNumber = "9261290306531704519171", 
            courierCode = "usps"
        };


        var response = tracking51.Tracking.CreateTracking(createTrackingParams);

        Assert.NotNull(response);
    }

    [Fact]
    public void TestGetTrackingResults()
    {

        var getTrackingResultsParams = new GetTrackingResultsParams
        {
            createdDateMin = "2023-08-09T06:00:00+00:00", 
            createdDateMax = "2023-10-10T13:45:00+00:00"
        };
        var response = tracking51.Tracking.GetTrackingResults(getTrackingResultsParams);

        Assert.NotNull(response);
    }

    [Fact]
    public void TestBatchCreateTrackingsNormalCase()
    {

        var trackingParamsList = new List<CreateTrackingParams>
        {
            new CreateTrackingParams
            {
                trackingNumber = "9261290306531704519176",
                courierCode = "usps",
            },
            new CreateTrackingParams
            {
                trackingNumber = "9261290306531704519175",
                courierCode = "usps",
            },
        };

        var response = tracking51.Tracking.BatchCreateTrackings(trackingParamsList);
        Assert.NotNull(response);
    }

    [Fact]
    public void TestBatchCreateTrackingsEmptyTrackingNumber()
    {

        var emptyTrackingParamsList = new List<CreateTrackingParams>
        {
            new CreateTrackingParams
            {
                trackingNumber = null,
                courierCode = "usps",
            },
        };

        var exception = Assert.Throws<Tracking51Exception>(() => tracking51.Tracking.BatchCreateTrackings(emptyTrackingParamsList));

        Assert.Equal(Enums.ErrMissingTrackingNumber, exception.Message);
    }

    [Fact]
    public void TestBatchCreateTrackingsEmptyCourierCode()
    {
        var emptyTrackingParamsList = new List<CreateTrackingParams>
        {
            new CreateTrackingParams
            {
                trackingNumber = "9261290306531704519176",
                courierCode = null,
            },
        };

        var exception = Assert.Throws<Tracking51Exception>(() => tracking51.Tracking.BatchCreateTrackings(emptyTrackingParamsList));

        Assert.Equal(Enums.ErrMissingCourierCode, exception.Message);
    }

    [Fact]
    public void TestBatchCreateTrackingsTooManyTrackingNumbers()
    {

        var tooManyTrackingParamsList = new List<CreateTrackingParams>();
        
        for (int i = 0; i < 41; i++) 
        {
            tooManyTrackingParamsList.Add(new CreateTrackingParams
            {
                trackingNumber = $"trackingNumber{i}",
                courierCode = $"courierCode{i}",
            });
        }

        var exception = Assert.Throws<Tracking51Exception>(() => tracking51.Tracking.BatchCreateTrackings(tooManyTrackingParamsList));

        Assert.Equal(Enums.ErrMaxTrackingNumbersExceeded, exception.Message);
    }

    [Fact]
    public void TestUpdateTrackingByIDValidId()
    {
        var validIdString = "9a55b9092eeef2513ec2cb0d064eab24";
        var updateTrackingParams = new UpdateTrackingParams
        {
            customerName = "New name",
            note = "New tests order note"
        };

        var response = tracking51.Tracking.UpdateTrackingByID(validIdString, updateTrackingParams);

        Assert.NotNull(response);
    }

    [Fact]
    public void TestUpdateTrackingByIDInvalidId()
    {
        var invalidIdString = "";
        var updateTrackingParams = new UpdateTrackingParams
        {
            customerName = "New name",
            note = "New tests order note"
        };

        var exception = Assert.Throws<Tracking51Exception>(() => tracking51.Tracking.UpdateTrackingByID(invalidIdString, updateTrackingParams));

        Assert.Equal(Enums.ErrEmptyId, exception.Message);

    }

    [Fact]
    public void TestDeleteTrackingByIDValidId()
    {
        var validIdString = "9a55b9092eeef2513ec2cb0d064eab24";

        var response = tracking51.Tracking.DeleteTrackingByID(validIdString);

        Assert.NotNull(response);
    }

    [Fact]
    public void TestDeleteTrackingByIDInvalidId()
    {
        var invalidIdString = "";

        var exception = Assert.Throws<Tracking51Exception>(() => tracking51.Tracking.DeleteTrackingByID(invalidIdString));

        Assert.Equal(Enums.ErrEmptyId, exception.Message);
    }

    [Fact]
    public void TestRetrackTrackingByIDValidId()
    {
        var validIdString = "9a55b9092eeef2513ec2cb0d064eab24";

        var response = tracking51.Tracking.RetrackTrackingByID(validIdString);

        Assert.NotNull(response);
    }

    [Fact]
    public void TestRetrackTrackingByIDInvalidId()
    {
        var invalidIdString = "";

        var exception = Assert.Throws<Tracking51Exception>(() => tracking51.Tracking.RetrackTrackingByID(invalidIdString));

        Assert.Equal(Enums.ErrEmptyId, exception.Message);
    }

}