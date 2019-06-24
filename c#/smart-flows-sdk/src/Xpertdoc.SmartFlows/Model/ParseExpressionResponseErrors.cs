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
    /// ParseExpressionResponseErrors
    /// </summary>
    [DataContract]
    public partial class ParseExpressionResponseErrors : IEquatable<ParseExpressionResponseErrors>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParseExpressionResponseErrors" /> class.
        /// </summary>
        /// <param name="Message">Message.</param>
        /// <param name="Line">Line.</param>
        /// <param name="PosInLine">PosInLine.</param>
        /// <param name="Offset">Offset.</param>
        public ParseExpressionResponseErrors(string Message = default(string), int? Line = default(int?), int? PosInLine = default(int?), int? Offset = default(int?))
        {
            this.Message = Message;
            this.Line = Line;
            this.PosInLine = PosInLine;
            this.Offset = Offset;
        }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }
        /// <summary>
        /// Gets or Sets Line
        /// </summary>
        [DataMember(Name = "line", EmitDefaultValue = false)]
        public int? Line { get; set; }
        /// <summary>
        /// Gets or Sets PosInLine
        /// </summary>
        [DataMember(Name = "posInLine", EmitDefaultValue = false)]
        public int? PosInLine { get; set; }
        /// <summary>
        /// Gets or Sets Offset
        /// </summary>
        [DataMember(Name = "offset", EmitDefaultValue = false)]
        public int? Offset { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParseExpressionResponseErrors {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Line: ").Append(Line).Append("\n");
            sb.Append("  PosInLine: ").Append(PosInLine).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
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
            return this.Equals(obj as ParseExpressionResponseErrors);
        }

        /// <summary>
        /// Returns true if ParseExpressionResponseErrors instances are equal
        /// </summary>
        /// <param name="other">Instance of ParseExpressionResponseErrors to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParseExpressionResponseErrors other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) &&
                (
                    this.Line == other.Line ||
                    this.Line != null &&
                    this.Line.Equals(other.Line)
                ) &&
                (
                    this.PosInLine == other.PosInLine ||
                    this.PosInLine != null &&
                    this.PosInLine.Equals(other.PosInLine)
                ) &&
                (
                    this.Offset == other.Offset ||
                    this.Offset != null &&
                    this.Offset.Equals(other.Offset)
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
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.Line != null)
                    hash = hash * 59 + this.Line.GetHashCode();
                if (this.PosInLine != null)
                    hash = hash * 59 + this.PosInLine.GetHashCode();
                if (this.Offset != null)
                    hash = hash * 59 + this.Offset.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
