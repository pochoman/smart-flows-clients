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
    /// PrinterDefinition
    /// </summary>
    [DataContract]
    public partial class PrinterDefinition : IEquatable<PrinterDefinition>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="PrinterDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PrinterDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PrinterDefinition" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="DisplayName">DisplayName (required).</param>
        /// <param name="Description">Description.</param>
        /// <param name="Flavor">Flavor (required).</param>
        /// <param name="PrinterInfo">PrinterInfo.</param>
        public PrinterDefinition(string Id = default(string), string DisplayName = default(string), string Description = default(string), FlavorEnum? Flavor = default(FlavorEnum?), PrinterDefinitionPrinterInfo PrinterInfo = default(PrinterDefinitionPrinterInfo))
        {
            // to ensure "DisplayName" is required (not null)
            if (DisplayName == null)
            {
                throw new InvalidDataException("DisplayName is a required property for PrinterDefinition and cannot be null");
            }
            else
            {
                this.DisplayName = DisplayName;
            }
            // to ensure "Flavor" is required (not null)
            if (Flavor == null)
            {
                throw new InvalidDataException("Flavor is a required property for PrinterDefinition and cannot be null");
            }
            else
            {
                this.Flavor = Flavor;
            }
            this.Id = Id;
            this.Description = Description;
            this.PrinterInfo = PrinterInfo;
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
        /// Gets or Sets PrinterInfo
        /// </summary>
        [DataMember(Name = "printerInfo", EmitDefaultValue = false)]
        public PrinterDefinitionPrinterInfo PrinterInfo { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrinterDefinition {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Flavor: ").Append(Flavor).Append("\n");
            sb.Append("  PrinterInfo: ").Append(PrinterInfo).Append("\n");
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
            return this.Equals(obj as PrinterDefinition);
        }

        /// <summary>
        /// Returns true if PrinterDefinition instances are equal
        /// </summary>
        /// <param name="other">Instance of PrinterDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrinterDefinition other)
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
                    this.Flavor == other.Flavor ||
                    this.Flavor != null &&
                    this.Flavor.Equals(other.Flavor)
                ) &&
                (
                    this.PrinterInfo == other.PrinterInfo ||
                    this.PrinterInfo != null &&
                    this.PrinterInfo.Equals(other.PrinterInfo)
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
                if (this.Flavor != null)
                    hash = hash * 59 + this.Flavor.GetHashCode();
                if (this.PrinterInfo != null)
                    hash = hash * 59 + this.PrinterInfo.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
