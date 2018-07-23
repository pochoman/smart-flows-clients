/* 
 * SmartFlows
 *
 * This describes the REST api for one SmartFlows project 
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
using SwaggerDateConverter = Xpertdoc.SmartFlows.Client.SwaggerDateConverter;

namespace Xpertdoc.SmartFlows.Model
{
    /// <summary>
    /// DocGenSettingsResultOdt
    /// </summary>
    [DataContract]
    public partial class DocGenSettingsResultOdt :  IEquatable<DocGenSettingsResultOdt>, IValidatableObject
    {
        /// <summary>
        /// Either ODT or OTT
        /// </summary>
        /// <value>Either ODT or OTT</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FormatEnum
        {
            
            /// <summary>
            /// Enum Odt for value: odt
            /// </summary>
            [EnumMember(Value = "odt")]
            Odt = 1,
            
            /// <summary>
            /// Enum Ott for value: ott
            /// </summary>
            [EnumMember(Value = "ott")]
            Ott = 2
        }

        /// <summary>
        /// Either ODT or OTT
        /// </summary>
        /// <value>Either ODT or OTT</value>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public FormatEnum? Format { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocGenSettingsResultOdt" /> class.
        /// </summary>
        /// <param name="Format">Either ODT or OTT (default to FormatEnum.Odt).</param>
        /// <param name="IsStrictSchema11">Specifies whether export should correspond to ODT specification 1.1 strictly. OOo 3.0 displays files correctly when they contain elements and attributes of ODT 1.2. Use false for this purpose, or true for strict conformity of specification 1.1 (default to false).</param>
        public DocGenSettingsResultOdt(FormatEnum? Format = FormatEnum.Odt, bool? IsStrictSchema11 = false)
        {
            // use default value if no "Format" provided
            if (Format == null)
            {
                this.Format = FormatEnum.Odt;
            }
            else
            {
                this.Format = Format;
            }
            // use default value if no "IsStrictSchema11" provided
            if (IsStrictSchema11 == null)
            {
                this.IsStrictSchema11 = false;
            }
            else
            {
                this.IsStrictSchema11 = IsStrictSchema11;
            }
        }
        

        /// <summary>
        /// Specifies whether export should correspond to ODT specification 1.1 strictly. OOo 3.0 displays files correctly when they contain elements and attributes of ODT 1.2. Use false for this purpose, or true for strict conformity of specification 1.1
        /// </summary>
        /// <value>Specifies whether export should correspond to ODT specification 1.1 strictly. OOo 3.0 displays files correctly when they contain elements and attributes of ODT 1.2. Use false for this purpose, or true for strict conformity of specification 1.1</value>
        [DataMember(Name="isStrictSchema11", EmitDefaultValue=false)]
        public bool? IsStrictSchema11 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocGenSettingsResultOdt {\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  IsStrictSchema11: ").Append(IsStrictSchema11).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DocGenSettingsResultOdt);
        }

        /// <summary>
        /// Returns true if DocGenSettingsResultOdt instances are equal
        /// </summary>
        /// <param name="input">Instance of DocGenSettingsResultOdt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocGenSettingsResultOdt input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && 
                (
                    this.IsStrictSchema11 == input.IsStrictSchema11 ||
                    (this.IsStrictSchema11 != null &&
                    this.IsStrictSchema11.Equals(input.IsStrictSchema11))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.IsStrictSchema11 != null)
                    hashCode = hashCode * 59 + this.IsStrictSchema11.GetHashCode();
                return hashCode;
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