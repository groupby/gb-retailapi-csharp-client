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
    /// TriggerSet
    /// </summary>
    [DataContract(Name = "TriggerSet")]
    public partial class TriggerSet : IEquatable<TriggerSet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerSet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TriggerSet() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerSet" /> class.
        /// </summary>
        /// <param name="queryPatternTriggers">Query pattern triggers. (required).</param>
        /// <param name="selectedRefinementTriggers">Selected refinement triggers. (required).</param>
        /// <param name="customParameterTriggers">Custom parameter triggers. (required).</param>
        public TriggerSet(List<QueryPatternTrigger> queryPatternTriggers = default(List<QueryPatternTrigger>), List<SelectedRefinementTrigger> selectedRefinementTriggers = default(List<SelectedRefinementTrigger>), List<CustomParameterTrigger> customParameterTriggers = default(List<CustomParameterTrigger>))
        {
            // to ensure "queryPatternTriggers" is required (not null)
            if (queryPatternTriggers == null)
            {
                throw new ArgumentNullException("queryPatternTriggers is a required property for TriggerSet and cannot be null");
            }
            this.QueryPatternTriggers = queryPatternTriggers;
            // to ensure "selectedRefinementTriggers" is required (not null)
            if (selectedRefinementTriggers == null)
            {
                throw new ArgumentNullException("selectedRefinementTriggers is a required property for TriggerSet and cannot be null");
            }
            this.SelectedRefinementTriggers = selectedRefinementTriggers;
            // to ensure "customParameterTriggers" is required (not null)
            if (customParameterTriggers == null)
            {
                throw new ArgumentNullException("customParameterTriggers is a required property for TriggerSet and cannot be null");
            }
            this.CustomParameterTriggers = customParameterTriggers;
        }

        /// <summary>
        /// Query pattern triggers.
        /// </summary>
        /// <value>Query pattern triggers.</value>
        [DataMember(Name = "queryPatternTriggers", IsRequired = true, EmitDefaultValue = true)]
        public List<QueryPatternTrigger> QueryPatternTriggers { get; set; }

        /// <summary>
        /// Selected refinement triggers.
        /// </summary>
        /// <value>Selected refinement triggers.</value>
        [DataMember(Name = "selectedRefinementTriggers", IsRequired = true, EmitDefaultValue = true)]
        public List<SelectedRefinementTrigger> SelectedRefinementTriggers { get; set; }

        /// <summary>
        /// Custom parameter triggers.
        /// </summary>
        /// <value>Custom parameter triggers.</value>
        [DataMember(Name = "customParameterTriggers", IsRequired = true, EmitDefaultValue = true)]
        public List<CustomParameterTrigger> CustomParameterTriggers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TriggerSet {\n");
            sb.Append("  QueryPatternTriggers: ").Append(QueryPatternTriggers).Append("\n");
            sb.Append("  SelectedRefinementTriggers: ").Append(SelectedRefinementTriggers).Append("\n");
            sb.Append("  CustomParameterTriggers: ").Append(CustomParameterTriggers).Append("\n");
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
            return this.Equals(input as TriggerSet);
        }

        /// <summary>
        /// Returns true if TriggerSet instances are equal
        /// </summary>
        /// <param name="input">Instance of TriggerSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TriggerSet input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.QueryPatternTriggers == input.QueryPatternTriggers ||
                    this.QueryPatternTriggers != null &&
                    input.QueryPatternTriggers != null &&
                    this.QueryPatternTriggers.SequenceEqual(input.QueryPatternTriggers)
                ) && 
                (
                    this.SelectedRefinementTriggers == input.SelectedRefinementTriggers ||
                    this.SelectedRefinementTriggers != null &&
                    input.SelectedRefinementTriggers != null &&
                    this.SelectedRefinementTriggers.SequenceEqual(input.SelectedRefinementTriggers)
                ) && 
                (
                    this.CustomParameterTriggers == input.CustomParameterTriggers ||
                    this.CustomParameterTriggers != null &&
                    input.CustomParameterTriggers != null &&
                    this.CustomParameterTriggers.SequenceEqual(input.CustomParameterTriggers)
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
                if (this.QueryPatternTriggers != null)
                {
                    hashCode = (hashCode * 59) + this.QueryPatternTriggers.GetHashCode();
                }
                if (this.SelectedRefinementTriggers != null)
                {
                    hashCode = (hashCode * 59) + this.SelectedRefinementTriggers.GetHashCode();
                }
                if (this.CustomParameterTriggers != null)
                {
                    hashCode = (hashCode * 59) + this.CustomParameterTriggers.GetHashCode();
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
