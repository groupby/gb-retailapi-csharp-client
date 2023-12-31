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
    /// The amount the bias will affect the search results.
    /// </summary>
    /// <value>The amount the bias will affect the search results.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BiasDtoStrengthDto
    {
        /// <summary>
        /// Enum ABSOLUTEINCREASE for value: ABSOLUTE_INCREASE
        /// </summary>
        [EnumMember(Value = "ABSOLUTE_INCREASE")]
        ABSOLUTEINCREASE = 1,

        /// <summary>
        /// Enum STRONGINCREASE for value: STRONG_INCREASE
        /// </summary>
        [EnumMember(Value = "STRONG_INCREASE")]
        STRONGINCREASE = 2,

        /// <summary>
        /// Enum MEDIUMINCREASE for value: MEDIUM_INCREASE
        /// </summary>
        [EnumMember(Value = "MEDIUM_INCREASE")]
        MEDIUMINCREASE = 3,

        /// <summary>
        /// Enum WEAKINCREASE for value: WEAK_INCREASE
        /// </summary>
        [EnumMember(Value = "WEAK_INCREASE")]
        WEAKINCREASE = 4,

        /// <summary>
        /// Enum LEAVEUNCHANGED for value: LEAVE_UNCHANGED
        /// </summary>
        [EnumMember(Value = "LEAVE_UNCHANGED")]
        LEAVEUNCHANGED = 5,

        /// <summary>
        /// Enum WEAKDECREASE for value: WEAK_DECREASE
        /// </summary>
        [EnumMember(Value = "WEAK_DECREASE")]
        WEAKDECREASE = 6,

        /// <summary>
        /// Enum MEDIUMDECREASE for value: MEDIUM_DECREASE
        /// </summary>
        [EnumMember(Value = "MEDIUM_DECREASE")]
        MEDIUMDECREASE = 7,

        /// <summary>
        /// Enum STRONGDECREASE for value: STRONG_DECREASE
        /// </summary>
        [EnumMember(Value = "STRONG_DECREASE")]
        STRONGDECREASE = 8,

        /// <summary>
        /// Enum ABSOLUTEDECREASE for value: ABSOLUTE_DECREASE
        /// </summary>
        [EnumMember(Value = "ABSOLUTE_DECREASE")]
        ABSOLUTEDECREASE = 9
    }

}
