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
    /// PriceInfoPriceRange
    /// </summary>
    [DataContract(Name = "PriceInfo_priceRange")]
    public partial class PriceInfoPriceRange : IEquatable<PriceInfoPriceRange>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PriceInfoPriceRange" /> class.
        /// </summary>
        /// <param name="price">price.</param>
        /// <param name="originalPrice">originalPrice.</param>
        public PriceInfoPriceRange(PriceInfoPriceRangePrice price = default(PriceInfoPriceRangePrice), PriceInfoPriceRangeOriginalPrice originalPrice = default(PriceInfoPriceRangeOriginalPrice))
        {
            this.Price = price;
            this.OriginalPrice = originalPrice;
        }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public PriceInfoPriceRangePrice Price { get; set; }

        /// <summary>
        /// Gets or Sets OriginalPrice
        /// </summary>
        [DataMember(Name = "originalPrice", EmitDefaultValue = false)]
        public PriceInfoPriceRangeOriginalPrice OriginalPrice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PriceInfoPriceRange {\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  OriginalPrice: ").Append(OriginalPrice).Append("\n");
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
            return this.Equals(input as PriceInfoPriceRange);
        }

        /// <summary>
        /// Returns true if PriceInfoPriceRange instances are equal
        /// </summary>
        /// <param name="input">Instance of PriceInfoPriceRange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PriceInfoPriceRange input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.OriginalPrice == input.OriginalPrice ||
                    (this.OriginalPrice != null &&
                    this.OriginalPrice.Equals(input.OriginalPrice))
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
                if (this.Price != null)
                {
                    hashCode = (hashCode * 59) + this.Price.GetHashCode();
                }
                if (this.OriginalPrice != null)
                {
                    hashCode = (hashCode * 59) + this.OriginalPrice.GetHashCode();
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
