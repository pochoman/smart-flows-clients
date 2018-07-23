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
    /// Archivable
    /// </summary>
    [DataContract]
    public partial class Archivable :  IEquatable<Archivable>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ArchiveType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ArchiveTypeEnum
        {
            
            /// <summary>
            /// Enum Explicit for "explicit"
            /// </summary>
            [EnumMember(Value = "explicit")]
            Explicit,
            
            /// <summary>
            /// Enum Dependency for "dependency"
            /// </summary>
            [EnumMember(Value = "dependency")]
            Dependency
        }

        /// <summary>
        /// Gets or Sets ArchiveType
        /// </summary>
        [DataMember(Name="archiveType", EmitDefaultValue=false)]
        public ArchiveTypeEnum? ArchiveType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Archivable" /> class.
        /// </summary>
        /// <param name="Identifier">Identifier.</param>
        /// <param name="ArchiveType">ArchiveType.</param>
        /// <param name="Definition">Definition.</param>
        /// <param name="Checksum">Checksum.</param>
        /// <param name="Contents">Contents.</param>
        /// <param name="OutboundDependencies">OutboundDependencies.</param>
        public Archivable(IdWithName Identifier = default(IdWithName), ArchiveTypeEnum? ArchiveType = default(ArchiveTypeEnum?), string Definition = default(string), string Checksum = default(string), List<ArchivableContent> Contents = default(List<ArchivableContent>), List<DependencyTreeNode> OutboundDependencies = default(List<DependencyTreeNode>))
        {
            this.Identifier = Identifier;
            this.ArchiveType = ArchiveType;
            this.Definition = Definition;
            this.Checksum = Checksum;
            this.Contents = Contents;
            this.OutboundDependencies = OutboundDependencies;
        }
        
        /// <summary>
        /// Gets or Sets Identifier
        /// </summary>
        [DataMember(Name="identifier", EmitDefaultValue=false)]
        public IdWithName Identifier { get; set; }


        /// <summary>
        /// Gets or Sets Definition
        /// </summary>
        [DataMember(Name="definition", EmitDefaultValue=false)]
        public string Definition { get; set; }

        /// <summary>
        /// Gets or Sets Checksum
        /// </summary>
        [DataMember(Name="checksum", EmitDefaultValue=false)]
        public string Checksum { get; set; }

        /// <summary>
        /// Gets or Sets Contents
        /// </summary>
        [DataMember(Name="contents", EmitDefaultValue=false)]
        public List<ArchivableContent> Contents { get; set; }

        /// <summary>
        /// Gets or Sets OutboundDependencies
        /// </summary>
        [DataMember(Name="outboundDependencies", EmitDefaultValue=false)]
        public List<DependencyTreeNode> OutboundDependencies { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Archivable {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  ArchiveType: ").Append(ArchiveType).Append("\n");
            sb.Append("  Definition: ").Append(Definition).Append("\n");
            sb.Append("  Checksum: ").Append(Checksum).Append("\n");
            sb.Append("  Contents: ").Append(Contents).Append("\n");
            sb.Append("  OutboundDependencies: ").Append(OutboundDependencies).Append("\n");
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
            return this.Equals(obj as Archivable);
        }

        /// <summary>
        /// Returns true if Archivable instances are equal
        /// </summary>
        /// <param name="other">Instance of Archivable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Archivable other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Identifier == other.Identifier ||
                    this.Identifier != null &&
                    this.Identifier.Equals(other.Identifier)
                ) && 
                (
                    this.ArchiveType == other.ArchiveType ||
                    this.ArchiveType != null &&
                    this.ArchiveType.Equals(other.ArchiveType)
                ) && 
                (
                    this.Definition == other.Definition ||
                    this.Definition != null &&
                    this.Definition.Equals(other.Definition)
                ) && 
                (
                    this.Checksum == other.Checksum ||
                    this.Checksum != null &&
                    this.Checksum.Equals(other.Checksum)
                ) && 
                (
                    this.Contents == other.Contents ||
                    this.Contents != null &&
                    this.Contents.SequenceEqual(other.Contents)
                ) && 
                (
                    this.OutboundDependencies == other.OutboundDependencies ||
                    this.OutboundDependencies != null &&
                    this.OutboundDependencies.SequenceEqual(other.OutboundDependencies)
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
                if (this.Identifier != null)
                    hash = hash * 59 + this.Identifier.GetHashCode();
                if (this.ArchiveType != null)
                    hash = hash * 59 + this.ArchiveType.GetHashCode();
                if (this.Definition != null)
                    hash = hash * 59 + this.Definition.GetHashCode();
                if (this.Checksum != null)
                    hash = hash * 59 + this.Checksum.GetHashCode();
                if (this.Contents != null)
                    hash = hash * 59 + this.Contents.GetHashCode();
                if (this.OutboundDependencies != null)
                    hash = hash * 59 + this.OutboundDependencies.GetHashCode();
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