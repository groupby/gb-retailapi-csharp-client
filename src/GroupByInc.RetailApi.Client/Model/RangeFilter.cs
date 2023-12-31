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
    /// RangeFilter
    /// </summary>
    [DataContract(Name = "RangeFilter")]
    public partial class RangeFilter : IEquatable<RangeFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RangeFilter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RangeFilter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RangeFilter" /> class.
        /// </summary>
        /// <param name="field">Field the range applies to. (required).</param>
        /// <param name="range">Range of values the field value can be. (required).</param>
        public RangeFilter(string field = default(string), Object range = default(Object))
        {
            // to ensure "field" is required (not null)
            if (field == null)
            {
                throw new ArgumentNullException("field is a required property for RangeFilter and cannot be null");
            }
            this.Field = field;
            // to ensure "range" is required (not null)
            if (range == null)
            {
                throw new ArgumentNullException("range is a required property for RangeFilter and cannot be null");
            }
            this.Range = range;
        }

        /// <summary>
        /// Field the range applies to.
        /// </summary>
        /// <value>Field the range applies to.</value>
        [DataMember(Name = "field", IsRequired = true, EmitDefaultValue = true)]
        public string Field { get; set; }

        /// <summary>
        /// Range of values the field value can be.
        /// </summary>
        /// <value>Range of values the field value can be.</value>
        [DataMember(Name = "range", IsRequired = true, EmitDefaultValue = true)]
        public Object Range { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RangeFilter {\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Range: ").Append(Range).Append("\n");
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
            return this.Equals(input as RangeFilter);
        }

        /// <summary>
        /// Returns true if RangeFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of RangeFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RangeFilter input)
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
                    this.Range == input.Range ||
                    (this.Range != null &&
                    this.Range.Equals(input.Range))
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
                if (this.Range != null)
                {
                    hashCode = (hashCode * 59) + this.Range.GetHashCode();
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
