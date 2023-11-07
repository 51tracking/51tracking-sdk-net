namespace Tracking51API;

public class Enums
{
   public const string ErrEmptyAPIKey = "API Key is missing";
   public const string ErrMissingTrackingNumber = "Tracking number cannot be empty";
   public const string ErrMissingCourierCode = "Courier Code cannot be empty";
   public const string ErrMissingAwbNumber = "Awb number cannot be empty";
   public const string ErrMaxTrackingNumbersExceeded = "Max. 40 tracking numbers create in one call";
   public const string ErrEmptyId = "Id cannot be empty";
   public const string ErrInvalidAirWaybillFormat = "The air waybill number format is invalid";
}
