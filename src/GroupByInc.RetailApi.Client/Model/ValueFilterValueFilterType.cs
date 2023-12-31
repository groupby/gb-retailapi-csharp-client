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
    /// Defines ValueFilter.ValueFilterType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ValueFilterValueFilterType
    {
        /// <summary>
        /// Enum TEXTUAL for value: TEXTUAL
        /// </summary>
        [EnumMember(Value = "TEXTUAL")]
        TEXTUAL = 1,

        /// <summary>
        /// Enum NUMERIC for value: NUMERIC
        /// </summary>
        [EnumMember(Value = "NUMERIC")]
        NUMERIC = 2
    }

}
