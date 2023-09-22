# GroupByInc.RetailApi.Client.Api.RecommendationsAPIApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Predict**](RecommendationsAPIApi.md#predict) | **POST** /api/predict | Provide Recommendations AI functionality. |
| [**PredictV2**](RecommendationsAPIApi.md#predictv2) | **POST** /api/recommendation | Provide Recommendations AI functionality. |

<a id="predict"></a>
# **Predict**
> PredictResults Predict (string xGroupbyCustomerId, RecommendationsRequest recommendationsRequest)

Provide Recommendations AI functionality.

Perform a recommendation request against the GroupBy Retail Recommendations API.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupByInc.RetailApi.Client.Api;
using GroupByInc.RetailApi.Client.Client;
using GroupByInc.RetailApi.Client.Model;

namespace Example
{
    public class PredictExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: GroupByIncEmployee
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: ClientKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RecommendationsAPIApi(config);
            var xGroupbyCustomerId = "xGroupbyCustomerId_example";  // string | Custom HTTP header which may contain tenant name. Used to define a client by its name.
            var recommendationsRequest = new RecommendationsRequest(); // RecommendationsRequest | Request that should be populated to configure a recommendations API call made by the client.

            try
            {
                // Provide Recommendations AI functionality.
                PredictResults result = apiInstance.Predict(xGroupbyCustomerId, recommendationsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecommendationsAPIApi.Predict: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PredictWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Provide Recommendations AI functionality.
    ApiResponse<PredictResults> response = apiInstance.PredictWithHttpInfo(xGroupbyCustomerId, recommendationsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecommendationsAPIApi.PredictWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xGroupbyCustomerId** | **string** | Custom HTTP header which may contain tenant name. Used to define a client by its name. |  |
| **recommendationsRequest** | [**RecommendationsRequest**](RecommendationsRequest.md) | Request that should be populated to configure a recommendations API call made by the client. |  |

### Return type

[**PredictResults**](PredictResults.md)

### Authorization

[GroupByIncEmployee](../README.md#GroupByIncEmployee), [ClientKey](../README.md#ClientKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  * Content-Type - In responses, a Content-Type header provides the client with the actual content type of the returned content. <br>  * Date - The Date general HTTP header contains the date and time at which the message was originated. <br>  * Content-Length - The Content-Length header indicates the size of the message body, in bytes, sent to the recipient. <br>  * Connection - The Connection general header controls whether the network connection stays open after the current transaction finishes. If the value sent is keep-alive, the connection is persistent and not closed, allowing for subsequent requests to the same server to be done. <br>  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="predictv2"></a>
# **PredictV2**
> PredictResults PredictV2 (string xGroupbyCustomerId, RecommendationsRequest recommendationsRequest)

Provide Recommendations AI functionality.

Perform a recommendation request against the GroupBy Retail Recommendations API.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupByInc.RetailApi.Client.Api;
using GroupByInc.RetailApi.Client.Client;
using GroupByInc.RetailApi.Client.Model;

namespace Example
{
    public class PredictV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: GroupByIncEmployee
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: ClientKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RecommendationsAPIApi(config);
            var xGroupbyCustomerId = "xGroupbyCustomerId_example";  // string | Custom HTTP header which may contain tenant name. Used to define a client by its name.
            var recommendationsRequest = new RecommendationsRequest(); // RecommendationsRequest | Request that should be populated to configure a recommendations API call made by the client.

            try
            {
                // Provide Recommendations AI functionality.
                PredictResults result = apiInstance.PredictV2(xGroupbyCustomerId, recommendationsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecommendationsAPIApi.PredictV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PredictV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Provide Recommendations AI functionality.
    ApiResponse<PredictResults> response = apiInstance.PredictV2WithHttpInfo(xGroupbyCustomerId, recommendationsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecommendationsAPIApi.PredictV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xGroupbyCustomerId** | **string** | Custom HTTP header which may contain tenant name. Used to define a client by its name. |  |
| **recommendationsRequest** | [**RecommendationsRequest**](RecommendationsRequest.md) | Request that should be populated to configure a recommendations API call made by the client. |  |

### Return type

[**PredictResults**](PredictResults.md)

### Authorization

[GroupByIncEmployee](../README.md#GroupByIncEmployee), [ClientKey](../README.md#ClientKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  * Content-Type - In responses, a Content-Type header provides the client with the actual content type of the returned content. <br>  * Date - The Date general HTTP header contains the date and time at which the message was originated. <br>  * Content-Length - The Content-Length header indicates the size of the message body, in bytes, sent to the recipient. <br>  * Connection - The Connection general header controls whether the network connection stays open after the current transaction finishes. If the value sent is keep-alive, the connection is persistent and not closed, allowing for subsequent requests to the same server to be done. <br>  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

