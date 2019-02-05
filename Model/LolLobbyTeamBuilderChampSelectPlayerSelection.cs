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
    /// LolLobbyTeamBuilderChampSelectPlayerSelection
    /// </summary>
    [DataContract]
    public partial class LolLobbyTeamBuilderChampSelectPlayerSelection :  IEquatable<LolLobbyTeamBuilderChampSelectPlayerSelection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolLobbyTeamBuilderChampSelectPlayerSelection" /> class.
        /// </summary>
        /// <param name="AssignedPosition">AssignedPosition.</param>
        /// <param name="CellId">CellId.</param>
        /// <param name="ChampionId">ChampionId.</param>
        /// <param name="ChampionPickIntent">ChampionPickIntent.</param>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="PlayerType">PlayerType.</param>
        /// <param name="SelectedSkinId">SelectedSkinId.</param>
        /// <param name="Spell1Id">Spell1Id.</param>
        /// <param name="Spell2Id">Spell2Id.</param>
        /// <param name="SummonerId">SummonerId.</param>
        /// <param name="Team">Team.</param>
        /// <param name="WardSkinId">WardSkinId.</param>
        public LolLobbyTeamBuilderChampSelectPlayerSelection(string AssignedPosition = default(string), long? CellId = default(long?), int? ChampionId = default(int?), int? ChampionPickIntent = default(int?), string DisplayName = default(string), string PlayerType = default(string), int? SelectedSkinId = default(int?), long? Spell1Id = default(long?), long? Spell2Id = default(long?), long? SummonerId = default(long?), int? Team = default(int?), long? WardSkinId = default(long?))
        {
            this.AssignedPosition = AssignedPosition;
            this.CellId = CellId;
            this.ChampionId = ChampionId;
            this.ChampionPickIntent = ChampionPickIntent;
            this.DisplayName = DisplayName;
            this.PlayerType = PlayerType;
            this.SelectedSkinId = SelectedSkinId;
            this.Spell1Id = Spell1Id;
            this.Spell2Id = Spell2Id;
            this.SummonerId = SummonerId;
            this.Team = Team;
            this.WardSkinId = WardSkinId;
        }
        
        /// <summary>
        /// Gets or Sets AssignedPosition
        /// </summary>
        [DataMember(Name="assignedPosition", EmitDefaultValue=false)]
        public string AssignedPosition { get; set; }

        /// <summary>
        /// Gets or Sets CellId
        /// </summary>
        [DataMember(Name="cellId", EmitDefaultValue=false)]
        public long? CellId { get; set; }

        /// <summary>
        /// Gets or Sets ChampionId
        /// </summary>
        [DataMember(Name="championId", EmitDefaultValue=false)]
        public int? ChampionId { get; set; }

        /// <summary>
        /// Gets or Sets ChampionPickIntent
        /// </summary>
        [DataMember(Name="championPickIntent", EmitDefaultValue=false)]
        public int? ChampionPickIntent { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets PlayerType
        /// </summary>
        [DataMember(Name="playerType", EmitDefaultValue=false)]
        public string PlayerType { get; set; }

        /// <summary>
        /// Gets or Sets SelectedSkinId
        /// </summary>
        [DataMember(Name="selectedSkinId", EmitDefaultValue=false)]
        public int? SelectedSkinId { get; set; }

        /// <summary>
        /// Gets or Sets Spell1Id
        /// </summary>
        [DataMember(Name="spell1Id", EmitDefaultValue=false)]
        public long? Spell1Id { get; set; }

        /// <summary>
        /// Gets or Sets Spell2Id
        /// </summary>
        [DataMember(Name="spell2Id", EmitDefaultValue=false)]
        public long? Spell2Id { get; set; }

        /// <summary>
        /// Gets or Sets SummonerId
        /// </summary>
        [DataMember(Name="summonerId", EmitDefaultValue=false)]
        public long? SummonerId { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public int? Team { get; set; }

        /// <summary>
        /// Gets or Sets WardSkinId
        /// </summary>
        [DataMember(Name="wardSkinId", EmitDefaultValue=false)]
        public long? WardSkinId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolLobbyTeamBuilderChampSelectPlayerSelection {\n");
            sb.Append("  AssignedPosition: ").Append(AssignedPosition).Append("\n");
            sb.Append("  CellId: ").Append(CellId).Append("\n");
            sb.Append("  ChampionId: ").Append(ChampionId).Append("\n");
            sb.Append("  ChampionPickIntent: ").Append(ChampionPickIntent).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  PlayerType: ").Append(PlayerType).Append("\n");
            sb.Append("  SelectedSkinId: ").Append(SelectedSkinId).Append("\n");
            sb.Append("  Spell1Id: ").Append(Spell1Id).Append("\n");
            sb.Append("  Spell2Id: ").Append(Spell2Id).Append("\n");
            sb.Append("  SummonerId: ").Append(SummonerId).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  WardSkinId: ").Append(WardSkinId).Append("\n");
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
            return this.Equals(obj as LolLobbyTeamBuilderChampSelectPlayerSelection);
        }

        /// <summary>
        /// Returns true if LolLobbyTeamBuilderChampSelectPlayerSelection instances are equal
        /// </summary>
        /// <param name="other">Instance of LolLobbyTeamBuilderChampSelectPlayerSelection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolLobbyTeamBuilderChampSelectPlayerSelection other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AssignedPosition == other.AssignedPosition ||
                    this.AssignedPosition != null &&
                    this.AssignedPosition.Equals(other.AssignedPosition)
                ) && 
                (
                    this.CellId == other.CellId ||
                    this.CellId != null &&
                    this.CellId.Equals(other.CellId)
                ) && 
                (
                    this.ChampionId == other.ChampionId ||
                    this.ChampionId != null &&
                    this.ChampionId.Equals(other.ChampionId)
                ) && 
                (
                    this.ChampionPickIntent == other.ChampionPickIntent ||
                    this.ChampionPickIntent != null &&
                    this.ChampionPickIntent.Equals(other.ChampionPickIntent)
                ) && 
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    this.PlayerType == other.PlayerType ||
                    this.PlayerType != null &&
                    this.PlayerType.Equals(other.PlayerType)
                ) && 
                (
                    this.SelectedSkinId == other.SelectedSkinId ||
                    this.SelectedSkinId != null &&
                    this.SelectedSkinId.Equals(other.SelectedSkinId)
                ) && 
                (
                    this.Spell1Id == other.Spell1Id ||
                    this.Spell1Id != null &&
                    this.Spell1Id.Equals(other.Spell1Id)
                ) && 
                (
                    this.Spell2Id == other.Spell2Id ||
                    this.Spell2Id != null &&
                    this.Spell2Id.Equals(other.Spell2Id)
                ) && 
                (
                    this.SummonerId == other.SummonerId ||
                    this.SummonerId != null &&
                    this.SummonerId.Equals(other.SummonerId)
                ) && 
                (
                    this.Team == other.Team ||
                    this.Team != null &&
                    this.Team.Equals(other.Team)
                ) && 
                (
                    this.WardSkinId == other.WardSkinId ||
                    this.WardSkinId != null &&
                    this.WardSkinId.Equals(other.WardSkinId)
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
                if (this.AssignedPosition != null)
                    hash = hash * 59 + this.AssignedPosition.GetHashCode();
                if (this.CellId != null)
                    hash = hash * 59 + this.CellId.GetHashCode();
                if (this.ChampionId != null)
                    hash = hash * 59 + this.ChampionId.GetHashCode();
                if (this.ChampionPickIntent != null)
                    hash = hash * 59 + this.ChampionPickIntent.GetHashCode();
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.PlayerType != null)
                    hash = hash * 59 + this.PlayerType.GetHashCode();
                if (this.SelectedSkinId != null)
                    hash = hash * 59 + this.SelectedSkinId.GetHashCode();
                if (this.Spell1Id != null)
                    hash = hash * 59 + this.Spell1Id.GetHashCode();
                if (this.Spell2Id != null)
                    hash = hash * 59 + this.Spell2Id.GetHashCode();
                if (this.SummonerId != null)
                    hash = hash * 59 + this.SummonerId.GetHashCode();
                if (this.Team != null)
                    hash = hash * 59 + this.Team.GetHashCode();
                if (this.WardSkinId != null)
                    hash = hash * 59 + this.WardSkinId.GetHashCode();
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