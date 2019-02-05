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
    /// GameflowLcdsGameDTO
    /// </summary>
    [DataContract]
    public partial class GameflowLcdsGameDTO :  IEquatable<GameflowLcdsGameDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameflowLcdsGameDTO" /> class.
        /// </summary>
        /// <param name="GameMode">GameMode.</param>
        /// <param name="GameState">GameState.</param>
        /// <param name="GameType">GameType.</param>
        /// <param name="GameTypeConfigId">GameTypeConfigId.</param>
        /// <param name="Id">Id.</param>
        /// <param name="MapId">MapId.</param>
        /// <param name="MaxNumPlayers">MaxNumPlayers.</param>
        /// <param name="PlayerChampionSelections">PlayerChampionSelections.</param>
        /// <param name="QueueTypeName">QueueTypeName.</param>
        /// <param name="SpectatorDelay">SpectatorDelay.</param>
        /// <param name="TeamOne">TeamOne.</param>
        /// <param name="TeamTwo">TeamTwo.</param>
        public GameflowLcdsGameDTO(string GameMode = default(string), string GameState = default(string), string GameType = default(string), int? GameTypeConfigId = default(int?), long? Id = default(long?), int? MapId = default(int?), int? MaxNumPlayers = default(int?), List<Object> PlayerChampionSelections = default(List<Object>), string QueueTypeName = default(string), int? SpectatorDelay = default(int?), List<Object> TeamOne = default(List<Object>), List<Object> TeamTwo = default(List<Object>))
        {
            this.GameMode = GameMode;
            this.GameState = GameState;
            this.GameType = GameType;
            this.GameTypeConfigId = GameTypeConfigId;
            this.Id = Id;
            this.MapId = MapId;
            this.MaxNumPlayers = MaxNumPlayers;
            this.PlayerChampionSelections = PlayerChampionSelections;
            this.QueueTypeName = QueueTypeName;
            this.SpectatorDelay = SpectatorDelay;
            this.TeamOne = TeamOne;
            this.TeamTwo = TeamTwo;
        }
        
        /// <summary>
        /// Gets or Sets GameMode
        /// </summary>
        [DataMember(Name="gameMode", EmitDefaultValue=false)]
        public string GameMode { get; set; }

        /// <summary>
        /// Gets or Sets GameState
        /// </summary>
        [DataMember(Name="gameState", EmitDefaultValue=false)]
        public string GameState { get; set; }

        /// <summary>
        /// Gets or Sets GameType
        /// </summary>
        [DataMember(Name="gameType", EmitDefaultValue=false)]
        public string GameType { get; set; }

        /// <summary>
        /// Gets or Sets GameTypeConfigId
        /// </summary>
        [DataMember(Name="gameTypeConfigId", EmitDefaultValue=false)]
        public int? GameTypeConfigId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets MapId
        /// </summary>
        [DataMember(Name="mapId", EmitDefaultValue=false)]
        public int? MapId { get; set; }

        /// <summary>
        /// Gets or Sets MaxNumPlayers
        /// </summary>
        [DataMember(Name="maxNumPlayers", EmitDefaultValue=false)]
        public int? MaxNumPlayers { get; set; }

        /// <summary>
        /// Gets or Sets PlayerChampionSelections
        /// </summary>
        [DataMember(Name="playerChampionSelections", EmitDefaultValue=false)]
        public List<Object> PlayerChampionSelections { get; set; }

        /// <summary>
        /// Gets or Sets QueueTypeName
        /// </summary>
        [DataMember(Name="queueTypeName", EmitDefaultValue=false)]
        public string QueueTypeName { get; set; }

        /// <summary>
        /// Gets or Sets SpectatorDelay
        /// </summary>
        [DataMember(Name="spectatorDelay", EmitDefaultValue=false)]
        public int? SpectatorDelay { get; set; }

        /// <summary>
        /// Gets or Sets TeamOne
        /// </summary>
        [DataMember(Name="teamOne", EmitDefaultValue=false)]
        public List<Object> TeamOne { get; set; }

        /// <summary>
        /// Gets or Sets TeamTwo
        /// </summary>
        [DataMember(Name="teamTwo", EmitDefaultValue=false)]
        public List<Object> TeamTwo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GameflowLcdsGameDTO {\n");
            sb.Append("  GameMode: ").Append(GameMode).Append("\n");
            sb.Append("  GameState: ").Append(GameState).Append("\n");
            sb.Append("  GameType: ").Append(GameType).Append("\n");
            sb.Append("  GameTypeConfigId: ").Append(GameTypeConfigId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MapId: ").Append(MapId).Append("\n");
            sb.Append("  MaxNumPlayers: ").Append(MaxNumPlayers).Append("\n");
            sb.Append("  PlayerChampionSelections: ").Append(PlayerChampionSelections).Append("\n");
            sb.Append("  QueueTypeName: ").Append(QueueTypeName).Append("\n");
            sb.Append("  SpectatorDelay: ").Append(SpectatorDelay).Append("\n");
            sb.Append("  TeamOne: ").Append(TeamOne).Append("\n");
            sb.Append("  TeamTwo: ").Append(TeamTwo).Append("\n");
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
            return this.Equals(obj as GameflowLcdsGameDTO);
        }

        /// <summary>
        /// Returns true if GameflowLcdsGameDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of GameflowLcdsGameDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GameflowLcdsGameDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.GameMode == other.GameMode ||
                    this.GameMode != null &&
                    this.GameMode.Equals(other.GameMode)
                ) && 
                (
                    this.GameState == other.GameState ||
                    this.GameState != null &&
                    this.GameState.Equals(other.GameState)
                ) && 
                (
                    this.GameType == other.GameType ||
                    this.GameType != null &&
                    this.GameType.Equals(other.GameType)
                ) && 
                (
                    this.GameTypeConfigId == other.GameTypeConfigId ||
                    this.GameTypeConfigId != null &&
                    this.GameTypeConfigId.Equals(other.GameTypeConfigId)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.MapId == other.MapId ||
                    this.MapId != null &&
                    this.MapId.Equals(other.MapId)
                ) && 
                (
                    this.MaxNumPlayers == other.MaxNumPlayers ||
                    this.MaxNumPlayers != null &&
                    this.MaxNumPlayers.Equals(other.MaxNumPlayers)
                ) && 
                (
                    this.PlayerChampionSelections == other.PlayerChampionSelections ||
                    this.PlayerChampionSelections != null &&
                    this.PlayerChampionSelections.SequenceEqual(other.PlayerChampionSelections)
                ) && 
                (
                    this.QueueTypeName == other.QueueTypeName ||
                    this.QueueTypeName != null &&
                    this.QueueTypeName.Equals(other.QueueTypeName)
                ) && 
                (
                    this.SpectatorDelay == other.SpectatorDelay ||
                    this.SpectatorDelay != null &&
                    this.SpectatorDelay.Equals(other.SpectatorDelay)
                ) && 
                (
                    this.TeamOne == other.TeamOne ||
                    this.TeamOne != null &&
                    this.TeamOne.SequenceEqual(other.TeamOne)
                ) && 
                (
                    this.TeamTwo == other.TeamTwo ||
                    this.TeamTwo != null &&
                    this.TeamTwo.SequenceEqual(other.TeamTwo)
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
                if (this.GameMode != null)
                    hash = hash * 59 + this.GameMode.GetHashCode();
                if (this.GameState != null)
                    hash = hash * 59 + this.GameState.GetHashCode();
                if (this.GameType != null)
                    hash = hash * 59 + this.GameType.GetHashCode();
                if (this.GameTypeConfigId != null)
                    hash = hash * 59 + this.GameTypeConfigId.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.MapId != null)
                    hash = hash * 59 + this.MapId.GetHashCode();
                if (this.MaxNumPlayers != null)
                    hash = hash * 59 + this.MaxNumPlayers.GetHashCode();
                if (this.PlayerChampionSelections != null)
                    hash = hash * 59 + this.PlayerChampionSelections.GetHashCode();
                if (this.QueueTypeName != null)
                    hash = hash * 59 + this.QueueTypeName.GetHashCode();
                if (this.SpectatorDelay != null)
                    hash = hash * 59 + this.SpectatorDelay.GetHashCode();
                if (this.TeamOne != null)
                    hash = hash * 59 + this.TeamOne.GetHashCode();
                if (this.TeamTwo != null)
                    hash = hash * 59 + this.TeamTwo.GetHashCode();
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