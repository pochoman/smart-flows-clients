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
    /// CustomContentFieldBoolean
    /// </summary>
    [DataContract]
    public partial class CustomContentFieldBoolean : IEquatable<CustomContentFieldBoolean>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomContentFieldBoolean" /> class.
        /// </summary>
        /// <param name="_Default">_Default.</param>
        public CustomContentFieldBoolean(bool? _Default = default(bool?))
        {
            this._Default = _Default;
        }

        /// <summary>
        /// Gets or Sets _Default
        /// </summary>
        [DataMember(Name = "default", EmitDefaultValue = false)]
        public bool? _Default { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomContentFieldBoolean {\n");
            sb.Append("  _Default: ").Append(_Default).Append("\n");
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
            return this.Equals(obj as CustomContentFieldBoolean);
        }

        /// <summary>
        /// Returns true if CustomContentFieldBoolean instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomContentFieldBoolean to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomContentFieldBoolean other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this._Default == other._Default ||
                    this._Default != null &&
                    this._Default.Equals(other._Default)
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
                if (this._Default != null)
                    hash = hash * 59 + this._Default.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
