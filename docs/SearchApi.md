# GroupByInc.RetailApi.Client.Api.SearchApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**FacetSearch**](SearchApi.md#facetsearch) | **POST** /api/search/facet | Provided search functionality |
| [**Search**](SearchApi.md#search) | **POST** /api/search | Provided search functionality |

<a id="facetsearch"></a>
# **FacetSearch**
> FacetSearchResponseDto FacetSearch (string xGroupbyCustomerId, FacetSearchRequestDto facetSearchRequestDto)

Provided search functionality

Perform a facet search against the GroupBy Retail Search API.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupByInc.RetailApi.Client.Api;
using GroupByInc.RetailApi.Client.Client;
using GroupByInc.RetailApi.Client.Model;

namespace Example
{
    public class FacetSearchExample
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

            var apiInstance = new SearchApi(config);
            var xGroupbyCustomerId = "xGroupbyCustomerId_example";  // string | Custom HTTP header which may contain tenant name. Used to define a client by its name.
            var facetSearchRequestDto = new FacetSearchRequestDto(); // FacetSearchRequestDto | Request that should be populated to configure a search API call, made by the client on behalf of a shopper. Contains original request and information about facet for which extra keys requested.

            try
            {
                // Provided search functionality
                FacetSearchResponseDto result = apiInstance.FacetSearch(xGroupbyCustomerId, facetSearchRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.FacetSearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FacetSearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Provided search functionality
    ApiResponse<FacetSearchResponseDto> response = apiInstance.FacetSearchWithHttpInfo(xGroupbyCustomerId, facetSearchRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchApi.FacetSearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xGroupbyCustomerId** | **string** | Custom HTTP header which may contain tenant name. Used to define a client by its name. |  |
| **facetSearchRequestDto** | [**FacetSearchRequestDto**](FacetSearchRequestDto.md) | Request that should be populated to configure a search API call, made by the client on behalf of a shopper. Contains original request and information about facet for which extra keys requested. |  |

### Return type

[**FacetSearchResponseDto**](FacetSearchResponseDto.md)

### Authorization

[GroupByIncEmployee](../README.md#GroupByIncEmployee), [ClientKey](../README.md#ClientKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful facet search response. Contains original request and navigation with relevant facet keys. |  * Content-Type - In responses, a Content-Type header provides the client with the actual content type of the returned content. <br>  * Date - The Date general HTTP header contains the date and time at which the message was originated. <br>  * Content-Length - The Content-Length header indicates the size of the message body, in bytes, sent to the recipient. <br>  * Connection - The Connection general header controls whether the network connection stays open after the current transaction finishes. If the value sent is keep-alive, the connection is persistent and not closed, allowing for subsequent requests to the same server to be done. <br>  |
| **400** | Client has made a bad request, usually a validation constraint has been violated. See the message for further information. |  -  |
| **403** | Client is not authorized to perform the requested operation. |  -  |
| **500** | There was an internal error processing the search request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="search"></a>
# **Search**
> SearchResponseDto Search (string xGroupbyCustomerId, SearchRequestDto searchRequestDto)

Provided search functionality

Perform a search against the GroupBy Retail Search API.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupByInc.RetailApi.Client.Api;
using GroupByInc.RetailApi.Client.Client;
using GroupByInc.RetailApi.Client.Model;

namespace Example
{
    public class SearchExample
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

            var apiInstance = new SearchApi(config);
            var xGroupbyCustomerId = "xGroupbyCustomerId_example";  // string | Custom HTTP header which may contain tenant name. Used to define a client by its name.
            var searchRequestDto = new SearchRequestDto(); // SearchRequestDto | Request that should be populated to configure a search API call, made by the client on behalf of a shopper.

            try
            {
                // Provided search functionality
                SearchResponseDto result = apiInstance.Search(xGroupbyCustomerId, searchRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.Search: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Provided search functionality
    ApiResponse<SearchResponseDto> response = apiInstance.SearchWithHttpInfo(xGroupbyCustomerId, searchRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchApi.SearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xGroupbyCustomerId** | **string** | Custom HTTP header which may contain tenant name. Used to define a client by its name. |  |
| **searchRequestDto** | [**SearchRequestDto**](SearchRequestDto.md) | Request that should be populated to configure a search API call, made by the client on behalf of a shopper. |  |

### Return type

[**SearchResponseDto**](SearchResponseDto.md)

### Authorization

[GroupByIncEmployee](../README.md#GroupByIncEmployee), [ClientKey](../README.md#ClientKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Search was accepted and a normal response could be generated. |  * Content-Type - In responses, a Content-Type header provides the client with the actual content type of the returned content. <br>  * Date - The Date general HTTP header contains the date and time at which the message was originated. <br>  * Content-Length - The Content-Length header indicates the size of the message body, in bytes, sent to the recipient. <br>  * Connection - The Connection general header controls whether the network connection stays open after the current transaction finishes. If the value sent is keep-alive, the connection is persistent and not closed, allowing for subsequent requests to the same server to be done. <br>  |
| **400** | Client has made a bad request, usually a validation constraint has been violated. See the message for further information. |  -  |
| **403** | Client is not authorized to perform the requested operation. |  -  |
| **500** | There was an internal error processing the search request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

