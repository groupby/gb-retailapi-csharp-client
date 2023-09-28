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
    /// FilterParameter
    /// </summary>
    [DataContract(Name = "FilterParameter")]
    public partial class FilterParameter : IEquatable<FilterParameter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterParameter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FilterParameter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterParameter" /> class.
        /// </summary>
        /// <param name="field">field (required).</param>
        /// <param name="value">value.</param>
        /// <param name="exclude">exclude (required).</param>
        /// <param name="derivedFromProduct">derivedFromProduct (required).</param>
        public FilterParameter(string field = default(string), string value = default(string), bool exclude = default(bool), bool derivedFromProduct = default(bool))
        {
            // to ensure "field" is required (not null)
            if (field == null)
            {
                throw new ArgumentNullException("field is a required property for FilterParameter and cannot be null");
            }
            this.Field = field;
            this.Exclude = exclude;
            this.DerivedFromProduct = derivedFromProduct;
            this.Value = value;
        }

        /// <summary>
        /// Gets or Sets Field
        /// </summary>
        [DataMember(Name = "field", IsRequired = true, EmitDefaultValue = true)]
        public string Field { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets Exclude
        /// </summary>
        [DataMember(Name = "exclude", IsRequired = true, EmitDefaultValue = true)]
        public bool Exclude { get; set; }

        /// <summary>
        /// Gets or Sets DerivedFromProduct
        /// </summary>
        [DataMember(Name = "derivedFromProduct", IsRequired = true, EmitDefaultValue = true)]
        public bool DerivedFromProduct { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FilterParameter {\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Exclude: ").Append(Exclude).Append("\n");
            sb.Append("  DerivedFromProduct: ").Append(DerivedFromProduct).Append("\n");
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
            return this.Equals(input as FilterParameter);
        }

        /// <summary>
        /// Returns true if FilterParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of FilterParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilterParameter input)
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
                    this.Exclude == input.Exclude ||
                    this.Exclude.Equals(input.Exclude)
                ) && 
                (
                    this.DerivedFromProduct == input.DerivedFromProduct ||
                    this.DerivedFromProduct.Equals(input.DerivedFromProduct)
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
                hashCode = (hashCode * 59) + this.Exclude.GetHashCode();
                hashCode = (hashCode * 59) + this.DerivedFromProduct.GetHashCode();
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
            // Field (string) minLength
            if (this.Field != null && this.Field.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Field, length must be greater than 1.", new [] { "Field" });
            }

            yield break;
        }
    }

}
