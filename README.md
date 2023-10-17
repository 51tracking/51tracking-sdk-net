51tracking-sdk-net
=================

The .Net SDK of 51Tracking API

Contact: <service@51tracking.org>

## Official document

[Document](https://www.51tracking.com/v4/api-index/API-)

## Index
1. [Installation](https://github.com/51tracking/51tracking-sdk-net#installation)
2. [Testing](https://github.com/51tracking/51tracking-sdk-net#testing)
3. [Error Handling](https://github.com/51tracking/51tracking-sdk-net#error-handling)
4. SDK
    1. [Couriers](https://github.com/51tracking/51tracking-sdk-net#couriers)
    2. [Trackings](https://github.com/51tracking/51tracking-sdk-net#trackings)
    3. [Air Waybill](https://github.com/51tracking/51tracking-sdk-net#air-waybill)


## Installation

使用 dotnet CLI 下载 NuGet 软件包

```
$ dotnet add package 51tracking
```

使用 NuGet 命令行工具下载 NuGet 软件包

```
$ nuget install 51tracking
```

与 dotnet cli 不同的是，您需要手动修改 .csproj 文件并添加以下代码

```text
<ItemGroup>
    <PackageReference Include="51Tracking" Version="X.Y.Z" />
</ItemGroup>
```

## Quick Start

```c#
using Tracking51API;

namespace Testing;

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
```

## Testing

在测试项目的根目录下，运行以下命令执行测试

```
dotnet test
```

## Error handling

**Throw** by the new SDK client

```c#
try
{
    string apiKey = "";
    Tracking51 tracking51 = new Tracking51(apiKey);
}
catch (Tracking51Exception ex)
{
    Console.WriteLine("Catch custom exceptions：" + ex.Message);
}

# API Key is missing
```

**Throw** by the parameter validation in function

```c#
try
{
    string apiKey = "you api key";
    Tracking51 tracking51 = new Tracking51(apiKey);

    CreateTrackingParams createTrackingParams = new CreateTrackingParams();
    createTrackingParams.trackingNumber = "";
    createTrackingParams.courierCode = "usps";
    var apiResponse = tracking51.Tracking.CreateTracking(createTrackingParams);
}
catch (Tracking51Exception ex)
{
    Console.WriteLine("Catch custom exceptions：" + ex.Message);
}

# Tracking number cannot be empty
```
## Examples

## Couriers
##### 返回所有支持的快递公司列表
https://api.51Tracking.com/v4/couriers/all
```c#
var apiResponse = tracking51.Courier.GetAllCouriers();
Console.WriteLine(apiResponse.meta.code);
foreach (var item in apiResponse.data)
{
    Console.WriteLine("courierName: " + item.courierName);
    Console.WriteLine("courierCode: " + item.courierCode);
    Console.WriteLine();
}
```

## Trackings
##### 单个物流单号实时添加且查询
https://api.51Tracking.com/v4/trackings/create
```c#
CreateTrackingParams createTrackingParams = new CreateTrackingParams();
createTrackingParams.trackingNumber = "9261290306531704519171";
createTrackingParams.courierCode = "usps";
var apiResponse = tracking51.Tracking.CreateTracking(createTrackingParams);
Console.WriteLine(apiResponse.meta.code);
Console.WriteLine(apiResponse.data.trackingNumber);
Console.WriteLine(apiResponse.data.courierCode);

```

##### 获取多个物流单号的查询结果
https://api.51Tracking.com/v4/trackings/get
```c#
GetTrackingResultsParams getTrackingResultsParams = new GetTrackingResultsParams();
getTrackingResultsParams.trackingNumbers = "9261290306531704519171,92612903029511573030094547";
getTrackingResultsParams.courierCode = "usps";
getTrackingResultsParams.createdDateMin = "2023-10-09T06:00:00+00:00";
getTrackingResultsParams.createdDateMax = "2023-10-10T13:45:00+00:00";
var apiResponse = tracking51.Tracking.GetTrackingResults(getTrackingResultsParams);
Console.WriteLine(apiResponse.meta.code);
foreach (var item in apiResponse.data.success)
{
    Console.WriteLine("id: " + item.id);
    Console.WriteLine("trackingNumber: " + item.trackingNumber);
    Console.WriteLine("courierCode: " + item.courierCode);
    
    Console.WriteLine();
}

foreach (var item in apiResponse.data.rejected)
{
    Console.WriteLine("trackingNumber: " + item.trackingNumber);
    Console.WriteLine("rejectedCode: " + item.rejectedCode);
    Console.WriteLine("rejectedMessage: " + item.rejectedMessage);
    
    Console.WriteLine();
}
```

##### 添加多个物流单号（一次调用最多创建 40 个物流单号）
https://api.51Tracking.com/v4/trackings/batch
```c#
List<CreateTrackingParams> trackingParamsList = new List<CreateTrackingParams>();

CreateTrackingParams trackingParams1 = new CreateTrackingParams
{
    trackingNumber = "9261290306531704519172",
    courierCode = "usps"
};

trackingParamsList.Add(trackingParams1);

CreateTrackingParams trackingParams2 = new CreateTrackingParams
{
    trackingNumber = "9261290306531704519174",
    courierCode = "usps"
};

trackingParamsList.Add(trackingParams2);
var apiResponse = tracking51.Tracking.BatchCreateTrackings(trackingParamsList);
Console.WriteLine(apiResponse.meta.code);
foreach (var item in apiResponse.data.success)
{
    Console.WriteLine("trackingNumber: " + item.trackingNumber);
    Console.WriteLine("courierCode: " + item.courierCode);
    
    Console.WriteLine();
}

foreach (var item in apiResponse.data.error)
{
    Console.WriteLine("trackingNumber: " + item.trackingNumber);
    Console.WriteLine("courierCode: " + item.courierCode);
    
    Console.WriteLine();
}
```

##### 根据ID更新物流信息
https://api.51Tracking.com/v4/trackings/update/{id}
```c#
UpdateTrackingParams updateTrackingParams = new UpdateTrackingParams();
updateTrackingParams.customerName = "New name";
updateTrackingParams.note = "New tests order note";
string idString = "9a557acc90dd57df78933fcc09ab9657";
var apiResponse = tracking51.Tracking.UpdateTrackingByID(idString, updateTrackingParams);
Console.WriteLine(apiResponse.meta.code);
if(apiResponse.data != null){
    Console.WriteLine(apiResponse.data.trackingNumber);
    Console.WriteLine(apiResponse.data.courierCode);
    Console.WriteLine(apiResponse.data.customerName);
    Console.WriteLine(apiResponse.data.note);
}
```

##### 通过ID删除单号
https://api.51Tracking.com/v4/trackings/delete/{id}
```c#
string idString = "9a5575a8b14833ff3a34d357709707b7";
var apiResponse = tracking51.Tracking.RetrackTrackingByID(idString);
Console.WriteLine(apiResponse.meta.code);
if(apiResponse.data != null){
    Console.WriteLine(apiResponse.data.trackingNumber);
    Console.WriteLine(apiResponse.data.courierCode);
}
```

##### 通过ID重新查询过期的单号
https://api.51Tracking.com/v4/trackings/retrack/{id}
```c#
string idString = "9a5575a8b14833ff3a34d357709707b7";
var apiResponse = tracking51.Tracking.RetrackTrackingByID(idString);
Console.WriteLine(apiResponse.meta.code);
if(apiResponse.data != null){
    Console.WriteLine(apiResponse.data.trackingNumber);
    Console.WriteLine(apiResponse.data.courierCode);
}
```
## Air Waybill
##### 查询航空运单的结果
https://api.51Tracking.com/v4/awb
```c#
AirWaybillParams airWaybillParams = new AirWaybillParams();
airWaybillParams.awbNumber = "235-69030430";
var apiResponse = tracking51.AirWaybill.CreateAnAirWayBill(airWaybillParams);
Console.WriteLine(apiResponse.meta.code);
Console.WriteLine(apiResponse.data.awbNumber);
Console.WriteLine(apiResponse.data.flightInfoNew[0].flightNumber);
Console.WriteLine(apiResponse.data.flightInfo["TK0721"].departStation);

```

## 响应状态码

51Tracking 使用传统的HTTP状态码来表明 API 请求的状态。通常，2xx形式的状态码表示请求成功，4XX形式的状态码表请求发生错误（比如：必要参数缺失），5xx格式的状态码表示 51tracking 的服务器可能发生了问题。



Http CODE|META CODE|TYPE | MESSAGE
----|-----|--------------|-------------------------------
200    |200     | <code>成功</code>        |    请求响应成功。
400    |400     | <code>错误请求</code>     |    请求类型错误。请查看 API 文档以了解此 API 的请求类型。
400    |4101    | <code>错误请求</code>     |    物流单号已存在。
400    |4102    | <code>错误请求</code>     |    物流单号不存在。请先使用「Create接口」将单号添加至系统。
400    |4103    | <code>错误请求</code>     |    您已超出 API 调用的创建数量。每次创建的最大数量为 40 个快递单号。
400    |4110    | <code>错误请求</code>     |    物流单号(tracking_number) 不符合规则。
400    |4111    | <code>错误请求</code>     |    物流单号(tracking_number)为必填字段。
400    |4112    | <code>错误请求</code>     |    查询ID无效。
400    |4113    | <code>错误请求</code>     |    不允许重新查询。您只能重新查询过期的物流单号。
400    |4120    | <code>错误请求</code>     |    物流商简码(courier_code)的值无效。
400    |4121    | <code>错误请求</code>     |    无法识别物流商。
400    |4122    | <code>错误请求</code>     |    特殊物流商字段缺失或填写不符合规范。
400    |4130    | <code>错误请求</code>     |    请求参数的格式无效。
400    |4160    | <code>错误请求</code>     |    空运单号(awb_number)是必需的或有效的格式。
400    |4161    | <code>错误请求</code>     |    此空运航空不支持查询。
400    |4165    | <code>错误请求</code>     |    查询失败：未创建空运单号。
400    |4166    | <code>错误请求</code>     |    删除未创建的空运单号失败。
400    |4167    | <code>错误请求</code>     |    空运单号已存在，无需再次创建。
400    |4190    | <code>错误请求</code>     |    当前查询额度不足。
401    |401     | <code>未经授权</code>   |    身份验证失败或没有权限。请检查并确保您的 API 密钥正确无误。
403    |403     | <code>禁止</code>      |    禁止访问。请求被拒绝或不允许访问。
404    |404     | <code>未找到</code>       |    页面不存在。请检查并确保您的链接正确无误。
429    |429     | <code>太多请求</code>|    超出 API 请求限制，请稍后重试。请查看 API 文档以了解此 API 的限制。
500    |511     | <code>服务器错误</code>    |    服务器错误。请联系我们： service@51Tracking.org。
500    |512     | <code>服务器错误</code>    |    服务器错误。请联系我们：service@51Tracking.org。
500    |513     | <code>服务器错误</code>    |    服务器错误。请联系我们： service@51Tracking.org。