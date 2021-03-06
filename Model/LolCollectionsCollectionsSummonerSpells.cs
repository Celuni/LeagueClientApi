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
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;


namespace LeagueClientApi.Model
{
    /// <summary>
    /// LolCollectionsCollectionsSummonerSpells
    /// </summary>
    [DataContract]
    public partial class LolCollectionsCollectionsSummonerSpells :  IEquatable<LolCollectionsCollectionsSummonerSpells>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolCollectionsCollectionsSummonerSpells" /> class.
        /// </summary>
        /// <param name="Spells">Spells.</param>
        /// <param name="SummonerId">SummonerId.</param>
        public LolCollectionsCollectionsSummonerSpells(List<long?> Spells = default(List<long?>), long? SummonerId = default(long?))
        {
            this.Spells = Spells;
            this.SummonerId = SummonerId;
        }
        
        /// <summary>
        /// Gets or Sets Spells
        /// </summary>
        [DataMember(Name="spells", EmitDefaultValue=false)]
        public List<long?> Spells { get; set; }

        /// <summary>
        /// Gets or Sets SummonerId
        /// </summary>
        [DataMember(Name="summonerId", EmitDefaultValue=false)]
        public long? SummonerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolCollectionsCollectionsSummonerSpells {\n");
            sb.Append("  Spells: ").Append(Spells).Append("\n");
            sb.Append("  SummonerId: ").Append(SummonerId).Append("\n");
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
            return this.Equals(obj as LolCollectionsCollectionsSummonerSpells);
        }

        /// <summary>
        /// Returns true if LolCollectionsCollectionsSummonerSpells instances are equal
        /// </summary>
        /// <param name="other">Instance of LolCollectionsCollectionsSummonerSpells to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolCollectionsCollectionsSummonerSpells other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Spells == other.Spells ||
                    this.Spells != null &&
                    this.Spells.SequenceEqual(other.Spells)
                ) && 
                (
                    this.SummonerId == other.SummonerId ||
                    this.SummonerId != null &&
                    this.SummonerId.Equals(other.SummonerId)
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
                if (this.Spells != null)
                    hash = hash * 59 + this.Spells.GetHashCode();
                if (this.SummonerId != null)
                    hash = hash * 59 + this.SummonerId.GetHashCode();
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
