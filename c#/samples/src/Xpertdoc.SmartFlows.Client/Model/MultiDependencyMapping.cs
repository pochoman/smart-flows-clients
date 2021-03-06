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
    /// MultiDependencyMapping
    /// </summary>
    [DataContract]
    public partial class MultiDependencyMapping :  IEquatable<MultiDependencyMapping>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiDependencyMapping" /> class.
        /// </summary>
        /// <param name="Source">Source.</param>
        /// <param name="Targets">Targets.</param>
        public MultiDependencyMapping(IdWithName Source = default(IdWithName), List<IdWithName> Targets = default(List<IdWithName>))
        {
            this.Source = Source;
            this.Targets = Targets;
        }
        
        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public IdWithName Source { get; set; }

        /// <summary>
        /// Gets or Sets Targets
        /// </summary>
        [DataMember(Name="targets", EmitDefaultValue=false)]
        public List<IdWithName> Targets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultiDependencyMapping {\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Targets: ").Append(Targets).Append("\n");
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
            return this.Equals(obj as MultiDependencyMapping);
        }

        /// <summary>
        /// Returns true if MultiDependencyMapping instances are equal
        /// </summary>
        /// <param name="other">Instance of MultiDependencyMapping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MultiDependencyMapping other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
                ) && 
                (
                    this.Targets == other.Targets ||
                    this.Targets != null &&
                    this.Targets.SequenceEqual(other.Targets)
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
                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();
                if (this.Targets != null)
                    hash = hash * 59 + this.Targets.GetHashCode();
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
