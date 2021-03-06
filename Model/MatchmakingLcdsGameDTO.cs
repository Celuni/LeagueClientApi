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
    /// MatchmakingLcdsGameDTO
    /// </summary>
    [DataContract]
    public partial class MatchmakingLcdsGameDTO :  IEquatable<MatchmakingLcdsGameDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchmakingLcdsGameDTO" /> class.
        /// </summary>
        /// <param name="GameState">GameState.</param>
        /// <param name="StatusOfParticipants">StatusOfParticipants.</param>
        /// <param name="TeamOne">TeamOne.</param>
        /// <param name="TeamTwo">TeamTwo.</param>
        /// <param name="TerminatedCondition">TerminatedCondition.</param>
        public MatchmakingLcdsGameDTO(string GameState = default(string), string StatusOfParticipants = default(string), List<MatchmakingLcdsPlayerParticipant> TeamOne = default(List<MatchmakingLcdsPlayerParticipant>), List<MatchmakingLcdsPlayerParticipant> TeamTwo = default(List<MatchmakingLcdsPlayerParticipant>), string TerminatedCondition = default(string))
        {
            this.GameState = GameState;
            this.StatusOfParticipants = StatusOfParticipants;
            this.TeamOne = TeamOne;
            this.TeamTwo = TeamTwo;
            this.TerminatedCondition = TerminatedCondition;
        }
        
        /// <summary>
        /// Gets or Sets GameState
        /// </summary>
        [DataMember(Name="gameState", EmitDefaultValue=false)]
        public string GameState { get; set; }

        /// <summary>
        /// Gets or Sets StatusOfParticipants
        /// </summary>
        [DataMember(Name="statusOfParticipants", EmitDefaultValue=false)]
        public string StatusOfParticipants { get; set; }

        /// <summary>
        /// Gets or Sets TeamOne
        /// </summary>
        [DataMember(Name="teamOne", EmitDefaultValue=false)]
        public List<MatchmakingLcdsPlayerParticipant> TeamOne { get; set; }

        /// <summary>
        /// Gets or Sets TeamTwo
        /// </summary>
        [DataMember(Name="teamTwo", EmitDefaultValue=false)]
        public List<MatchmakingLcdsPlayerParticipant> TeamTwo { get; set; }

        /// <summary>
        /// Gets or Sets TerminatedCondition
        /// </summary>
        [DataMember(Name="terminatedCondition", EmitDefaultValue=false)]
        public string TerminatedCondition { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MatchmakingLcdsGameDTO {\n");
            sb.Append("  GameState: ").Append(GameState).Append("\n");
            sb.Append("  StatusOfParticipants: ").Append(StatusOfParticipants).Append("\n");
            sb.Append("  TeamOne: ").Append(TeamOne).Append("\n");
            sb.Append("  TeamTwo: ").Append(TeamTwo).Append("\n");
            sb.Append("  TerminatedCondition: ").Append(TerminatedCondition).Append("\n");
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
            return this.Equals(obj as MatchmakingLcdsGameDTO);
        }

        /// <summary>
        /// Returns true if MatchmakingLcdsGameDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of MatchmakingLcdsGameDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MatchmakingLcdsGameDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.GameState == other.GameState ||
                    this.GameState != null &&
                    this.GameState.Equals(other.GameState)
                ) && 
                (
                    this.StatusOfParticipants == other.StatusOfParticipants ||
                    this.StatusOfParticipants != null &&
                    this.StatusOfParticipants.Equals(other.StatusOfParticipants)
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
                ) && 
                (
                    this.TerminatedCondition == other.TerminatedCondition ||
                    this.TerminatedCondition != null &&
                    this.TerminatedCondition.Equals(other.TerminatedCondition)
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
                if (this.GameState != null)
                    hash = hash * 59 + this.GameState.GetHashCode();
                if (this.StatusOfParticipants != null)
                    hash = hash * 59 + this.StatusOfParticipants.GetHashCode();
                if (this.TeamOne != null)
                    hash = hash * 59 + this.TeamOne.GetHashCode();
                if (this.TeamTwo != null)
                    hash = hash * 59 + this.TeamTwo.GetHashCode();
                if (this.TerminatedCondition != null)
                    hash = hash * 59 + this.TerminatedCondition.GetHashCode();
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
