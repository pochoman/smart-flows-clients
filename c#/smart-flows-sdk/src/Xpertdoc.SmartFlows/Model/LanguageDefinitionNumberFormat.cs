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
    /// LanguageDefinitionNumberFormat
    /// </summary>
    [DataContract]
    public partial class LanguageDefinitionNumberFormat : IEquatable<LanguageDefinitionNumberFormat>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageDefinitionNumberFormat" /> class.
        /// </summary>
        /// <param name="GroupingSeparator">GroupingSeparator.</param>
        /// <param name="DecimalSeparator">DecimalSeparator.</param>
        /// <param name="Sample">Sample.</param>
        public LanguageDefinitionNumberFormat(string GroupingSeparator = default(string), string DecimalSeparator = default(string), string Sample = default(string))
        {
            this.GroupingSeparator = GroupingSeparator;
            this.DecimalSeparator = DecimalSeparator;
            this.Sample = Sample;
        }

        /// <summary>
        /// Gets or Sets GroupingSeparator
        /// </summary>
        [DataMember(Name = "groupingSeparator", EmitDefaultValue = false)]
        public string GroupingSeparator { get; set; }
        /// <summary>
        /// Gets or Sets DecimalSeparator
        /// </summary>
        [DataMember(Name = "decimalSeparator", EmitDefaultValue = false)]
        public string DecimalSeparator { get; set; }
        /// <summary>
        /// Gets or Sets Sample
        /// </summary>
        [DataMember(Name = "sample", EmitDefaultValue = false)]
        public string Sample { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LanguageDefinitionNumberFormat {\n");
            sb.Append("  GroupingSeparator: ").Append(GroupingSeparator).Append("\n");
            sb.Append("  DecimalSeparator: ").Append(DecimalSeparator).Append("\n");
            sb.Append("  Sample: ").Append(Sample).Append("\n");
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
            return this.Equals(obj as LanguageDefinitionNumberFormat);
        }

        /// <summary>
        /// Returns true if LanguageDefinitionNumberFormat instances are equal
        /// </summary>
        /// <param name="other">Instance of LanguageDefinitionNumberFormat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LanguageDefinitionNumberFormat other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.GroupingSeparator == other.GroupingSeparator ||
                    this.GroupingSeparator != null &&
                    this.GroupingSeparator.Equals(other.GroupingSeparator)
                ) &&
                (
                    this.DecimalSeparator == other.DecimalSeparator ||
                    this.DecimalSeparator != null &&
                    this.DecimalSeparator.Equals(other.DecimalSeparator)
                ) &&
                (
                    this.Sample == other.Sample ||
                    this.Sample != null &&
                    this.Sample.Equals(other.Sample)
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
                if (this.GroupingSeparator != null)
                    hash = hash * 59 + this.GroupingSeparator.GetHashCode();
                if (this.DecimalSeparator != null)
                    hash = hash * 59 + this.DecimalSeparator.GetHashCode();
                if (this.Sample != null)
                    hash = hash * 59 + this.Sample.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
