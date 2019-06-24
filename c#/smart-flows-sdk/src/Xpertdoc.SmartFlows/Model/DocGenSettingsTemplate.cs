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
    /// DocGenSettingsTemplate
    /// </summary>
    [DataContract]
    public partial class DocGenSettingsTemplate : IEquatable<DocGenSettingsTemplate>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {

            /// <summary>
            /// Enum Standard for "standard"
            /// </summary>
            [EnumMember(Value = "standard")]
            Standard,

            /// <summary>
            /// Enum Composed for "composed"
            /// </summary>
            [EnumMember(Value = "composed")]
            Composed
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocGenSettingsTemplate" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="Standard">Standard.</param>
        /// <param name="Composed">Composed.</param>
        public DocGenSettingsTemplate(TypeEnum? Type = default(TypeEnum?), string DisplayName = default(string), StandardTemplateDefinition Standard = default(StandardTemplateDefinition), DocGenSettingsTemplateComposed Composed = default(DocGenSettingsTemplateComposed))
        {
            this.Type = Type;
            this.DisplayName = DisplayName;
            this.Standard = Standard;
            this.Composed = Composed;
        }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or Sets Standard
        /// </summary>
        [DataMember(Name = "standard", EmitDefaultValue = false)]
        public StandardTemplateDefinition Standard { get; set; }
        /// <summary>
        /// Gets or Sets Composed
        /// </summary>
        [DataMember(Name = "composed", EmitDefaultValue = false)]
        public DocGenSettingsTemplateComposed Composed { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocGenSettingsTemplate {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Standard: ").Append(Standard).Append("\n");
            sb.Append("  Composed: ").Append(Composed).Append("\n");
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
            return this.Equals(obj as DocGenSettingsTemplate);
        }

        /// <summary>
        /// Returns true if DocGenSettingsTemplate instances are equal
        /// </summary>
        /// <param name="other">Instance of DocGenSettingsTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocGenSettingsTemplate other)
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
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) &&
                (
                    this.Standard == other.Standard ||
                    this.Standard != null &&
                    this.Standard.Equals(other.Standard)
                ) &&
                (
                    this.Composed == other.Composed ||
                    this.Composed != null &&
                    this.Composed.Equals(other.Composed)
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
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.Standard != null)
                    hash = hash * 59 + this.Standard.GetHashCode();
                if (this.Composed != null)
                    hash = hash * 59 + this.Composed.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
