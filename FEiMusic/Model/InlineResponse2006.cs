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
    /// InlineResponse2006
    /// </summary>
    [DataContract]
        public partial class InlineResponse2006 :  IEquatable<InlineResponse2006>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2006" /> class.
        /// </summary>
        /// <param name="albumlike">albumlike.</param>
        public InlineResponse2006(List<AlbumLikeResponse> albumlike = default(List<AlbumLikeResponse>))
        {
            this.Albumlike = albumlike;
        }
        
        /// <summary>
        /// Gets or Sets Albumlike
        /// </summary>
        [DataMember(Name="albumlike", EmitDefaultValue=false)]
        public List<AlbumLikeResponse> Albumlike { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2006 {\n");
            sb.Append("  Albumlike: ").Append(Albumlike).Append("\n");
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
            return this.Equals(input as InlineResponse2006);
        }

        /// <summary>
        /// Returns true if InlineResponse2006 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse2006 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2006 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Albumlike == input.Albumlike ||
                    this.Albumlike != null &&
                    input.Albumlike != null &&
                    this.Albumlike.SequenceEqual(input.Albumlike)
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
                if (this.Albumlike != null)
                    hashCode = hashCode * 59 + this.Albumlike.GetHashCode();
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
