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
    /// LolClashEogPlayerUpdateDTO
    /// </summary>
    [DataContract]
    public partial class LolClashEogPlayerUpdateDTO :  IEquatable<LolClashEogPlayerUpdateDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolClashEogPlayerUpdateDTO" /> class.
        /// </summary>
        /// <param name="EarnedRewards">EarnedRewards.</param>
        /// <param name="GameId">GameId.</param>
        /// <param name="RewardProgress">RewardProgress.</param>
        /// <param name="SeasonVp">SeasonVp.</param>
        /// <param name="ThemeVp">ThemeVp.</param>
        /// <param name="TournamentId">TournamentId.</param>
        /// <param name="Winner">Winner.</param>
        public LolClashEogPlayerUpdateDTO(List<ClashRewardDefinition> EarnedRewards = default(List<ClashRewardDefinition>), long? GameId = default(long?), List<ClashRewardDefinition> RewardProgress = default(List<ClashRewardDefinition>), int? SeasonVp = default(int?), int? ThemeVp = default(int?), long? TournamentId = default(long?), bool? Winner = default(bool?))
        {
            this.EarnedRewards = EarnedRewards;
            this.GameId = GameId;
            this.RewardProgress = RewardProgress;
            this.SeasonVp = SeasonVp;
            this.ThemeVp = ThemeVp;
            this.TournamentId = TournamentId;
            this.Winner = Winner;
        }
        
        /// <summary>
        /// Gets or Sets EarnedRewards
        /// </summary>
        [DataMember(Name="earnedRewards", EmitDefaultValue=false)]
        public List<ClashRewardDefinition> EarnedRewards { get; set; }

        /// <summary>
        /// Gets or Sets GameId
        /// </summary>
        [DataMember(Name="gameId", EmitDefaultValue=false)]
        public long? GameId { get; set; }

        /// <summary>
        /// Gets or Sets RewardProgress
        /// </summary>
        [DataMember(Name="rewardProgress", EmitDefaultValue=false)]
        public List<ClashRewardDefinition> RewardProgress { get; set; }

        /// <summary>
        /// Gets or Sets SeasonVp
        /// </summary>
        [DataMember(Name="seasonVp", EmitDefaultValue=false)]
        public int? SeasonVp { get; set; }

        /// <summary>
        /// Gets or Sets ThemeVp
        /// </summary>
        [DataMember(Name="themeVp", EmitDefaultValue=false)]
        public int? ThemeVp { get; set; }

        /// <summary>
        /// Gets or Sets TournamentId
        /// </summary>
        [DataMember(Name="tournamentId", EmitDefaultValue=false)]
        public long? TournamentId { get; set; }

        /// <summary>
        /// Gets or Sets Winner
        /// </summary>
        [DataMember(Name="winner", EmitDefaultValue=false)]
        public bool? Winner { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolClashEogPlayerUpdateDTO {\n");
            sb.Append("  EarnedRewards: ").Append(EarnedRewards).Append("\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  RewardProgress: ").Append(RewardProgress).Append("\n");
            sb.Append("  SeasonVp: ").Append(SeasonVp).Append("\n");
            sb.Append("  ThemeVp: ").Append(ThemeVp).Append("\n");
            sb.Append("  TournamentId: ").Append(TournamentId).Append("\n");
            sb.Append("  Winner: ").Append(Winner).Append("\n");
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
            return this.Equals(obj as LolClashEogPlayerUpdateDTO);
        }

        /// <summary>
        /// Returns true if LolClashEogPlayerUpdateDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of LolClashEogPlayerUpdateDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolClashEogPlayerUpdateDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EarnedRewards == other.EarnedRewards ||
                    this.EarnedRewards != null &&
                    this.EarnedRewards.SequenceEqual(other.EarnedRewards)
                ) && 
                (
                    this.GameId == other.GameId ||
                    this.GameId != null &&
                    this.GameId.Equals(other.GameId)
                ) && 
                (
                    this.RewardProgress == other.RewardProgress ||
                    this.RewardProgress != null &&
                    this.RewardProgress.SequenceEqual(other.RewardProgress)
                ) && 
                (
                    this.SeasonVp == other.SeasonVp ||
                    this.SeasonVp != null &&
                    this.SeasonVp.Equals(other.SeasonVp)
                ) && 
                (
                    this.ThemeVp == other.ThemeVp ||
                    this.ThemeVp != null &&
                    this.ThemeVp.Equals(other.ThemeVp)
                ) && 
                (
                    this.TournamentId == other.TournamentId ||
                    this.TournamentId != null &&
                    this.TournamentId.Equals(other.TournamentId)
                ) && 
                (
                    this.Winner == other.Winner ||
                    this.Winner != null &&
                    this.Winner.Equals(other.Winner)
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
                if (this.EarnedRewards != null)
                    hash = hash * 59 + this.EarnedRewards.GetHashCode();
                if (this.GameId != null)
                    hash = hash * 59 + this.GameId.GetHashCode();
                if (this.RewardProgress != null)
                    hash = hash * 59 + this.RewardProgress.GetHashCode();
                if (this.SeasonVp != null)
                    hash = hash * 59 + this.SeasonVp.GetHashCode();
                if (this.ThemeVp != null)
                    hash = hash * 59 + this.ThemeVp.GetHashCode();
                if (this.TournamentId != null)
                    hash = hash * 59 + this.TournamentId.GetHashCode();
                if (this.Winner != null)
                    hash = hash * 59 + this.Winner.GetHashCode();
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
