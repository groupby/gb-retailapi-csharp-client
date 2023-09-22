# GroupByInc.RetailApi.Client.Model.ProductDto
Product representation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Relative path to product in Google Retail system. | [optional] 
**Id** | **string** | Product id in Google Retail system. | [optional] 
**Type** | **string** | Product type. Possible values: PRIMARY, VARIANT. If the product has variant list and the request specifies the variantIds, requested variants will be the first in the response. | [optional] 
**PrimaryProductId** | **string** | Product ID that is primary in relation to the current one | [optional] 
**CollectionMemberIds** | **List&lt;string&gt;** | The of the collection members when product type is COLLECTION | [optional] 
**Gtin** | **string** | Global Trade Item Number can be used by a company to uniquely identify all of its trade items.GTIN defines trade items as products or services that are priced, ordered or invoiced at any point in the supply chain. | [optional] 
**Categories** | **List&lt;string&gt;** | Product categories (array). | [optional] 
**Title** | **string** | Product title. | [optional] 
**Brands** | **List&lt;string&gt;** | Product brands. | [optional] 
**Description** | **string** | Product description. | [optional] 
**LanguageCode** | **string** | Language of the title/description and other string attributes. Use language tags defined by [BCP 47][https://www.rfc-editor.org/rfc/bcp/bcp47.txt]. For product search this field is in use. It defaults to &#39;en-US&#39; if unset. | [optional] 
**Attributes** | [**Dictionary&lt;string, ProductCustomAttribute&gt;**](ProductCustomAttribute.md) | Highly encouraged. Extra product attributes to be included. For example, for products, this could include the store name, vendor, style, color, etc. These are very strong signals for recommendation model, thus we highly recommend providing the attributes here. Features that can take on one of a limited number of possible values. Two types of features can be set are: Textual features. some examples would be the brand/maker of a product, or country of a customer. Numerical features. Some examples would be the height/weight of a product, or age of a customer.  Max entries count: 200. Length limit of 128 characters. | [optional] 
**Tags** | **List&lt;string&gt;** | Product tags (array). | [optional] 
**PriceInfo** | [**ProductDtoPriceInfo**](ProductDtoPriceInfo.md) |  | [optional] 
**Rating** | [**ProductDtoRating**](ProductDtoRating.md) |  | [optional] 
**AvailableTime** | [**ProductDtoAvailableTime**](ProductDtoAvailableTime.md) |  | [optional] 
**Availability** | **string** | The online availability of the product. Default to IN_STOCK | [optional] 
**AvailableQuantity** | **int** | The available quantity of the item. | [optional] 
**FulfillmentInfos** | [**List&lt;FulfillmentInfo&gt;**](FulfillmentInfo.md) | Fulfillment information, such as the store IDs for in-store pickup or region IDs for different shipping methods. | [optional] 
**Uri** | **string** | Link to the appropriate product. | [optional] 
**Images** | [**List&lt;Image&gt;**](Image.md) | Product Image. | [optional] 
**Audience** | [**ProductDtoAudience**](ProductDtoAudience.md) |  | [optional] 
**ColorInfo** | [**ProductDtoColorInfo**](ProductDtoColorInfo.md) |  | [optional] 
**Sizes** | **List&lt;string&gt;** | Product sizes (array). | [optional] 
**Materials** | **List&lt;string&gt;** | The material of the product. For example, &#39;leather&#39;, &#39;wooden&#39;. A maximum of 20 values are allowed. Length limit of 128 characters | [optional] 
**Patterns** | **List&lt;string&gt;** | The pattern or graphic print of the product. For example, &#39;striped&#39;, &#39;polka dot&#39;, &#39;paisley&#39;. A maximum of 20 values are allowed per product. Length limit of 128 characters. | [optional] 
**Conditions** | **List&lt;string&gt;** | The condition of the product. Strongly encouraged to use the standardvalues: &#39;new&#39;, &#39;refurbished&#39;, &#39;used&#39;. A maximum of 5 values are allowed per product. Length limit of 128 characters. | [optional] 
**PublishTime** | [**ProductDtoPublishTime**](ProductDtoPublishTime.md) |  | [optional] 
**RetrievableFields** | [**ProductDtoRetrievableFields**](ProductDtoRetrievableFields.md) |  | [optional] 
**Promotions** | [**List&lt;Promotion&gt;**](Promotion.md) | The promotions applied to the product. A maximum of 10 values are allowed per product. | [optional] 
**Variants** | [**List&lt;ProductDto&gt;**](ProductDto.md) | If the product has variant list and the request specifies the variantIds, requested variants will be the first in the response. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

