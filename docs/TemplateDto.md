# GroupByInc.RetailApi.Client.Model.TemplateDto
Template to assist the front end application in rendering the UI. Currently only the triggered rule name will be included, or the 'default' template name to indicate no rule was triggered. This is to mainly compatibility with the Searchandiser API and the addition of templates in the future. Template is search agnostic and do not affect search request or result. Templated selected only by triggered rule.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the template. | [optional] 
**RuleName** | **string** | Name of the rule which may have triggered. | [optional] 
**TriggerSet** | [**TemplateDtoTriggerSet**](TemplateDtoTriggerSet.md) |  | [optional] 
**Zones** | [**List&lt;ZoneDto&gt;**](ZoneDto.md) | Zones for linked template. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

