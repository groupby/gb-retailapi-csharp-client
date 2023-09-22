# GroupByInc.RetailApi.Client.Model.SearchResults
SAYT response. Contains list of suggestions ad base response information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Stats** | [**SearchResultsStats**](SearchResultsStats.md) |  | [optional] 
**SearchTerms** | [**List&lt;SearchTerms&gt;**](SearchTerms.md) |  | 
**ExtendedAttributes** | **Dictionary&lt;string, List&lt;string&gt;&gt;** | Map with extended attributes which are returned in autocomplete response.  | [optional] 
**AttributeResults** | [**Dictionary&lt;string, AttributeSuggestion&gt;**](AttributeSuggestion.md) | SAYT response attributes. Contains list of direct matching attributes. | [optional] 
**SiteFilter** | **string** | SiteFilter object used with request. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

