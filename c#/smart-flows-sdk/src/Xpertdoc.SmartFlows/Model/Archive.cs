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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Xpertdoc.SmartFlows.Model
{
    /// <summary>
    /// Archive
    /// </summary>
    [DataContract]
    public partial class Archive : IEquatable<Archive>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Archive" /> class.
        /// </summary>
        /// <param name="General">General.</param>
        /// <param name="Items">Items.</param>
        public Archive(ArchiveGeneral General = default(ArchiveGeneral), List<Archivable> Items = default(List<Archivable>))
        {
            this.General = General;
            this.Items = Items;
        }

        /// <summary>
        /// Gets or Sets General
        /// </summary>
        [DataMember(Name = "general", EmitDefaultValue = false)]
        public ArchiveGeneral General { get; set; }
        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public List<Archivable> Items { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Archive {\n");
            sb.Append("  General: ").Append(General).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(obj as Archive);
        }

        /// <summary>
        /// Returns true if Archive instances are equal
        /// </summary>
        /// <param name="other">Instance of Archive to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Archive other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.General == other.General ||
                    this.General != null &&
                    this.General.Equals(other.General)
                ) &&
                (
                    this.Items == other.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(other.Items)
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
                if (this.General != null)
                    hash = hash * 59 + this.General.GetHashCode();
                if (this.Items != null)
                    hash = hash * 59 + this.Items.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
