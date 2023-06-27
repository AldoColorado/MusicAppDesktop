/* 
 * FEIMusic API
 *
 * Api que nos permite administrar la aplicacion de musica FEIMusic
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = FEiMusic.Client.SwaggerDateConverter;

namespace FEiMusic.Model
{
    /// <summary>
    /// Auth
    /// </summary>
    [DataContract]
        public partial class Auth :  IEquatable<Auth>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Auth" /> class.
        /// </summary>
        /// <param name="username">username.</param>
        /// <param name="tipoUsuario">tipoUsuario.</param>
        /// <param name="authtoken">authtoken.</param>
        /// <param name="status">status.</param>
        public Auth(string username = default(string), string tipoUsuario = default(string), string authtoken = default(string), string status = default(string))
        {
            this.Username = username;
            this.TipoUsuario = tipoUsuario;
            this.Authtoken = authtoken;
            this.Status = status;
        }
        
        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets TipoUsuario
        /// </summary>
        [DataMember(Name="tipoUsuario", EmitDefaultValue=false)]
        public string TipoUsuario { get; set; }

        /// <summary>
        /// Gets or Sets Authtoken
        /// </summary>
        [DataMember(Name="authtoken", EmitDefaultValue=false)]
        public string Authtoken { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Auth {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  TipoUsuario: ").Append(TipoUsuario).Append("\n");
            sb.Append("  Authtoken: ").Append(Authtoken).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as Auth);
        }

        /// <summary>
        /// Returns true if Auth instances are equal
        /// </summary>
        /// <param name="input">Instance of Auth to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Auth input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.TipoUsuario == input.TipoUsuario ||
                    (this.TipoUsuario != null &&
                    this.TipoUsuario.Equals(input.TipoUsuario))
                ) && 
                (
                    this.Authtoken == input.Authtoken ||
                    (this.Authtoken != null &&
                    this.Authtoken.Equals(input.Authtoken))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.TipoUsuario != null)
                    hashCode = hashCode * 59 + this.TipoUsuario.GetHashCode();
                if (this.Authtoken != null)
                    hashCode = hashCode * 59 + this.Authtoken.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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