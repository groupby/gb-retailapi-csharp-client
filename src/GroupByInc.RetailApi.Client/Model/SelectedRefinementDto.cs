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
    /// Refinement the shopper has selected for filtering.
    /// </summary>
    [DataContract(Name = "SelectedRefinementDto")]
    public partial class SelectedRefinementDto : IEquatable<SelectedRefinementDto>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public NavigationTypeDto Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectedRefinementDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SelectedRefinementDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectedRefinementDto" /> class.
        /// </summary>
        /// <param name="navigationName">The name of the navigation the refinement is for. (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="value">Value of selected refinement, if type is value..</param>
        /// <param name="low">The lowest end or value of the range, if applicable..</param>
        /// <param name="high">The highest end or value of the range, if applicable..</param>
        /// <param name="source">Field which is indicated that it is dynamic navigation..</param>
        /// <param name="or">Navigation multiselect. Indicate that it is possibly to select more than one navigation value due to search request..</param>
        public SelectedRefinementDto(string navigationName = default(string), NavigationTypeDto type = default(NavigationTypeDto), string value = default(string), double low = default(double), double high = default(double), string source = default(string), bool or = default(bool))
        {
            // to ensure "navigationName" is required (not null)
            if (navigationName == null)
            {
                throw new ArgumentNullException("navigationName is a required property for SelectedRefinementDto and cannot be null");
            }
            this.NavigationName = navigationName;
            this.Type = type;
            this.Value = value;
            this.Low = low;
            this.High = high;
            this.Source = source;
            this.Or = or;
        }

        /// <summary>
        /// The name of the navigation the refinement is for.
        /// </summary>
        /// <value>The name of the navigation the refinement is for.</value>
        /// <example>brands</example>
        [DataMember(Name = "navigationName", IsRequired = true, EmitDefaultValue = true)]
        public string NavigationName { get; set; }

        /// <summary>
        /// Value of selected refinement, if type is value.
        /// </summary>
        /// <value>Value of selected refinement, if type is value.</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// The lowest end or value of the range, if applicable.
        /// </summary>
        /// <value>The lowest end or value of the range, if applicable.</value>
        /// <example>50</example>
        [DataMember(Name = "low", EmitDefaultValue = false)]
        public double Low { get; set; }

        /// <summary>
        /// The highest end or value of the range, if applicable.
        /// </summary>
        /// <value>The highest end or value of the range, if applicable.</value>
        /// <example>100</example>
        [DataMember(Name = "high", EmitDefaultValue = false)]
        public double High { get; set; }

        /// <summary>
        /// Field which is indicated that it is dynamic navigation.
        /// </summary>
        /// <value>Field which is indicated that it is dynamic navigation.</value>
        /// <example>Dynamic</example>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public string Source { get; set; }

        /// <summary>
        /// Navigation multiselect. Indicate that it is possibly to select more than one navigation value due to search request.
        /// </summary>
        /// <value>Navigation multiselect. Indicate that it is possibly to select more than one navigation value due to search request.</value>
        /// <example>false</example>
        [DataMember(Name = "or", EmitDefaultValue = true)]
        public bool Or { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SelectedRefinementDto {\n");
            sb.Append("  NavigationName: ").Append(NavigationName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Low: ").Append(Low).Append("\n");
            sb.Append("  High: ").Append(High).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Or: ").Append(Or).Append("\n");
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
            return this.Equals(input as SelectedRefinementDto);
        }

        /// <summary>
        /// Returns true if SelectedRefinementDto instances are equal
        /// </summary>
        /// <param name="input">Instance of SelectedRefinementDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SelectedRefinementDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NavigationName == input.NavigationName ||
                    (this.NavigationName != null &&
                    this.NavigationName.Equals(input.NavigationName))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Or == input.Or ||
                    this.Or.Equals(input.Or)
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
                if (this.NavigationName != null)
                {
                    hashCode = (hashCode * 59) + this.NavigationName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Low.GetHashCode();
                hashCode = (hashCode * 59) + this.High.GetHashCode();
                if (this.Source != null)
                {
                    hashCode = (hashCode * 59) + this.Source.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Or.GetHashCode();
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
