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
    /// Range
    /// </summary>
    [DataContract(Name = "Range")]
    public partial class Range : IEquatable<Range>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Range" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Range() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Range" /> class.
        /// </summary>
        /// <param name="low">low (required).</param>
        /// <param name="high">high (required).</param>
        public Range(double low = default(double), double high = default(double))
        {
            this.Low = low;
            this.High = high;
        }

        /// <summary>
        /// Gets or Sets Low
        /// </summary>
        [DataMember(Name = "low", IsRequired = true, EmitDefaultValue = true)]
        public double Low { get; set; }

        /// <summary>
        /// Gets or Sets High
        /// </summary>
        [DataMember(Name = "high", IsRequired = true, EmitDefaultValue = true)]
        public double High { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Range {\n");
            sb.Append("  Low: ").Append(Low).Append("\n");
            sb.Append("  High: ").Append(High).Append("\n");
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
            return this.Equals(input as Range);
        }

        /// <summary>
        /// Returns true if Range instances are equal
        /// </summary>
        /// <param name="input">Instance of Range to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Range input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Low == input.Low ||
                    this.Low.Equals(input.Low)
                ) && 
                (
                    this.High == input.High ||
                    this.High.Equals(input.High)
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
                hashCode = (hashCode * 59) + this.Low.GetHashCode();
                hashCode = (hashCode * 59) + this.High.GetHashCode();
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