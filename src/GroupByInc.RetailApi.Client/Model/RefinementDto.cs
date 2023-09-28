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
    /// Refinement value or range in the navigation.
    /// </summary>
    [DataContract(Name = "RefinementDto")]
    public partial class RefinementDto : IEquatable<RefinementDto>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public NavigationTypeDto Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RefinementDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RefinementDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RefinementDto" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="count">Number of products which match this refinement value or range..</param>
        /// <param name="value">Value of the refinement..</param>
        /// <param name="low">Lower bound of the refinement range..</param>
        /// <param name="high">Upper bound  of the refinement range..</param>
        public RefinementDto(NavigationTypeDto type = default(NavigationTypeDto), long count = default(long), string value = default(string), double low = default(double), double high = default(double))
        {
            this.Type = type;
            this.Count = count;
            this.Value = value;
            this.Low = low;
            this.High = high;
        }

        /// <summary>
        /// Number of products which match this refinement value or range.
        /// </summary>
        /// <value>Number of products which match this refinement value or range.</value>
        /// <example>189</example>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public long Count { get; set; }

        /// <summary>
        /// Value of the refinement.
        /// </summary>
        /// <value>Value of the refinement.</value>
        /// <example>Surf&#39;s Up</example>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Lower bound of the refinement range.
        /// </summary>
        /// <value>Lower bound of the refinement range.</value>
        /// <example>50</example>
        [DataMember(Name = "low", EmitDefaultValue = false)]
        public double Low { get; set; }

        /// <summary>
        /// Upper bound  of the refinement range.
        /// </summary>
        /// <value>Upper bound  of the refinement range.</value>
        /// <example>100</example>
        [DataMember(Name = "high", EmitDefaultValue = false)]
        public double High { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RefinementDto {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as RefinementDto);
        }

        /// <summary>
        /// Returns true if RefinementDto instances are equal
        /// </summary>
        /// <param name="input">Instance of RefinementDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RefinementDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Count == input.Count ||
                    this.Count.Equals(input.Count)
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                hashCode = (hashCode * 59) + this.Count.GetHashCode();
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
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
