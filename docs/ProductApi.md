# GroupByInc.RetailApi.Client.Api.ProductApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetByProductIds**](ProductApi.md#getbyproductids) | **GET** /api/search/product | Provided product search functionality |

<a id="getbyproductids"></a>
# **GetByProductIds**
> ProductDto GetByProductIds (string collection, string productId, string xGroupbyCustomerId, List<string>? variantIds = null)

Provided product search functionality

Perform a product search against the GroupBy Retail Search API.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupByInc.RetailApi.Client.Api;
using GroupByInc.RetailApi.Client.Client;
using GroupByInc.RetailApi.Client.Model;

namespace Example
{
    public class GetByProductIdsExample
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

            var apiInstance = new ProductApi(config);
            var collection = "collection_example";  // string | Collection name
            var productId = "productId_example";  // string | Product ID which need to be search
            var xGroupbyCustomerId = "xGroupbyCustomerId_example";  // string | Required. This parameter will extract from header X-Groupby-Customer-Id. May contain tenant name. Used to define a                           client by its name.
            var variantIds = new List<string>?(); // List<string>? | Not required. If the product has variant list and the request specifies the variantIds, requested variants will be the                           first in the response. (optional) 

            try
            {
                // Provided product search functionality
                ProductDto result = apiInstance.GetByProductIds(collection, productId, xGroupbyCustomerId, variantIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.GetByProductIds: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetByProductIdsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Provided product search functionality
    ApiResponse<ProductDto> response = apiInstance.GetByProductIdsWithHttpInfo(collection, productId, xGroupbyCustomerId, variantIds);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.GetByProductIdsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collection** | **string** | Collection name |  |
| **productId** | **string** | Product ID which need to be search |  |
| **xGroupbyCustomerId** | **string** | Required. This parameter will extract from header X-Groupby-Customer-Id. May contain tenant name. Used to define a                           client by its name. |  |
| **variantIds** | [**List&lt;string&gt;?**](string.md) | Not required. If the product has variant list and the request specifies the variantIds, requested variants will be the                           first in the response. | [optional]  |

### Return type

[**ProductDto**](ProductDto.md)

### Authorization

[GroupByIncEmployee](../README.md#GroupByIncEmployee), [ClientKey](../README.md#ClientKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Product is found. |  * Content-Type - In responses, a Content-Type header provides the client with the actual content type of the returned content. <br>  * Date - The Date general HTTP header contains the date and time at which the message was originated. <br>  * Content-Length - The Content-Length header indicates the size of the message body, in bytes, sent to the recipient. <br>  * Connection - The Connection general header controls whether the network connection stays open after the current transaction finishes. If the value sent is keep-alive, the connection is persistent and not closed, allowing for subsequent requests to the same server to be done. <br>  |
| **400** | Client has made a bad request, usually a validation constraint has been violated. See the message for further information. |  -  |
| **403** | Client is not authorized to perform the requested operation. |  -  |
| **500** | There was an internal error processing the search request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

