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
    /// Define type of content which is can be stored in zone.
    /// </summary>
    /// <value>Define type of content which is can be stored in zone.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ZoneDtoType
    {
        /// <summary>
        /// Enum Content for value: Content
        /// </summary>
        [EnumMember(Value = "Content")]
        Content = 1,

        /// <summary>
        /// Enum RichContent for value: Rich_Content
        /// </summary>
        [EnumMember(Value = "Rich_Content")]
        RichContent = 2,

        /// <summary>
        /// Enum Products for value: Products
        /// </summary>
        [EnumMember(Value = "Products")]
        Products = 3,

        /// <summary>
        /// Enum GeneratedContent for value: Generated_Content
        /// </summary>
        [EnumMember(Value = "Generated_Content")]
        GeneratedContent = 4
    }

}
