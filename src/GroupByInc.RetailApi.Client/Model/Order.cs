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
    /// Defines Order
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Order
    {
        /// <summary>
        /// Enum ASCENDING for value: ASCENDING
        /// </summary>
        [EnumMember(Value = "ASCENDING")]
        ASCENDING = 1,

        /// <summary>
        /// Enum DESCENDING for value: DESCENDING
        /// </summary>
        [EnumMember(Value = "DESCENDING")]
        DESCENDING = 2
    }

}