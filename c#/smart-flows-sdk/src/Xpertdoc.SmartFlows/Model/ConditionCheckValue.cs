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
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Xpertdoc.SmartFlows.Model
{
    /// <summary>
    /// ConditionCheckValue
    /// </summary>
    [DataContract]
    public partial class ConditionCheckValue : IEquatable<ConditionCheckValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionCheckValue" /> class.
        /// </summary>
        /// <param name="Value">Value.</param>
        /// <param name="SettingsType">SettingsType.</param>
        /// <param name="Settings">Settings.</param>
        public ConditionCheckValue(ConditionValue Value = default(ConditionValue), ConditionType SettingsType = default(ConditionType), ConditionCheckValueSettings Settings = default(ConditionCheckValueSettings))
        {
            this.Value = Value;
            this.SettingsType = SettingsType;
            this.Settings = Settings;
        }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public ConditionValue Value { get; set; }
        /// <summary>
        /// Gets or Sets SettingsType
        /// </summary>
        [DataMember(Name = "settingsType", EmitDefaultValue = false)]
        public ConditionType SettingsType { get; set; }
        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name = "settings", EmitDefaultValue = false)]
        public ConditionCheckValueSettings Settings { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConditionCheckValue {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  SettingsType: ").Append(SettingsType).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
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
            return this.Equals(obj as ConditionCheckValue);
        }

        /// <summary>
        /// Returns true if ConditionCheckValue instances are equal
        /// </summary>
        /// <param name="other">Instance of ConditionCheckValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConditionCheckValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.SettingsType == other.SettingsType ||
                    this.SettingsType != null &&
                    this.SettingsType.Equals(other.SettingsType)
                ) &&
                (
                    this.Settings == other.Settings ||
                    this.Settings != null &&
                    this.Settings.Equals(other.Settings)
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
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this.SettingsType != null)
                    hash = hash * 59 + this.SettingsType.GetHashCode();
                if (this.Settings != null)
                    hash = hash * 59 + this.Settings.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
