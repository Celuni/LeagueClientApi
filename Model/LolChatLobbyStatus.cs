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
    /// LolChatLobbyStatus
    /// </summary>
    [DataContract]
    public partial class LolChatLobbyStatus :  IEquatable<LolChatLobbyStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolChatLobbyStatus" /> class.
        /// </summary>
        /// <param name="CustomSpectatorPolicy">CustomSpectatorPolicy.</param>
        /// <param name="IsCustom">IsCustom.</param>
        /// <param name="IsLeader">IsLeader.</param>
        /// <param name="IsPracticeTool">IsPracticeTool.</param>
        /// <param name="QueueId">QueueId.</param>
        public LolChatLobbyStatus(LolChatQueueCustomGameSpectatorPolicy CustomSpectatorPolicy = default(LolChatQueueCustomGameSpectatorPolicy), bool? IsCustom = default(bool?), bool? IsLeader = default(bool?), bool? IsPracticeTool = default(bool?), int? QueueId = default(int?))
        {
            this.CustomSpectatorPolicy = CustomSpectatorPolicy;
            this.IsCustom = IsCustom;
            this.IsLeader = IsLeader;
            this.IsPracticeTool = IsPracticeTool;
            this.QueueId = QueueId;
        }
        
        /// <summary>
        /// Gets or Sets CustomSpectatorPolicy
        /// </summary>
        [DataMember(Name="customSpectatorPolicy", EmitDefaultValue=false)]
        public LolChatQueueCustomGameSpectatorPolicy CustomSpectatorPolicy { get; set; }

        /// <summary>
        /// Gets or Sets IsCustom
        /// </summary>
        [DataMember(Name="isCustom", EmitDefaultValue=false)]
        public bool? IsCustom { get; set; }

        /// <summary>
        /// Gets or Sets IsLeader
        /// </summary>
        [DataMember(Name="isLeader", EmitDefaultValue=false)]
        public bool? IsLeader { get; set; }

        /// <summary>
        /// Gets or Sets IsPracticeTool
        /// </summary>
        [DataMember(Name="isPracticeTool", EmitDefaultValue=false)]
        public bool? IsPracticeTool { get; set; }

        /// <summary>
        /// Gets or Sets QueueId
        /// </summary>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public int? QueueId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolChatLobbyStatus {\n");
            sb.Append("  CustomSpectatorPolicy: ").Append(CustomSpectatorPolicy).Append("\n");
            sb.Append("  IsCustom: ").Append(IsCustom).Append("\n");
            sb.Append("  IsLeader: ").Append(IsLeader).Append("\n");
            sb.Append("  IsPracticeTool: ").Append(IsPracticeTool).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
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
            return this.Equals(obj as LolChatLobbyStatus);
        }

        /// <summary>
        /// Returns true if LolChatLobbyStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of LolChatLobbyStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolChatLobbyStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CustomSpectatorPolicy == other.CustomSpectatorPolicy ||
                    this.CustomSpectatorPolicy != null &&
                    this.CustomSpectatorPolicy.Equals(other.CustomSpectatorPolicy)
                ) && 
                (
                    this.IsCustom == other.IsCustom ||
                    this.IsCustom != null &&
                    this.IsCustom.Equals(other.IsCustom)
                ) && 
                (
                    this.IsLeader == other.IsLeader ||
                    this.IsLeader != null &&
                    this.IsLeader.Equals(other.IsLeader)
                ) && 
                (
                    this.IsPracticeTool == other.IsPracticeTool ||
                    this.IsPracticeTool != null &&
                    this.IsPracticeTool.Equals(other.IsPracticeTool)
                ) && 
                (
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
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
                if (this.CustomSpectatorPolicy != null)
                    hash = hash * 59 + this.CustomSpectatorPolicy.GetHashCode();
                if (this.IsCustom != null)
                    hash = hash * 59 + this.IsCustom.GetHashCode();
                if (this.IsLeader != null)
                    hash = hash * 59 + this.IsLeader.GetHashCode();
                if (this.IsPracticeTool != null)
                    hash = hash * 59 + this.IsPracticeTool.GetHashCode();
                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();
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
