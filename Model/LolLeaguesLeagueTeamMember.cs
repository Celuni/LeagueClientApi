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
    /// LolLeaguesLeagueTeamMember
    /// </summary>
    [DataContract]
    public partial class LolLeaguesLeagueTeamMember :  IEquatable<LolLeaguesLeagueTeamMember>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolLeaguesLeagueTeamMember" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="TotalGamePlayed">TotalGamePlayed.</param>
        /// <param name="WinRate">WinRate.</param>
        public LolLeaguesLeagueTeamMember(long? Id = default(long?), string Name = default(string), long? TotalGamePlayed = default(long?), float? WinRate = default(float?))
        {
            this.Id = Id;
            this.Name = Name;
            this.TotalGamePlayed = TotalGamePlayed;
            this.WinRate = WinRate;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets TotalGamePlayed
        /// </summary>
        [DataMember(Name="totalGamePlayed", EmitDefaultValue=false)]
        public long? TotalGamePlayed { get; set; }

        /// <summary>
        /// Gets or Sets WinRate
        /// </summary>
        [DataMember(Name="winRate", EmitDefaultValue=false)]
        public float? WinRate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolLeaguesLeagueTeamMember {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TotalGamePlayed: ").Append(TotalGamePlayed).Append("\n");
            sb.Append("  WinRate: ").Append(WinRate).Append("\n");
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
            return this.Equals(obj as LolLeaguesLeagueTeamMember);
        }

        /// <summary>
        /// Returns true if LolLeaguesLeagueTeamMember instances are equal
        /// </summary>
        /// <param name="other">Instance of LolLeaguesLeagueTeamMember to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolLeaguesLeagueTeamMember other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.TotalGamePlayed == other.TotalGamePlayed ||
                    this.TotalGamePlayed != null &&
                    this.TotalGamePlayed.Equals(other.TotalGamePlayed)
                ) && 
                (
                    this.WinRate == other.WinRate ||
                    this.WinRate != null &&
                    this.WinRate.Equals(other.WinRate)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.TotalGamePlayed != null)
                    hash = hash * 59 + this.TotalGamePlayed.GetHashCode();
                if (this.WinRate != null)
                    hash = hash * 59 + this.WinRate.GetHashCode();
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
