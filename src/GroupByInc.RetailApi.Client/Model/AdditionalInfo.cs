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
    /// Object which is contains brands and categories associated with this suggestion.
    /// </summary>
    [DataContract(Name = "AdditionalInfo")]
    public partial class AdditionalInfo : IEquatable<AdditionalInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdditionalInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalInfo" /> class.
        /// </summary>
        /// <param name="brands">brands (required).</param>
        /// <param name="categories">categories (required).</param>
        public AdditionalInfo(List<string> brands = default(List<string>), List<string> categories = default(List<string>))
        {
            // to ensure "brands" is required (not null)
            if (brands == null)
            {
                throw new ArgumentNullException("brands is a required property for AdditionalInfo and cannot be null");
            }
            this.Brands = brands;
            // to ensure "categories" is required (not null)
            if (categories == null)
            {
                throw new ArgumentNullException("categories is a required property for AdditionalInfo and cannot be null");
            }
            this.Categories = categories;
        }

        /// <summary>
        /// Gets or Sets Brands
        /// </summary>
        [DataMember(Name = "brands", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Brands { get; set; }

        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name = "categories", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Categories { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdditionalInfo {\n");
            sb.Append("  Brands: ").Append(Brands).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
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
            return this.Equals(input as AdditionalInfo);
        }

        /// <summary>
        /// Returns true if AdditionalInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Brands == input.Brands ||
                    this.Brands != null &&
                    input.Brands != null &&
                    this.Brands.SequenceEqual(input.Brands)
                ) && 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
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
                if (this.Brands != null)
                {
                    hashCode = (hashCode * 59) + this.Brands.GetHashCode();
                }
                if (this.Categories != null)
                {
                    hashCode = (hashCode * 59) + this.Categories.GetHashCode();
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
