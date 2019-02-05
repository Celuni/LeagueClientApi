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
    /// LolLobbyLobbyMatchmakingLowPriorityDataResource
    /// </summary>
    [DataContract]
    public partial class LolLobbyLobbyMatchmakingLowPriorityDataResource :  IEquatable<LolLobbyLobbyMatchmakingLowPriorityDataResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolLobbyLobbyMatchmakingLowPriorityDataResource" /> class.
        /// </summary>
        /// <param name="BustedLeaverAccessToken">BustedLeaverAccessToken.</param>
        /// <param name="PenalizedSummonerIds">PenalizedSummonerIds.</param>
        /// <param name="PenaltyTime">PenaltyTime.</param>
        /// <param name="PenaltyTimeRemaining">PenaltyTimeRemaining.</param>
        public LolLobbyLobbyMatchmakingLowPriorityDataResource(string BustedLeaverAccessToken = default(string), List<long?> PenalizedSummonerIds = default(List<long?>), double? PenaltyTime = default(double?), double? PenaltyTimeRemaining = default(double?))
        {
            this.BustedLeaverAccessToken = BustedLeaverAccessToken;
            this.PenalizedSummonerIds = PenalizedSummonerIds;
            this.PenaltyTime = PenaltyTime;
            this.PenaltyTimeRemaining = PenaltyTimeRemaining;
        }
        
        /// <summary>
        /// Gets or Sets BustedLeaverAccessToken
        /// </summary>
        [DataMember(Name="bustedLeaverAccessToken", EmitDefaultValue=false)]
        public string BustedLeaverAccessToken { get; set; }

        /// <summary>
        /// Gets or Sets PenalizedSummonerIds
        /// </summary>
        [DataMember(Name="penalizedSummonerIds", EmitDefaultValue=false)]
        public List<long?> PenalizedSummonerIds { get; set; }

        /// <summary>
        /// Gets or Sets PenaltyTime
        /// </summary>
        [DataMember(Name="penaltyTime", EmitDefaultValue=false)]
        public double? PenaltyTime { get; set; }

        /// <summary>
        /// Gets or Sets PenaltyTimeRemaining
        /// </summary>
        [DataMember(Name="penaltyTimeRemaining", EmitDefaultValue=false)]
        public double? PenaltyTimeRemaining { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolLobbyLobbyMatchmakingLowPriorityDataResource {\n");
            sb.Append("  BustedLeaverAccessToken: ").Append(BustedLeaverAccessToken).Append("\n");
            sb.Append("  PenalizedSummonerIds: ").Append(PenalizedSummonerIds).Append("\n");
            sb.Append("  PenaltyTime: ").Append(PenaltyTime).Append("\n");
            sb.Append("  PenaltyTimeRemaining: ").Append(PenaltyTimeRemaining).Append("\n");
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
            return this.Equals(obj as LolLobbyLobbyMatchmakingLowPriorityDataResource);
        }

        /// <summary>
        /// Returns true if LolLobbyLobbyMatchmakingLowPriorityDataResource instances are equal
        /// </summary>
        /// <param name="other">Instance of LolLobbyLobbyMatchmakingLowPriorityDataResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolLobbyLobbyMatchmakingLowPriorityDataResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BustedLeaverAccessToken == other.BustedLeaverAccessToken ||
                    this.BustedLeaverAccessToken != null &&
                    this.BustedLeaverAccessToken.Equals(other.BustedLeaverAccessToken)
                ) && 
                (
                    this.PenalizedSummonerIds == other.PenalizedSummonerIds ||
                    this.PenalizedSummonerIds != null &&
                    this.PenalizedSummonerIds.SequenceEqual(other.PenalizedSummonerIds)
                ) && 
                (
                    this.PenaltyTime == other.PenaltyTime ||
                    this.PenaltyTime != null &&
                    this.PenaltyTime.Equals(other.PenaltyTime)
                ) && 
                (
                    this.PenaltyTimeRemaining == other.PenaltyTimeRemaining ||
                    this.PenaltyTimeRemaining != null &&
                    this.PenaltyTimeRemaining.Equals(other.PenaltyTimeRemaining)
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
                if (this.BustedLeaverAccessToken != null)
                    hash = hash * 59 + this.BustedLeaverAccessToken.GetHashCode();
                if (this.PenalizedSummonerIds != null)
                    hash = hash * 59 + this.PenalizedSummonerIds.GetHashCode();
                if (this.PenaltyTime != null)
                    hash = hash * 59 + this.PenaltyTime.GetHashCode();
                if (this.PenaltyTimeRemaining != null)
                    hash = hash * 59 + this.PenaltyTimeRemaining.GetHashCode();
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