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
    /// LolMatchHistoryRecentlyPlayedSummoner
    /// </summary>
    [DataContract]
    public partial class LolMatchHistoryRecentlyPlayedSummoner :  IEquatable<LolMatchHistoryRecentlyPlayedSummoner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolMatchHistoryRecentlyPlayedSummoner" /> class.
        /// </summary>
        /// <param name="ChampionId">ChampionId.</param>
        /// <param name="GameCreationDate">GameCreationDate.</param>
        /// <param name="GameId">GameId.</param>
        /// <param name="SummonerId">SummonerId.</param>
        /// <param name="SummonerName">SummonerName.</param>
        /// <param name="TeamId">TeamId.</param>
        public LolMatchHistoryRecentlyPlayedSummoner(long? ChampionId = default(long?), string GameCreationDate = default(string), long? GameId = default(long?), long? SummonerId = default(long?), string SummonerName = default(string), long? TeamId = default(long?))
        {
            this.ChampionId = ChampionId;
            this.GameCreationDate = GameCreationDate;
            this.GameId = GameId;
            this.SummonerId = SummonerId;
            this.SummonerName = SummonerName;
            this.TeamId = TeamId;
        }
        
        /// <summary>
        /// Gets or Sets ChampionId
        /// </summary>
        [DataMember(Name="championId", EmitDefaultValue=false)]
        public long? ChampionId { get; set; }

        /// <summary>
        /// Gets or Sets GameCreationDate
        /// </summary>
        [DataMember(Name="gameCreationDate", EmitDefaultValue=false)]
        public string GameCreationDate { get; set; }

        /// <summary>
        /// Gets or Sets GameId
        /// </summary>
        [DataMember(Name="gameId", EmitDefaultValue=false)]
        public long? GameId { get; set; }

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
        public long? TeamId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolMatchHistoryRecentlyPlayedSummoner {\n");
            sb.Append("  ChampionId: ").Append(ChampionId).Append("\n");
            sb.Append("  GameCreationDate: ").Append(GameCreationDate).Append("\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  SummonerId: ").Append(SummonerId).Append("\n");
            sb.Append("  SummonerName: ").Append(SummonerName).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
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
            return this.Equals(obj as LolMatchHistoryRecentlyPlayedSummoner);
        }

        /// <summary>
        /// Returns true if LolMatchHistoryRecentlyPlayedSummoner instances are equal
        /// </summary>
        /// <param name="other">Instance of LolMatchHistoryRecentlyPlayedSummoner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolMatchHistoryRecentlyPlayedSummoner other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ChampionId == other.ChampionId ||
                    this.ChampionId != null &&
                    this.ChampionId.Equals(other.ChampionId)
                ) && 
                (
                    this.GameCreationDate == other.GameCreationDate ||
                    this.GameCreationDate != null &&
                    this.GameCreationDate.Equals(other.GameCreationDate)
                ) && 
                (
                    this.GameId == other.GameId ||
                    this.GameId != null &&
                    this.GameId.Equals(other.GameId)
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
                if (this.ChampionId != null)
                    hash = hash * 59 + this.ChampionId.GetHashCode();
                if (this.GameCreationDate != null)
                    hash = hash * 59 + this.GameCreationDate.GetHashCode();
                if (this.GameId != null)
                    hash = hash * 59 + this.GameId.GetHashCode();
                if (this.SummonerId != null)
                    hash = hash * 59 + this.SummonerId.GetHashCode();
                if (this.SummonerName != null)
                    hash = hash * 59 + this.SummonerName.GetHashCode();
                if (this.TeamId != null)
                    hash = hash * 59 + this.TeamId.GetHashCode();
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
