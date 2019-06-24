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
    /// Defines dependencyDepth
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DependencyDepth
    {

        /// <summary>
        /// Enum Direct for "direct"
        /// </summary>
        [EnumMember(Value = "direct")]
        Direct,

        /// <summary>
        /// Enum Full for "full"
        /// </summary>
        [EnumMember(Value = "full")]
        Full
    }

}
