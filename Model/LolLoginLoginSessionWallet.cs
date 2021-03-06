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
    /// LolLoginLoginSessionWallet
    /// </summary>
    [DataContract]
    public partial class LolLoginLoginSessionWallet :  IEquatable<LolLoginLoginSessionWallet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolLoginLoginSessionWallet" /> class.
        /// </summary>
        /// <param name="Ip">Ip.</param>
        /// <param name="Rp">Rp.</param>
        public LolLoginLoginSessionWallet(long? Ip = default(long?), long? Rp = default(long?))
        {
            this.Ip = Ip;
            this.Rp = Rp;
        }
        
        /// <summary>
        /// Gets or Sets Ip
        /// </summary>
        [DataMember(Name="ip", EmitDefaultValue=false)]
        public long? Ip { get; set; }

        /// <summary>
        /// Gets or Sets Rp
        /// </summary>
        [DataMember(Name="rp", EmitDefaultValue=false)]
        public long? Rp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolLoginLoginSessionWallet {\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  Rp: ").Append(Rp).Append("\n");
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
            return this.Equals(obj as LolLoginLoginSessionWallet);
        }

        /// <summary>
        /// Returns true if LolLoginLoginSessionWallet instances are equal
        /// </summary>
        /// <param name="other">Instance of LolLoginLoginSessionWallet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolLoginLoginSessionWallet other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Ip == other.Ip ||
                    this.Ip != null &&
                    this.Ip.Equals(other.Ip)
                ) && 
                (
                    this.Rp == other.Rp ||
                    this.Rp != null &&
                    this.Rp.Equals(other.Rp)
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
                if (this.Ip != null)
                    hash = hash * 59 + this.Ip.GetHashCode();
                if (this.Rp != null)
                    hash = hash * 59 + this.Rp.GetHashCode();
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
