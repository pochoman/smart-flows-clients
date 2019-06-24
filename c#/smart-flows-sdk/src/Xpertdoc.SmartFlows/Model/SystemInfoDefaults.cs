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
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Xpertdoc.SmartFlows.Model
{
    /// <summary>
    /// SystemInfoDefaults
    /// </summary>
    [DataContract]
    public partial class SystemInfoDefaults : IEquatable<SystemInfoDefaults>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets EsignProvider
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EsignProviderEnum
        {

            /// <summary>
            /// Enum DocuSign for "DocuSign"
            /// </summary>
            [EnumMember(Value = "DocuSign")]
            DocuSign,

            /// <summary>
            /// Enum Sertifi for "Sertifi"
            /// </summary>
            [EnumMember(Value = "Sertifi")]
            Sertifi,

            /// <summary>
            /// Enum OneSpan for "OneSpan"
            /// </summary>
            [EnumMember(Value = "OneSpan")]
            OneSpan
        }

        /// <summary>
        /// Gets or Sets EsignProvider
        /// </summary>
        [DataMember(Name = "esignProvider", EmitDefaultValue = false)]
        public EsignProviderEnum? EsignProvider { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemInfoDefaults" /> class.
        /// </summary>
        /// <param name="EsignProvider">EsignProvider.</param>
        public SystemInfoDefaults(EsignProviderEnum? EsignProvider = default(EsignProviderEnum?))
        {
            this.EsignProvider = EsignProvider;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemInfoDefaults {\n");
            sb.Append("  EsignProvider: ").Append(EsignProvider).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as SystemInfoDefaults);
        }

        /// <summary>
        /// Returns true if SystemInfoDefaults instances are equal
        /// </summary>
        /// <param name="other">Instance of SystemInfoDefaults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemInfoDefaults other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.EsignProvider == other.EsignProvider ||
                    this.EsignProvider != null &&
                    this.EsignProvider.Equals(other.EsignProvider)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.EsignProvider != null)
                    hash = hash * 59 + this.EsignProvider.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
