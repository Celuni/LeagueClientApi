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
    /// LolPerksPerkSubStyleBonusResource
    /// </summary>
    [DataContract]
    public partial class LolPerksPerkSubStyleBonusResource :  IEquatable<LolPerksPerkSubStyleBonusResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolPerksPerkSubStyleBonusResource" /> class.
        /// </summary>
        /// <param name="PerkId">PerkId.</param>
        /// <param name="StyleId">StyleId.</param>
        public LolPerksPerkSubStyleBonusResource(int? PerkId = default(int?), int? StyleId = default(int?))
        {
            this.PerkId = PerkId;
            this.StyleId = StyleId;
        }
        
        /// <summary>
        /// Gets or Sets PerkId
        /// </summary>
        [DataMember(Name="perkId", EmitDefaultValue=false)]
        public int? PerkId { get; set; }

        /// <summary>
        /// Gets or Sets StyleId
        /// </summary>
        [DataMember(Name="styleId", EmitDefaultValue=false)]
        public int? StyleId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolPerksPerkSubStyleBonusResource {\n");
            sb.Append("  PerkId: ").Append(PerkId).Append("\n");
            sb.Append("  StyleId: ").Append(StyleId).Append("\n");
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
            return this.Equals(obj as LolPerksPerkSubStyleBonusResource);
        }

        /// <summary>
        /// Returns true if LolPerksPerkSubStyleBonusResource instances are equal
        /// </summary>
        /// <param name="other">Instance of LolPerksPerkSubStyleBonusResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolPerksPerkSubStyleBonusResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PerkId == other.PerkId ||
                    this.PerkId != null &&
                    this.PerkId.Equals(other.PerkId)
                ) && 
                (
                    this.StyleId == other.StyleId ||
                    this.StyleId != null &&
                    this.StyleId.Equals(other.StyleId)
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
                if (this.PerkId != null)
                    hash = hash * 59 + this.PerkId.GetHashCode();
                if (this.StyleId != null)
                    hash = hash * 59 + this.StyleId.GetHashCode();
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
