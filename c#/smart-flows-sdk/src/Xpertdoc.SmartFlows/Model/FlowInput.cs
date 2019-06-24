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
    /// FlowInput
    /// </summary>
    [DataContract]
    public partial class FlowInput : IEquatable<FlowInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowInput" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Dataset">Dataset.</param>
        public FlowInput(string Id = default(string), string DisplayName = default(string), FlowInputType Type = default(FlowInputType), IdWithName Dataset = default(IdWithName))
        {
            this.Id = Id;
            this.DisplayName = DisplayName;
            this.Type = Type;
            this.Dataset = Dataset;
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
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public FlowInputType Type { get; set; }
        /// <summary>
        /// Gets or Sets Dataset
        /// </summary>
        [DataMember(Name = "dataset", EmitDefaultValue = false)]
        public IdWithName Dataset { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowInput {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Dataset: ").Append(Dataset).Append("\n");
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
            return this.Equals(obj as FlowInput);
        }

        /// <summary>
        /// Returns true if FlowInput instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowInput other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Dataset == other.Dataset ||
                    this.Dataset != null &&
                    this.Dataset.Equals(other.Dataset)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Dataset != null)
                    hash = hash * 59 + this.Dataset.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
