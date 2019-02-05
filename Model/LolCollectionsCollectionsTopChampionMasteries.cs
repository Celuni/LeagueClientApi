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
    /// LolCollectionsCollectionsTopChampionMasteries
    /// </summary>
    [DataContract]
    public partial class LolCollectionsCollectionsTopChampionMasteries :  IEquatable<LolCollectionsCollectionsTopChampionMasteries>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolCollectionsCollectionsTopChampionMasteries" /> class.
        /// </summary>
        /// <param name="Masteries">Masteries.</param>
        /// <param name="Score">Score.</param>
        /// <param name="SummonerId">SummonerId.</param>
        public LolCollectionsCollectionsTopChampionMasteries(List<LolCollectionsCollectionsChampionMastery> Masteries = default(List<LolCollectionsCollectionsChampionMastery>), long? Score = default(long?), long? SummonerId = default(long?))
        {
            this.Masteries = Masteries;
            this.Score = Score;
            this.SummonerId = SummonerId;
        }
        
        /// <summary>
        /// Gets or Sets Masteries
        /// </summary>
        [DataMember(Name="masteries", EmitDefaultValue=false)]
        public List<LolCollectionsCollectionsChampionMastery> Masteries { get; set; }

        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public long? Score { get; set; }

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
            sb.Append("class LolCollectionsCollectionsTopChampionMasteries {\n");
            sb.Append("  Masteries: ").Append(Masteries).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
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
            return this.Equals(obj as LolCollectionsCollectionsTopChampionMasteries);
        }

        /// <summary>
        /// Returns true if LolCollectionsCollectionsTopChampionMasteries instances are equal
        /// </summary>
        /// <param name="other">Instance of LolCollectionsCollectionsTopChampionMasteries to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolCollectionsCollectionsTopChampionMasteries other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Masteries == other.Masteries ||
                    this.Masteries != null &&
                    this.Masteries.SequenceEqual(other.Masteries)
                ) && 
                (
                    this.Score == other.Score ||
                    this.Score != null &&
                    this.Score.Equals(other.Score)
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
                if (this.Masteries != null)
                    hash = hash * 59 + this.Masteries.GetHashCode();
                if (this.Score != null)
                    hash = hash * 59 + this.Score.GetHashCode();
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