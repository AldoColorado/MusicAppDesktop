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
    /// Genero
    /// </summary>
    [DataContract]
        public partial class Genero :  IEquatable<Genero>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Genero" /> class.
        /// </summary>
        /// <param name="idGenero">idGenero.</param>
        /// <param name="nombre">nombre.</param>
        public Genero(string idGenero = default(string), string nombre = default(string))
        {
            this.IdGenero = idGenero;
            this.Nombre = nombre;
        }
        
        /// <summary>
        /// Gets or Sets IdGenero
        /// </summary>
        [DataMember(Name="idGenero", EmitDefaultValue=false)]
        public string IdGenero { get; set; }

        /// <summary>
        /// Gets or Sets Nombre
        /// </summary>
        [DataMember(Name="nombre", EmitDefaultValue=false)]
        public string Nombre { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Genero {\n");
            sb.Append("  IdGenero: ").Append(IdGenero).Append("\n");
            sb.Append("  Nombre: ").Append(Nombre).Append("\n");
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
            return this.Equals(input as Genero);
        }

        /// <summary>
        /// Returns true if Genero instances are equal
        /// </summary>
        /// <param name="input">Instance of Genero to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Genero input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdGenero == input.IdGenero ||
                    (this.IdGenero != null &&
                    this.IdGenero.Equals(input.IdGenero))
                ) && 
                (
                    this.Nombre == input.Nombre ||
                    (this.Nombre != null &&
                    this.Nombre.Equals(input.Nombre))
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
                if (this.IdGenero != null)
                    hashCode = hashCode * 59 + this.IdGenero.GetHashCode();
                if (this.Nombre != null)
                    hashCode = hashCode * 59 + this.Nombre.GetHashCode();
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
