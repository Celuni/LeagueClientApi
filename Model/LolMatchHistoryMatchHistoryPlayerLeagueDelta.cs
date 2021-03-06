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
    /// LolMatchHistoryMatchHistoryPlayerLeagueDelta
    /// </summary>
    [DataContract]
    public partial class LolMatchHistoryMatchHistoryPlayerLeagueDelta :  IEquatable<LolMatchHistoryMatchHistoryPlayerLeagueDelta>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolMatchHistoryMatchHistoryPlayerLeagueDelta" /> class.
        /// </summary>
        /// <param name="LeaguePointDelta">LeaguePointDelta.</param>
        /// <param name="MiniSeriesProgress">MiniSeriesProgress.</param>
        /// <param name="Reason">Reason.</param>
        /// <param name="Timestamp">Timestamp.</param>
        public LolMatchHistoryMatchHistoryPlayerLeagueDelta(long? LeaguePointDelta = default(long?), List<string> MiniSeriesProgress = default(List<string>), string Reason = default(string), long? Timestamp = default(long?))
        {
            this.LeaguePointDelta = LeaguePointDelta;
            this.MiniSeriesProgress = MiniSeriesProgress;
            this.Reason = Reason;
            this.Timestamp = Timestamp;
        }
        
        /// <summary>
        /// Gets or Sets LeaguePointDelta
        /// </summary>
        [DataMember(Name="leaguePointDelta", EmitDefaultValue=false)]
        public long? LeaguePointDelta { get; set; }

        /// <summary>
        /// Gets or Sets MiniSeriesProgress
        /// </summary>
        [DataMember(Name="miniSeriesProgress", EmitDefaultValue=false)]
        public List<string> MiniSeriesProgress { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public long? Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolMatchHistoryMatchHistoryPlayerLeagueDelta {\n");
            sb.Append("  LeaguePointDelta: ").Append(LeaguePointDelta).Append("\n");
            sb.Append("  MiniSeriesProgress: ").Append(MiniSeriesProgress).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(obj as LolMatchHistoryMatchHistoryPlayerLeagueDelta);
        }

        /// <summary>
        /// Returns true if LolMatchHistoryMatchHistoryPlayerLeagueDelta instances are equal
        /// </summary>
        /// <param name="other">Instance of LolMatchHistoryMatchHistoryPlayerLeagueDelta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolMatchHistoryMatchHistoryPlayerLeagueDelta other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LeaguePointDelta == other.LeaguePointDelta ||
                    this.LeaguePointDelta != null &&
                    this.LeaguePointDelta.Equals(other.LeaguePointDelta)
                ) && 
                (
                    this.MiniSeriesProgress == other.MiniSeriesProgress ||
                    this.MiniSeriesProgress != null &&
                    this.MiniSeriesProgress.SequenceEqual(other.MiniSeriesProgress)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) && 
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
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
                if (this.LeaguePointDelta != null)
                    hash = hash * 59 + this.LeaguePointDelta.GetHashCode();
                if (this.MiniSeriesProgress != null)
                    hash = hash * 59 + this.MiniSeriesProgress.GetHashCode();
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
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
