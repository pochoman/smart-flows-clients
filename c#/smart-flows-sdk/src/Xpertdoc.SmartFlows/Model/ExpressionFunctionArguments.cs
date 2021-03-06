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
    /// ExpressionFunctionArguments
    /// </summary>
    [DataContract]
    public partial class ExpressionFunctionArguments : IEquatable<ExpressionFunctionArguments>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {

            /// <summary>
            /// Enum NotSpecified for "notSpecified"
            /// </summary>
            [EnumMember(Value = "notSpecified")]
            NotSpecified,

            /// <summary>
            /// Enum Period for "period"
            /// </summary>
            [EnumMember(Value = "period")]
            Period,

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
            Boolean,

            /// <summary>
            /// Enum Pattern for "pattern"
            /// </summary>
            [EnumMember(Value = "pattern")]
            Pattern,

            /// <summary>
            /// Enum DatePattern for "datePattern"
            /// </summary>
            [EnumMember(Value = "datePattern")]
            DatePattern,

            /// <summary>
            /// Enum TimePattern for "timePattern"
            /// </summary>
            [EnumMember(Value = "timePattern")]
            TimePattern,

            /// <summary>
            /// Enum DateTimePattern for "dateTimePattern"
            /// </summary>
            [EnumMember(Value = "dateTimePattern")]
            DateTimePattern,

            /// <summary>
            /// Enum TextWithExtendedCharacters for "textWithExtendedCharacters"
            /// </summary>
            [EnumMember(Value = "textWithExtendedCharacters")]
            TextWithExtendedCharacters,

            /// <summary>
            /// Enum RegEx for "regEx"
            /// </summary>
            [EnumMember(Value = "regEx")]
            RegEx,

            /// <summary>
            /// Enum RegExSubstitution for "regExSubstitution"
            /// </summary>
            [EnumMember(Value = "regExSubstitution")]
            RegExSubstitution,

            /// <summary>
            /// Enum Locale for "locale"
            /// </summary>
            [EnumMember(Value = "locale")]
            Locale,

            /// <summary>
            /// Enum DurationPattern for "durationPattern"
            /// </summary>
            [EnumMember(Value = "durationPattern")]
            DurationPattern,

            /// <summary>
            /// Enum DecimalPattern for "decimalPattern"
            /// </summary>
            [EnumMember(Value = "decimalPattern")]
            DecimalPattern
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressionFunctionArguments" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Type">Type (default to TypeEnum.NotSpecified).</param>
        /// <param name="Optional">Optional.</param>
        /// <param name="HelpLink">HelpLink.</param>
        /// <param name="DefaultValue">DefaultValue.</param>
        public ExpressionFunctionArguments(string Name = default(string), TypeEnum? Type = TypeEnum.NotSpecified, bool? Optional = default(bool?), string HelpLink = default(string), string DefaultValue = default(string))
        {
            this.Name = Name;
            // use default value if no "Type" provided
            if (Type == null)
            {
                this.Type = TypeEnum.NotSpecified;
            }
            else
            {
                this.Type = Type;
            }
            this.Optional = Optional;
            this.HelpLink = HelpLink;
            this.DefaultValue = DefaultValue;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Optional
        /// </summary>
        [DataMember(Name = "optional", EmitDefaultValue = false)]
        public bool? Optional { get; set; }
        /// <summary>
        /// Gets or Sets HelpLink
        /// </summary>
        [DataMember(Name = "helpLink", EmitDefaultValue = false)]
        public string HelpLink { get; set; }
        /// <summary>
        /// Gets or Sets DefaultValue
        /// </summary>
        [DataMember(Name = "defaultValue", EmitDefaultValue = false)]
        public string DefaultValue { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExpressionFunctionArguments {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Optional: ").Append(Optional).Append("\n");
            sb.Append("  HelpLink: ").Append(HelpLink).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
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
            return this.Equals(obj as ExpressionFunctionArguments);
        }

        /// <summary>
        /// Returns true if ExpressionFunctionArguments instances are equal
        /// </summary>
        /// <param name="other">Instance of ExpressionFunctionArguments to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExpressionFunctionArguments other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Optional == other.Optional ||
                    this.Optional != null &&
                    this.Optional.Equals(other.Optional)
                ) &&
                (
                    this.HelpLink == other.HelpLink ||
                    this.HelpLink != null &&
                    this.HelpLink.Equals(other.HelpLink)
                ) &&
                (
                    this.DefaultValue == other.DefaultValue ||
                    this.DefaultValue != null &&
                    this.DefaultValue.Equals(other.DefaultValue)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Optional != null)
                    hash = hash * 59 + this.Optional.GetHashCode();
                if (this.HelpLink != null)
                    hash = hash * 59 + this.HelpLink.GetHashCode();
                if (this.DefaultValue != null)
                    hash = hash * 59 + this.DefaultValue.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
