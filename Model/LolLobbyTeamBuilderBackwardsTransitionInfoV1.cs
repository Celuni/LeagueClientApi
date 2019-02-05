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
    /// LolLobbyTeamBuilderBackwardsTransitionInfoV1
    /// </summary>
    [DataContract]
    public partial class LolLobbyTeamBuilderBackwardsTransitionInfoV1 :  IEquatable<LolLobbyTeamBuilderBackwardsTransitionInfoV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolLobbyTeamBuilderBackwardsTransitionInfoV1" /> class.
        /// </summary>
        /// <param name="BackwardsTransitionReason">BackwardsTransitionReason.</param>
        /// <param name="InitiatorSummonerIds">InitiatorSummonerIds.</param>
        public LolLobbyTeamBuilderBackwardsTransitionInfoV1(string BackwardsTransitionReason = default(string), List<long?> InitiatorSummonerIds = default(List<long?>))
        {
            this.BackwardsTransitionReason = BackwardsTransitionReason;
            this.InitiatorSummonerIds = InitiatorSummonerIds;
        }
        
        /// <summary>
        /// Gets or Sets BackwardsTransitionReason
        /// </summary>
        [DataMember(Name="backwardsTransitionReason", EmitDefaultValue=false)]
        public string BackwardsTransitionReason { get; set; }

        /// <summary>
        /// Gets or Sets InitiatorSummonerIds
        /// </summary>
        [DataMember(Name="initiatorSummonerIds", EmitDefaultValue=false)]
        public List<long?> InitiatorSummonerIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolLobbyTeamBuilderBackwardsTransitionInfoV1 {\n");
            sb.Append("  BackwardsTransitionReason: ").Append(BackwardsTransitionReason).Append("\n");
            sb.Append("  InitiatorSummonerIds: ").Append(InitiatorSummonerIds).Append("\n");
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
            return this.Equals(obj as LolLobbyTeamBuilderBackwardsTransitionInfoV1);
        }

        /// <summary>
        /// Returns true if LolLobbyTeamBuilderBackwardsTransitionInfoV1 instances are equal
        /// </summary>
        /// <param name="other">Instance of LolLobbyTeamBuilderBackwardsTransitionInfoV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolLobbyTeamBuilderBackwardsTransitionInfoV1 other)
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
                    this.InitiatorSummonerIds == other.InitiatorSummonerIds ||
                    this.InitiatorSummonerIds != null &&
                    this.InitiatorSummonerIds.SequenceEqual(other.InitiatorSummonerIds)
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
                if (this.InitiatorSummonerIds != null)
                    hash = hash * 59 + this.InitiatorSummonerIds.GetHashCode();
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