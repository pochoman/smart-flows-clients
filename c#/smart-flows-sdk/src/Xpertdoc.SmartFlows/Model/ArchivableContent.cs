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
    /// ArchivableContent
    /// </summary>
    [DataContract]
    public partial class ArchivableContent : IEquatable<ArchivableContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArchivableContent" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Parent">Parent.</param>
        /// <param name="Revision">Revision.</param>
        /// <param name="Checksum">Checksum.</param>
        /// <param name="Language">Language.</param>
        /// <param name="Definition">Definition.</param>
        public ArchivableContent(string Id = default(string), string Description = default(string), string Parent = default(string), int? Revision = default(int?), string Checksum = default(string), string Language = default(string), string Definition = default(string))
        {
            this.Id = Id;
            this.Description = Description;
            this.Parent = Parent;
            this.Revision = Revision;
            this.Checksum = Checksum;
            this.Language = Language;
            this.Definition = Definition;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets Parent
        /// </summary>
        [DataMember(Name = "parent", EmitDefaultValue = false)]
        public string Parent { get; set; }
        /// <summary>
        /// Gets or Sets Revision
        /// </summary>
        [DataMember(Name = "revision", EmitDefaultValue = false)]
        public int? Revision { get; set; }
        /// <summary>
        /// Gets or Sets Checksum
        /// </summary>
        [DataMember(Name = "checksum", EmitDefaultValue = false)]
        public string Checksum { get; set; }
        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public string Language { get; set; }
        /// <summary>
        /// Gets or Sets Definition
        /// </summary>
        [DataMember(Name = "definition", EmitDefaultValue = false)]
        public string Definition { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArchivableContent {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  Checksum: ").Append(Checksum).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Definition: ").Append(Definition).Append("\n");
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
            return this.Equals(obj as ArchivableContent);
        }

        /// <summary>
        /// Returns true if ArchivableContent instances are equal
        /// </summary>
        /// <param name="other">Instance of ArchivableContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArchivableContent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Parent == other.Parent ||
                    this.Parent != null &&
                    this.Parent.Equals(other.Parent)
                ) &&
                (
                    this.Revision == other.Revision ||
                    this.Revision != null &&
                    this.Revision.Equals(other.Revision)
                ) &&
                (
                    this.Checksum == other.Checksum ||
                    this.Checksum != null &&
                    this.Checksum.Equals(other.Checksum)
                ) &&
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) &&
                (
                    this.Definition == other.Definition ||
                    this.Definition != null &&
                    this.Definition.Equals(other.Definition)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Parent != null)
                    hash = hash * 59 + this.Parent.GetHashCode();
                if (this.Revision != null)
                    hash = hash * 59 + this.Revision.GetHashCode();
                if (this.Checksum != null)
                    hash = hash * 59 + this.Checksum.GetHashCode();
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                if (this.Definition != null)
                    hash = hash * 59 + this.Definition.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
