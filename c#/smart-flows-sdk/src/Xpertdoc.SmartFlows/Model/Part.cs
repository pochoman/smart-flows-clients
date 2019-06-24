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
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace Xpertdoc.SmartFlows.Model
{
    /// <summary>
    /// Part
    /// </summary>
    [DataContract]
    public partial class Part : IEquatable<Part>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {

            /// <summary>
            /// Enum Body for "body"
            /// </summary>
            [EnumMember(Value = "body")]
            Body,

            /// <summary>
            /// Enum Header for "header"
            /// </summary>
            [EnumMember(Value = "header")]
            Header,

            /// <summary>
            /// Enum Footer for "footer"
            /// </summary>
            [EnumMember(Value = "footer")]
            Footer,

            /// <summary>
            /// Enum Addition for "addition"
            /// </summary>
            [EnumMember(Value = "addition")]
            Addition
        }

        /// <summary>
        /// Gets or Sets _Break
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BreakEnum
        {

            /// <summary>
            /// Enum None for "none"
            /// </summary>
            [EnumMember(Value = "none")]
            None,

            /// <summary>
            /// Enum Continuous for "continuous"
            /// </summary>
            [EnumMember(Value = "continuous")]
            Continuous,

            /// <summary>
            /// Enum NewColumn for "newColumn"
            /// </summary>
            [EnumMember(Value = "newColumn")]
            NewColumn,

            /// <summary>
            /// Enum NewPage for "newPage"
            /// </summary>
            [EnumMember(Value = "newPage")]
            NewPage,

            /// <summary>
            /// Enum EvenPage for "evenPage"
            /// </summary>
            [EnumMember(Value = "evenPage")]
            EvenPage,

            /// <summary>
            /// Enum OddPage for "oddPage"
            /// </summary>
            [EnumMember(Value = "oddPage")]
            OddPage
        }

        /// <summary>
        /// Gets or Sets Occurrence
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OccurrenceEnum
        {

            /// <summary>
            /// Enum Primary for "primary"
            /// </summary>
            [EnumMember(Value = "primary")]
            Primary,

            /// <summary>
            /// Enum FirstPage for "firstPage"
            /// </summary>
            [EnumMember(Value = "firstPage")]
            FirstPage,

            /// <summary>
            /// Enum EvenPage for "evenPage"
            /// </summary>
            [EnumMember(Value = "evenPage")]
            EvenPage
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Gets or Sets _Break
        /// </summary>
        [DataMember(Name = "break", EmitDefaultValue = false)]
        public BreakEnum? _Break { get; set; }
        /// <summary>
        /// Gets or Sets Occurrence
        /// </summary>
        [DataMember(Name = "occurrence", EmitDefaultValue = false)]
        public OccurrenceEnum? Occurrence { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Part" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Part() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Part" /> class.
        /// </summary>
        /// <param name="Template">Template (required).</param>
        /// <param name="TemplateDisplayName">Read-only, will contain the displayName of the linked template at the moment of retrieval.</param>
        /// <param name="Type">Type (required).</param>
        /// <param name="_Break">_Break.</param>
        /// <param name="LinkHeaders">LinkHeaders (default to true).</param>
        /// <param name="Occurrence">Occurrence (default to OccurrenceEnum.Primary).</param>
        /// <param name="Conditions">Conditions.</param>
        public Part(string Template = default(string), string TemplateDisplayName = default(string), TypeEnum? Type = default(TypeEnum?), BreakEnum? _Break = default(BreakEnum?), bool? LinkHeaders = true, OccurrenceEnum? Occurrence = OccurrenceEnum.Primary, ConditionGroup Conditions = default(ConditionGroup))
        {
            // to ensure "Template" is required (not null)
            if (Template == null)
            {
                throw new InvalidDataException("Template is a required property for Part and cannot be null");
            }
            else
            {
                this.Template = Template;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for Part and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.TemplateDisplayName = TemplateDisplayName;
            this._Break = _Break;
            // use default value if no "LinkHeaders" provided
            if (LinkHeaders == null)
            {
                this.LinkHeaders = true;
            }
            else
            {
                this.LinkHeaders = LinkHeaders;
            }
            // use default value if no "Occurrence" provided
            if (Occurrence == null)
            {
                this.Occurrence = OccurrenceEnum.Primary;
            }
            else
            {
                this.Occurrence = Occurrence;
            }
            this.Conditions = Conditions;
        }

        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [DataMember(Name = "template", EmitDefaultValue = false)]
        public string Template { get; set; }
        /// <summary>
        /// Read-only, will contain the displayName of the linked template at the moment of retrieval
        /// </summary>
        /// <value>Read-only, will contain the displayName of the linked template at the moment of retrieval</value>
        [DataMember(Name = "templateDisplayName", EmitDefaultValue = false)]
        public string TemplateDisplayName { get; set; }
        /// <summary>
        /// Gets or Sets LinkHeaders
        /// </summary>
        [DataMember(Name = "linkHeaders", EmitDefaultValue = false)]
        public bool? LinkHeaders { get; set; }
        /// <summary>
        /// Gets or Sets Conditions
        /// </summary>
        [DataMember(Name = "conditions", EmitDefaultValue = false)]
        public ConditionGroup Conditions { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Part {\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  TemplateDisplayName: ").Append(TemplateDisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  _Break: ").Append(_Break).Append("\n");
            sb.Append("  LinkHeaders: ").Append(LinkHeaders).Append("\n");
            sb.Append("  Occurrence: ").Append(Occurrence).Append("\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
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
            return this.Equals(obj as Part);
        }

        /// <summary>
        /// Returns true if Part instances are equal
        /// </summary>
        /// <param name="other">Instance of Part to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Part other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Template == other.Template ||
                    this.Template != null &&
                    this.Template.Equals(other.Template)
                ) &&
                (
                    this.TemplateDisplayName == other.TemplateDisplayName ||
                    this.TemplateDisplayName != null &&
                    this.TemplateDisplayName.Equals(other.TemplateDisplayName)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this._Break == other._Break ||
                    this._Break != null &&
                    this._Break.Equals(other._Break)
                ) &&
                (
                    this.LinkHeaders == other.LinkHeaders ||
                    this.LinkHeaders != null &&
                    this.LinkHeaders.Equals(other.LinkHeaders)
                ) &&
                (
                    this.Occurrence == other.Occurrence ||
                    this.Occurrence != null &&
                    this.Occurrence.Equals(other.Occurrence)
                ) &&
                (
                    this.Conditions == other.Conditions ||
                    this.Conditions != null &&
                    this.Conditions.Equals(other.Conditions)
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
                if (this.Template != null)
                    hash = hash * 59 + this.Template.GetHashCode();
                if (this.TemplateDisplayName != null)
                    hash = hash * 59 + this.TemplateDisplayName.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this._Break != null)
                    hash = hash * 59 + this._Break.GetHashCode();
                if (this.LinkHeaders != null)
                    hash = hash * 59 + this.LinkHeaders.GetHashCode();
                if (this.Occurrence != null)
                    hash = hash * 59 + this.Occurrence.GetHashCode();
                if (this.Conditions != null)
                    hash = hash * 59 + this.Conditions.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
