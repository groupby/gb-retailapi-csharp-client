# GroupByInc.RetailApi.Client.Model.Request
Object which is represent autocomplete request and encapsulate all passed parameters. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Area** | **string** | Area i.e. &#39;Production&#39; Will not be used immediately. This will be useful when we eventually need to support a US area vs a Canada area. But this would require using the custom dataset instead of user-generated. | 
**Collection** | **string** | Name of the collection used to determine the retail backend to use. Usually it is name which is associated with retail project in command center (project configuration). | 
**SearchItems** | **int** | Completion max suggestions. The maximum allowed max suggestions is 20. | 
**Query** | **string** | String. Required. The query used to generate suggestions. The maximum number of allowed characters is 255. | 
**EnableAttributeSuggestion** | **bool** | Enable attribute suggestions, by setting the field enableAttributeSuggestion&#x3D;true in the API request. Then in response, there will be an additional field attributeResults to show direct match results on brands/categories  Note that attribute results directly come from the products we import and Google does not apply any cleaning on them.  | [optional] 
**ExtendedSuggestions** | **bool?** | Optional param which is define if extended suggestions will be returned in autocomplete response or not. Possibly values: true, false, not specified (If not specified default collection setting will be used).  | [optional] 
**ExtendedAttributes** | **List&lt;string&gt;** |     List with extended attributes which are would be returned in autocomplete response.     Requires extendedSuggestions to be enabled using search param or on collection layer.  | [optional] 
**VisitorId** | **string** | String. Not required field. A unique identifier for tracking visitors. For example, this could be implemented with an HTTP cookie, which should be able to uniquely identify a visitor on a single device. This unique identifier should not change if the visitor logs in or out of the website. The field must be a UTF-8 encoded string with a length limit of 128 characters. Otherwise, an INVALID_ARGUMENT error is returned.  | [optional] 
**Site** | **string** | Name of site filter. If not specified, the specified area&#39;s default site will be applied if configured in Command Center. To not use default specify empty value i.e.\&quot;\&quot;.  If the site doesn&#39;t exist then the search will execute without the site filter. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

