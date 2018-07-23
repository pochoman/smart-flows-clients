/* 
 * Xpertdoc SmartFlows
 *
 * This describes the REST api for one Xpertdoc SmartFlows project
 *
 * OpenAPI spec version: 4.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Xpertdoc.SmartFlows.Client.Client.SwaggerDateConverter;

namespace Xpertdoc.SmartFlows.Client.Model
{
    /// <summary>
    /// Period
    /// </summary>
    [DataContract]
    public partial class Period :  IEquatable<Period>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets TimeUnit
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TimeUnitEnum
        {
            
            /// <summary>
            /// Enum Seconds for "seconds"
            /// </summary>
            [EnumMember(Value = "seconds")]
            Seconds,
            
            /// <summary>
            /// Enum Minutes for "minutes"
            /// </summary>
            [EnumMember(Value = "minutes")]
            Minutes,
            
            /// <summary>
            /// Enum Hours for "hours"
            /// </summary>
            [EnumMember(Value = "hours")]
            Hours,
            
            /// <summary>
            /// Enum Days for "days"
            /// </summary>
            [EnumMember(Value = "days")]
            Days
        }

        /// <summary>
        /// Gets or Sets TimeUnit
        /// </summary>
        [DataMember(Name="timeUnit", EmitDefaultValue=false)]
        public TimeUnitEnum? TimeUnit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Period" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Period() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Period" /> class.
        /// </summary>
        /// <param name="_Period">_Period (required).</param>
        /// <param name="TimeUnit">TimeUnit (required).</param>
        public Period(int? _Period = default(int?), TimeUnitEnum? TimeUnit = default(TimeUnitEnum?))
        {
            // to ensure "_Period" is required (not null)
            if (_Period == null)
            {
                throw new InvalidDataException("_Period is a required property for Period and cannot be null");
            }
            else
            {
                this._Period = _Period;
            }
            // to ensure "TimeUnit" is required (not null)
            if (TimeUnit == null)
            {
                throw new InvalidDataException("TimeUnit is a required property for Period and cannot be null");
            }
            else
            {
                this.TimeUnit = TimeUnit;
            }
        }
        
        /// <summary>
        /// Gets or Sets _Period
        /// </summary>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public int? _Period { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Period {\n");
            sb.Append("  _Period: ").Append(_Period).Append("\n");
            sb.Append("  TimeUnit: ").Append(TimeUnit).Append("\n");
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
            return this.Equals(obj as Period);
        }

        /// <summary>
        /// Returns true if Period instances are equal
        /// </summary>
        /// <param name="other">Instance of Period to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Period other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._Period == other._Period ||
                    this._Period != null &&
                    this._Period.Equals(other._Period)
                ) && 
                (
                    this.TimeUnit == other.TimeUnit ||
                    this.TimeUnit != null &&
                    this.TimeUnit.Equals(other.TimeUnit)
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
                if (this._Period != null)
                    hash = hash * 59 + this._Period.GetHashCode();
                if (this.TimeUnit != null)
                    hash = hash * 59 + this.TimeUnit.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}