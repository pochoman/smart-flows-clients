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
    /// UserIdentity
    /// </summary>
    [DataContract]
    public partial class UserIdentity : IEquatable<UserIdentity>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {

            /// <summary>
            /// Enum Native for "native"
            /// </summary>
            [EnumMember(Value = "native")]
            Native,

            /// <summary>
            /// Enum External for "external"
            /// </summary>
            [EnumMember(Value = "external")]
            External,

            /// <summary>
            /// Enum None for "none"
            /// </summary>
            [EnumMember(Value = "none")]
            None
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserIdentity" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="Native">Native.</param>
        /// <param name="External">External.</param>
        public UserIdentity(TypeEnum? Type = default(TypeEnum?), UserIdentityNative Native = default(UserIdentityNative), UserIdentityExternal External = default(UserIdentityExternal))
        {
            this.Type = Type;
            this.Native = Native;
            this.External = External;
        }

        /// <summary>
        /// Gets or Sets Native
        /// </summary>
        [DataMember(Name = "native", EmitDefaultValue = false)]
        public UserIdentityNative Native { get; set; }
        /// <summary>
        /// Gets or Sets External
        /// </summary>
        [DataMember(Name = "external", EmitDefaultValue = false)]
        public UserIdentityExternal External { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserIdentity {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Native: ").Append(Native).Append("\n");
            sb.Append("  External: ").Append(External).Append("\n");
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
            return this.Equals(obj as UserIdentity);
        }

        /// <summary>
        /// Returns true if UserIdentity instances are equal
        /// </summary>
        /// <param name="other">Instance of UserIdentity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserIdentity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Native == other.Native ||
                    this.Native != null &&
                    this.Native.Equals(other.Native)
                ) &&
                (
                    this.External == other.External ||
                    this.External != null &&
                    this.External.Equals(other.External)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Native != null)
                    hash = hash * 59 + this.Native.GetHashCode();
                if (this.External != null)
                    hash = hash * 59 + this.External.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
