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
    /// Album
    /// </summary>
    [DataContract]
        public partial class Album :  IEquatable<Album>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Album" /> class.
        /// </summary>
        /// <param name="idAlbum">idAlbum.</param>
        /// <param name="nombreAlbum">nombreAlbum.</param>
        /// <param name="anioLanzamiento">anioLanzamiento.</param>
        /// <param name="imagenAlbum">imagenAlbum.</param>
        public Album(string idAlbum = default(string), string nombreAlbum = default(string), string anioLanzamiento = default(string), string imagenAlbum = default(string))
        {
            this.IdAlbum = idAlbum;
            this.NombreAlbum = nombreAlbum;
            this.AnioLanzamiento = anioLanzamiento;
            this.ImagenAlbum = imagenAlbum;
        }
        
        /// <summary>
        /// Gets or Sets IdAlbum
        /// </summary>
        [DataMember(Name="idAlbum", EmitDefaultValue=false)]
        public string IdAlbum { get; set; }

        /// <summary>
        /// Gets or Sets NombreAlbum
        /// </summary>
        [DataMember(Name="nombreAlbum", EmitDefaultValue=false)]
        public string NombreAlbum { get; set; }

        /// <summary>
        /// Gets or Sets AnioLanzamiento
        /// </summary>
        [DataMember(Name="anioLanzamiento", EmitDefaultValue=false)]
        public string AnioLanzamiento { get; set; }

        /// <summary>
        /// Gets or Sets ImagenAlbum
        /// </summary>
        [DataMember(Name="imagenAlbum", EmitDefaultValue=false)]
        public string ImagenAlbum { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Album {\n");
            sb.Append("  IdAlbum: ").Append(IdAlbum).Append("\n");
            sb.Append("  NombreAlbum: ").Append(NombreAlbum).Append("\n");
            sb.Append("  AnioLanzamiento: ").Append(AnioLanzamiento).Append("\n");
            sb.Append("  ImagenAlbum: ").Append(ImagenAlbum).Append("\n");
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
            return this.Equals(input as Album);
        }

        /// <summary>
        /// Returns true if Album instances are equal
        /// </summary>
        /// <param name="input">Instance of Album to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Album input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdAlbum == input.IdAlbum ||
                    (this.IdAlbum != null &&
                    this.IdAlbum.Equals(input.IdAlbum))
                ) && 
                (
                    this.NombreAlbum == input.NombreAlbum ||
                    (this.NombreAlbum != null &&
                    this.NombreAlbum.Equals(input.NombreAlbum))
                ) && 
                (
                    this.AnioLanzamiento == input.AnioLanzamiento ||
                    (this.AnioLanzamiento != null &&
                    this.AnioLanzamiento.Equals(input.AnioLanzamiento))
                ) && 
                (
                    this.ImagenAlbum == input.ImagenAlbum ||
                    (this.ImagenAlbum != null &&
                    this.ImagenAlbum.Equals(input.ImagenAlbum))
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
                if (this.IdAlbum != null)
                    hashCode = hashCode * 59 + this.IdAlbum.GetHashCode();
                if (this.NombreAlbum != null)
                    hashCode = hashCode * 59 + this.NombreAlbum.GetHashCode();
                if (this.AnioLanzamiento != null)
                    hashCode = hashCode * 59 + this.AnioLanzamiento.GetHashCode();
                if (this.ImagenAlbum != null)
                    hashCode = hashCode * 59 + this.ImagenAlbum.GetHashCode();
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
