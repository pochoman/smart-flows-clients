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
using System.Runtime.Serialization;
using System.Text;

namespace Xpertdoc.SmartFlows.Model
{
    /// <summary>
    /// Printer
    /// </summary>
    [DataContract]
    public partial class Printer : IEquatable<Printer>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Flavor
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FlavorEnum
        {

            /// <summary>
            /// Enum Jps for "jps"
            /// </summary>
            [EnumMember(Value = "jps")]
            Jps,

            /// <summary>
            /// Enum Gcp for "gcp"
            /// </summary>
            [EnumMember(Value = "gcp")]
            Gcp
        }

        /// <summary>
        /// Gets or Sets Flavor
        /// </summary>
        [DataMember(Name = "flavor", EmitDefaultValue = false)]
        public FlavorEnum? Flavor { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Printer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Printer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Printer" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="DisplayName">DisplayName (required).</param>
        /// <param name="Description">Description.</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="CreatedBy">CreatedBy.</param>
        /// <param name="ModifiedAt">ModifiedAt.</param>
        /// <param name="ModifiedBy">ModifiedBy.</param>
        /// <param name="Definition">Definition (required).</param>
        /// <param name="Flavor">Flavor.</param>
        /// <param name="DefaultPrinter">DefaultPrinter (default to false).</param>
        /// <param name="Properties">Properties.</param>
        public Printer(string Id = default(string), string DisplayName = default(string), string Description = default(string), string CreatedAt = default(string), IdWithName CreatedBy = default(IdWithName), string ModifiedAt = default(string), IdWithName ModifiedBy = default(IdWithName), IdWithName Definition = default(IdWithName), FlavorEnum? Flavor = default(FlavorEnum?), bool? DefaultPrinter = false, PrinterProperties Properties = default(PrinterProperties))
        {
            // to ensure "DisplayName" is required (not null)
            if (DisplayName == null)
            {
                throw new InvalidDataException("DisplayName is a required property for Printer and cannot be null");
            }
            else
            {
                this.DisplayName = DisplayName;
            }
            // to ensure "Definition" is required (not null)
            if (Definition == null)
            {
                throw new InvalidDataException("Definition is a required property for Printer and cannot be null");
            }
            else
            {
                this.Definition = Definition;
            }
            this.Id = Id;
            this.Description = Description;
            this.CreatedAt = CreatedAt;
            this.CreatedBy = CreatedBy;
            this.ModifiedAt = ModifiedAt;
            this.ModifiedBy = ModifiedBy;
            this.Flavor = Flavor;
            // use default value if no "DefaultPrinter" provided
            if (DefaultPrinter == null)
            {
                this.DefaultPrinter = false;
            }
            else
            {
                this.DefaultPrinter = DefaultPrinter;
            }
            this.Properties = Properties;
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
        /// Gets or Sets Definition
        /// </summary>
        [DataMember(Name = "definition", EmitDefaultValue = false)]
        public IdWithName Definition { get; set; }
        /// <summary>
        /// Gets or Sets DefaultPrinter
        /// </summary>
        [DataMember(Name = "defaultPrinter", EmitDefaultValue = false)]
        public bool? DefaultPrinter { get; set; }
        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name = "properties", EmitDefaultValue = false)]
        public PrinterProperties Properties { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Printer {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  ModifiedAt: ").Append(ModifiedAt).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  Definition: ").Append(Definition).Append("\n");
            sb.Append("  Flavor: ").Append(Flavor).Append("\n");
            sb.Append("  DefaultPrinter: ").Append(DefaultPrinter).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return this.Equals(obj as Printer);
        }

        /// <summary>
        /// Returns true if Printer instances are equal
        /// </summary>
        /// <param name="other">Instance of Printer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Printer other)
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
                    this.Definition == other.Definition ||
                    this.Definition != null &&
                    this.Definition.Equals(other.Definition)
                ) &&
                (
                    this.Flavor == other.Flavor ||
                    this.Flavor != null &&
                    this.Flavor.Equals(other.Flavor)
                ) &&
                (
                    this.DefaultPrinter == other.DefaultPrinter ||
                    this.DefaultPrinter != null &&
                    this.DefaultPrinter.Equals(other.DefaultPrinter)
                ) &&
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.Equals(other.Properties)
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
                if (this.Definition != null)
                    hash = hash * 59 + this.Definition.GetHashCode();
                if (this.Flavor != null)
                    hash = hash * 59 + this.Flavor.GetHashCode();
                if (this.DefaultPrinter != null)
                    hash = hash * 59 + this.DefaultPrinter.GetHashCode();
                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();
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
