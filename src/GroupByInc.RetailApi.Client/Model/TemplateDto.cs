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
    /// Template to assist the front end application in rendering the UI. Currently only the triggered rule name will be included, or the &#39;default&#39; template name to indicate no rule was triggered. This is to mainly compatibility with the Searchandiser API and the addition of templates in the future. Template is search agnostic and do not affect search request or result. Templated selected only by triggered rule.
    /// </summary>
    [DataContract(Name = "TemplateDto")]
    public partial class TemplateDto : IEquatable<TemplateDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateDto" /> class.
        /// </summary>
        /// <param name="name">Name of the template..</param>
        /// <param name="ruleName">Name of the rule which may have triggered..</param>
        /// <param name="triggerSet">triggerSet.</param>
        /// <param name="zones">Zones for linked template..</param>
        public TemplateDto(string name = default(string), string ruleName = default(string), TemplateDtoTriggerSet triggerSet = default(TemplateDtoTriggerSet), List<ZoneDto> zones = default(List<ZoneDto>))
        {
            this.Name = name;
            this.RuleName = ruleName;
            this.TriggerSet = triggerSet;
            this.Zones = zones;
        }

        /// <summary>
        /// Name of the template.
        /// </summary>
        /// <value>Name of the template.</value>
        /// <example>default</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Name of the rule which may have triggered.
        /// </summary>
        /// <value>Name of the rule which may have triggered.</value>
        /// <example>Easter Sale 2021</example>
        [DataMember(Name = "ruleName", EmitDefaultValue = false)]
        public string RuleName { get; set; }

        /// <summary>
        /// Gets or Sets TriggerSet
        /// </summary>
        [DataMember(Name = "triggerSet", EmitDefaultValue = false)]
        public TemplateDtoTriggerSet TriggerSet { get; set; }

        /// <summary>
        /// Zones for linked template.
        /// </summary>
        /// <value>Zones for linked template.</value>
        [DataMember(Name = "zones", EmitDefaultValue = false)]
        public List<ZoneDto> Zones { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TemplateDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RuleName: ").Append(RuleName).Append("\n");
            sb.Append("  TriggerSet: ").Append(TriggerSet).Append("\n");
            sb.Append("  Zones: ").Append(Zones).Append("\n");
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
            return this.Equals(input as TemplateDto);
        }

        /// <summary>
        /// Returns true if TemplateDto instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.RuleName == input.RuleName ||
                    (this.RuleName != null &&
                    this.RuleName.Equals(input.RuleName))
                ) && 
                (
                    this.TriggerSet == input.TriggerSet ||
                    (this.TriggerSet != null &&
                    this.TriggerSet.Equals(input.TriggerSet))
                ) && 
                (
                    this.Zones == input.Zones ||
                    this.Zones != null &&
                    input.Zones != null &&
                    this.Zones.SequenceEqual(input.Zones)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.RuleName != null)
                {
                    hashCode = (hashCode * 59) + this.RuleName.GetHashCode();
                }
                if (this.TriggerSet != null)
                {
                    hashCode = (hashCode * 59) + this.TriggerSet.GetHashCode();
                }
                if (this.Zones != null)
                {
                    hashCode = (hashCode * 59) + this.Zones.GetHashCode();
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
