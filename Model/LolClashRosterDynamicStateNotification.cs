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
    /// LolClashRosterDynamicStateNotification
    /// </summary>
    [DataContract]
    public partial class LolClashRosterDynamicStateNotification :  IEquatable<LolClashRosterDynamicStateNotification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolClashRosterDynamicStateNotification" /> class.
        /// </summary>
        /// <param name="NotifyReason">NotifyReason.</param>
        /// <param name="RosterDynamicState">RosterDynamicState.</param>
        /// <param name="SourcePlayerId">SourcePlayerId.</param>
        public LolClashRosterDynamicStateNotification(LolClashRosterNotifyReason NotifyReason = default(LolClashRosterNotifyReason), RosterDynamicStateDTO RosterDynamicState = default(RosterDynamicStateDTO), long? SourcePlayerId = default(long?))
        {
            this.NotifyReason = NotifyReason;
            this.RosterDynamicState = RosterDynamicState;
            this.SourcePlayerId = SourcePlayerId;
        }
        
        /// <summary>
        /// Gets or Sets NotifyReason
        /// </summary>
        [DataMember(Name="notifyReason", EmitDefaultValue=false)]
        public LolClashRosterNotifyReason NotifyReason { get; set; }

        /// <summary>
        /// Gets or Sets RosterDynamicState
        /// </summary>
        [DataMember(Name="rosterDynamicState", EmitDefaultValue=false)]
        public RosterDynamicStateDTO RosterDynamicState { get; set; }

        /// <summary>
        /// Gets or Sets SourcePlayerId
        /// </summary>
        [DataMember(Name="sourcePlayerId", EmitDefaultValue=false)]
        public long? SourcePlayerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolClashRosterDynamicStateNotification {\n");
            sb.Append("  NotifyReason: ").Append(NotifyReason).Append("\n");
            sb.Append("  RosterDynamicState: ").Append(RosterDynamicState).Append("\n");
            sb.Append("  SourcePlayerId: ").Append(SourcePlayerId).Append("\n");
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
            return this.Equals(obj as LolClashRosterDynamicStateNotification);
        }

        /// <summary>
        /// Returns true if LolClashRosterDynamicStateNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of LolClashRosterDynamicStateNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolClashRosterDynamicStateNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NotifyReason == other.NotifyReason ||
                    this.NotifyReason != null &&
                    this.NotifyReason.Equals(other.NotifyReason)
                ) && 
                (
                    this.RosterDynamicState == other.RosterDynamicState ||
                    this.RosterDynamicState != null &&
                    this.RosterDynamicState.Equals(other.RosterDynamicState)
                ) && 
                (
                    this.SourcePlayerId == other.SourcePlayerId ||
                    this.SourcePlayerId != null &&
                    this.SourcePlayerId.Equals(other.SourcePlayerId)
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
                if (this.NotifyReason != null)
                    hash = hash * 59 + this.NotifyReason.GetHashCode();
                if (this.RosterDynamicState != null)
                    hash = hash * 59 + this.RosterDynamicState.GetHashCode();
                if (this.SourcePlayerId != null)
                    hash = hash * 59 + this.SourcePlayerId.GetHashCode();
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
