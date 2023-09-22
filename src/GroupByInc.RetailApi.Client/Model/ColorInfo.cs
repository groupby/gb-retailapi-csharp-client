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
    /// Product color info.
    /// </summary>
    [DataContract(Name = "ColorInfo")]
    public partial class ColorInfo : IEquatable<ColorInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ColorInfo" /> class.
        /// </summary>
        /// <param name="colorFamilies">Product color families (array)..</param>
        /// <param name="colors">Product color (array)..</param>
        public ColorInfo(List<string> colorFamilies = default(List<string>), List<string> colors = default(List<string>))
        {
            this.ColorFamilies = colorFamilies;
            this.Colors = colors;
        }

        /// <summary>
        /// Product color families (array).
        /// </summary>
        /// <value>Product color families (array).</value>
        /// <example>Blue</example>
        [DataMember(Name = "colorFamilies", EmitDefaultValue = false)]
        public List<string> ColorFamilies { get; set; }

        /// <summary>
        /// Product color (array).
        /// </summary>
        /// <value>Product color (array).</value>
        /// <example>Navy</example>
        [DataMember(Name = "colors", EmitDefaultValue = false)]
        public List<string> Colors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ColorInfo {\n");
            sb.Append("  ColorFamilies: ").Append(ColorFamilies).Append("\n");
            sb.Append("  Colors: ").Append(Colors).Append("\n");
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
            return this.Equals(input as ColorInfo);
        }

        /// <summary>
        /// Returns true if ColorInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ColorInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ColorInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ColorFamilies == input.ColorFamilies ||
                    this.ColorFamilies != null &&
                    input.ColorFamilies != null &&
                    this.ColorFamilies.SequenceEqual(input.ColorFamilies)
                ) && 
                (
                    this.Colors == input.Colors ||
                    this.Colors != null &&
                    input.Colors != null &&
                    this.Colors.SequenceEqual(input.Colors)
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
                if (this.ColorFamilies != null)
                {
                    hashCode = (hashCode * 59) + this.ColorFamilies.GetHashCode();
                }
                if (this.Colors != null)
                {
                    hashCode = (hashCode * 59) + this.Colors.GetHashCode();
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
