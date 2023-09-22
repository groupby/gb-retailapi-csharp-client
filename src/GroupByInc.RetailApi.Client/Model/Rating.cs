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
    /// The rating of this product.
    /// </summary>
    [DataContract(Name = "Rating")]
    public partial class Rating : IEquatable<Rating>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rating" /> class.
        /// </summary>
        /// <param name="ratingCount">The total number of ratings. This value is independent of the value of histogram.This value must be nonnegative..</param>
        /// <param name="averageRating">The average rating of the product. The rating is scaled at 1-5..</param>
        /// <param name="ratingHistogram">List of rating counts per rating value (index &#x3D; rating - 1). The list is empty if there is no rating. If the list is non-empty, its size is always 5. For example, [41, 14, 13, 47, 303]. It means that the product got 41 ratings with 1 star, 14 ratings with 2 star, and so on..</param>
        public Rating(int ratingCount = default(int), float averageRating = default(float), List<int> ratingHistogram = default(List<int>))
        {
            this.RatingCount = ratingCount;
            this.AverageRating = averageRating;
            this.RatingHistogram = ratingHistogram;
        }

        /// <summary>
        /// The total number of ratings. This value is independent of the value of histogram.This value must be nonnegative.
        /// </summary>
        /// <value>The total number of ratings. This value is independent of the value of histogram.This value must be nonnegative.</value>
        /// <example>5</example>
        [DataMember(Name = "ratingCount", EmitDefaultValue = false)]
        public int RatingCount { get; set; }

        /// <summary>
        /// The average rating of the product. The rating is scaled at 1-5.
        /// </summary>
        /// <value>The average rating of the product. The rating is scaled at 1-5.</value>
        /// <example>4.5</example>
        [DataMember(Name = "averageRating", EmitDefaultValue = false)]
        public float AverageRating { get; set; }

        /// <summary>
        /// List of rating counts per rating value (index &#x3D; rating - 1). The list is empty if there is no rating. If the list is non-empty, its size is always 5. For example, [41, 14, 13, 47, 303]. It means that the product got 41 ratings with 1 star, 14 ratings with 2 star, and so on.
        /// </summary>
        /// <value>List of rating counts per rating value (index &#x3D; rating - 1). The list is empty if there is no rating. If the list is non-empty, its size is always 5. For example, [41, 14, 13, 47, 303]. It means that the product got 41 ratings with 1 star, 14 ratings with 2 star, and so on.</value>
        /// <example>[41, 14, 13, 47, 303]</example>
        [DataMember(Name = "ratingHistogram", EmitDefaultValue = false)]
        public List<int> RatingHistogram { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Rating {\n");
            sb.Append("  RatingCount: ").Append(RatingCount).Append("\n");
            sb.Append("  AverageRating: ").Append(AverageRating).Append("\n");
            sb.Append("  RatingHistogram: ").Append(RatingHistogram).Append("\n");
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
            return this.Equals(input as Rating);
        }

        /// <summary>
        /// Returns true if Rating instances are equal
        /// </summary>
        /// <param name="input">Instance of Rating to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Rating input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RatingCount == input.RatingCount ||
                    this.RatingCount.Equals(input.RatingCount)
                ) && 
                (
                    this.AverageRating == input.AverageRating ||
                    this.AverageRating.Equals(input.AverageRating)
                ) && 
                (
                    this.RatingHistogram == input.RatingHistogram ||
                    this.RatingHistogram != null &&
                    input.RatingHistogram != null &&
                    this.RatingHistogram.SequenceEqual(input.RatingHistogram)
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
                hashCode = (hashCode * 59) + this.RatingCount.GetHashCode();
                hashCode = (hashCode * 59) + this.AverageRating.GetHashCode();
                if (this.RatingHistogram != null)
                {
                    hashCode = (hashCode * 59) + this.RatingHistogram.GetHashCode();
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
