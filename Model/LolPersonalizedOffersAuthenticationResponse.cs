/* 
 * LeagueClient
 *
 * 7.23.209.3517
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;


namespace LeagueClientApi.Model
{
    /// <summary>
    /// LolPersonalizedOffersAuthenticationResponse
    /// </summary>
    [DataContract]
    public partial class LolPersonalizedOffersAuthenticationResponse :  IEquatable<LolPersonalizedOffersAuthenticationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolPersonalizedOffersAuthenticationResponse" /> class.
        /// </summary>
        /// <param name="Expiration">Expiration.</param>
        /// <param name="Token">Token.</param>
        public LolPersonalizedOffersAuthenticationResponse(string Expiration = default(string), string Token = default(string))
        {
            this.Expiration = Expiration;
            this.Token = Token;
        }
        
        /// <summary>
        /// Gets or Sets Expiration
        /// </summary>
        [DataMember(Name="expiration", EmitDefaultValue=false)]
        public string Expiration { get; set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolPersonalizedOffersAuthenticationResponse {\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
            return this.Equals(obj as LolPersonalizedOffersAuthenticationResponse);
        }

        /// <summary>
        /// Returns true if LolPersonalizedOffersAuthenticationResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of LolPersonalizedOffersAuthenticationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolPersonalizedOffersAuthenticationResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Expiration == other.Expiration ||
                    this.Expiration != null &&
                    this.Expiration.Equals(other.Expiration)
                ) && 
                (
                    this.Token == other.Token ||
                    this.Token != null &&
                    this.Token.Equals(other.Token)
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
                if (this.Expiration != null)
                    hash = hash * 59 + this.Expiration.GetHashCode();
                if (this.Token != null)
                    hash = hash * 59 + this.Token.GetHashCode();
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
