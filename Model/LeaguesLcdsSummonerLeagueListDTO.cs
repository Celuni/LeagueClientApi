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
    /// LeaguesLcdsSummonerLeagueListDTO
    /// </summary>
    [DataContract]
    public partial class LeaguesLcdsSummonerLeagueListDTO :  IEquatable<LeaguesLcdsSummonerLeagueListDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LeaguesLcdsSummonerLeagueListDTO" /> class.
        /// </summary>
        /// <param name="Entries">Entries.</param>
        /// <param name="Name">Name.</param>
        /// <param name="NextApexUpdate">NextApexUpdate.</param>
        /// <param name="Queue">Queue.</param>
        /// <param name="RequestorsName">RequestorsName.</param>
        /// <param name="RequestorsRank">RequestorsRank.</param>
        /// <param name="Tier">Tier.</param>
        public LeaguesLcdsSummonerLeagueListDTO(List<LeaguesLcdsLeagueItemDTO> Entries = default(List<LeaguesLcdsLeagueItemDTO>), string Name = default(string), long? NextApexUpdate = default(long?), LeaguesLcdsQueueType Queue = default(LeaguesLcdsQueueType), string RequestorsName = default(string), LeaguesLcdsLeagueRank RequestorsRank = default(LeaguesLcdsLeagueRank), LeaguesLcdsLeagueTier Tier = default(LeaguesLcdsLeagueTier))
        {
            this.Entries = Entries;
            this.Name = Name;
            this.NextApexUpdate = NextApexUpdate;
            this.Queue = Queue;
            this.RequestorsName = RequestorsName;
            this.RequestorsRank = RequestorsRank;
            this.Tier = Tier;
        }
        
        /// <summary>
        /// Gets or Sets Entries
        /// </summary>
        [DataMember(Name="entries", EmitDefaultValue=false)]
        public List<LeaguesLcdsLeagueItemDTO> Entries { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets NextApexUpdate
        /// </summary>
        [DataMember(Name="nextApexUpdate", EmitDefaultValue=false)]
        public long? NextApexUpdate { get; set; }

        /// <summary>
        /// Gets or Sets Queue
        /// </summary>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public LeaguesLcdsQueueType Queue { get; set; }

        /// <summary>
        /// Gets or Sets RequestorsName
        /// </summary>
        [DataMember(Name="requestorsName", EmitDefaultValue=false)]
        public string RequestorsName { get; set; }

        /// <summary>
        /// Gets or Sets RequestorsRank
        /// </summary>
        [DataMember(Name="requestorsRank", EmitDefaultValue=false)]
        public LeaguesLcdsLeagueRank RequestorsRank { get; set; }

        /// <summary>
        /// Gets or Sets Tier
        /// </summary>
        [DataMember(Name="tier", EmitDefaultValue=false)]
        public LeaguesLcdsLeagueTier Tier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LeaguesLcdsSummonerLeagueListDTO {\n");
            sb.Append("  Entries: ").Append(Entries).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NextApexUpdate: ").Append(NextApexUpdate).Append("\n");
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  RequestorsName: ").Append(RequestorsName).Append("\n");
            sb.Append("  RequestorsRank: ").Append(RequestorsRank).Append("\n");
            sb.Append("  Tier: ").Append(Tier).Append("\n");
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
            return this.Equals(obj as LeaguesLcdsSummonerLeagueListDTO);
        }

        /// <summary>
        /// Returns true if LeaguesLcdsSummonerLeagueListDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of LeaguesLcdsSummonerLeagueListDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LeaguesLcdsSummonerLeagueListDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Entries == other.Entries ||
                    this.Entries != null &&
                    this.Entries.SequenceEqual(other.Entries)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.NextApexUpdate == other.NextApexUpdate ||
                    this.NextApexUpdate != null &&
                    this.NextApexUpdate.Equals(other.NextApexUpdate)
                ) && 
                (
                    this.Queue == other.Queue ||
                    this.Queue != null &&
                    this.Queue.Equals(other.Queue)
                ) && 
                (
                    this.RequestorsName == other.RequestorsName ||
                    this.RequestorsName != null &&
                    this.RequestorsName.Equals(other.RequestorsName)
                ) && 
                (
                    this.RequestorsRank == other.RequestorsRank ||
                    this.RequestorsRank != null &&
                    this.RequestorsRank.Equals(other.RequestorsRank)
                ) && 
                (
                    this.Tier == other.Tier ||
                    this.Tier != null &&
                    this.Tier.Equals(other.Tier)
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
                if (this.Entries != null)
                    hash = hash * 59 + this.Entries.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.NextApexUpdate != null)
                    hash = hash * 59 + this.NextApexUpdate.GetHashCode();
                if (this.Queue != null)
                    hash = hash * 59 + this.Queue.GetHashCode();
                if (this.RequestorsName != null)
                    hash = hash * 59 + this.RequestorsName.GetHashCode();
                if (this.RequestorsRank != null)
                    hash = hash * 59 + this.RequestorsRank.GetHashCode();
                if (this.Tier != null)
                    hash = hash * 59 + this.Tier.GetHashCode();
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