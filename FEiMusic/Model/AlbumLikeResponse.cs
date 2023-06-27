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
    /// AlbumLikeResponse
    /// </summary>
    [DataContract]
        public partial class AlbumLikeResponse :  IEquatable<AlbumLikeResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlbumLikeResponse" /> class.
        /// </summary>
        /// <param name="idConsumidor">idConsumidor.</param>
        /// <param name="schema">schema.</param>
        public AlbumLikeResponse(string idConsumidor = default(string), AlbumResponse schema = default(AlbumResponse))
        {
            this.IdConsumidor = idConsumidor;
            this.Schema = schema;
        }
        
        /// <summary>
        /// Gets or Sets IdConsumidor
        /// </summary>
        [DataMember(Name="idConsumidor", EmitDefaultValue=false)]
        public string IdConsumidor { get; set; }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name="schema", EmitDefaultValue=false)]
        public AlbumResponse Schema { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlbumLikeResponse {\n");
            sb.Append("  IdConsumidor: ").Append(IdConsumidor).Append("\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
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
            return this.Equals(input as AlbumLikeResponse);
        }

        /// <summary>
        /// Returns true if AlbumLikeResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AlbumLikeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlbumLikeResponse input)
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
                    this.Schema == input.Schema ||
                    (this.Schema != null &&
                    this.Schema.Equals(input.Schema))
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
                if (this.Schema != null)
                    hashCode = hashCode * 59 + this.Schema.GetHashCode();
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