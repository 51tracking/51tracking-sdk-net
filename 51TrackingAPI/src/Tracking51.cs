namespace Tracking51API;

public class Tracking51
{

      public Courier Courier { get; }

      public AirWaybill AirWaybill { get; }

      public Tracking Tracking { get; }

      public static string apiKey;

      public Tracking51(string key)
      {
        if (string.IsNullOrEmpty(key))
        {
            throw new Tracking51Exception(Enums.ErrEmptyAPIKey);
        }
        Tracking51.apiKey = key;
        this.Courier = new Courier();
        this.AirWaybill = new AirWaybill();
        this.Tracking = new Tracking();
      }
      
}
