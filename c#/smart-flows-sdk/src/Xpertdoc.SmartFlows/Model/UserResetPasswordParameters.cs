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
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace Xpertdoc.SmartFlows.Model
{
    /// <summary>
    /// UserResetPasswordParameters
    /// </summary>
    [DataContract]
    public partial class UserResetPasswordParameters : IEquatable<UserResetPasswordParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserResetPasswordParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserResetPasswordParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserResetPasswordParameters" /> class.
        /// </summary>
        /// <param name="UserId">UserId (required).</param>
        /// <param name="ResetToken">ResetToken (required).</param>
        /// <param name="Password">Password (required).</param>
        public UserResetPasswordParameters(string UserId = default(string), string ResetToken = default(string), string Password = default(string))
        {
            // to ensure "UserId" is required (not null)
            if (UserId == null)
            {
                throw new InvalidDataException("UserId is a required property for UserResetPasswordParameters and cannot be null");
            }
            else
            {
                this.UserId = UserId;
            }
            // to ensure "ResetToken" is required (not null)
            if (ResetToken == null)
            {
                throw new InvalidDataException("ResetToken is a required property for UserResetPasswordParameters and cannot be null");
            }
            else
            {
                this.ResetToken = ResetToken;
            }
            // to ensure "Password" is required (not null)
            if (Password == null)
            {
                throw new InvalidDataException("Password is a required property for UserResetPasswordParameters and cannot be null");
            }
            else
            {
                this.Password = Password;
            }
        }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public string UserId { get; set; }
        /// <summary>
        /// Gets or Sets ResetToken
        /// </summary>
        [DataMember(Name = "resetToken", EmitDefaultValue = false)]
        public string ResetToken { get; set; }
        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserResetPasswordParameters {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ResetToken: ").Append(ResetToken).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
            return this.Equals(obj as UserResetPasswordParameters);
        }

        /// <summary>
        /// Returns true if UserResetPasswordParameters instances are equal
        /// </summary>
        /// <param name="other">Instance of UserResetPasswordParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserResetPasswordParameters other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.ResetToken == other.ResetToken ||
                    this.ResetToken != null &&
                    this.ResetToken.Equals(other.ResetToken)
                ) &&
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
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
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.ResetToken != null)
                    hash = hash * 59 + this.ResetToken.GetHashCode();
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}