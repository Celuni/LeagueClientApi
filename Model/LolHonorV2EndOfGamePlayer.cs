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
    /// LolHonorV2EndOfGamePlayer
    /// </summary>
    [DataContract]
    public partial class LolHonorV2EndOfGamePlayer :  IEquatable<LolHonorV2EndOfGamePlayer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolHonorV2EndOfGamePlayer" /> class.
        /// </summary>
        /// <param name="BotPlayer">BotPlayer.</param>
        /// <param name="ChampionId">ChampionId.</param>
        /// <param name="GameId">GameId.</param>
        /// <param name="IsReportingDisabled">IsReportingDisabled.</param>
        /// <param name="Leaver">Leaver.</param>
        /// <param name="ProfileIconId">ProfileIconId.</param>
        /// <param name="SkinIndex">SkinIndex.</param>
        /// <param name="SkinName">SkinName.</param>
        /// <param name="Stats">Stats.</param>
        /// <param name="SummonerId">SummonerId.</param>
        /// <param name="SummonerName">SummonerName.</param>
        /// <param name="TeamId">TeamId.</param>
        /// <param name="UserId">UserId.</param>
        /// <param name="Wins">Wins.</param>
        public LolHonorV2EndOfGamePlayer(bool? BotPlayer = default(bool?), int? ChampionId = default(int?), long? GameId = default(long?), bool? IsReportingDisabled = default(bool?), bool? Leaver = default(bool?), int? ProfileIconId = default(int?), int? SkinIndex = default(int?), string SkinName = default(string), Object Stats = default(Object), long? SummonerId = default(long?), string SummonerName = default(string), int? TeamId = default(int?), long? UserId = default(long?), int? Wins = default(int?))
        {
            this.BotPlayer = BotPlayer;
            this.ChampionId = ChampionId;
            this.GameId = GameId;
            this.IsReportingDisabled = IsReportingDisabled;
            this.Leaver = Leaver;
            this.ProfileIconId = ProfileIconId;
            this.SkinIndex = SkinIndex;
            this.SkinName = SkinName;
            this.Stats = Stats;
            this.SummonerId = SummonerId;
            this.SummonerName = SummonerName;
            this.TeamId = TeamId;
            this.UserId = UserId;
            this.Wins = Wins;
        }
        
        /// <summary>
        /// Gets or Sets BotPlayer
        /// </summary>
        [DataMember(Name="botPlayer", EmitDefaultValue=false)]
        public bool? BotPlayer { get; set; }

        /// <summary>
        /// Gets or Sets ChampionId
        /// </summary>
        [DataMember(Name="championId", EmitDefaultValue=false)]
        public int? ChampionId { get; set; }

        /// <summary>
        /// Gets or Sets GameId
        /// </summary>
        [DataMember(Name="gameId", EmitDefaultValue=false)]
        public long? GameId { get; set; }

        /// <summary>
        /// Gets or Sets IsReportingDisabled
        /// </summary>
        [DataMember(Name="isReportingDisabled", EmitDefaultValue=false)]
        public bool? IsReportingDisabled { get; set; }

        /// <summary>
        /// Gets or Sets Leaver
        /// </summary>
        [DataMember(Name="leaver", EmitDefaultValue=false)]
        public bool? Leaver { get; set; }

        /// <summary>
        /// Gets or Sets ProfileIconId
        /// </summary>
        [DataMember(Name="profileIconId", EmitDefaultValue=false)]
        public int? ProfileIconId { get; set; }

        /// <summary>
        /// Gets or Sets SkinIndex
        /// </summary>
        [DataMember(Name="skinIndex", EmitDefaultValue=false)]
        public int? SkinIndex { get; set; }

        /// <summary>
        /// Gets or Sets SkinName
        /// </summary>
        [DataMember(Name="skinName", EmitDefaultValue=false)]
        public string SkinName { get; set; }

        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public Object Stats { get; set; }

        /// <summary>
        /// Gets or Sets SummonerId
        /// </summary>
        [DataMember(Name="summonerId", EmitDefaultValue=false)]
        public long? SummonerId { get; set; }

        /// <summary>
        /// Gets or Sets SummonerName
        /// </summary>
        [DataMember(Name="summonerName", EmitDefaultValue=false)]
        public string SummonerName { get; set; }

        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [DataMember(Name="teamId", EmitDefaultValue=false)]
        public int? TeamId { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public long? UserId { get; set; }

        /// <summary>
        /// Gets or Sets Wins
        /// </summary>
        [DataMember(Name="wins", EmitDefaultValue=false)]
        public int? Wins { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolHonorV2EndOfGamePlayer {\n");
            sb.Append("  BotPlayer: ").Append(BotPlayer).Append("\n");
            sb.Append("  ChampionId: ").Append(ChampionId).Append("\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  IsReportingDisabled: ").Append(IsReportingDisabled).Append("\n");
            sb.Append("  Leaver: ").Append(Leaver).Append("\n");
            sb.Append("  ProfileIconId: ").Append(ProfileIconId).Append("\n");
            sb.Append("  SkinIndex: ").Append(SkinIndex).Append("\n");
            sb.Append("  SkinName: ").Append(SkinName).Append("\n");
            sb.Append("  Stats: ").Append(Stats).Append("\n");
            sb.Append("  SummonerId: ").Append(SummonerId).Append("\n");
            sb.Append("  SummonerName: ").Append(SummonerName).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Wins: ").Append(Wins).Append("\n");
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
            return this.Equals(obj as LolHonorV2EndOfGamePlayer);
        }

        /// <summary>
        /// Returns true if LolHonorV2EndOfGamePlayer instances are equal
        /// </summary>
        /// <param name="other">Instance of LolHonorV2EndOfGamePlayer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolHonorV2EndOfGamePlayer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BotPlayer == other.BotPlayer ||
                    this.BotPlayer != null &&
                    this.BotPlayer.Equals(other.BotPlayer)
                ) && 
                (
                    this.ChampionId == other.ChampionId ||
                    this.ChampionId != null &&
                    this.ChampionId.Equals(other.ChampionId)
                ) && 
                (
                    this.GameId == other.GameId ||
                    this.GameId != null &&
                    this.GameId.Equals(other.GameId)
                ) && 
                (
                    this.IsReportingDisabled == other.IsReportingDisabled ||
                    this.IsReportingDisabled != null &&
                    this.IsReportingDisabled.Equals(other.IsReportingDisabled)
                ) && 
                (
                    this.Leaver == other.Leaver ||
                    this.Leaver != null &&
                    this.Leaver.Equals(other.Leaver)
                ) && 
                (
                    this.ProfileIconId == other.ProfileIconId ||
                    this.ProfileIconId != null &&
                    this.ProfileIconId.Equals(other.ProfileIconId)
                ) && 
                (
                    this.SkinIndex == other.SkinIndex ||
                    this.SkinIndex != null &&
                    this.SkinIndex.Equals(other.SkinIndex)
                ) && 
                (
                    this.SkinName == other.SkinName ||
                    this.SkinName != null &&
                    this.SkinName.Equals(other.SkinName)
                ) && 
                (
                    this.Stats == other.Stats ||
                    this.Stats != null &&
                    this.Stats.Equals(other.Stats)
                ) && 
                (
                    this.SummonerId == other.SummonerId ||
                    this.SummonerId != null &&
                    this.SummonerId.Equals(other.SummonerId)
                ) && 
                (
                    this.SummonerName == other.SummonerName ||
                    this.SummonerName != null &&
                    this.SummonerName.Equals(other.SummonerName)
                ) && 
                (
                    this.TeamId == other.TeamId ||
                    this.TeamId != null &&
                    this.TeamId.Equals(other.TeamId)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.Wins == other.Wins ||
                    this.Wins != null &&
                    this.Wins.Equals(other.Wins)
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
                if (this.BotPlayer != null)
                    hash = hash * 59 + this.BotPlayer.GetHashCode();
                if (this.ChampionId != null)
                    hash = hash * 59 + this.ChampionId.GetHashCode();
                if (this.GameId != null)
                    hash = hash * 59 + this.GameId.GetHashCode();
                if (this.IsReportingDisabled != null)
                    hash = hash * 59 + this.IsReportingDisabled.GetHashCode();
                if (this.Leaver != null)
                    hash = hash * 59 + this.Leaver.GetHashCode();
                if (this.ProfileIconId != null)
                    hash = hash * 59 + this.ProfileIconId.GetHashCode();
                if (this.SkinIndex != null)
                    hash = hash * 59 + this.SkinIndex.GetHashCode();
                if (this.SkinName != null)
                    hash = hash * 59 + this.SkinName.GetHashCode();
                if (this.Stats != null)
                    hash = hash * 59 + this.Stats.GetHashCode();
                if (this.SummonerId != null)
                    hash = hash * 59 + this.SummonerId.GetHashCode();
                if (this.SummonerName != null)
                    hash = hash * 59 + this.SummonerName.GetHashCode();
                if (this.TeamId != null)
                    hash = hash * 59 + this.TeamId.GetHashCode();
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.Wins != null)
                    hash = hash * 59 + this.Wins.GetHashCode();
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