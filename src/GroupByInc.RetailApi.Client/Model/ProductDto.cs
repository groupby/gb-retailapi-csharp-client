/*
 * GroupBy Retail
 *
 * GroupBy Retail API
 *
 * The version of the OpenAPI document: 0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = GroupByInc.RetailApi.Client.Client.OpenAPIDateConverter;

namespace GroupByInc.RetailApi.Client.Model
{
    /// <summary>
    /// Product representation.
    /// </summary>
    [DataContract(Name = "ProductDto")]
    public partial class ProductDto : IEquatable<ProductDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductDto" /> class.
        /// </summary>
        /// <param name="name">Relative path to product in Google Retail system..</param>
        /// <param name="id">Product id in Google Retail system..</param>
        /// <param name="type">Product type. Possible values: PRIMARY, VARIANT. If the product has variant list and the request specifies the variantIds, requested variants will be the first in the response..</param>
        /// <param name="primaryProductId">Product ID that is primary in relation to the current one.</param>
        /// <param name="collectionMemberIds">The of the collection members when product type is COLLECTION.</param>
        /// <param name="gtin">Global Trade Item Number can be used by a company to uniquely identify all of its trade items.GTIN defines trade items as products or services that are priced, ordered or invoiced at any point in the supply chain..</param>
        /// <param name="categories">Product categories (array)..</param>
        /// <param name="title">Product title..</param>
        /// <param name="brands">Product brands..</param>
        /// <param name="description">Product description..</param>
        /// <param name="languageCode">Language of the title/description and other string attributes. Use language tags defined by [BCP 47][https://www.rfc-editor.org/rfc/bcp/bcp47.txt]. For product search this field is in use. It defaults to &#39;en-US&#39; if unset..</param>
        /// <param name="attributes">Highly encouraged. Extra product attributes to be included. For example, for products, this could include the store name, vendor, style, color, etc. These are very strong signals for recommendation model, thus we highly recommend providing the attributes here. Features that can take on one of a limited number of possible values. Two types of features can be set are: Textual features. some examples would be the brand/maker of a product, or country of a customer. Numerical features. Some examples would be the height/weight of a product, or age of a customer.  Max entries count: 200. Length limit of 128 characters..</param>
        /// <param name="tags">Product tags (array)..</param>
        /// <param name="priceInfo">priceInfo.</param>
        /// <param name="rating">rating.</param>
        /// <param name="availableTime">availableTime.</param>
        /// <param name="availability">The online availability of the product. Default to IN_STOCK.</param>
        /// <param name="availableQuantity">The available quantity of the item..</param>
        /// <param name="fulfillmentInfos">Fulfillment information, such as the store IDs for in-store pickup or region IDs for different shipping methods..</param>
        /// <param name="uri">Link to the appropriate product..</param>
        /// <param name="images">Product Image..</param>
        /// <param name="audience">audience.</param>
        /// <param name="colorInfo">colorInfo.</param>
        /// <param name="sizes">Product sizes (array)..</param>
        /// <param name="materials">The material of the product. For example, &#39;leather&#39;, &#39;wooden&#39;. A maximum of 20 values are allowed. Length limit of 128 characters.</param>
        /// <param name="patterns">The pattern or graphic print of the product. For example, &#39;striped&#39;, &#39;polka dot&#39;, &#39;paisley&#39;. A maximum of 20 values are allowed per product. Length limit of 128 characters..</param>
        /// <param name="conditions">The condition of the product. Strongly encouraged to use the standardvalues: &#39;new&#39;, &#39;refurbished&#39;, &#39;used&#39;. A maximum of 5 values are allowed per product. Length limit of 128 characters..</param>
        /// <param name="publishTime">publishTime.</param>
        /// <param name="retrievableFields">retrievableFields.</param>
        /// <param name="promotions">The promotions applied to the product. A maximum of 10 values are allowed per product..</param>
        /// <param name="variants">If the product has variant list and the request specifies the variantIds, requested variants will be the first in the response..</param>
        public ProductDto(string name = default(string), string id = default(string), string type = default(string), string primaryProductId = default(string), List<string> collectionMemberIds = default(List<string>), string gtin = default(string), List<string> categories = default(List<string>), string title = default(string), List<string> brands = default(List<string>), string description = default(string), string languageCode = default(string), Dictionary<string, ProductCustomAttribute> attributes = default(Dictionary<string, ProductCustomAttribute>), List<string> tags = default(List<string>), ProductDtoPriceInfo priceInfo = default(ProductDtoPriceInfo), ProductDtoRating rating = default(ProductDtoRating), ProductDtoAvailableTime availableTime = default(ProductDtoAvailableTime), string availability = default(string), int availableQuantity = default(int), List<FulfillmentInfo> fulfillmentInfos = default(List<FulfillmentInfo>), string uri = default(string), List<Image> images = default(List<Image>), ProductDtoAudience audience = default(ProductDtoAudience), ProductDtoColorInfo colorInfo = default(ProductDtoColorInfo), List<string> sizes = default(List<string>), List<string> materials = default(List<string>), List<string> patterns = default(List<string>), List<string> conditions = default(List<string>), ProductDtoPublishTime publishTime = default(ProductDtoPublishTime), ProductDtoRetrievableFields retrievableFields = default(ProductDtoRetrievableFields), List<Promotion> promotions = default(List<Promotion>), List<ProductDto> variants = default(List<ProductDto>))
        {
            this.Name = name;
            this.Id = id;
            this.Type = type;
            this.PrimaryProductId = primaryProductId;
            this.CollectionMemberIds = collectionMemberIds;
            this.Gtin = gtin;
            this.Categories = categories;
            this.Title = title;
            this.Brands = brands;
            this.Description = description;
            this.LanguageCode = languageCode;
            this.Attributes = attributes;
            this.Tags = tags;
            this.PriceInfo = priceInfo;
            this.Rating = rating;
            this.AvailableTime = availableTime;
            this.Availability = availability;
            this.AvailableQuantity = availableQuantity;
            this.FulfillmentInfos = fulfillmentInfos;
            this.Uri = uri;
            this.Images = images;
            this.Audience = audience;
            this.ColorInfo = colorInfo;
            this.Sizes = sizes;
            this.Materials = materials;
            this.Patterns = patterns;
            this.Conditions = conditions;
            this.PublishTime = publishTime;
            this.RetrievableFields = retrievableFields;
            this.Promotions = promotions;
            this.Variants = variants;
        }

        /// <summary>
        /// Relative path to product in Google Retail system.
        /// </summary>
        /// <value>Relative path to product in Google Retail system.</value>
        /// <example>projects/123456789012/locations/global/catalogs/default_catalog/branches/1/products/12345678901</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Product id in Google Retail system.
        /// </summary>
        /// <value>Product id in Google Retail system.</value>
        /// <example>12345678901</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Product type. Possible values: PRIMARY, VARIANT. If the product has variant list and the request specifies the variantIds, requested variants will be the first in the response.
        /// </summary>
        /// <value>Product type. Possible values: PRIMARY, VARIANT. If the product has variant list and the request specifies the variantIds, requested variants will be the first in the response.</value>
        /// <example>VARIANT, PRIMARY</example>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Product ID that is primary in relation to the current one
        /// </summary>
        /// <value>Product ID that is primary in relation to the current one</value>
        /// <example>1234567</example>
        [DataMember(Name = "primaryProductId", EmitDefaultValue = false)]
        public string PrimaryProductId { get; set; }

        /// <summary>
        /// The of the collection members when product type is COLLECTION
        /// </summary>
        /// <value>The of the collection members when product type is COLLECTION</value>
        /// <example>5</example>
        [DataMember(Name = "collectionMemberIds", EmitDefaultValue = false)]
        public List<string> CollectionMemberIds { get; set; }

        /// <summary>
        /// Global Trade Item Number can be used by a company to uniquely identify all of its trade items.GTIN defines trade items as products or services that are priced, ordered or invoiced at any point in the supply chain.
        /// </summary>
        /// <value>Global Trade Item Number can be used by a company to uniquely identify all of its trade items.GTIN defines trade items as products or services that are priced, ordered or invoiced at any point in the supply chain.</value>
        /// <example>10614141999993</example>
        [DataMember(Name = "gtin", EmitDefaultValue = false)]
        public string Gtin { get; set; }

        /// <summary>
        /// Product categories (array).
        /// </summary>
        /// <value>Product categories (array).</value>
        /// <example>Men, Men &gt; Shoes</example>
        [DataMember(Name = "categories", EmitDefaultValue = false)]
        public List<string> Categories { get; set; }

        /// <summary>
        /// Product title.
        /// </summary>
        /// <value>Product title.</value>
        /// <example>Eastland Shoe Men&#39;s Yarmouth Boat Shoes</example>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Product brands.
        /// </summary>
        /// <value>Product brands.</value>
        /// <example>Eastland Shoe</example>
        [DataMember(Name = "brands", EmitDefaultValue = false)]
        public List<string> Brands { get; set; }

        /// <summary>
        /// Product description.
        /// </summary>
        /// <value>Product description.</value>
        /// <example>Eastland Shoe recalls an age of timeless casual fashion with these leather boat shoes.</example>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Language of the title/description and other string attributes. Use language tags defined by [BCP 47][https://www.rfc-editor.org/rfc/bcp/bcp47.txt]. For product search this field is in use. It defaults to &#39;en-US&#39; if unset.
        /// </summary>
        /// <value>Language of the title/description and other string attributes. Use language tags defined by [BCP 47][https://www.rfc-editor.org/rfc/bcp/bcp47.txt]. For product search this field is in use. It defaults to &#39;en-US&#39; if unset.</value>
        /// <example>en-US</example>
        [DataMember(Name = "languageCode", EmitDefaultValue = false)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// Highly encouraged. Extra product attributes to be included. For example, for products, this could include the store name, vendor, style, color, etc. These are very strong signals for recommendation model, thus we highly recommend providing the attributes here. Features that can take on one of a limited number of possible values. Two types of features can be set are: Textual features. some examples would be the brand/maker of a product, or country of a customer. Numerical features. Some examples would be the height/weight of a product, or age of a customer.  Max entries count: 200. Length limit of 128 characters.
        /// </summary>
        /// <value>Highly encouraged. Extra product attributes to be included. For example, for products, this could include the store name, vendor, style, color, etc. These are very strong signals for recommendation model, thus we highly recommend providing the attributes here. Features that can take on one of a limited number of possible values. Two types of features can be set are: Textual features. some examples would be the brand/maker of a product, or country of a customer. Numerical features. Some examples would be the height/weight of a product, or age of a customer.  Max entries count: 200. Length limit of 128 characters.</value>
        /// <example>{ &#39;vendor&#39;: {&#39;text&#39;: [&#39;vendor123&#39;, &#39;vendor456&#39;]}, &#39;lengths_cm&#39;: {&#39;numbers&#39;:[2.3, 15.4]}, &#39;heights_cm&#39;: {&#39;numbers&#39;:[8.1, 6.4]}}</example>
        [DataMember(Name = "attributes", EmitDefaultValue = false)]
        public Dictionary<string, ProductCustomAttribute> Attributes { get; set; }

        /// <summary>
        /// Product tags (array).
        /// </summary>
        /// <value>Product tags (array).</value>
        /// <example>Any string.</example>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets PriceInfo
        /// </summary>
        [DataMember(Name = "priceInfo", EmitDefaultValue = false)]
        public ProductDtoPriceInfo PriceInfo { get; set; }

        /// <summary>
        /// Gets or Sets Rating
        /// </summary>
        [DataMember(Name = "rating", EmitDefaultValue = false)]
        public ProductDtoRating Rating { get; set; }

        /// <summary>
        /// Gets or Sets AvailableTime
        /// </summary>
        [DataMember(Name = "availableTime", EmitDefaultValue = false)]
        public ProductDtoAvailableTime AvailableTime { get; set; }

        /// <summary>
        /// The online availability of the product. Default to IN_STOCK
        /// </summary>
        /// <value>The online availability of the product. Default to IN_STOCK</value>
        /// <example>IN_STOCK</example>
        [DataMember(Name = "availability", EmitDefaultValue = false)]
        public string Availability { get; set; }

        /// <summary>
        /// The available quantity of the item.
        /// </summary>
        /// <value>The available quantity of the item.</value>
        /// <example>10</example>
        [DataMember(Name = "availableQuantity", EmitDefaultValue = false)]
        public int AvailableQuantity { get; set; }

        /// <summary>
        /// Fulfillment information, such as the store IDs for in-store pickup or region IDs for different shipping methods.
        /// </summary>
        /// <value>Fulfillment information, such as the store IDs for in-store pickup or region IDs for different shipping methods.</value>
        [DataMember(Name = "fulfillmentInfos", EmitDefaultValue = false)]
        public List<FulfillmentInfo> FulfillmentInfos { get; set; }

        /// <summary>
        /// Link to the appropriate product.
        /// </summary>
        /// <value>Link to the appropriate product.</value>
        /// <example>https://s4r-apparel.groupby.cloud/product/Eastland-Shoe-Men&#39;s-Yarmouth-Boat-Shoes/2725066/94352309386</example>
        [DataMember(Name = "uri", EmitDefaultValue = false)]
        public string Uri { get; set; }

        /// <summary>
        /// Product Image.
        /// </summary>
        /// <value>Product Image.</value>
        [DataMember(Name = "images", EmitDefaultValue = false)]
        public List<Image> Images { get; set; }

        /// <summary>
        /// Gets or Sets Audience
        /// </summary>
        [DataMember(Name = "audience", EmitDefaultValue = false)]
        public ProductDtoAudience Audience { get; set; }

        /// <summary>
        /// Gets or Sets ColorInfo
        /// </summary>
        [DataMember(Name = "colorInfo", EmitDefaultValue = false)]
        public ProductDtoColorInfo ColorInfo { get; set; }

        /// <summary>
        /// Product sizes (array).
        /// </summary>
        /// <value>Product sizes (array).</value>
        /// <example>8.5</example>
        [DataMember(Name = "sizes", EmitDefaultValue = false)]
        public List<string> Sizes { get; set; }

        /// <summary>
        /// The material of the product. For example, &#39;leather&#39;, &#39;wooden&#39;. A maximum of 20 values are allowed. Length limit of 128 characters
        /// </summary>
        /// <value>The material of the product. For example, &#39;leather&#39;, &#39;wooden&#39;. A maximum of 20 values are allowed. Length limit of 128 characters</value>
        /// <example>leather</example>
        [DataMember(Name = "materials", EmitDefaultValue = false)]
        public List<string> Materials { get; set; }

        /// <summary>
        /// The pattern or graphic print of the product. For example, &#39;striped&#39;, &#39;polka dot&#39;, &#39;paisley&#39;. A maximum of 20 values are allowed per product. Length limit of 128 characters.
        /// </summary>
        /// <value>The pattern or graphic print of the product. For example, &#39;striped&#39;, &#39;polka dot&#39;, &#39;paisley&#39;. A maximum of 20 values are allowed per product. Length limit of 128 characters.</value>
        /// <example>paisley</example>
        [DataMember(Name = "patterns", EmitDefaultValue = false)]
        public List<string> Patterns { get; set; }

        /// <summary>
        /// The condition of the product. Strongly encouraged to use the standardvalues: &#39;new&#39;, &#39;refurbished&#39;, &#39;used&#39;. A maximum of 5 values are allowed per product. Length limit of 128 characters.
        /// </summary>
        /// <value>The condition of the product. Strongly encouraged to use the standardvalues: &#39;new&#39;, &#39;refurbished&#39;, &#39;used&#39;. A maximum of 5 values are allowed per product. Length limit of 128 characters.</value>
        /// <example>new</example>
        [DataMember(Name = "conditions", EmitDefaultValue = false)]
        public List<string> Conditions { get; set; }

        /// <summary>
        /// Gets or Sets PublishTime
        /// </summary>
        [DataMember(Name = "publishTime", EmitDefaultValue = false)]
        public ProductDtoPublishTime PublishTime { get; set; }

        /// <summary>
        /// Gets or Sets RetrievableFields
        /// </summary>
        [DataMember(Name = "retrievableFields", EmitDefaultValue = false)]
        public ProductDtoRetrievableFields RetrievableFields { get; set; }

        /// <summary>
        /// The promotions applied to the product. A maximum of 10 values are allowed per product.
        /// </summary>
        /// <value>The promotions applied to the product. A maximum of 10 values are allowed per product.</value>
        [DataMember(Name = "promotions", EmitDefaultValue = false)]
        public List<Promotion> Promotions { get; set; }

        /// <summary>
        /// If the product has variant list and the request specifies the variantIds, requested variants will be the first in the response.
        /// </summary>
        /// <value>If the product has variant list and the request specifies the variantIds, requested variants will be the first in the response.</value>
        [DataMember(Name = "variants", EmitDefaultValue = false)]
        public List<ProductDto> Variants { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  PrimaryProductId: ").Append(PrimaryProductId).Append("\n");
            sb.Append("  CollectionMemberIds: ").Append(CollectionMemberIds).Append("\n");
            sb.Append("  Gtin: ").Append(Gtin).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Brands: ").Append(Brands).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  PriceInfo: ").Append(PriceInfo).Append("\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  AvailableTime: ").Append(AvailableTime).Append("\n");
            sb.Append("  Availability: ").Append(Availability).Append("\n");
            sb.Append("  AvailableQuantity: ").Append(AvailableQuantity).Append("\n");
            sb.Append("  FulfillmentInfos: ").Append(FulfillmentInfos).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            sb.Append("  Audience: ").Append(Audience).Append("\n");
            sb.Append("  ColorInfo: ").Append(ColorInfo).Append("\n");
            sb.Append("  Sizes: ").Append(Sizes).Append("\n");
            sb.Append("  Materials: ").Append(Materials).Append("\n");
            sb.Append("  Patterns: ").Append(Patterns).Append("\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
            sb.Append("  PublishTime: ").Append(PublishTime).Append("\n");
            sb.Append("  RetrievableFields: ").Append(RetrievableFields).Append("\n");
            sb.Append("  Promotions: ").Append(Promotions).Append("\n");
            sb.Append("  Variants: ").Append(Variants).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProductDto);
        }

        /// <summary>
        /// Returns true if ProductDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.PrimaryProductId == input.PrimaryProductId ||
                    (this.PrimaryProductId != null &&
                    this.PrimaryProductId.Equals(input.PrimaryProductId))
                ) && 
                (
                    this.CollectionMemberIds == input.CollectionMemberIds ||
                    this.CollectionMemberIds != null &&
                    input.CollectionMemberIds != null &&
                    this.CollectionMemberIds.SequenceEqual(input.CollectionMemberIds)
                ) && 
                (
                    this.Gtin == input.Gtin ||
                    (this.Gtin != null &&
                    this.Gtin.Equals(input.Gtin))
                ) && 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Brands == input.Brands ||
                    this.Brands != null &&
                    input.Brands != null &&
                    this.Brands.SequenceEqual(input.Brands)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.LanguageCode == input.LanguageCode ||
                    (this.LanguageCode != null &&
                    this.LanguageCode.Equals(input.LanguageCode))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    input.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.PriceInfo == input.PriceInfo ||
                    (this.PriceInfo != null &&
                    this.PriceInfo.Equals(input.PriceInfo))
                ) && 
                (
                    this.Rating == input.Rating ||
                    (this.Rating != null &&
                    this.Rating.Equals(input.Rating))
                ) && 
                (
                    this.AvailableTime == input.AvailableTime ||
                    (this.AvailableTime != null &&
                    this.AvailableTime.Equals(input.AvailableTime))
                ) && 
                (
                    this.Availability == input.Availability ||
                    (this.Availability != null &&
                    this.Availability.Equals(input.Availability))
                ) && 
                (
                    this.AvailableQuantity == input.AvailableQuantity ||
                    this.AvailableQuantity.Equals(input.AvailableQuantity)
                ) && 
                (
                    this.FulfillmentInfos == input.FulfillmentInfos ||
                    this.FulfillmentInfos != null &&
                    input.FulfillmentInfos != null &&
                    this.FulfillmentInfos.SequenceEqual(input.FulfillmentInfos)
                ) && 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.Images == input.Images ||
                    this.Images != null &&
                    input.Images != null &&
                    this.Images.SequenceEqual(input.Images)
                ) && 
                (
                    this.Audience == input.Audience ||
                    (this.Audience != null &&
                    this.Audience.Equals(input.Audience))
                ) && 
                (
                    this.ColorInfo == input.ColorInfo ||
                    (this.ColorInfo != null &&
                    this.ColorInfo.Equals(input.ColorInfo))
                ) && 
                (
                    this.Sizes == input.Sizes ||
                    this.Sizes != null &&
                    input.Sizes != null &&
                    this.Sizes.SequenceEqual(input.Sizes)
                ) && 
                (
                    this.Materials == input.Materials ||
                    this.Materials != null &&
                    input.Materials != null &&
                    this.Materials.SequenceEqual(input.Materials)
                ) && 
                (
                    this.Patterns == input.Patterns ||
                    this.Patterns != null &&
                    input.Patterns != null &&
                    this.Patterns.SequenceEqual(input.Patterns)
                ) && 
                (
                    this.Conditions == input.Conditions ||
                    this.Conditions != null &&
                    input.Conditions != null &&
                    this.Conditions.SequenceEqual(input.Conditions)
                ) && 
                (
                    this.PublishTime == input.PublishTime ||
                    (this.PublishTime != null &&
                    this.PublishTime.Equals(input.PublishTime))
                ) && 
                (
                    this.RetrievableFields == input.RetrievableFields ||
                    (this.RetrievableFields != null &&
                    this.RetrievableFields.Equals(input.RetrievableFields))
                ) && 
                (
                    this.Promotions == input.Promotions ||
                    this.Promotions != null &&
                    input.Promotions != null &&
                    this.Promotions.SequenceEqual(input.Promotions)
                ) && 
                (
                    this.Variants == input.Variants ||
                    this.Variants != null &&
                    input.Variants != null &&
                    this.Variants.SequenceEqual(input.Variants)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.PrimaryProductId != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryProductId.GetHashCode();
                }
                if (this.CollectionMemberIds != null)
                {
                    hashCode = (hashCode * 59) + this.CollectionMemberIds.GetHashCode();
                }
                if (this.Gtin != null)
                {
                    hashCode = (hashCode * 59) + this.Gtin.GetHashCode();
                }
                if (this.Categories != null)
                {
                    hashCode = (hashCode * 59) + this.Categories.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Brands != null)
                {
                    hashCode = (hashCode * 59) + this.Brands.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.LanguageCode != null)
                {
                    hashCode = (hashCode * 59) + this.LanguageCode.GetHashCode();
                }
                if (this.Attributes != null)
                {
                    hashCode = (hashCode * 59) + this.Attributes.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.PriceInfo != null)
                {
                    hashCode = (hashCode * 59) + this.PriceInfo.GetHashCode();
                }
                if (this.Rating != null)
                {
                    hashCode = (hashCode * 59) + this.Rating.GetHashCode();
                }
                if (this.AvailableTime != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableTime.GetHashCode();
                }
                if (this.Availability != null)
                {
                    hashCode = (hashCode * 59) + this.Availability.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AvailableQuantity.GetHashCode();
                if (this.FulfillmentInfos != null)
                {
                    hashCode = (hashCode * 59) + this.FulfillmentInfos.GetHashCode();
                }
                if (this.Uri != null)
                {
                    hashCode = (hashCode * 59) + this.Uri.GetHashCode();
                }
                if (this.Images != null)
                {
                    hashCode = (hashCode * 59) + this.Images.GetHashCode();
                }
                if (this.Audience != null)
                {
                    hashCode = (hashCode * 59) + this.Audience.GetHashCode();
                }
                if (this.ColorInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ColorInfo.GetHashCode();
                }
                if (this.Sizes != null)
                {
                    hashCode = (hashCode * 59) + this.Sizes.GetHashCode();
                }
                if (this.Materials != null)
                {
                    hashCode = (hashCode * 59) + this.Materials.GetHashCode();
                }
                if (this.Patterns != null)
                {
                    hashCode = (hashCode * 59) + this.Patterns.GetHashCode();
                }
                if (this.Conditions != null)
                {
                    hashCode = (hashCode * 59) + this.Conditions.GetHashCode();
                }
                if (this.PublishTime != null)
                {
                    hashCode = (hashCode * 59) + this.PublishTime.GetHashCode();
                }
                if (this.RetrievableFields != null)
                {
                    hashCode = (hashCode * 59) + this.RetrievableFields.GetHashCode();
                }
                if (this.Promotions != null)
                {
                    hashCode = (hashCode * 59) + this.Promotions.GetHashCode();
                }
                if (this.Variants != null)
                {
                    hashCode = (hashCode * 59) + this.Variants.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}