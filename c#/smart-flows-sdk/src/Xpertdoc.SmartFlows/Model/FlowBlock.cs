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
    /// FlowBlock
    /// </summary>
    [DataContract]
    public partial class FlowBlock : IEquatable<FlowBlock>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowBlock" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="OutputParameters">OutputParameters.</param>
        /// <param name="Step">Step.</param>
        /// <param name="Condition">Condition.</param>
        /// <param name="_Try">_Try.</param>
        /// <param name="_Switch">_Switch.</param>
        public FlowBlock(string Id = default(string), string DisplayName = default(string), List<string> OutputParameters = default(List<string>), FlowDoStep Step = default(FlowDoStep), FlowCondition Condition = default(FlowCondition), FlowTry _Try = default(FlowTry), FlowSwitch _Switch = default(FlowSwitch))
        {
            this.Id = Id;
            this.DisplayName = DisplayName;
            this.OutputParameters = OutputParameters;
            this.Step = Step;
            this.Condition = Condition;
            this._Try = _Try;
            this._Switch = _Switch;
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
        /// Gets or Sets OutputParameters
        /// </summary>
        [DataMember(Name = "outputParameters", EmitDefaultValue = false)]
        public List<string> OutputParameters { get; set; }
        /// <summary>
        /// Gets or Sets Step
        /// </summary>
        [DataMember(Name = "step", EmitDefaultValue = false)]
        public FlowDoStep Step { get; set; }
        /// <summary>
        /// Gets or Sets Condition
        /// </summary>
        [DataMember(Name = "condition", EmitDefaultValue = false)]
        public FlowCondition Condition { get; set; }
        /// <summary>
        /// Gets or Sets _Try
        /// </summary>
        [DataMember(Name = "try", EmitDefaultValue = false)]
        public FlowTry _Try { get; set; }
        /// <summary>
        /// Gets or Sets _Switch
        /// </summary>
        [DataMember(Name = "switch", EmitDefaultValue = false)]
        public FlowSwitch _Switch { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowBlock {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  OutputParameters: ").Append(OutputParameters).Append("\n");
            sb.Append("  Step: ").Append(Step).Append("\n");
            sb.Append("  Condition: ").Append(Condition).Append("\n");
            sb.Append("  _Try: ").Append(_Try).Append("\n");
            sb.Append("  _Switch: ").Append(_Switch).Append("\n");
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
            return this.Equals(obj as FlowBlock);
        }

        /// <summary>
        /// Returns true if FlowBlock instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowBlock to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowBlock other)
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
                    this.OutputParameters == other.OutputParameters ||
                    this.OutputParameters != null &&
                    this.OutputParameters.SequenceEqual(other.OutputParameters)
                ) &&
                (
                    this.Step == other.Step ||
                    this.Step != null &&
                    this.Step.Equals(other.Step)
                ) &&
                (
                    this.Condition == other.Condition ||
                    this.Condition != null &&
                    this.Condition.Equals(other.Condition)
                ) &&
                (
                    this._Try == other._Try ||
                    this._Try != null &&
                    this._Try.Equals(other._Try)
                ) &&
                (
                    this._Switch == other._Switch ||
                    this._Switch != null &&
                    this._Switch.Equals(other._Switch)
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
                if (this.OutputParameters != null)
                    hash = hash * 59 + this.OutputParameters.GetHashCode();
                if (this.Step != null)
                    hash = hash * 59 + this.Step.GetHashCode();
                if (this.Condition != null)
                    hash = hash * 59 + this.Condition.GetHashCode();
                if (this._Try != null)
                    hash = hash * 59 + this._Try.GetHashCode();
                if (this._Switch != null)
                    hash = hash * 59 + this._Switch.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
