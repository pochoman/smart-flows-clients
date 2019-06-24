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
    /// Some flows are executed multiple times, these are the iterations
    /// </summary>
    [DataContract]
    public partial class FlowExecutionIteration : IEquatable<FlowExecutionIteration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowExecutionIteration" /> class.
        /// </summary>
        /// <param name="Id">Contrary to most IDs, this does not have to be a UUID, just a string unique to one execution.</param>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="Report">Report.</param>
        public FlowExecutionIteration(string Id = default(string), string DisplayName = default(string), List<FlowZoneState> Report = default(List<FlowZoneState>))
        {
            this.Id = Id;
            this.DisplayName = DisplayName;
            this.Report = Report;
        }

        /// <summary>
        /// Contrary to most IDs, this does not have to be a UUID, just a string unique to one execution
        /// </summary>
        /// <value>Contrary to most IDs, this does not have to be a UUID, just a string unique to one execution</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or Sets Report
        /// </summary>
        [DataMember(Name = "report", EmitDefaultValue = false)]
        public List<FlowZoneState> Report { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowExecutionIteration {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Report: ").Append(Report).Append("\n");
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
            return this.Equals(obj as FlowExecutionIteration);
        }

        /// <summary>
        /// Returns true if FlowExecutionIteration instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowExecutionIteration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowExecutionIteration other)
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
                    this.Report == other.Report ||
                    this.Report != null &&
                    this.Report.SequenceEqual(other.Report)
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
                if (this.Report != null)
                    hash = hash * 59 + this.Report.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
