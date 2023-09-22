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
    /// Navigation available for the shopper to refine the results on.
    /// </summary>
    [DataContract(Name = "NavigationDto")]
    public partial class NavigationDto : IEquatable<NavigationDto>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public NavigationTypeDto Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NavigationDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NavigationDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NavigationDto" /> class.
        /// </summary>
        /// <param name="name">Name of the field the navigation in on..</param>
        /// <param name="displayName">Name of the navigation for display purposes..</param>
        /// <param name="type">type (required).</param>
        /// <param name="refinements">refinements (required).</param>
        /// <param name="or">Flag if this navigation supports or queries..</param>
        /// <param name="source">source (required).</param>
        /// <param name="metadata">metadata (required).</param>
        /// <param name="placeId">Place id for inventory navigations. (required).</param>
        public NavigationDto(string name = default(string), string displayName = default(string), NavigationTypeDto type = default(NavigationTypeDto), List<RefinementDto> refinements = default(List<RefinementDto>), bool or = default(bool), string source = default(string), List<Metadata> metadata = default(List<Metadata>), string placeId = default(string))
        {
            this.Type = type;
            // to ensure "refinements" is required (not null)
            if (refinements == null)
            {
                throw new ArgumentNullException("refinements is a required property for NavigationDto and cannot be null");
            }
            this.Refinements = refinements;
            // to ensure "source" is required (not null)
            if (source == null)
            {
                throw new ArgumentNullException("source is a required property for NavigationDto and cannot be null");
            }
            this.Source = source;
            // to ensure "metadata" is required (not null)
            if (metadata == null)
            {
                throw new ArgumentNullException("metadata is a required property for NavigationDto and cannot be null");
            }
            this.Metadata = metadata;
            // to ensure "placeId" is required (not null)
            if (placeId == null)
            {
                throw new ArgumentNullException("placeId is a required property for NavigationDto and cannot be null");
            }
            this.PlaceId = placeId;
            this.Name = name;
            this.DisplayName = displayName;
            this.Or = or;
        }

        /// <summary>
        /// Name of the field the navigation in on.
        /// </summary>
        /// <value>Name of the field the navigation in on.</value>
        /// <example>brands</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Name of the navigation for display purposes.
        /// </summary>
        /// <value>Name of the navigation for display purposes.</value>
        /// <example>Brand</example>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Refinements
        /// </summary>
        [DataMember(Name = "refinements", IsRequired = true, EmitDefaultValue = true)]
        public List<RefinementDto> Refinements { get; set; }

        /// <summary>
        /// Flag if this navigation supports or queries.
        /// </summary>
        /// <value>Flag if this navigation supports or queries.</value>
        [DataMember(Name = "or", EmitDefaultValue = true)]
        public bool Or { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", IsRequired = true, EmitDefaultValue = true)]
        public string Source { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", IsRequired = true, EmitDefaultValue = true)]
        public List<Metadata> Metadata { get; set; }

        /// <summary>
        /// Place id for inventory navigations.
        /// </summary>
        /// <value>Place id for inventory navigations.</value>
        [DataMember(Name = "placeId", IsRequired = true, EmitDefaultValue = true)]
        public string PlaceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NavigationDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Refinements: ").Append(Refinements).Append("\n");
            sb.Append("  Or: ").Append(Or).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  PlaceId: ").Append(PlaceId).Append("\n");
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
            return this.Equals(input as NavigationDto);
        }

        /// <summary>
        /// Returns true if NavigationDto instances are equal
        /// </summary>
        /// <param name="input">Instance of NavigationDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NavigationDto input)
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
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Refinements == input.Refinements ||
                    this.Refinements != null &&
                    input.Refinements != null &&
                    this.Refinements.SequenceEqual(input.Refinements)
                ) && 
                (
                    this.Or == input.Or ||
                    this.Or.Equals(input.Or)
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.PlaceId == input.PlaceId ||
                    (this.PlaceId != null &&
                    this.PlaceId.Equals(input.PlaceId))
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
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Refinements != null)
                {
                    hashCode = (hashCode * 59) + this.Refinements.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Or.GetHashCode();
                if (this.Source != null)
                {
                    hashCode = (hashCode * 59) + this.Source.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.PlaceId != null)
                {
                    hashCode = (hashCode * 59) + this.PlaceId.GetHashCode();
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
