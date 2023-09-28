/*
 * GroupBy Retail
 *
 * GroupBy Retail API
 *
 * The version of the OpenAPI document: 0.0.0
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
    /// SearchResultsStats
    /// </summary>
    [DataContract(Name = "SearchResults_stats")]
    public partial class SearchResultsStats : IEquatable<SearchResultsStats>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultsStats" /> class.
        /// </summary>
        /// <param name="searchCount">Count of suggested sentences in response..</param>
        /// <param name="autocompleteResponse">Time in milliseconds taken by autocomplete service to handle request and send response..</param>
        /// <param name="extendedAttributesCount">Count of extended attributes in autocomplete response..</param>
        /// <param name="extendedAttributesResponse">Time in milliseconds taken by application to enrich response with extended attributes..</param>
        public SearchResultsStats(int searchCount = default(int), long autocompleteResponse = default(long), int extendedAttributesCount = default(int), long extendedAttributesResponse = default(long))
        {
            this.SearchCount = searchCount;
            this.AutocompleteResponse = autocompleteResponse;
            this.ExtendedAttributesCount = extendedAttributesCount;
            this.ExtendedAttributesResponse = extendedAttributesResponse;
        }

        /// <summary>
        /// Count of suggested sentences in response.
        /// </summary>
        /// <value>Count of suggested sentences in response.</value>
        [DataMember(Name = "searchCount", EmitDefaultValue = false)]
        public int SearchCount { get; set; }

        /// <summary>
        /// Time in milliseconds taken by autocomplete service to handle request and send response.
        /// </summary>
        /// <value>Time in milliseconds taken by autocomplete service to handle request and send response.</value>
        [DataMember(Name = "autocompleteResponse", EmitDefaultValue = false)]
        public long AutocompleteResponse { get; set; }

        /// <summary>
        /// Count of extended attributes in autocomplete response.
        /// </summary>
        /// <value>Count of extended attributes in autocomplete response.</value>
        [DataMember(Name = "extendedAttributesCount", EmitDefaultValue = false)]
        public int ExtendedAttributesCount { get; set; }

        /// <summary>
        /// Time in milliseconds taken by application to enrich response with extended attributes.
        /// </summary>
        /// <value>Time in milliseconds taken by application to enrich response with extended attributes.</value>
        [DataMember(Name = "extendedAttributesResponse", EmitDefaultValue = false)]
        public long ExtendedAttributesResponse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchResultsStats {\n");
            sb.Append("  SearchCount: ").Append(SearchCount).Append("\n");
            sb.Append("  AutocompleteResponse: ").Append(AutocompleteResponse).Append("\n");
            sb.Append("  ExtendedAttributesCount: ").Append(ExtendedAttributesCount).Append("\n");
            sb.Append("  ExtendedAttributesResponse: ").Append(ExtendedAttributesResponse).Append("\n");
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
            return this.Equals(input as SearchResultsStats);
        }

        /// <summary>
        /// Returns true if SearchResultsStats instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchResultsStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchResultsStats input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SearchCount == input.SearchCount ||
                    this.SearchCount.Equals(input.SearchCount)
                ) && 
                (
                    this.AutocompleteResponse == input.AutocompleteResponse ||
                    this.AutocompleteResponse.Equals(input.AutocompleteResponse)
                ) && 
                (
                    this.ExtendedAttributesCount == input.ExtendedAttributesCount ||
                    this.ExtendedAttributesCount.Equals(input.ExtendedAttributesCount)
                ) && 
                (
                    this.ExtendedAttributesResponse == input.ExtendedAttributesResponse ||
                    this.ExtendedAttributesResponse.Equals(input.ExtendedAttributesResponse)
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
                hashCode = (hashCode * 59) + this.SearchCount.GetHashCode();
                hashCode = (hashCode * 59) + this.AutocompleteResponse.GetHashCode();
                hashCode = (hashCode * 59) + this.ExtendedAttributesCount.GetHashCode();
                hashCode = (hashCode * 59) + this.ExtendedAttributesResponse.GetHashCode();
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
