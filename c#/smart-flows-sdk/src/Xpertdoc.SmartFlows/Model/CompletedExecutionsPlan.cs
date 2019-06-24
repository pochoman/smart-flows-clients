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
    /// CompletedExecutionsPlan
    /// </summary>
    [DataContract]
    public partial class CompletedExecutionsPlan : IEquatable<CompletedExecutionsPlan>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompletedExecutionsPlan" /> class.
        /// </summary>
        /// <param name="Schedule">Schedule.</param>
        /// <param name="_Internal">_Internal.</param>
        /// <param name="Output">Output.</param>
        /// <param name="Full">Full.</param>
        public CompletedExecutionsPlan(Schedule Schedule = default(Schedule), CleanupActionSettings _Internal = default(CleanupActionSettings), CleanupActionSettings Output = default(CleanupActionSettings), CleanupActionSettings Full = default(CleanupActionSettings))
        {
            this.Schedule = Schedule;
            this._Internal = _Internal;
            this.Output = Output;
            this.Full = Full;
        }

        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name = "schedule", EmitDefaultValue = false)]
        public Schedule Schedule { get; set; }
        /// <summary>
        /// Gets or Sets _Internal
        /// </summary>
        [DataMember(Name = "internal", EmitDefaultValue = false)]
        public CleanupActionSettings _Internal { get; set; }
        /// <summary>
        /// Gets or Sets Output
        /// </summary>
        [DataMember(Name = "output", EmitDefaultValue = false)]
        public CleanupActionSettings Output { get; set; }
        /// <summary>
        /// Gets or Sets Full
        /// </summary>
        [DataMember(Name = "full", EmitDefaultValue = false)]
        public CleanupActionSettings Full { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompletedExecutionsPlan {\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  _Internal: ").Append(_Internal).Append("\n");
            sb.Append("  Output: ").Append(Output).Append("\n");
            sb.Append("  Full: ").Append(Full).Append("\n");
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
            return this.Equals(obj as CompletedExecutionsPlan);
        }

        /// <summary>
        /// Returns true if CompletedExecutionsPlan instances are equal
        /// </summary>
        /// <param name="other">Instance of CompletedExecutionsPlan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompletedExecutionsPlan other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Schedule == other.Schedule ||
                    this.Schedule != null &&
                    this.Schedule.Equals(other.Schedule)
                ) &&
                (
                    this._Internal == other._Internal ||
                    this._Internal != null &&
                    this._Internal.Equals(other._Internal)
                ) &&
                (
                    this.Output == other.Output ||
                    this.Output != null &&
                    this.Output.Equals(other.Output)
                ) &&
                (
                    this.Full == other.Full ||
                    this.Full != null &&
                    this.Full.Equals(other.Full)
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
                if (this.Schedule != null)
                    hash = hash * 59 + this.Schedule.GetHashCode();
                if (this._Internal != null)
                    hash = hash * 59 + this._Internal.GetHashCode();
                if (this.Output != null)
                    hash = hash * 59 + this.Output.GetHashCode();
                if (this.Full != null)
                    hash = hash * 59 + this.Full.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
