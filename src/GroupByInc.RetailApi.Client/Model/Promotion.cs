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
    /// The promotions applied to the product. A maximum of 10 values are allowed per product.
    /// </summary>
    [DataContract(Name = "Promotion")]
    public partial class Promotion : IEquatable<Promotion>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Promotion" /> class.
        /// </summary>
        /// <param name="promotionId">ID of the promotion. For example, &#39;free gift&#39;. Length limit of 128 characters..</param>
        public Promotion(string promotionId = default(string))
        {
            this.PromotionId = promotionId;
        }

        /// <summary>
        /// ID of the promotion. For example, &#39;free gift&#39;. Length limit of 128 characters.
        /// </summary>
        /// <value>ID of the promotion. For example, &#39;free gift&#39;. Length limit of 128 characters.</value>
        /// <example>id0LikeThis</example>
        [DataMember(Name = "promotionId", EmitDefaultValue = false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Promotion {\n");
            sb.Append("  PromotionId: ").Append(PromotionId).Append("\n");
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
            return this.Equals(input as Promotion);
        }

        /// <summary>
        /// Returns true if Promotion instances are equal
        /// </summary>
        /// <param name="input">Instance of Promotion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Promotion input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PromotionId == input.PromotionId ||
                    (this.PromotionId != null &&
                    this.PromotionId.Equals(input.PromotionId))
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
                if (this.PromotionId != null)
                {
                    hashCode = (hashCode * 59) + this.PromotionId.GetHashCode();
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
