# GroupByInc.RetailApi.Client.Model.RecommendationsRequest
Object to wrap all recommendation request configs.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Collection** | **string** |  | 
**VisitorId** | **string** |  | [optional] 
**Limit** | **string** |  | [optional] 
**PageSize** | **string** |  | [optional] 
**EventType** | **string** |  | [optional] 
**LoginId** | **string** |  | [optional] 
**ProductID** | **List&lt;string&gt;** |  | [optional] 
**Fields** | **List&lt;string&gt;** |  | [optional] 
**Filters** | [**List&lt;Filter&gt;**](Filter.md) |  | [optional] 
**RawFilter** | **string** |  | [optional] 
**Placement** | **string** |  | [optional] 
**Name** | **string** |  | [optional] 
**StrictFiltering** | **bool?** | The default is true. If strictFiltering true only products that are within the scope of the filter specified. If false, relax the filtering so that the response may contain other products that are outside the scope of the filtering. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

