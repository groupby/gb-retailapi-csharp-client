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
    /// Sort
    /// </summary>
    [DataContract(Name = "Sort")]
    public partial class Sort : IEquatable<Sort>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Sort" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Sort() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Sort" /> class.
        /// </summary>
        /// <param name="field">Field the order will be applied to. (required).</param>
        /// <param name="order">OrderDto the products will appear in. (required).</param>
        public Sort(string field = default(string), Object order = default(Object))
        {
            // to ensure "field" is required (not null)
            if (field == null)
            {
                throw new ArgumentNullException("field is a required property for Sort and cannot be null");
            }
            this.Field = field;
            // to ensure "order" is required (not null)
            if (order == null)
            {
                throw new ArgumentNullException("order is a required property for Sort and cannot be null");
            }
            this.Order = order;
        }

        /// <summary>
        /// Field the order will be applied to.
        /// </summary>
        /// <value>Field the order will be applied to.</value>
        [DataMember(Name = "field", IsRequired = true, EmitDefaultValue = true)]
        public string Field { get; set; }

        /// <summary>
        /// OrderDto the products will appear in.
        /// </summary>
        /// <value>OrderDto the products will appear in.</value>
        [DataMember(Name = "order", IsRequired = true, EmitDefaultValue = true)]
        public Object Order { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Sort {\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
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
            return this.Equals(input as Sort);
        }

        /// <summary>
        /// Returns true if Sort instances are equal
        /// </summary>
        /// <param name="input">Instance of Sort to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Sort input)
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
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
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
                if (this.Order != null)
                {
                    hashCode = (hashCode * 59) + this.Order.GetHashCode();
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
