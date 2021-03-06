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
    /// LicenseInformationLimits
    /// </summary>
    [DataContract]
    public partial class LicenseInformationLimits : IEquatable<LicenseInformationLimits>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseInformationLimits" /> class.
        /// </summary>
        /// <param name="Users">Users.</param>
        /// <param name="Documents">Documents.</param>
        /// <param name="Packs">Packs.</param>
        public LicenseInformationLimits(LicenseInformationLimitsUsers Users = default(LicenseInformationLimitsUsers), LicenseInformationLimitsDocuments Documents = default(LicenseInformationLimitsDocuments), LicenseInformationLimitsPacks Packs = default(LicenseInformationLimitsPacks))
        {
            this.Users = Users;
            this.Documents = Documents;
            this.Packs = Packs;
        }

        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name = "users", EmitDefaultValue = false)]
        public LicenseInformationLimitsUsers Users { get; set; }
        /// <summary>
        /// Gets or Sets Documents
        /// </summary>
        [DataMember(Name = "documents", EmitDefaultValue = false)]
        public LicenseInformationLimitsDocuments Documents { get; set; }
        /// <summary>
        /// Gets or Sets Packs
        /// </summary>
        [DataMember(Name = "packs", EmitDefaultValue = false)]
        public LicenseInformationLimitsPacks Packs { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LicenseInformationLimits {\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  Documents: ").Append(Documents).Append("\n");
            sb.Append("  Packs: ").Append(Packs).Append("\n");
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
            return this.Equals(obj as LicenseInformationLimits);
        }

        /// <summary>
        /// Returns true if LicenseInformationLimits instances are equal
        /// </summary>
        /// <param name="other">Instance of LicenseInformationLimits to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LicenseInformationLimits other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Users == other.Users ||
                    this.Users != null &&
                    this.Users.Equals(other.Users)
                ) &&
                (
                    this.Documents == other.Documents ||
                    this.Documents != null &&
                    this.Documents.Equals(other.Documents)
                ) &&
                (
                    this.Packs == other.Packs ||
                    this.Packs != null &&
                    this.Packs.Equals(other.Packs)
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
                if (this.Users != null)
                    hash = hash * 59 + this.Users.GetHashCode();
                if (this.Documents != null)
                    hash = hash * 59 + this.Documents.GetHashCode();
                if (this.Packs != null)
                    hash = hash * 59 + this.Packs.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
