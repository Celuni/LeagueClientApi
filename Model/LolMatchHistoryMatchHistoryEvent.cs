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
    /// LolMatchHistoryMatchHistoryEvent
    /// </summary>
    [DataContract]
    public partial class LolMatchHistoryMatchHistoryEvent :  IEquatable<LolMatchHistoryMatchHistoryEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolMatchHistoryMatchHistoryEvent" /> class.
        /// </summary>
        /// <param name="AssistingParticipantIds">AssistingParticipantIds.</param>
        /// <param name="BuildingType">BuildingType.</param>
        /// <param name="ItemId">ItemId.</param>
        /// <param name="KillerId">KillerId.</param>
        /// <param name="LaneType">LaneType.</param>
        /// <param name="MonsterSubType">MonsterSubType.</param>
        /// <param name="MonsterType">MonsterType.</param>
        /// <param name="ParticipantId">ParticipantId.</param>
        /// <param name="Position">Position.</param>
        /// <param name="SkillSlot">SkillSlot.</param>
        /// <param name="TeamId">TeamId.</param>
        /// <param name="Timestamp">Timestamp.</param>
        /// <param name="TowerType">TowerType.</param>
        /// <param name="Type">Type.</param>
        /// <param name="VictimId">VictimId.</param>
        public LolMatchHistoryMatchHistoryEvent(List<int?> AssistingParticipantIds = default(List<int?>), string BuildingType = default(string), int? ItemId = default(int?), int? KillerId = default(int?), string LaneType = default(string), string MonsterSubType = default(string), string MonsterType = default(string), int? ParticipantId = default(int?), LolMatchHistoryMatchHistoryPosition Position = default(LolMatchHistoryMatchHistoryPosition), int? SkillSlot = default(int?), int? TeamId = default(int?), long? Timestamp = default(long?), string TowerType = default(string), string Type = default(string), int? VictimId = default(int?))
        {
            this.AssistingParticipantIds = AssistingParticipantIds;
            this.BuildingType = BuildingType;
            this.ItemId = ItemId;
            this.KillerId = KillerId;
            this.LaneType = LaneType;
            this.MonsterSubType = MonsterSubType;
            this.MonsterType = MonsterType;
            this.ParticipantId = ParticipantId;
            this.Position = Position;
            this.SkillSlot = SkillSlot;
            this.TeamId = TeamId;
            this.Timestamp = Timestamp;
            this.TowerType = TowerType;
            this.Type = Type;
            this.VictimId = VictimId;
        }
        
        /// <summary>
        /// Gets or Sets AssistingParticipantIds
        /// </summary>
        [DataMember(Name="assistingParticipantIds", EmitDefaultValue=false)]
        public List<int?> AssistingParticipantIds { get; set; }

        /// <summary>
        /// Gets or Sets BuildingType
        /// </summary>
        [DataMember(Name="buildingType", EmitDefaultValue=false)]
        public string BuildingType { get; set; }

        /// <summary>
        /// Gets or Sets ItemId
        /// </summary>
        [DataMember(Name="itemId", EmitDefaultValue=false)]
        public int? ItemId { get; set; }

        /// <summary>
        /// Gets or Sets KillerId
        /// </summary>
        [DataMember(Name="killerId", EmitDefaultValue=false)]
        public int? KillerId { get; set; }

        /// <summary>
        /// Gets or Sets LaneType
        /// </summary>
        [DataMember(Name="laneType", EmitDefaultValue=false)]
        public string LaneType { get; set; }

        /// <summary>
        /// Gets or Sets MonsterSubType
        /// </summary>
        [DataMember(Name="monsterSubType", EmitDefaultValue=false)]
        public string MonsterSubType { get; set; }

        /// <summary>
        /// Gets or Sets MonsterType
        /// </summary>
        [DataMember(Name="monsterType", EmitDefaultValue=false)]
        public string MonsterType { get; set; }

        /// <summary>
        /// Gets or Sets ParticipantId
        /// </summary>
        [DataMember(Name="participantId", EmitDefaultValue=false)]
        public int? ParticipantId { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public LolMatchHistoryMatchHistoryPosition Position { get; set; }

        /// <summary>
        /// Gets or Sets SkillSlot
        /// </summary>
        [DataMember(Name="skillSlot", EmitDefaultValue=false)]
        public int? SkillSlot { get; set; }

        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [DataMember(Name="teamId", EmitDefaultValue=false)]
        public int? TeamId { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public long? Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets TowerType
        /// </summary>
        [DataMember(Name="towerType", EmitDefaultValue=false)]
        public string TowerType { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets VictimId
        /// </summary>
        [DataMember(Name="victimId", EmitDefaultValue=false)]
        public int? VictimId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolMatchHistoryMatchHistoryEvent {\n");
            sb.Append("  AssistingParticipantIds: ").Append(AssistingParticipantIds).Append("\n");
            sb.Append("  BuildingType: ").Append(BuildingType).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  KillerId: ").Append(KillerId).Append("\n");
            sb.Append("  LaneType: ").Append(LaneType).Append("\n");
            sb.Append("  MonsterSubType: ").Append(MonsterSubType).Append("\n");
            sb.Append("  MonsterType: ").Append(MonsterType).Append("\n");
            sb.Append("  ParticipantId: ").Append(ParticipantId).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  SkillSlot: ").Append(SkillSlot).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  TowerType: ").Append(TowerType).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  VictimId: ").Append(VictimId).Append("\n");
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
            return this.Equals(obj as LolMatchHistoryMatchHistoryEvent);
        }

        /// <summary>
        /// Returns true if LolMatchHistoryMatchHistoryEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of LolMatchHistoryMatchHistoryEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolMatchHistoryMatchHistoryEvent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AssistingParticipantIds == other.AssistingParticipantIds ||
                    this.AssistingParticipantIds != null &&
                    this.AssistingParticipantIds.SequenceEqual(other.AssistingParticipantIds)
                ) && 
                (
                    this.BuildingType == other.BuildingType ||
                    this.BuildingType != null &&
                    this.BuildingType.Equals(other.BuildingType)
                ) && 
                (
                    this.ItemId == other.ItemId ||
                    this.ItemId != null &&
                    this.ItemId.Equals(other.ItemId)
                ) && 
                (
                    this.KillerId == other.KillerId ||
                    this.KillerId != null &&
                    this.KillerId.Equals(other.KillerId)
                ) && 
                (
                    this.LaneType == other.LaneType ||
                    this.LaneType != null &&
                    this.LaneType.Equals(other.LaneType)
                ) && 
                (
                    this.MonsterSubType == other.MonsterSubType ||
                    this.MonsterSubType != null &&
                    this.MonsterSubType.Equals(other.MonsterSubType)
                ) && 
                (
                    this.MonsterType == other.MonsterType ||
                    this.MonsterType != null &&
                    this.MonsterType.Equals(other.MonsterType)
                ) && 
                (
                    this.ParticipantId == other.ParticipantId ||
                    this.ParticipantId != null &&
                    this.ParticipantId.Equals(other.ParticipantId)
                ) && 
                (
                    this.Position == other.Position ||
                    this.Position != null &&
                    this.Position.Equals(other.Position)
                ) && 
                (
                    this.SkillSlot == other.SkillSlot ||
                    this.SkillSlot != null &&
                    this.SkillSlot.Equals(other.SkillSlot)
                ) && 
                (
                    this.TeamId == other.TeamId ||
                    this.TeamId != null &&
                    this.TeamId.Equals(other.TeamId)
                ) && 
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    this.TowerType == other.TowerType ||
                    this.TowerType != null &&
                    this.TowerType.Equals(other.TowerType)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.VictimId == other.VictimId ||
                    this.VictimId != null &&
                    this.VictimId.Equals(other.VictimId)
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
                if (this.AssistingParticipantIds != null)
                    hash = hash * 59 + this.AssistingParticipantIds.GetHashCode();
                if (this.BuildingType != null)
                    hash = hash * 59 + this.BuildingType.GetHashCode();
                if (this.ItemId != null)
                    hash = hash * 59 + this.ItemId.GetHashCode();
                if (this.KillerId != null)
                    hash = hash * 59 + this.KillerId.GetHashCode();
                if (this.LaneType != null)
                    hash = hash * 59 + this.LaneType.GetHashCode();
                if (this.MonsterSubType != null)
                    hash = hash * 59 + this.MonsterSubType.GetHashCode();
                if (this.MonsterType != null)
                    hash = hash * 59 + this.MonsterType.GetHashCode();
                if (this.ParticipantId != null)
                    hash = hash * 59 + this.ParticipantId.GetHashCode();
                if (this.Position != null)
                    hash = hash * 59 + this.Position.GetHashCode();
                if (this.SkillSlot != null)
                    hash = hash * 59 + this.SkillSlot.GetHashCode();
                if (this.TeamId != null)
                    hash = hash * 59 + this.TeamId.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                if (this.TowerType != null)
                    hash = hash * 59 + this.TowerType.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.VictimId != null)
                    hash = hash * 59 + this.VictimId.GetHashCode();
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
