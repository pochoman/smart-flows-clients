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
    /// ProjectSettings
    /// </summary>
    [DataContract]
    public partial class ProjectSettings : IEquatable<ProjectSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSettings" /> class.
        /// </summary>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Initialized">Initialized.</param>
        /// <param name="TimeZone">TimeZone.</param>
        /// <param name="SystemLanguage">SystemLanguage.</param>
        /// <param name="DefaultPriority">DefaultPriority.</param>
        public ProjectSettings(string DisplayName = default(string), string Description = default(string), bool? Initialized = default(bool?), string TimeZone = default(string), LanguageReference SystemLanguage = default(LanguageReference), int? DefaultPriority = default(int?))
        {
            this.DisplayName = DisplayName;
            this.Description = Description;
            this.Initialized = Initialized;
            this.TimeZone = TimeZone;
            this.SystemLanguage = SystemLanguage;
            this.DefaultPriority = DefaultPriority;
        }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets Initialized
        /// </summary>
        [DataMember(Name = "initialized", EmitDefaultValue = false)]
        public bool? Initialized { get; set; }
        /// <summary>
        /// Gets or Sets TimeZone
        /// </summary>
        [DataMember(Name = "timeZone", EmitDefaultValue = false)]
        public string TimeZone { get; set; }
        /// <summary>
        /// Gets or Sets SystemLanguage
        /// </summary>
        [DataMember(Name = "systemLanguage", EmitDefaultValue = false)]
        public LanguageReference SystemLanguage { get; set; }
        /// <summary>
        /// Gets or Sets DefaultPriority
        /// </summary>
        [DataMember(Name = "defaultPriority", EmitDefaultValue = false)]
        public int? DefaultPriority { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectSettings {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Initialized: ").Append(Initialized).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  SystemLanguage: ").Append(SystemLanguage).Append("\n");
            sb.Append("  DefaultPriority: ").Append(DefaultPriority).Append("\n");
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
            return this.Equals(obj as ProjectSettings);
        }

        /// <summary>
        /// Returns true if ProjectSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of ProjectSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Initialized == other.Initialized ||
                    this.Initialized != null &&
                    this.Initialized.Equals(other.Initialized)
                ) &&
                (
                    this.TimeZone == other.TimeZone ||
                    this.TimeZone != null &&
                    this.TimeZone.Equals(other.TimeZone)
                ) &&
                (
                    this.SystemLanguage == other.SystemLanguage ||
                    this.SystemLanguage != null &&
                    this.SystemLanguage.Equals(other.SystemLanguage)
                ) &&
                (
                    this.DefaultPriority == other.DefaultPriority ||
                    this.DefaultPriority != null &&
                    this.DefaultPriority.Equals(other.DefaultPriority)
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
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Initialized != null)
                    hash = hash * 59 + this.Initialized.GetHashCode();
                if (this.TimeZone != null)
                    hash = hash * 59 + this.TimeZone.GetHashCode();
                if (this.SystemLanguage != null)
                    hash = hash * 59 + this.SystemLanguage.GetHashCode();
                if (this.DefaultPriority != null)
                    hash = hash * 59 + this.DefaultPriority.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // DefaultPriority (int?) maximum
            if (this.DefaultPriority > (int?)9)
            {
                yield return new ValidationResult("Invalid value for DefaultPriority, must be a value less than or equal to 9.", new[] { "DefaultPriority" });
            }

            // DefaultPriority (int?) minimum
            if (this.DefaultPriority < (int?)0)
            {
                yield return new ValidationResult("Invalid value for DefaultPriority, must be a value greater than or equal to 0.", new[] { "DefaultPriority" });
            }

            yield break;
        }
    }

}
