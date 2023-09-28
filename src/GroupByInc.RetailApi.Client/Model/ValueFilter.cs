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
    /// ValueFilter
    /// </summary>
    [DataContract(Name = "ValueFilter")]
    public partial class ValueFilter : IEquatable<ValueFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueFilter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ValueFilter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueFilter" /> class.
        /// </summary>
        /// <param name="field">Field the value applies to. (required).</param>
        /// <param name="value">Value to filter on. (required).</param>
        /// <param name="numberValue">Numeric value to filter on. (required).</param>
        /// <param name="exclude">Describing whether the filter is negated or not: color that is NOT red. (required).</param>
        /// <param name="type">Determine which field we need to use - value if &#39;TEXTUAL&#39; type or numberValue if &#39;NUMERIC&#39; type. (required).</param>
        public ValueFilter(string field = default(string), string value = default(string), double numberValue = default(double), bool exclude = default(bool), Object type = default(Object))
        {
            // to ensure "field" is required (not null)
            if (field == null)
            {
                throw new ArgumentNullException("field is a required property for ValueFilter and cannot be null");
            }
            this.Field = field;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for ValueFilter and cannot be null");
            }
            this.Value = value;
            this.NumberValue = numberValue;
            this.Exclude = exclude;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for ValueFilter and cannot be null");
            }
            this.Type = type;
        }

        /// <summary>
        /// Field the value applies to.
        /// </summary>
        /// <value>Field the value applies to.</value>
        [DataMember(Name = "field", IsRequired = true, EmitDefaultValue = true)]
        public string Field { get; set; }

        /// <summary>
        /// Value to filter on.
        /// </summary>
        /// <value>Value to filter on.</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Numeric value to filter on.
        /// </summary>
        /// <value>Numeric value to filter on.</value>
        [DataMember(Name = "numberValue", IsRequired = true, EmitDefaultValue = true)]
        public double NumberValue { get; set; }

        /// <summary>
        /// Describing whether the filter is negated or not: color that is NOT red.
        /// </summary>
        /// <value>Describing whether the filter is negated or not: color that is NOT red.</value>
        [DataMember(Name = "exclude", IsRequired = true, EmitDefaultValue = true)]
        public bool Exclude { get; set; }

        /// <summary>
        /// Determine which field we need to use - value if &#39;TEXTUAL&#39; type or numberValue if &#39;NUMERIC&#39; type.
        /// </summary>
        /// <value>Determine which field we need to use - value if &#39;TEXTUAL&#39; type or numberValue if &#39;NUMERIC&#39; type.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public Object Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ValueFilter {\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  NumberValue: ").Append(NumberValue).Append("\n");
            sb.Append("  Exclude: ").Append(Exclude).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as ValueFilter);
        }

        /// <summary>
        /// Returns true if ValueFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of ValueFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValueFilter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Field == input.Field ||
                    (this.Field != null &&
                    this.Field.Equals(input.Field))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.NumberValue == input.NumberValue ||
                    this.NumberValue.Equals(input.NumberValue)
                ) && 
                (
                    this.Exclude == input.Exclude ||
                    this.Exclude.Equals(input.Exclude)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Field != null)
                {
                    hashCode = (hashCode * 59) + this.Field.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NumberValue.GetHashCode();
                hashCode = (hashCode * 59) + this.Exclude.GetHashCode();
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
