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
    /// LolClashTournamentPhase
    /// </summary>
    [DataContract]
    public partial class LolClashTournamentPhase :  IEquatable<LolClashTournamentPhase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolClashTournamentPhase" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="LockinStartTime">LockinStartTime.</param>
        /// <param name="Period">Period.</param>
        /// <param name="ScoutingStartTime">ScoutingStartTime.</param>
        /// <param name="TournamentId">TournamentId.</param>
        public LolClashTournamentPhase(long? Id = default(long?), long? LockinStartTime = default(long?), int? Period = default(int?), long? ScoutingStartTime = default(long?), long? TournamentId = default(long?))
        {
            this.Id = Id;
            this.LockinStartTime = LockinStartTime;
            this.Period = Period;
            this.ScoutingStartTime = ScoutingStartTime;
            this.TournamentId = TournamentId;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets LockinStartTime
        /// </summary>
        [DataMember(Name="lockinStartTime", EmitDefaultValue=false)]
        public long? LockinStartTime { get; set; }

        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public int? Period { get; set; }

        /// <summary>
        /// Gets or Sets ScoutingStartTime
        /// </summary>
        [DataMember(Name="scoutingStartTime", EmitDefaultValue=false)]
        public long? ScoutingStartTime { get; set; }

        /// <summary>
        /// Gets or Sets TournamentId
        /// </summary>
        [DataMember(Name="tournamentId", EmitDefaultValue=false)]
        public long? TournamentId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolClashTournamentPhase {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LockinStartTime: ").Append(LockinStartTime).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  ScoutingStartTime: ").Append(ScoutingStartTime).Append("\n");
            sb.Append("  TournamentId: ").Append(TournamentId).Append("\n");
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
            return this.Equals(obj as LolClashTournamentPhase);
        }

        /// <summary>
        /// Returns true if LolClashTournamentPhase instances are equal
        /// </summary>
        /// <param name="other">Instance of LolClashTournamentPhase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolClashTournamentPhase other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LockinStartTime == other.LockinStartTime ||
                    this.LockinStartTime != null &&
                    this.LockinStartTime.Equals(other.LockinStartTime)
                ) && 
                (
                    this.Period == other.Period ||
                    this.Period != null &&
                    this.Period.Equals(other.Period)
                ) && 
                (
                    this.ScoutingStartTime == other.ScoutingStartTime ||
                    this.ScoutingStartTime != null &&
                    this.ScoutingStartTime.Equals(other.ScoutingStartTime)
                ) && 
                (
                    this.TournamentId == other.TournamentId ||
                    this.TournamentId != null &&
                    this.TournamentId.Equals(other.TournamentId)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.LockinStartTime != null)
                    hash = hash * 59 + this.LockinStartTime.GetHashCode();
                if (this.Period != null)
                    hash = hash * 59 + this.Period.GetHashCode();
                if (this.ScoutingStartTime != null)
                    hash = hash * 59 + this.ScoutingStartTime.GetHashCode();
                if (this.TournamentId != null)
                    hash = hash * 59 + this.TournamentId.GetHashCode();
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
