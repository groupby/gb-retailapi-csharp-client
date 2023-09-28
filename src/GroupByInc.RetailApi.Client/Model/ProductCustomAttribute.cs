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
    /// A custom attribute that is not explicitly modeled in product.
    /// </summary>
    [DataContract(Name = "ProductCustomAttribute")]
    public partial class ProductCustomAttribute : IEquatable<ProductCustomAttribute>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductCustomAttribute" /> class.
        /// </summary>
        /// <param name="text">The textual values of this custom attribute. At most 400 values are allowed. Empty values are not allowed. Length limit of 256 characters. Exactly one of text or numbers should be set..</param>
        /// <param name="numbers">The numerical values of this custom attribute. At most 400 values are allowed. Exactly one of text or numbers should be set..</param>
        /// <param name="searchable">If true, custom attribute values are searchable by text queries in. search. Only set if type text set..</param>
        /// <param name="indexable">If true, custom attribute values are indexed, so that it can be filtered, faceted or boosted in search..</param>
        public ProductCustomAttribute(List<string> text = default(List<string>), List<double> numbers = default(List<double>), bool searchable = default(bool), bool indexable = default(bool))
        {
            this.Text = text;
            this.Numbers = numbers;
            this.Searchable = searchable;
            this.Indexable = indexable;
        }

        /// <summary>
        /// The textual values of this custom attribute. At most 400 values are allowed. Empty values are not allowed. Length limit of 256 characters. Exactly one of text or numbers should be set.
        /// </summary>
        /// <value>The textual values of this custom attribute. At most 400 values are allowed. Empty values are not allowed. Length limit of 256 characters. Exactly one of text or numbers should be set.</value>
        /// <example>[&#39;yellow&#39;,&#39;green&#39;]&#x60; when the key is &#39;color&#39;.</example>
        [DataMember(Name = "text", EmitDefaultValue = false)]
        public List<string> Text { get; set; }

        /// <summary>
        /// The numerical values of this custom attribute. At most 400 values are allowed. Exactly one of text or numbers should be set.
        /// </summary>
        /// <value>The numerical values of this custom attribute. At most 400 values are allowed. Exactly one of text or numbers should be set.</value>
        /// <example>[2.3, 15.4] when the key is &#39;lengths_cm&#39;</example>
        [DataMember(Name = "numbers", EmitDefaultValue = false)]
        public List<double> Numbers { get; set; }

        /// <summary>
        /// If true, custom attribute values are searchable by text queries in. search. Only set if type text set.
        /// </summary>
        /// <value>If true, custom attribute values are searchable by text queries in. search. Only set if type text set.</value>
        /// <example>false</example>
        [DataMember(Name = "searchable", EmitDefaultValue = true)]
        public bool Searchable { get; set; }

        /// <summary>
        /// If true, custom attribute values are indexed, so that it can be filtered, faceted or boosted in search.
        /// </summary>
        /// <value>If true, custom attribute values are indexed, so that it can be filtered, faceted or boosted in search.</value>
        /// <example>false</example>
        [DataMember(Name = "indexable", EmitDefaultValue = true)]
        public bool Indexable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductCustomAttribute {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Numbers: ").Append(Numbers).Append("\n");
            sb.Append("  Searchable: ").Append(Searchable).Append("\n");
            sb.Append("  Indexable: ").Append(Indexable).Append("\n");
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
            return this.Equals(input as ProductCustomAttribute);
        }

        /// <summary>
        /// Returns true if ProductCustomAttribute instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductCustomAttribute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductCustomAttribute input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Text == input.Text ||
                    this.Text != null &&
                    input.Text != null &&
                    this.Text.SequenceEqual(input.Text)
                ) && 
                (
                    this.Numbers == input.Numbers ||
                    this.Numbers != null &&
                    input.Numbers != null &&
                    this.Numbers.SequenceEqual(input.Numbers)
                ) && 
                (
                    this.Searchable == input.Searchable ||
                    this.Searchable.Equals(input.Searchable)
                ) && 
                (
                    this.Indexable == input.Indexable ||
                    this.Indexable.Equals(input.Indexable)
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
                if (this.Text != null)
                {
                    hashCode = (hashCode * 59) + this.Text.GetHashCode();
                }
                if (this.Numbers != null)
                {
                    hashCode = (hashCode * 59) + this.Numbers.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Searchable.GetHashCode();
                hashCode = (hashCode * 59) + this.Indexable.GetHashCode();
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
