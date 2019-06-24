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
    /// FlowDoStep
    /// </summary>
    [DataContract]
    public partial class FlowDoStep : IEquatable<FlowDoStep>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowDoStep" /> class.
        /// </summary>
        /// <param name="StepId">StepId.</param>
        /// <param name="UserSelectable">UserSelectable.</param>
        /// <param name="UserSelectableDefault">UserSelectableDefault.</param>
        /// <param name="Parameters">Parameters.</param>
        public FlowDoStep(string StepId = default(string), bool? UserSelectable = default(bool?), bool? UserSelectableDefault = default(bool?), Object Parameters = default(Object))
        {
            this.StepId = StepId;
            this.UserSelectable = UserSelectable;
            this.UserSelectableDefault = UserSelectableDefault;
            this.Parameters = Parameters;
        }

        /// <summary>
        /// Gets or Sets StepId
        /// </summary>
        [DataMember(Name = "stepId", EmitDefaultValue = false)]
        public string StepId { get; set; }
        /// <summary>
        /// Gets or Sets UserSelectable
        /// </summary>
        [DataMember(Name = "userSelectable", EmitDefaultValue = false)]
        public bool? UserSelectable { get; set; }
        /// <summary>
        /// Gets or Sets UserSelectableDefault
        /// </summary>
        [DataMember(Name = "userSelectableDefault", EmitDefaultValue = false)]
        public bool? UserSelectableDefault { get; set; }
        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name = "parameters", EmitDefaultValue = false)]
        public Object Parameters { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowDoStep {\n");
            sb.Append("  StepId: ").Append(StepId).Append("\n");
            sb.Append("  UserSelectable: ").Append(UserSelectable).Append("\n");
            sb.Append("  UserSelectableDefault: ").Append(UserSelectableDefault).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
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
            return this.Equals(obj as FlowDoStep);
        }

        /// <summary>
        /// Returns true if FlowDoStep instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowDoStep to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowDoStep other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.StepId == other.StepId ||
                    this.StepId != null &&
                    this.StepId.Equals(other.StepId)
                ) &&
                (
                    this.UserSelectable == other.UserSelectable ||
                    this.UserSelectable != null &&
                    this.UserSelectable.Equals(other.UserSelectable)
                ) &&
                (
                    this.UserSelectableDefault == other.UserSelectableDefault ||
                    this.UserSelectableDefault != null &&
                    this.UserSelectableDefault.Equals(other.UserSelectableDefault)
                ) &&
                (
                    this.Parameters == other.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.Equals(other.Parameters)
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
                if (this.StepId != null)
                    hash = hash * 59 + this.StepId.GetHashCode();
                if (this.UserSelectable != null)
                    hash = hash * 59 + this.UserSelectable.GetHashCode();
                if (this.UserSelectableDefault != null)
                    hash = hash * 59 + this.UserSelectableDefault.GetHashCode();
                if (this.Parameters != null)
                    hash = hash * 59 + this.Parameters.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
