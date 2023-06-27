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
using System.Text.RegularExpressions;
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
    /// ConsumidorResponse
    /// </summary>
    [DataContract]
        public partial class ConsumidorResponse :  IEquatable<ConsumidorResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsumidorResponse" /> class.
        /// </summary>
        /// <param name="idConsumidor">idConsumidor.</param>
        /// <param name="nombre">nombre.</param>
        /// <param name="apellidos">apellidos.</param>
        /// <param name="username">username.</param>
        public ConsumidorResponse(string idConsumidor = default(string), string nombre = default(string), string apellidos = default(string), string username = default(string))
        {
            this.IdConsumidor = idConsumidor;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Username = username;
        }
        
        /// <summary>
        /// Gets or Sets IdConsumidor
        /// </summary>
        [DataMember(Name="idConsumidor", EmitDefaultValue=false)]
        public string IdConsumidor { get; set; }

        /// <summary>
        /// Gets or Sets Nombre
        /// </summary>
        [DataMember(Name="nombre", EmitDefaultValue=false)]
        public string Nombre { get; set; }

        /// <summary>
        /// Gets or Sets Apellidos
        /// </summary>
        [DataMember(Name="apellidos", EmitDefaultValue=false)]
        public string Apellidos { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsumidorResponse {\n");
            sb.Append("  IdConsumidor: ").Append(IdConsumidor).Append("\n");
            sb.Append("  Nombre: ").Append(Nombre).Append("\n");
            sb.Append("  Apellidos: ").Append(Apellidos).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            return this.Equals(input as ConsumidorResponse);
        }

        /// <summary>
        /// Returns true if ConsumidorResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ConsumidorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsumidorResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdConsumidor == input.IdConsumidor ||
                    (this.IdConsumidor != null &&
                    this.IdConsumidor.Equals(input.IdConsumidor))
                ) && 
                (
                    this.Nombre == input.Nombre ||
                    (this.Nombre != null &&
                    this.Nombre.Equals(input.Nombre))
                ) && 
                (
                    this.Apellidos == input.Apellidos ||
                    (this.Apellidos != null &&
                    this.Apellidos.Equals(input.Apellidos))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                if (this.IdConsumidor != null)
                    hashCode = hashCode * 59 + this.IdConsumidor.GetHashCode();
                if (this.Nombre != null)
                    hashCode = hashCode * 59 + this.Nombre.GetHashCode();
                if (this.Apellidos != null)
                    hashCode = hashCode * 59 + this.Apellidos.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
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
