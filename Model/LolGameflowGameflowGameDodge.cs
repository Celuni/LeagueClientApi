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
    /// LolGameflowGameflowGameDodge
    /// </summary>
    [DataContract]
    public partial class LolGameflowGameflowGameDodge :  IEquatable<LolGameflowGameflowGameDodge>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolGameflowGameflowGameDodge" /> class.
        /// </summary>
        /// <param name="DodgeIds">DodgeIds.</param>
        /// <param name="Phase">Phase.</param>
        /// <param name="State">State.</param>
        public LolGameflowGameflowGameDodge(List<long?> DodgeIds = default(List<long?>), LolGameflowGameflowPhase Phase = default(LolGameflowGameflowPhase), LolGameflowGameflowGameDodgeState State = default(LolGameflowGameflowGameDodgeState))
        {
            this.DodgeIds = DodgeIds;
            this.Phase = Phase;
            this.State = State;
        }
        
        /// <summary>
        /// Gets or Sets DodgeIds
        /// </summary>
        [DataMember(Name="dodgeIds", EmitDefaultValue=false)]
        public List<long?> DodgeIds { get; set; }

        /// <summary>
        /// Gets or Sets Phase
        /// </summary>
        [DataMember(Name="phase", EmitDefaultValue=false)]
        public LolGameflowGameflowPhase Phase { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public LolGameflowGameflowGameDodgeState State { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolGameflowGameflowGameDodge {\n");
            sb.Append("  DodgeIds: ").Append(DodgeIds).Append("\n");
            sb.Append("  Phase: ").Append(Phase).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(obj as LolGameflowGameflowGameDodge);
        }

        /// <summary>
        /// Returns true if LolGameflowGameflowGameDodge instances are equal
        /// </summary>
        /// <param name="other">Instance of LolGameflowGameflowGameDodge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolGameflowGameflowGameDodge other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DodgeIds == other.DodgeIds ||
                    this.DodgeIds != null &&
                    this.DodgeIds.SequenceEqual(other.DodgeIds)
                ) && 
                (
                    this.Phase == other.Phase ||
                    this.Phase != null &&
                    this.Phase.Equals(other.Phase)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
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
                if (this.DodgeIds != null)
                    hash = hash * 59 + this.DodgeIds.GetHashCode();
                if (this.Phase != null)
                    hash = hash * 59 + this.Phase.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
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
