# GroupByInc.RetailApi.Client.Model.SearchResponseDto
Response of calling the search API, including various elements of the original request context, matching records and general metadata relating to the results.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for the search. | [optional] 
**Area** | **string** | Area Id the search was performed in. | [optional] 
**Query** | **string** | Original search query. | [optional] 
**CorrectedQuery** | **string** | Search query after any changes/corrections are done by the engine. | [optional] 
**BiasingProfile** | **string** | Name of the biasing profile which was used to bias products in the search results. | [optional] 
**BiasingProfileAppliedId** | **int** | Id of the biasing profile which was used to bias products in the search results. | [optional] 
**Filter** | **string** |  | 
**OriginalRequest** | [**SearchRequestDto**](SearchRequestDto.md) |  | 
**Records** | [**List&lt;RecordDto&gt;**](RecordDto.md) | The list of records that match the search. | [optional] 
**TotalRecordCount** | **long** | The total number of products that match the search. If all products were filtered out on S4R site equals to 0. | [optional] 
**Metadata** | [**SearchMetadataDto**](SearchMetadataDto.md) |  | 
**PageInfo** | [**PageInfoDto**](PageInfoDto.md) |  | 
**AvailableNavigation** | [**List&lt;NavigationDto&gt;**](NavigationDto.md) |  | 
**SelectedNavigation** | [**List&lt;NavigationDto&gt;**](NavigationDto.md) |  | 
**Redirect** | **string** | URL to which the merchandiser should redirect the shopper to. | [optional] 
**Experiments** | [**List&lt;Experiment&gt;**](Experiment.md) |  | 
**Template** | [**TemplateDto**](TemplateDto.md) |  | 
**Empty** | **bool** | True if the search yielded no results, otherwise false. | [optional] 
**SiteParams** | [**List&lt;Metadata&gt;**](Metadata.md) |  | 
**Debug** | [**DebugDto**](DebugDto.md) |  | 
**Warnings** | **List&lt;string&gt;** | Warning messages containing information about invalid products, etc. | [optional] 
**IncludeExpandedResults** | **bool** | When a shopper uses an ambiguous or a multi-word search phrase, they can get an empty response. After turning on include expanded results, Retail Search analyzes the request and returns the expanded list of products based on the parsed search query. For example, if you search \&quot;Google Pixel 5\&quot; without query expansion, you might only get \&quot;google_pixel_5\&quot; in the result. With query expansion, you might get \&quot;google_pixel_4a_with_5g\&quot;, \&quot;google_pixel_4a\&quot; and \&quot;google_pixel_5_case\&quot; as well.The default value is configured in the tenant settings or true if there is no such setting | [optional] 
**FacetLimit** | **int** | Maximum of facet values that should be returned for this facet. If not specified, defaults to 20. The maximum allowed value is 300. Values above 300 will be coerced to 300.  If this field is negative, an INVALID_ARGUMENT is returned.  This limit (300) is configured on Google side, but Google have an ability to change it for specific project.  | [optional] 
**RedirectMetadata** | [**List&lt;Metadata&gt;**](Metadata.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

