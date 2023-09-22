# GroupByInc.RetailApi.Client.Api.AutocompleteApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Autocompletesearch**](AutocompleteApi.md#autocompletesearch) | **GET** /api/request |  |

<a id="autocompletesearch"></a>
# **Autocompletesearch**
> SearchResults Autocompletesearch (string xGroupbyCustomerId, Identity identity, Merchandiser merchandiser, Request? request = null)



A simple request used to get completes the specified prefix with keyword suggestions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupByInc.RetailApi.Client.Api;
using GroupByInc.RetailApi.Client.Client;
using GroupByInc.RetailApi.Client.Model;

namespace Example
{
    public class AutocompletesearchExample
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

            var apiInstance = new AutocompleteApi(config);
            var xGroupbyCustomerId = "xGroupbyCustomerId_example";  // string | Header on incoming HTTP requests that is populated by the API gateway and indicates the customer ID.
            var identity = new Identity(); // Identity | 
            var merchandiser = new Merchandiser(); // Merchandiser | 
            var request = new Request?(); // Request? | Object which is represent autocomplete request and encapsulate all passed parameters.  (optional) 

            try
            {
                SearchResults result = apiInstance.Autocompletesearch(xGroupbyCustomerId, identity, merchandiser, request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutocompleteApi.Autocompletesearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AutocompletesearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SearchResults> response = apiInstance.AutocompletesearchWithHttpInfo(xGroupbyCustomerId, identity, merchandiser, request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutocompleteApi.AutocompletesearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xGroupbyCustomerId** | **string** | Header on incoming HTTP requests that is populated by the API gateway and indicates the customer ID. |  |
| **identity** | [**Identity**](Identity.md) |  |  |
| **merchandiser** | [**Merchandiser**](Merchandiser.md) |  |  |
| **request** | [**Request?**](Request?.md) | Object which is represent autocomplete request and encapsulate all passed parameters.  | [optional]  |

### Return type

[**SearchResults**](SearchResults.md)

### Authorization

[GroupByIncEmployee](../README.md#GroupByIncEmployee), [ClientKey](../README.md#ClientKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success response, returns result of operation. It is can be either empty body, object model or list of models. |  * Content-Type - In responses, a Content-Type header provides the client with the actual content type of the returned content. <br>  * Date - The Date general HTTP header contains the date and time at which the message was originated. <br>  * Content-Length - The Content-Length header indicates the size of the message body, in bytes, sent to the recipient. <br>  * Connection - The Connection general header controls whether the network connection stays open after the current transaction finishes. If the value sent is keep-alive, the connection is persistent and not closed, allowing for subsequent requests to the same server to be done. <br>  * Content-Encoding - The Content-Encoding representation header lists any encodings that have been applied to the representation (message payload), and in what order. This lets the recipient know how to decode the representation in order to obtain the original payload format. Content encoding is mainly used to compress the message data without losing information about the origin media type. <br>  |
| **400** | Client has made a bad request, usually a validation constraint has been violated. See the message for further information. |  * Content-Type - In responses, a Content-Type header provides the client with the actual content type of the returned content. <br>  * Date - The Date general HTTP header contains the date and time at which the message was originated. <br>  * Content-Length - The Content-Length header indicates the size of the message body, in bytes, sent to the recipient. <br>  * Connection - The Connection general header controls whether the network connection stays open after the current transaction finishes. If the value sent is keep-alive, the connection is persistent and not closed, allowing for subsequent requests to the same server to be done. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

