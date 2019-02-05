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
    /// LolLobbyTeamBuilderTBDMatchmakingState
    /// </summary>
    [DataContract]
    public partial class LolLobbyTeamBuilderTBDMatchmakingState :  IEquatable<LolLobbyTeamBuilderTBDMatchmakingState>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolLobbyTeamBuilderTBDMatchmakingState" /> class.
        /// </summary>
        /// <param name="BackwardsTransitionReason">BackwardsTransitionReason.</param>
        /// <param name="EstimatedMatchmakingTimeMillis">EstimatedMatchmakingTimeMillis.</param>
        /// <param name="TimeInMatchmakingMillis">TimeInMatchmakingMillis.</param>
        public LolLobbyTeamBuilderTBDMatchmakingState(string BackwardsTransitionReason = default(string), long? EstimatedMatchmakingTimeMillis = default(long?), long? TimeInMatchmakingMillis = default(long?))
        {
            this.BackwardsTransitionReason = BackwardsTransitionReason;
            this.EstimatedMatchmakingTimeMillis = EstimatedMatchmakingTimeMillis;
            this.TimeInMatchmakingMillis = TimeInMatchmakingMillis;
        }
        
        /// <summary>
        /// Gets or Sets BackwardsTransitionReason
        /// </summary>
        [DataMember(Name="backwardsTransitionReason", EmitDefaultValue=false)]
        public string BackwardsTransitionReason { get; set; }

        /// <summary>
        /// Gets or Sets EstimatedMatchmakingTimeMillis
        /// </summary>
        [DataMember(Name="estimatedMatchmakingTimeMillis", EmitDefaultValue=false)]
        public long? EstimatedMatchmakingTimeMillis { get; set; }

        /// <summary>
        /// Gets or Sets TimeInMatchmakingMillis
        /// </summary>
        [DataMember(Name="timeInMatchmakingMillis", EmitDefaultValue=false)]
        public long? TimeInMatchmakingMillis { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolLobbyTeamBuilderTBDMatchmakingState {\n");
            sb.Append("  BackwardsTransitionReason: ").Append(BackwardsTransitionReason).Append("\n");
            sb.Append("  EstimatedMatchmakingTimeMillis: ").Append(EstimatedMatchmakingTimeMillis).Append("\n");
            sb.Append("  TimeInMatchmakingMillis: ").Append(TimeInMatchmakingMillis).Append("\n");
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
            return this.Equals(obj as LolLobbyTeamBuilderTBDMatchmakingState);
        }

        /// <summary>
        /// Returns true if LolLobbyTeamBuilderTBDMatchmakingState instances are equal
        /// </summary>
        /// <param name="other">Instance of LolLobbyTeamBuilderTBDMatchmakingState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolLobbyTeamBuilderTBDMatchmakingState other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BackwardsTransitionReason == other.BackwardsTransitionReason ||
                    this.BackwardsTransitionReason != null &&
                    this.BackwardsTransitionReason.Equals(other.BackwardsTransitionReason)
                ) && 
                (
                    this.EstimatedMatchmakingTimeMillis == other.EstimatedMatchmakingTimeMillis ||
                    this.EstimatedMatchmakingTimeMillis != null &&
                    this.EstimatedMatchmakingTimeMillis.Equals(other.EstimatedMatchmakingTimeMillis)
                ) && 
                (
                    this.TimeInMatchmakingMillis == other.TimeInMatchmakingMillis ||
                    this.TimeInMatchmakingMillis != null &&
                    this.TimeInMatchmakingMillis.Equals(other.TimeInMatchmakingMillis)
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
                if (this.BackwardsTransitionReason != null)
                    hash = hash * 59 + this.BackwardsTransitionReason.GetHashCode();
                if (this.EstimatedMatchmakingTimeMillis != null)
                    hash = hash * 59 + this.EstimatedMatchmakingTimeMillis.GetHashCode();
                if (this.TimeInMatchmakingMillis != null)
                    hash = hash * 59 + this.TimeInMatchmakingMillis.GetHashCode();
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