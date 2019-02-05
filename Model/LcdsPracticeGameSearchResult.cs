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
    /// LcdsPracticeGameSearchResult
    /// </summary>
    [DataContract]
    public partial class LcdsPracticeGameSearchResult :  IEquatable<LcdsPracticeGameSearchResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LcdsPracticeGameSearchResult" /> class.
        /// </summary>
        /// <param name="AllowSpectators">AllowSpectators.</param>
        /// <param name="GameMap">GameMap.</param>
        /// <param name="GameMapId">GameMapId.</param>
        /// <param name="GameMode">GameMode.</param>
        /// <param name="Id">Id.</param>
        /// <param name="MaxNumPlayers">MaxNumPlayers.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Owner">Owner.</param>
        /// <param name="PickType">PickType.</param>
        /// <param name="PrivateGame">PrivateGame.</param>
        /// <param name="SpectatorCount">SpectatorCount.</param>
        /// <param name="Team1Count">Team1Count.</param>
        /// <param name="Team2Count">Team2Count.</param>
        public LcdsPracticeGameSearchResult(string AllowSpectators = default(string), LcdsGameMap GameMap = default(LcdsGameMap), int? GameMapId = default(int?), string GameMode = default(string), long? Id = default(long?), int? MaxNumPlayers = default(int?), string Name = default(string), LcdsPlayerParticipant Owner = default(LcdsPlayerParticipant), string PickType = default(string), bool? PrivateGame = default(bool?), int? SpectatorCount = default(int?), int? Team1Count = default(int?), int? Team2Count = default(int?))
        {
            this.AllowSpectators = AllowSpectators;
            this.GameMap = GameMap;
            this.GameMapId = GameMapId;
            this.GameMode = GameMode;
            this.Id = Id;
            this.MaxNumPlayers = MaxNumPlayers;
            this.Name = Name;
            this.Owner = Owner;
            this.PickType = PickType;
            this.PrivateGame = PrivateGame;
            this.SpectatorCount = SpectatorCount;
            this.Team1Count = Team1Count;
            this.Team2Count = Team2Count;
        }
        
        /// <summary>
        /// Gets or Sets AllowSpectators
        /// </summary>
        [DataMember(Name="allowSpectators", EmitDefaultValue=false)]
        public string AllowSpectators { get; set; }

        /// <summary>
        /// Gets or Sets GameMap
        /// </summary>
        [DataMember(Name="gameMap", EmitDefaultValue=false)]
        public LcdsGameMap GameMap { get; set; }

        /// <summary>
        /// Gets or Sets GameMapId
        /// </summary>
        [DataMember(Name="gameMapId", EmitDefaultValue=false)]
        public int? GameMapId { get; set; }

        /// <summary>
        /// Gets or Sets GameMode
        /// </summary>
        [DataMember(Name="gameMode", EmitDefaultValue=false)]
        public string GameMode { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets MaxNumPlayers
        /// </summary>
        [DataMember(Name="maxNumPlayers", EmitDefaultValue=false)]
        public int? MaxNumPlayers { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public LcdsPlayerParticipant Owner { get; set; }

        /// <summary>
        /// Gets or Sets PickType
        /// </summary>
        [DataMember(Name="pickType", EmitDefaultValue=false)]
        public string PickType { get; set; }

        /// <summary>
        /// Gets or Sets PrivateGame
        /// </summary>
        [DataMember(Name="privateGame", EmitDefaultValue=false)]
        public bool? PrivateGame { get; set; }

        /// <summary>
        /// Gets or Sets SpectatorCount
        /// </summary>
        [DataMember(Name="spectatorCount", EmitDefaultValue=false)]
        public int? SpectatorCount { get; set; }

        /// <summary>
        /// Gets or Sets Team1Count
        /// </summary>
        [DataMember(Name="team1Count", EmitDefaultValue=false)]
        public int? Team1Count { get; set; }

        /// <summary>
        /// Gets or Sets Team2Count
        /// </summary>
        [DataMember(Name="team2Count", EmitDefaultValue=false)]
        public int? Team2Count { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LcdsPracticeGameSearchResult {\n");
            sb.Append("  AllowSpectators: ").Append(AllowSpectators).Append("\n");
            sb.Append("  GameMap: ").Append(GameMap).Append("\n");
            sb.Append("  GameMapId: ").Append(GameMapId).Append("\n");
            sb.Append("  GameMode: ").Append(GameMode).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MaxNumPlayers: ").Append(MaxNumPlayers).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  PickType: ").Append(PickType).Append("\n");
            sb.Append("  PrivateGame: ").Append(PrivateGame).Append("\n");
            sb.Append("  SpectatorCount: ").Append(SpectatorCount).Append("\n");
            sb.Append("  Team1Count: ").Append(Team1Count).Append("\n");
            sb.Append("  Team2Count: ").Append(Team2Count).Append("\n");
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
            return this.Equals(obj as LcdsPracticeGameSearchResult);
        }

        /// <summary>
        /// Returns true if LcdsPracticeGameSearchResult instances are equal
        /// </summary>
        /// <param name="other">Instance of LcdsPracticeGameSearchResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LcdsPracticeGameSearchResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AllowSpectators == other.AllowSpectators ||
                    this.AllowSpectators != null &&
                    this.AllowSpectators.Equals(other.AllowSpectators)
                ) && 
                (
                    this.GameMap == other.GameMap ||
                    this.GameMap != null &&
                    this.GameMap.Equals(other.GameMap)
                ) && 
                (
                    this.GameMapId == other.GameMapId ||
                    this.GameMapId != null &&
                    this.GameMapId.Equals(other.GameMapId)
                ) && 
                (
                    this.GameMode == other.GameMode ||
                    this.GameMode != null &&
                    this.GameMode.Equals(other.GameMode)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.MaxNumPlayers == other.MaxNumPlayers ||
                    this.MaxNumPlayers != null &&
                    this.MaxNumPlayers.Equals(other.MaxNumPlayers)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Owner == other.Owner ||
                    this.Owner != null &&
                    this.Owner.Equals(other.Owner)
                ) && 
                (
                    this.PickType == other.PickType ||
                    this.PickType != null &&
                    this.PickType.Equals(other.PickType)
                ) && 
                (
                    this.PrivateGame == other.PrivateGame ||
                    this.PrivateGame != null &&
                    this.PrivateGame.Equals(other.PrivateGame)
                ) && 
                (
                    this.SpectatorCount == other.SpectatorCount ||
                    this.SpectatorCount != null &&
                    this.SpectatorCount.Equals(other.SpectatorCount)
                ) && 
                (
                    this.Team1Count == other.Team1Count ||
                    this.Team1Count != null &&
                    this.Team1Count.Equals(other.Team1Count)
                ) && 
                (
                    this.Team2Count == other.Team2Count ||
                    this.Team2Count != null &&
                    this.Team2Count.Equals(other.Team2Count)
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
                if (this.AllowSpectators != null)
                    hash = hash * 59 + this.AllowSpectators.GetHashCode();
                if (this.GameMap != null)
                    hash = hash * 59 + this.GameMap.GetHashCode();
                if (this.GameMapId != null)
                    hash = hash * 59 + this.GameMapId.GetHashCode();
                if (this.GameMode != null)
                    hash = hash * 59 + this.GameMode.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.MaxNumPlayers != null)
                    hash = hash * 59 + this.MaxNumPlayers.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Owner != null)
                    hash = hash * 59 + this.Owner.GetHashCode();
                if (this.PickType != null)
                    hash = hash * 59 + this.PickType.GetHashCode();
                if (this.PrivateGame != null)
                    hash = hash * 59 + this.PrivateGame.GetHashCode();
                if (this.SpectatorCount != null)
                    hash = hash * 59 + this.SpectatorCount.GetHashCode();
                if (this.Team1Count != null)
                    hash = hash * 59 + this.Team1Count.GetHashCode();
                if (this.Team2Count != null)
                    hash = hash * 59 + this.Team2Count.GetHashCode();
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