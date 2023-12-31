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
    /// A floating point interval.
    /// </summary>
    [DataContract(Name = "Interval")]
    public partial class Interval : IEquatable<Interval>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Interval" /> class.
        /// </summary>
        /// <param name="minimum">Inclusive lower bound. The lower bound of the interval. If neither of the min fields (minimum or exclusiveMinimum) are set, then the lower bound is negative infinity. This field must be not larger than maximum or exclusiveMaximum..</param>
        /// <param name="exclusiveMinimum">Exclusive lower bound. The lower bound of the interval. If neither of the min fields (minimum or exclusiveMinimum) are set, then the lower bound is negative infinity. This field must be not larger than maximum or exclusiveMaximum..</param>
        /// <param name="maximum">Inclusive upper bound. The upper bound of the interval. If neither of the max fields are set, then the upper bound is positive infinity. This field must be not smaller than minimum or exclusiveMinimum..</param>
        /// <param name="exclusiveMaximum">Exclusive upper bound. The upper bound of the interval. If neither of the max fields are set, then the upper bound is positive infinity. This field must be not smaller than minimum or exclusiveMinimum..</param>
        public Interval(double minimum = default(double), double exclusiveMinimum = default(double), double maximum = default(double), double exclusiveMaximum = default(double))
        {
            this.Minimum = minimum;
            this.ExclusiveMinimum = exclusiveMinimum;
            this.Maximum = maximum;
            this.ExclusiveMaximum = exclusiveMaximum;
        }

        /// <summary>
        /// Inclusive lower bound. The lower bound of the interval. If neither of the min fields (minimum or exclusiveMinimum) are set, then the lower bound is negative infinity. This field must be not larger than maximum or exclusiveMaximum.
        /// </summary>
        /// <value>Inclusive lower bound. The lower bound of the interval. If neither of the min fields (minimum or exclusiveMinimum) are set, then the lower bound is negative infinity. This field must be not larger than maximum or exclusiveMaximum.</value>
        /// <example>1</example>
        [DataMember(Name = "minimum", EmitDefaultValue = false)]
        public double Minimum { get; set; }

        /// <summary>
        /// Exclusive lower bound. The lower bound of the interval. If neither of the min fields (minimum or exclusiveMinimum) are set, then the lower bound is negative infinity. This field must be not larger than maximum or exclusiveMaximum.
        /// </summary>
        /// <value>Exclusive lower bound. The lower bound of the interval. If neither of the min fields (minimum or exclusiveMinimum) are set, then the lower bound is negative infinity. This field must be not larger than maximum or exclusiveMaximum.</value>
        /// <example>1</example>
        [DataMember(Name = "exclusiveMinimum", EmitDefaultValue = false)]
        public double ExclusiveMinimum { get; set; }

        /// <summary>
        /// Inclusive upper bound. The upper bound of the interval. If neither of the max fields are set, then the upper bound is positive infinity. This field must be not smaller than minimum or exclusiveMinimum.
        /// </summary>
        /// <value>Inclusive upper bound. The upper bound of the interval. If neither of the max fields are set, then the upper bound is positive infinity. This field must be not smaller than minimum or exclusiveMinimum.</value>
        /// <example>1</example>
        [DataMember(Name = "maximum", EmitDefaultValue = false)]
        public double Maximum { get; set; }

        /// <summary>
        /// Exclusive upper bound. The upper bound of the interval. If neither of the max fields are set, then the upper bound is positive infinity. This field must be not smaller than minimum or exclusiveMinimum.
        /// </summary>
        /// <value>Exclusive upper bound. The upper bound of the interval. If neither of the max fields are set, then the upper bound is positive infinity. This field must be not smaller than minimum or exclusiveMinimum.</value>
        /// <example>1</example>
        [DataMember(Name = "exclusiveMaximum", EmitDefaultValue = false)]
        public double ExclusiveMaximum { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Interval {\n");
            sb.Append("  Minimum: ").Append(Minimum).Append("\n");
            sb.Append("  ExclusiveMinimum: ").Append(ExclusiveMinimum).Append("\n");
            sb.Append("  Maximum: ").Append(Maximum).Append("\n");
            sb.Append("  ExclusiveMaximum: ").Append(ExclusiveMaximum).Append("\n");
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
            return this.Equals(input as Interval);
        }

        /// <summary>
        /// Returns true if Interval instances are equal
        /// </summary>
        /// <param name="input">Instance of Interval to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Interval input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Minimum == input.Minimum ||
                    this.Minimum.Equals(input.Minimum)
                ) && 
                (
                    this.ExclusiveMinimum == input.ExclusiveMinimum ||
                    this.ExclusiveMinimum.Equals(input.ExclusiveMinimum)
                ) && 
                (
                    this.Maximum == input.Maximum ||
                    this.Maximum.Equals(input.Maximum)
                ) && 
                (
                    this.ExclusiveMaximum == input.ExclusiveMaximum ||
                    this.ExclusiveMaximum.Equals(input.ExclusiveMaximum)
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
                hashCode = (hashCode * 59) + this.Minimum.GetHashCode();
                hashCode = (hashCode * 59) + this.ExclusiveMinimum.GetHashCode();
                hashCode = (hashCode * 59) + this.Maximum.GetHashCode();
                hashCode = (hashCode * 59) + this.ExclusiveMaximum.GetHashCode();
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
