# GroupByInc.RetailApi.Client.Model.ProductCustomAttribute
A custom attribute that is not explicitly modeled in product.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Text** | **List&lt;string&gt;** | The textual values of this custom attribute. At most 400 values are allowed. Empty values are not allowed. Length limit of 256 characters. Exactly one of text or numbers should be set. | [optional] 
**Numbers** | **List&lt;double&gt;** | The numerical values of this custom attribute. At most 400 values are allowed. Exactly one of text or numbers should be set. | [optional] 
**Searchable** | **bool** | If true, custom attribute values are searchable by text queries in. search. Only set if type text set. | [optional] 
**Indexable** | **bool** | If true, custom attribute values are indexed, so that it can be filtered, faceted or boosted in search. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

