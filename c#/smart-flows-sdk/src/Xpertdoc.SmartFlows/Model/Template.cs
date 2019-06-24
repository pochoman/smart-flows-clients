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
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Xpertdoc.SmartFlows.Model
{
    /// <summary>
    /// Template
    /// </summary>
    [DataContract]
    public partial class Template : IEquatable<Template>, IValidatableObject
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
            Composed,

            /// <summary>
            /// Enum Portal for "portal"
            /// </summary>
            [EnumMember(Value = "portal")]
            Portal
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Template" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Template() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Template" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="DisplayName">DisplayName (required).</param>
        /// <param name="Description">Description.</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="CreatedBy">CreatedBy.</param>
        /// <param name="ModifiedAt">ModifiedAt.</param>
        /// <param name="ModifiedBy">ModifiedBy.</param>
        /// <param name="Datasets">Datasets.</param>
        /// <param name="Type">Type.</param>
        /// <param name="TagGroups">TagGroups.</param>
        /// <param name="StandardContent">StandardContent.</param>
        /// <param name="ComposedContent">ComposedContent.</param>
        /// <param name="PortalContent">PortalContent.</param>
        public Template(string Id = default(string), string DisplayName = default(string), string Description = default(string), string CreatedAt = default(string), IdWithName CreatedBy = default(IdWithName), string ModifiedAt = default(string), IdWithName ModifiedBy = default(IdWithName), List<TemplateDatasets> Datasets = default(List<TemplateDatasets>), TypeEnum? Type = default(TypeEnum?), List<TagGroupRef> TagGroups = default(List<TagGroupRef>), TemplateStandardContent StandardContent = default(TemplateStandardContent), TemplateComposedContent ComposedContent = default(TemplateComposedContent), TemplatePortalContent PortalContent = default(TemplatePortalContent))
        {
            // to ensure "DisplayName" is required (not null)
            if (DisplayName == null)
            {
                throw new InvalidDataException("DisplayName is a required property for Template and cannot be null");
            }
            else
            {
                this.DisplayName = DisplayName;
            }
            this.Id = Id;
            this.Description = Description;
            this.CreatedAt = CreatedAt;
            this.CreatedBy = CreatedBy;
            this.ModifiedAt = ModifiedAt;
            this.ModifiedBy = ModifiedBy;
            this.Datasets = Datasets;
            this.Type = Type;
            this.TagGroups = TagGroups;
            this.StandardContent = StandardContent;
            this.ComposedContent = ComposedContent;
            this.PortalContent = PortalContent;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }
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
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }
        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public IdWithName CreatedBy { get; set; }
        /// <summary>
        /// Gets or Sets ModifiedAt
        /// </summary>
        [DataMember(Name = "modifiedAt", EmitDefaultValue = false)]
        public string ModifiedAt { get; set; }
        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
        public IdWithName ModifiedBy { get; set; }
        /// <summary>
        /// Gets or Sets Datasets
        /// </summary>
        [DataMember(Name = "datasets", EmitDefaultValue = false)]
        public List<TemplateDatasets> Datasets { get; set; }
        /// <summary>
        /// Gets or Sets TagGroups
        /// </summary>
        [DataMember(Name = "tagGroups", EmitDefaultValue = false)]
        public List<TagGroupRef> TagGroups { get; set; }
        /// <summary>
        /// Gets or Sets StandardContent
        /// </summary>
        [DataMember(Name = "standardContent", EmitDefaultValue = false)]
        public TemplateStandardContent StandardContent { get; set; }
        /// <summary>
        /// Gets or Sets ComposedContent
        /// </summary>
        [DataMember(Name = "composedContent", EmitDefaultValue = false)]
        public TemplateComposedContent ComposedContent { get; set; }
        /// <summary>
        /// Gets or Sets PortalContent
        /// </summary>
        [DataMember(Name = "portalContent", EmitDefaultValue = false)]
        public TemplatePortalContent PortalContent { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Template {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  ModifiedAt: ").Append(ModifiedAt).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  Datasets: ").Append(Datasets).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TagGroups: ").Append(TagGroups).Append("\n");
            sb.Append("  StandardContent: ").Append(StandardContent).Append("\n");
            sb.Append("  ComposedContent: ").Append(ComposedContent).Append("\n");
            sb.Append("  PortalContent: ").Append(PortalContent).Append("\n");
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
            return this.Equals(obj as Template);
        }

        /// <summary>
        /// Returns true if Template instances are equal
        /// </summary>
        /// <param name="other">Instance of Template to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Template other)
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
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.ModifiedAt == other.ModifiedAt ||
                    this.ModifiedAt != null &&
                    this.ModifiedAt.Equals(other.ModifiedAt)
                ) &&
                (
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
                ) &&
                (
                    this.Datasets == other.Datasets ||
                    this.Datasets != null &&
                    this.Datasets.SequenceEqual(other.Datasets)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.TagGroups == other.TagGroups ||
                    this.TagGroups != null &&
                    this.TagGroups.SequenceEqual(other.TagGroups)
                ) &&
                (
                    this.StandardContent == other.StandardContent ||
                    this.StandardContent != null &&
                    this.StandardContent.Equals(other.StandardContent)
                ) &&
                (
                    this.ComposedContent == other.ComposedContent ||
                    this.ComposedContent != null &&
                    this.ComposedContent.Equals(other.ComposedContent)
                ) &&
                (
                    this.PortalContent == other.PortalContent ||
                    this.PortalContent != null &&
                    this.PortalContent.Equals(other.PortalContent)
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
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                if (this.ModifiedAt != null)
                    hash = hash * 59 + this.ModifiedAt.GetHashCode();
                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();
                if (this.Datasets != null)
                    hash = hash * 59 + this.Datasets.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.TagGroups != null)
                    hash = hash * 59 + this.TagGroups.GetHashCode();
                if (this.StandardContent != null)
                    hash = hash * 59 + this.StandardContent.GetHashCode();
                if (this.ComposedContent != null)
                    hash = hash * 59 + this.ComposedContent.GetHashCode();
                if (this.PortalContent != null)
                    hash = hash * 59 + this.PortalContent.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // DisplayName (string) maxLength
            if (this.DisplayName != null && this.DisplayName.Length > 255)
            {
                yield return new ValidationResult("Invalid value for DisplayName, length must be less than 255.", new[] { "DisplayName" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 2048)
            {
                yield return new ValidationResult("Invalid value for Description, length must be less than 2048.", new[] { "Description" });
            }

            yield break;
        }
    }

}
