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
    /// LeaguesLcdsAggregatedStatsKey
    /// </summary>
    [DataContract]
    public partial class LeaguesLcdsAggregatedStatsKey :  IEquatable<LeaguesLcdsAggregatedStatsKey>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LeaguesLcdsAggregatedStatsKey" /> class.
        /// </summary>
        /// <param name="GameMode">GameMode.</param>
        /// <param name="UserId">UserId.</param>
        public LeaguesLcdsAggregatedStatsKey(string GameMode = default(string), long? UserId = default(long?))
        {
            this.GameMode = GameMode;
            this.UserId = UserId;
        }
        
        /// <summary>
        /// Gets or Sets GameMode
        /// </summary>
        [DataMember(Name="gameMode", EmitDefaultValue=false)]
        public string GameMode { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public long? UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LeaguesLcdsAggregatedStatsKey {\n");
            sb.Append("  GameMode: ").Append(GameMode).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(obj as LeaguesLcdsAggregatedStatsKey);
        }

        /// <summary>
        /// Returns true if LeaguesLcdsAggregatedStatsKey instances are equal
        /// </summary>
        /// <param name="other">Instance of LeaguesLcdsAggregatedStatsKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LeaguesLcdsAggregatedStatsKey other)
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
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
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
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
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
