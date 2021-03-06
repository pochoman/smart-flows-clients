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
    /// PrinterDefinitionPrinterInfoJps
    /// </summary>
    [DataContract]
    public partial class PrinterDefinitionPrinterInfoJps :  IEquatable<PrinterDefinitionPrinterInfoJps>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Supported
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SupportedEnum
        {
            
            /// <summary>
            /// Enum Collate for "collate"
            /// </summary>
            [EnumMember(Value = "collate")]
            Collate,
            
            /// <summary>
            /// Enum DuplexingTwoSidedLongEdge for "duplexingTwoSidedLongEdge"
            /// </summary>
            [EnumMember(Value = "duplexingTwoSidedLongEdge")]
            DuplexingTwoSidedLongEdge,
            
            /// <summary>
            /// Enum DuplexingTwoSidedShortEdge for "duplexingTwoSidedShortEdge"
            /// </summary>
            [EnumMember(Value = "duplexingTwoSidedShortEdge")]
            DuplexingTwoSidedShortEdge,
            
            /// <summary>
            /// Enum ChromacityColor for "chromacityColor"
            /// </summary>
            [EnumMember(Value = "chromacityColor")]
            ChromacityColor,
            
            /// <summary>
            /// Enum Orientation for "orientation"
            /// </summary>
            [EnumMember(Value = "orientation")]
            Orientation
        }

        /// <summary>
        /// Gets or Sets Supported
        /// </summary>
        [DataMember(Name="supported", EmitDefaultValue=false)]
        public List<SupportedEnum> Supported { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PrinterDefinitionPrinterInfoJps" /> class.
        /// </summary>
        /// <param name="Supported">Supported.</param>
        /// <param name="PaperSources">PaperSources.</param>
        /// <param name="PaperSizes">PaperSizes.</param>
        public PrinterDefinitionPrinterInfoJps(List<SupportedEnum> Supported = default(List<SupportedEnum>), List<PrinterDefinitionPrinterInfoJpsPaperSources> PaperSources = default(List<PrinterDefinitionPrinterInfoJpsPaperSources>), List<string> PaperSizes = default(List<string>))
        {
            this.Supported = Supported;
            this.PaperSources = PaperSources;
            this.PaperSizes = PaperSizes;
        }
        

        /// <summary>
        /// Gets or Sets PaperSources
        /// </summary>
        [DataMember(Name="paperSources", EmitDefaultValue=false)]
        public List<PrinterDefinitionPrinterInfoJpsPaperSources> PaperSources { get; set; }

        /// <summary>
        /// Gets or Sets PaperSizes
        /// </summary>
        [DataMember(Name="paperSizes", EmitDefaultValue=false)]
        public List<string> PaperSizes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrinterDefinitionPrinterInfoJps {\n");
            sb.Append("  Supported: ").Append(Supported).Append("\n");
            sb.Append("  PaperSources: ").Append(PaperSources).Append("\n");
            sb.Append("  PaperSizes: ").Append(PaperSizes).Append("\n");
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
            return this.Equals(obj as PrinterDefinitionPrinterInfoJps);
        }

        /// <summary>
        /// Returns true if PrinterDefinitionPrinterInfoJps instances are equal
        /// </summary>
        /// <param name="other">Instance of PrinterDefinitionPrinterInfoJps to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrinterDefinitionPrinterInfoJps other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Supported == other.Supported ||
                    this.Supported != null &&
                    this.Supported.SequenceEqual(other.Supported)
                ) && 
                (
                    this.PaperSources == other.PaperSources ||
                    this.PaperSources != null &&
                    this.PaperSources.SequenceEqual(other.PaperSources)
                ) && 
                (
                    this.PaperSizes == other.PaperSizes ||
                    this.PaperSizes != null &&
                    this.PaperSizes.SequenceEqual(other.PaperSizes)
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
                if (this.Supported != null)
                    hash = hash * 59 + this.Supported.GetHashCode();
                if (this.PaperSources != null)
                    hash = hash * 59 + this.PaperSources.GetHashCode();
                if (this.PaperSizes != null)
                    hash = hash * 59 + this.PaperSizes.GetHashCode();
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
