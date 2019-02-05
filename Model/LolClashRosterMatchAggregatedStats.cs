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
    /// LolClashRosterMatchAggregatedStats
    /// </summary>
    [DataContract]
    public partial class LolClashRosterMatchAggregatedStats :  IEquatable<LolClashRosterMatchAggregatedStats>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolClashRosterMatchAggregatedStats" /> class.
        /// </summary>
        /// <param name="DurationMs">DurationMs.</param>
        /// <param name="GameId">GameId.</param>
        /// <param name="LoserBracket">LoserBracket.</param>
        /// <param name="OpponentIconColorId">OpponentIconColorId.</param>
        /// <param name="OpponentIconId">OpponentIconId.</param>
        /// <param name="OpponentShortName">OpponentShortName.</param>
        /// <param name="PlayerChampionIds">PlayerChampionIds.</param>
        /// <param name="Round">Round.</param>
        /// <param name="Win">Win.</param>
        public LolClashRosterMatchAggregatedStats(long? DurationMs = default(long?), long? GameId = default(long?), bool? LoserBracket = default(bool?), int? OpponentIconColorId = default(int?), int? OpponentIconId = default(int?), string OpponentShortName = default(string), Dictionary<string, int?> PlayerChampionIds = default(Dictionary<string, int?>), int? Round = default(int?), bool? Win = default(bool?))
        {
            this.DurationMs = DurationMs;
            this.GameId = GameId;
            this.LoserBracket = LoserBracket;
            this.OpponentIconColorId = OpponentIconColorId;
            this.OpponentIconId = OpponentIconId;
            this.OpponentShortName = OpponentShortName;
            this.PlayerChampionIds = PlayerChampionIds;
            this.Round = Round;
            this.Win = Win;
        }
        
        /// <summary>
        /// Gets or Sets DurationMs
        /// </summary>
        [DataMember(Name="durationMs", EmitDefaultValue=false)]
        public long? DurationMs { get; set; }

        /// <summary>
        /// Gets or Sets GameId
        /// </summary>
        [DataMember(Name="gameId", EmitDefaultValue=false)]
        public long? GameId { get; set; }

        /// <summary>
        /// Gets or Sets LoserBracket
        /// </summary>
        [DataMember(Name="loserBracket", EmitDefaultValue=false)]
        public bool? LoserBracket { get; set; }

        /// <summary>
        /// Gets or Sets OpponentIconColorId
        /// </summary>
        [DataMember(Name="opponentIconColorId", EmitDefaultValue=false)]
        public int? OpponentIconColorId { get; set; }

        /// <summary>
        /// Gets or Sets OpponentIconId
        /// </summary>
        [DataMember(Name="opponentIconId", EmitDefaultValue=false)]
        public int? OpponentIconId { get; set; }

        /// <summary>
        /// Gets or Sets OpponentShortName
        /// </summary>
        [DataMember(Name="opponentShortName", EmitDefaultValue=false)]
        public string OpponentShortName { get; set; }

        /// <summary>
        /// Gets or Sets PlayerChampionIds
        /// </summary>
        [DataMember(Name="playerChampionIds", EmitDefaultValue=false)]
        public Dictionary<string, int?> PlayerChampionIds { get; set; }

        /// <summary>
        /// Gets or Sets Round
        /// </summary>
        [DataMember(Name="round", EmitDefaultValue=false)]
        public int? Round { get; set; }

        /// <summary>
        /// Gets or Sets Win
        /// </summary>
        [DataMember(Name="win", EmitDefaultValue=false)]
        public bool? Win { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolClashRosterMatchAggregatedStats {\n");
            sb.Append("  DurationMs: ").Append(DurationMs).Append("\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  LoserBracket: ").Append(LoserBracket).Append("\n");
            sb.Append("  OpponentIconColorId: ").Append(OpponentIconColorId).Append("\n");
            sb.Append("  OpponentIconId: ").Append(OpponentIconId).Append("\n");
            sb.Append("  OpponentShortName: ").Append(OpponentShortName).Append("\n");
            sb.Append("  PlayerChampionIds: ").Append(PlayerChampionIds).Append("\n");
            sb.Append("  Round: ").Append(Round).Append("\n");
            sb.Append("  Win: ").Append(Win).Append("\n");
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
            return this.Equals(obj as LolClashRosterMatchAggregatedStats);
        }

        /// <summary>
        /// Returns true if LolClashRosterMatchAggregatedStats instances are equal
        /// </summary>
        /// <param name="other">Instance of LolClashRosterMatchAggregatedStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolClashRosterMatchAggregatedStats other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DurationMs == other.DurationMs ||
                    this.DurationMs != null &&
                    this.DurationMs.Equals(other.DurationMs)
                ) && 
                (
                    this.GameId == other.GameId ||
                    this.GameId != null &&
                    this.GameId.Equals(other.GameId)
                ) && 
                (
                    this.LoserBracket == other.LoserBracket ||
                    this.LoserBracket != null &&
                    this.LoserBracket.Equals(other.LoserBracket)
                ) && 
                (
                    this.OpponentIconColorId == other.OpponentIconColorId ||
                    this.OpponentIconColorId != null &&
                    this.OpponentIconColorId.Equals(other.OpponentIconColorId)
                ) && 
                (
                    this.OpponentIconId == other.OpponentIconId ||
                    this.OpponentIconId != null &&
                    this.OpponentIconId.Equals(other.OpponentIconId)
                ) && 
                (
                    this.OpponentShortName == other.OpponentShortName ||
                    this.OpponentShortName != null &&
                    this.OpponentShortName.Equals(other.OpponentShortName)
                ) && 
                (
                    this.PlayerChampionIds == other.PlayerChampionIds ||
                    this.PlayerChampionIds != null &&
                    this.PlayerChampionIds.SequenceEqual(other.PlayerChampionIds)
                ) && 
                (
                    this.Round == other.Round ||
                    this.Round != null &&
                    this.Round.Equals(other.Round)
                ) && 
                (
                    this.Win == other.Win ||
                    this.Win != null &&
                    this.Win.Equals(other.Win)
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
                if (this.DurationMs != null)
                    hash = hash * 59 + this.DurationMs.GetHashCode();
                if (this.GameId != null)
                    hash = hash * 59 + this.GameId.GetHashCode();
                if (this.LoserBracket != null)
                    hash = hash * 59 + this.LoserBracket.GetHashCode();
                if (this.OpponentIconColorId != null)
                    hash = hash * 59 + this.OpponentIconColorId.GetHashCode();
                if (this.OpponentIconId != null)
                    hash = hash * 59 + this.OpponentIconId.GetHashCode();
                if (this.OpponentShortName != null)
                    hash = hash * 59 + this.OpponentShortName.GetHashCode();
                if (this.PlayerChampionIds != null)
                    hash = hash * 59 + this.PlayerChampionIds.GetHashCode();
                if (this.Round != null)
                    hash = hash * 59 + this.Round.GetHashCode();
                if (this.Win != null)
                    hash = hash * 59 + this.Win.GetHashCode();
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