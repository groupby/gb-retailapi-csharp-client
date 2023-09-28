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
    /// ProductDtoRetrievableFields
    /// </summary>
    [DataContract(Name = "ProductDto_retrievableFields")]
    public partial class ProductDtoRetrievableFields : IEquatable<ProductDtoRetrievableFields>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductDtoRetrievableFields" /> class.
        /// </summary>
        /// <param name="paths">Paths for retrievable fields (array)..</param>
        public ProductDtoRetrievableFields(List<string> paths = default(List<string>))
        {
            this.Paths = paths;
        }

        /// <summary>
        /// Paths for retrievable fields (array).
        /// </summary>
        /// <value>Paths for retrievable fields (array).</value>
        /// <example>color_info, price_info, audience, images, sizes, materials, name, availability, title, uri. When list is empty or &quot;*&quot; string exist in list -api will return all fields.</example>
        [DataMember(Name = "paths", EmitDefaultValue = false)]
        public List<string> Paths { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductDtoRetrievableFields {\n");
            sb.Append("  Paths: ").Append(Paths).Append("\n");
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
            return this.Equals(input as ProductDtoRetrievableFields);
        }

        /// <summary>
        /// Returns true if ProductDtoRetrievableFields instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductDtoRetrievableFields to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductDtoRetrievableFields input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Paths == input.Paths ||
                    this.Paths != null &&
                    input.Paths != null &&
                    this.Paths.SequenceEqual(input.Paths)
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
                if (this.Paths != null)
                {
                    hashCode = (hashCode * 59) + this.Paths.GetHashCode();
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
