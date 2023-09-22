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
    /// Defines RuleType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RuleType
    {
        /// <summary>
        /// Enum REGULAR for value: REGULAR
        /// </summary>
        [EnumMember(Value = "REGULAR")]
        REGULAR = 1,

        /// <summary>
        /// Enum EXPERIMENT for value: EXPERIMENT
        /// </summary>
        [EnumMember(Value = "EXPERIMENT")]
        EXPERIMENT = 2
    }

}
