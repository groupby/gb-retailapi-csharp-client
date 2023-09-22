# GroupByInc.RetailApi.Client.Model.SelectedRefinementDto
Refinement the shopper has selected for filtering.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NavigationName** | **string** | The name of the navigation the refinement is for. | 
**Type** | **NavigationTypeDto** |  | 
**Value** | **string** | Value of selected refinement, if type is value. | [optional] 
**Low** | **double** | The lowest end or value of the range, if applicable. | [optional] 
**High** | **double** | The highest end or value of the range, if applicable. | [optional] 
**Source** | **string** | Field which is indicated that it is dynamic navigation. | [optional] 
**Or** | **bool** | Navigation multiselect. Indicate that it is possibly to select more than one navigation value due to search request. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

