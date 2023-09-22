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
    /// Information regarding where the page of results starts and ends.
    /// </summary>
    [DataContract(Name = "PageInfoDto")]
    public partial class PageInfoDto : IEquatable<PageInfoDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageInfoDto" /> class.
        /// </summary>
        /// <param name="recordStart">Where in the list of products the page begins..</param>
        /// <param name="recordEnd">Where in the list of products the page ends..</param>
        public PageInfoDto(long recordStart = default(long), long recordEnd = default(long))
        {
            this.RecordStart = recordStart;
            this.RecordEnd = recordEnd;
        }

        /// <summary>
        /// Where in the list of products the page begins.
        /// </summary>
        /// <value>Where in the list of products the page begins.</value>
        /// <example>50</example>
        [DataMember(Name = "recordStart", EmitDefaultValue = false)]
        public long RecordStart { get; set; }

        /// <summary>
        /// Where in the list of products the page ends.
        /// </summary>
        /// <value>Where in the list of products the page ends.</value>
        /// <example>75</example>
        [DataMember(Name = "recordEnd", EmitDefaultValue = false)]
        public long RecordEnd { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PageInfoDto {\n");
            sb.Append("  RecordStart: ").Append(RecordStart).Append("\n");
            sb.Append("  RecordEnd: ").Append(RecordEnd).Append("\n");
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
            return this.Equals(input as PageInfoDto);
        }

        /// <summary>
        /// Returns true if PageInfoDto instances are equal
        /// </summary>
        /// <param name="input">Instance of PageInfoDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PageInfoDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RecordStart == input.RecordStart ||
                    this.RecordStart.Equals(input.RecordStart)
                ) && 
                (
                    this.RecordEnd == input.RecordEnd ||
                    this.RecordEnd.Equals(input.RecordEnd)
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
                hashCode = (hashCode * 59) + this.RecordStart.GetHashCode();
                hashCode = (hashCode * 59) + this.RecordEnd.GetHashCode();
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
            // RecordStart (long) minimum
            if (this.RecordStart < (long)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RecordStart, must be a value greater than or equal to 0.", new [] { "RecordStart" });
            }

            // RecordEnd (long) minimum
            if (this.RecordEnd < (long)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RecordEnd, must be a value greater than or equal to 1.", new [] { "RecordEnd" });
            }

            yield break;
        }
    }

}
