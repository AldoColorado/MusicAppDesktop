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
    /// ArtistLikeRequest
    /// </summary>
    [DataContract]
        public partial class ArtistLikeRequest :  IEquatable<ArtistLikeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArtistLikeRequest" /> class.
        /// </summary>
        /// <param name="idConsumidor">idConsumidor.</param>
        /// <param name="idArtista">idArtista.</param>
        public ArtistLikeRequest(string idConsumidor = default(string), string idArtista = default(string))
        {
            this.IdConsumidor = idConsumidor;
            this.IdArtista = idArtista;
        }
        
        /// <summary>
        /// Gets or Sets IdConsumidor
        /// </summary>
        [DataMember(Name="idConsumidor", EmitDefaultValue=false)]
        public string IdConsumidor { get; set; }

        /// <summary>
        /// Gets or Sets IdArtista
        /// </summary>
        [DataMember(Name="idArtista", EmitDefaultValue=false)]
        public string IdArtista { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArtistLikeRequest {\n");
            sb.Append("  IdConsumidor: ").Append(IdConsumidor).Append("\n");
            sb.Append("  IdArtista: ").Append(IdArtista).Append("\n");
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
            return this.Equals(input as ArtistLikeRequest);
        }

        /// <summary>
        /// Returns true if ArtistLikeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ArtistLikeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArtistLikeRequest input)
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
                    this.IdArtista == input.IdArtista ||
                    (this.IdArtista != null &&
                    this.IdArtista.Equals(input.IdArtista))
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
                if (this.IdArtista != null)
                    hashCode = hashCode * 59 + this.IdArtista.GetHashCode();
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
