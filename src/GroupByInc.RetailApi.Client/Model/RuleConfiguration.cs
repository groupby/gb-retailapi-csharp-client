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
    /// RuleConfiguration
    /// </summary>
    [DataContract(Name = "RuleConfiguration")]
    public partial class RuleConfiguration : IEquatable<RuleConfiguration>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets MessageType
        /// </summary>
        [DataMember(Name = "messageType", IsRequired = true, EmitDefaultValue = true)]
        public MessageType MessageType { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public RuleType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RuleConfiguration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleConfiguration" /> class.
        /// </summary>
        /// <param name="ruleInExperiment">ruleInExperiment.</param>
        /// <param name="id">id (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="areaId">areaId (required).</param>
        /// <param name="priority">priority (required).</param>
        /// <param name="enabled">enabled (required).</param>
        /// <param name="activeHoursEnabled">activeHoursEnabled (required).</param>
        /// <param name="activeFrom">activeFrom (required).</param>
        /// <param name="activeTo">activeTo (required).</param>
        /// <param name="triggerSets">triggerSets (required).</param>
        /// <param name="biasingProfileName">biasingProfileName (required).</param>
        /// <param name="sort">sort (required).</param>
        /// <param name="includedNavigations">includedNavigations (required).</param>
        /// <param name="valueFilters">valueFilters (required).</param>
        /// <param name="searchFilters">searchFilters (required).</param>
        /// <param name="rangeFilters">rangeFilters (required).</param>
        /// <param name="template">template (required).</param>
        /// <param name="boostedProductBuckets">boostedProductBuckets (required).</param>
        /// <param name="pinnedRefinements">pinnedRefinements (required).</param>
        /// <param name="messageType">messageType (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="variants">variants (required).</param>
        public RuleConfiguration(bool ruleInExperiment = default(bool), int id = default(int), string name = default(string), int areaId = default(int), int priority = default(int), bool enabled = default(bool), bool activeHoursEnabled = default(bool), long activeFrom = default(long), long activeTo = default(long), List<TriggerSet> triggerSets = default(List<TriggerSet>), string biasingProfileName = default(string), Sort sort = default(Sort), List<string> includedNavigations = default(List<string>), List<ValueFilter> valueFilters = default(List<ValueFilter>), List<SearchFilter> searchFilters = default(List<SearchFilter>), List<RangeFilter> rangeFilters = default(List<RangeFilter>), RuleTemplate template = default(RuleTemplate), List<BoostedProductBucket> boostedProductBuckets = default(List<BoostedProductBucket>), List<PinnedRefinement> pinnedRefinements = default(List<PinnedRefinement>), MessageType messageType = default(MessageType), RuleType type = default(RuleType), List<ExperimentVariant> variants = default(List<ExperimentVariant>))
        {
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for RuleConfiguration and cannot be null");
            }
            this.Name = name;
            this.AreaId = areaId;
            this.Priority = priority;
            this.Enabled = enabled;
            this.ActiveHoursEnabled = activeHoursEnabled;
            this.ActiveFrom = activeFrom;
            this.ActiveTo = activeTo;
            // to ensure "triggerSets" is required (not null)
            if (triggerSets == null)
            {
                throw new ArgumentNullException("triggerSets is a required property for RuleConfiguration and cannot be null");
            }
            this.TriggerSets = triggerSets;
            // to ensure "biasingProfileName" is required (not null)
            if (biasingProfileName == null)
            {
                throw new ArgumentNullException("biasingProfileName is a required property for RuleConfiguration and cannot be null");
            }
            this.BiasingProfileName = biasingProfileName;
            // to ensure "sort" is required (not null)
            if (sort == null)
            {
                throw new ArgumentNullException("sort is a required property for RuleConfiguration and cannot be null");
            }
            this.Sort = sort;
            // to ensure "includedNavigations" is required (not null)
            if (includedNavigations == null)
            {
                throw new ArgumentNullException("includedNavigations is a required property for RuleConfiguration and cannot be null");
            }
            this.IncludedNavigations = includedNavigations;
            // to ensure "valueFilters" is required (not null)
            if (valueFilters == null)
            {
                throw new ArgumentNullException("valueFilters is a required property for RuleConfiguration and cannot be null");
            }
            this.ValueFilters = valueFilters;
            // to ensure "searchFilters" is required (not null)
            if (searchFilters == null)
            {
                throw new ArgumentNullException("searchFilters is a required property for RuleConfiguration and cannot be null");
            }
            this.SearchFilters = searchFilters;
            // to ensure "rangeFilters" is required (not null)
            if (rangeFilters == null)
            {
                throw new ArgumentNullException("rangeFilters is a required property for RuleConfiguration and cannot be null");
            }
            this.RangeFilters = rangeFilters;
            // to ensure "template" is required (not null)
            if (template == null)
            {
                throw new ArgumentNullException("template is a required property for RuleConfiguration and cannot be null");
            }
            this.Template = template;
            // to ensure "boostedProductBuckets" is required (not null)
            if (boostedProductBuckets == null)
            {
                throw new ArgumentNullException("boostedProductBuckets is a required property for RuleConfiguration and cannot be null");
            }
            this.BoostedProductBuckets = boostedProductBuckets;
            // to ensure "pinnedRefinements" is required (not null)
            if (pinnedRefinements == null)
            {
                throw new ArgumentNullException("pinnedRefinements is a required property for RuleConfiguration and cannot be null");
            }
            this.PinnedRefinements = pinnedRefinements;
            this.MessageType = messageType;
            this.Type = type;
            // to ensure "variants" is required (not null)
            if (variants == null)
            {
                throw new ArgumentNullException("variants is a required property for RuleConfiguration and cannot be null");
            }
            this.Variants = variants;
            this.RuleInExperiment = ruleInExperiment;
        }

        /// <summary>
        /// Gets or Sets RuleInExperiment
        /// </summary>
        [DataMember(Name = "ruleInExperiment", EmitDefaultValue = true)]
        public bool RuleInExperiment { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets AreaId
        /// </summary>
        [DataMember(Name = "areaId", IsRequired = true, EmitDefaultValue = true)]
        public int AreaId { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "priority", IsRequired = true, EmitDefaultValue = true)]
        public int Priority { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", IsRequired = true, EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets ActiveHoursEnabled
        /// </summary>
        [DataMember(Name = "activeHoursEnabled", IsRequired = true, EmitDefaultValue = true)]
        public bool ActiveHoursEnabled { get; set; }

        /// <summary>
        /// Gets or Sets ActiveFrom
        /// </summary>
        [DataMember(Name = "activeFrom", IsRequired = true, EmitDefaultValue = true)]
        public long ActiveFrom { get; set; }

        /// <summary>
        /// Gets or Sets ActiveTo
        /// </summary>
        [DataMember(Name = "activeTo", IsRequired = true, EmitDefaultValue = true)]
        public long ActiveTo { get; set; }

        /// <summary>
        /// Gets or Sets TriggerSets
        /// </summary>
        [DataMember(Name = "triggerSets", IsRequired = true, EmitDefaultValue = true)]
        public List<TriggerSet> TriggerSets { get; set; }

        /// <summary>
        /// Gets or Sets BiasingProfileName
        /// </summary>
        [DataMember(Name = "biasingProfileName", IsRequired = true, EmitDefaultValue = true)]
        public string BiasingProfileName { get; set; }

        /// <summary>
        /// Gets or Sets Sort
        /// </summary>
        [DataMember(Name = "sort", IsRequired = true, EmitDefaultValue = true)]
        public Sort Sort { get; set; }

        /// <summary>
        /// Gets or Sets IncludedNavigations
        /// </summary>
        [DataMember(Name = "includedNavigations", IsRequired = true, EmitDefaultValue = true)]
        public List<string> IncludedNavigations { get; set; }

        /// <summary>
        /// Gets or Sets ValueFilters
        /// </summary>
        [DataMember(Name = "valueFilters", IsRequired = true, EmitDefaultValue = true)]
        public List<ValueFilter> ValueFilters { get; set; }

        /// <summary>
        /// Gets or Sets SearchFilters
        /// </summary>
        [DataMember(Name = "searchFilters", IsRequired = true, EmitDefaultValue = true)]
        public List<SearchFilter> SearchFilters { get; set; }

        /// <summary>
        /// Gets or Sets RangeFilters
        /// </summary>
        [DataMember(Name = "rangeFilters", IsRequired = true, EmitDefaultValue = true)]
        public List<RangeFilter> RangeFilters { get; set; }

        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [DataMember(Name = "template", IsRequired = true, EmitDefaultValue = true)]
        public RuleTemplate Template { get; set; }

        /// <summary>
        /// Gets or Sets BoostedProductBuckets
        /// </summary>
        [DataMember(Name = "boostedProductBuckets", IsRequired = true, EmitDefaultValue = true)]
        public List<BoostedProductBucket> BoostedProductBuckets { get; set; }

        /// <summary>
        /// Gets or Sets PinnedRefinements
        /// </summary>
        [DataMember(Name = "pinnedRefinements", IsRequired = true, EmitDefaultValue = true)]
        public List<PinnedRefinement> PinnedRefinements { get; set; }

        /// <summary>
        /// Gets or Sets Variants
        /// </summary>
        [DataMember(Name = "variants", IsRequired = true, EmitDefaultValue = true)]
        public List<ExperimentVariant> Variants { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RuleConfiguration {\n");
            sb.Append("  RuleInExperiment: ").Append(RuleInExperiment).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AreaId: ").Append(AreaId).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  ActiveHoursEnabled: ").Append(ActiveHoursEnabled).Append("\n");
            sb.Append("  ActiveFrom: ").Append(ActiveFrom).Append("\n");
            sb.Append("  ActiveTo: ").Append(ActiveTo).Append("\n");
            sb.Append("  TriggerSets: ").Append(TriggerSets).Append("\n");
            sb.Append("  BiasingProfileName: ").Append(BiasingProfileName).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  IncludedNavigations: ").Append(IncludedNavigations).Append("\n");
            sb.Append("  ValueFilters: ").Append(ValueFilters).Append("\n");
            sb.Append("  SearchFilters: ").Append(SearchFilters).Append("\n");
            sb.Append("  RangeFilters: ").Append(RangeFilters).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  BoostedProductBuckets: ").Append(BoostedProductBuckets).Append("\n");
            sb.Append("  PinnedRefinements: ").Append(PinnedRefinements).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Variants: ").Append(Variants).Append("\n");
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
            return this.Equals(input as RuleConfiguration);
        }

        /// <summary>
        /// Returns true if RuleConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of RuleConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RuleConfiguration input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RuleInExperiment == input.RuleInExperiment ||
                    this.RuleInExperiment.Equals(input.RuleInExperiment)
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.AreaId == input.AreaId ||
                    this.AreaId.Equals(input.AreaId)
                ) && 
                (
                    this.Priority == input.Priority ||
                    this.Priority.Equals(input.Priority)
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.ActiveHoursEnabled == input.ActiveHoursEnabled ||
                    this.ActiveHoursEnabled.Equals(input.ActiveHoursEnabled)
                ) && 
                (
                    this.ActiveFrom == input.ActiveFrom ||
                    this.ActiveFrom.Equals(input.ActiveFrom)
                ) && 
                (
                    this.ActiveTo == input.ActiveTo ||
                    this.ActiveTo.Equals(input.ActiveTo)
                ) && 
                (
                    this.TriggerSets == input.TriggerSets ||
                    this.TriggerSets != null &&
                    input.TriggerSets != null &&
                    this.TriggerSets.SequenceEqual(input.TriggerSets)
                ) && 
                (
                    this.BiasingProfileName == input.BiasingProfileName ||
                    (this.BiasingProfileName != null &&
                    this.BiasingProfileName.Equals(input.BiasingProfileName))
                ) && 
                (
                    this.Sort == input.Sort ||
                    (this.Sort != null &&
                    this.Sort.Equals(input.Sort))
                ) && 
                (
                    this.IncludedNavigations == input.IncludedNavigations ||
                    this.IncludedNavigations != null &&
                    input.IncludedNavigations != null &&
                    this.IncludedNavigations.SequenceEqual(input.IncludedNavigations)
                ) && 
                (
                    this.ValueFilters == input.ValueFilters ||
                    this.ValueFilters != null &&
                    input.ValueFilters != null &&
                    this.ValueFilters.SequenceEqual(input.ValueFilters)
                ) && 
                (
                    this.SearchFilters == input.SearchFilters ||
                    this.SearchFilters != null &&
                    input.SearchFilters != null &&
                    this.SearchFilters.SequenceEqual(input.SearchFilters)
                ) && 
                (
                    this.RangeFilters == input.RangeFilters ||
                    this.RangeFilters != null &&
                    input.RangeFilters != null &&
                    this.RangeFilters.SequenceEqual(input.RangeFilters)
                ) && 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
                ) && 
                (
                    this.BoostedProductBuckets == input.BoostedProductBuckets ||
                    this.BoostedProductBuckets != null &&
                    input.BoostedProductBuckets != null &&
                    this.BoostedProductBuckets.SequenceEqual(input.BoostedProductBuckets)
                ) && 
                (
                    this.PinnedRefinements == input.PinnedRefinements ||
                    this.PinnedRefinements != null &&
                    input.PinnedRefinements != null &&
                    this.PinnedRefinements.SequenceEqual(input.PinnedRefinements)
                ) && 
                (
                    this.MessageType == input.MessageType ||
                    this.MessageType.Equals(input.MessageType)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Variants == input.Variants ||
                    this.Variants != null &&
                    input.Variants != null &&
                    this.Variants.SequenceEqual(input.Variants)
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
                hashCode = (hashCode * 59) + this.RuleInExperiment.GetHashCode();
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AreaId.GetHashCode();
                hashCode = (hashCode * 59) + this.Priority.GetHashCode();
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                hashCode = (hashCode * 59) + this.ActiveHoursEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.ActiveFrom.GetHashCode();
                hashCode = (hashCode * 59) + this.ActiveTo.GetHashCode();
                if (this.TriggerSets != null)
                {
                    hashCode = (hashCode * 59) + this.TriggerSets.GetHashCode();
                }
                if (this.BiasingProfileName != null)
                {
                    hashCode = (hashCode * 59) + this.BiasingProfileName.GetHashCode();
                }
                if (this.Sort != null)
                {
                    hashCode = (hashCode * 59) + this.Sort.GetHashCode();
                }
                if (this.IncludedNavigations != null)
                {
                    hashCode = (hashCode * 59) + this.IncludedNavigations.GetHashCode();
                }
                if (this.ValueFilters != null)
                {
                    hashCode = (hashCode * 59) + this.ValueFilters.GetHashCode();
                }
                if (this.SearchFilters != null)
                {
                    hashCode = (hashCode * 59) + this.SearchFilters.GetHashCode();
                }
                if (this.RangeFilters != null)
                {
                    hashCode = (hashCode * 59) + this.RangeFilters.GetHashCode();
                }
                if (this.Template != null)
                {
                    hashCode = (hashCode * 59) + this.Template.GetHashCode();
                }
                if (this.BoostedProductBuckets != null)
                {
                    hashCode = (hashCode * 59) + this.BoostedProductBuckets.GetHashCode();
                }
                if (this.PinnedRefinements != null)
                {
                    hashCode = (hashCode * 59) + this.PinnedRefinements.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MessageType.GetHashCode();
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Variants != null)
                {
                    hashCode = (hashCode * 59) + this.Variants.GetHashCode();
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