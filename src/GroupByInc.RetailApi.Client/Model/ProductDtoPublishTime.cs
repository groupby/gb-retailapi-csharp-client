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
    /// ProductDtoPublishTime
    /// </summary>
    [DataContract(Name = "ProductDto_publishTime")]
    public partial class ProductDtoPublishTime : IEquatable<ProductDtoPublishTime>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductDtoPublishTime" /> class.
        /// </summary>
        /// <param name="seconds">Timestamp seconds..</param>
        /// <param name="nanos">Timestamp nanos..</param>
        public ProductDtoPublishTime(long seconds = default(long), int nanos = default(int))
        {
            this.Seconds = seconds;
            this.Nanos = nanos;
        }

        /// <summary>
        /// Timestamp seconds.
        /// </summary>
        /// <value>Timestamp seconds.</value>
        /// <example>100</example>
        [DataMember(Name = "seconds", EmitDefaultValue = false)]
        public long Seconds { get; set; }

        /// <summary>
        /// Timestamp nanos.
        /// </summary>
        /// <value>Timestamp nanos.</value>
        /// <example>100</example>
        [DataMember(Name = "nanos", EmitDefaultValue = false)]
        public int Nanos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductDtoPublishTime {\n");
            sb.Append("  Seconds: ").Append(Seconds).Append("\n");
            sb.Append("  Nanos: ").Append(Nanos).Append("\n");
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
            return this.Equals(input as ProductDtoPublishTime);
        }

        /// <summary>
        /// Returns true if ProductDtoPublishTime instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductDtoPublishTime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductDtoPublishTime input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Seconds == input.Seconds ||
                    this.Seconds.Equals(input.Seconds)
                ) && 
                (
                    this.Nanos == input.Nanos ||
                    this.Nanos.Equals(input.Nanos)
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
                hashCode = (hashCode * 59) + this.Seconds.GetHashCode();
                hashCode = (hashCode * 59) + this.Nanos.GetHashCode();
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
