/* 
 * SmartFlows
 *
 * This describes the REST api for one SmartFlows project 
 *
 * OpenAPI spec version: 4.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Xpertdoc.SmartFlows.Model
{
    /// <summary>
    /// Defines conditionType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ConditionType
    {

        /// <summary>
        /// Enum Date for "date"
        /// </summary>
        [EnumMember(Value = "date")]
        Date,

        /// <summary>
        /// Enum Time for "time"
        /// </summary>
        [EnumMember(Value = "time")]
        Time,

        /// <summary>
        /// Enum DateTime for "dateTime"
        /// </summary>
        [EnumMember(Value = "dateTime")]
        DateTime,

        /// <summary>
        /// Enum Number for "number"
        /// </summary>
        [EnumMember(Value = "number")]
        Number,

        /// <summary>
        /// Enum Text for "text"
        /// </summary>
        [EnumMember(Value = "text")]
        Text,

        /// <summary>
        /// Enum Boolean for "boolean"
        /// </summary>
        [EnumMember(Value = "boolean")]
        Boolean
    }

}
