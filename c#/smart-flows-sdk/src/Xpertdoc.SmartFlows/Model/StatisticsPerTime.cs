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
    /// StatisticsPerTime
    /// </summary>
    [DataContract]
    public partial class StatisticsPerTime : IEquatable<StatisticsPerTime>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticsPerTime" /> class.
        /// </summary>
        /// <param name="Label">Label.</param>
        /// <param name="PerStatus">PerStatus.</param>
        /// <param name="TotalCount">TotalCount.</param>
        public StatisticsPerTime(string Label = default(string), List<StatisticsPerStatus> PerStatus = default(List<StatisticsPerStatus>), int? TotalCount = default(int?))
        {
            this.Label = Label;
            this.PerStatus = PerStatus;
            this.TotalCount = TotalCount;
        }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name = "label", EmitDefaultValue = false)]
        public string Label { get; set; }
        /// <summary>
        /// Gets or Sets PerStatus
        /// </summary>
        [DataMember(Name = "perStatus", EmitDefaultValue = false)]
        public List<StatisticsPerStatus> PerStatus { get; set; }
        /// <summary>
        /// Gets or Sets TotalCount
        /// </summary>
        [DataMember(Name = "totalCount", EmitDefaultValue = false)]
        public int? TotalCount { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatisticsPerTime {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  PerStatus: ").Append(PerStatus).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
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
            return this.Equals(obj as StatisticsPerTime);
        }

        /// <summary>
        /// Returns true if StatisticsPerTime instances are equal
        /// </summary>
        /// <param name="other">Instance of StatisticsPerTime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatisticsPerTime other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.Equals(other.Label)
                ) &&
                (
                    this.PerStatus == other.PerStatus ||
                    this.PerStatus != null &&
                    this.PerStatus.SequenceEqual(other.PerStatus)
                ) &&
                (
                    this.TotalCount == other.TotalCount ||
                    this.TotalCount != null &&
                    this.TotalCount.Equals(other.TotalCount)
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
                if (this.Label != null)
                    hash = hash * 59 + this.Label.GetHashCode();
                if (this.PerStatus != null)
                    hash = hash * 59 + this.PerStatus.GetHashCode();
                if (this.TotalCount != null)
                    hash = hash * 59 + this.TotalCount.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // TotalCount (int?) minimum
            if (this.TotalCount < (int?)0)
            {
                yield return new ValidationResult("Invalid value for TotalCount, must be a value greater than or equal to 0.", new[] { "TotalCount" });
            }

            yield break;
        }
    }

}
