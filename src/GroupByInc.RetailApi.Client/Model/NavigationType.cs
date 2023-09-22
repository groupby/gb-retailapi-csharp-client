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
    /// Type of navigation.
    /// </summary>
    /// <value>Type of navigation.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NavigationType
    {
        /// <summary>
        /// Enum VALUE for value: VALUE
        /// </summary>
        [EnumMember(Value = "VALUE")]
        VALUE = 1,

        /// <summary>
        /// Enum RANGE for value: RANGE
        /// </summary>
        [EnumMember(Value = "RANGE")]
        RANGE = 2
    }

}
