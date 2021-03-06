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
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Xpertdoc.SmartFlows.Model
{
    /// <summary>
    /// Plugin
    /// </summary>
    [DataContract]
    public partial class Plugin : IEquatable<Plugin>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Plugin" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Plugin() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Plugin" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="DisplayName">DisplayName (required).</param>
        /// <param name="Description">Description.</param>
        /// <param name="ConnectorType">ConnectorType.</param>
        /// <param name="InputDataset">InputDataset.</param>
        /// <param name="FlowSteps">FlowSteps.</param>
        public Plugin(string Id = default(string), string DisplayName = default(string), string Description = default(string), IdWithName ConnectorType = default(IdWithName), IdWithName InputDataset = default(IdWithName), List<IdWithName> FlowSteps = default(List<IdWithName>))
        {
            // to ensure "DisplayName" is required (not null)
            if (DisplayName == null)
            {
                throw new InvalidDataException("DisplayName is a required property for Plugin and cannot be null");
            }
            else
            {
                this.DisplayName = DisplayName;
            }
            this.Id = Id;
            this.Description = Description;
            this.ConnectorType = ConnectorType;
            this.InputDataset = InputDataset;
            this.FlowSteps = FlowSteps;
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
        /// Gets or Sets ConnectorType
        /// </summary>
        [DataMember(Name = "connectorType", EmitDefaultValue = false)]
        public IdWithName ConnectorType { get; set; }
        /// <summary>
        /// Gets or Sets InputDataset
        /// </summary>
        [DataMember(Name = "inputDataset", EmitDefaultValue = false)]
        public IdWithName InputDataset { get; set; }
        /// <summary>
        /// Gets or Sets FlowSteps
        /// </summary>
        [DataMember(Name = "flowSteps", EmitDefaultValue = false)]
        public List<IdWithName> FlowSteps { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Plugin {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ConnectorType: ").Append(ConnectorType).Append("\n");
            sb.Append("  InputDataset: ").Append(InputDataset).Append("\n");
            sb.Append("  FlowSteps: ").Append(FlowSteps).Append("\n");
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
            return this.Equals(obj as Plugin);
        }

        /// <summary>
        /// Returns true if Plugin instances are equal
        /// </summary>
        /// <param name="other">Instance of Plugin to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Plugin other)
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
                    this.ConnectorType == other.ConnectorType ||
                    this.ConnectorType != null &&
                    this.ConnectorType.Equals(other.ConnectorType)
                ) &&
                (
                    this.InputDataset == other.InputDataset ||
                    this.InputDataset != null &&
                    this.InputDataset.Equals(other.InputDataset)
                ) &&
                (
                    this.FlowSteps == other.FlowSteps ||
                    this.FlowSteps != null &&
                    this.FlowSteps.SequenceEqual(other.FlowSteps)
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
                if (this.ConnectorType != null)
                    hash = hash * 59 + this.ConnectorType.GetHashCode();
                if (this.InputDataset != null)
                    hash = hash * 59 + this.InputDataset.GetHashCode();
                if (this.FlowSteps != null)
                    hash = hash * 59 + this.FlowSteps.GetHashCode();
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
