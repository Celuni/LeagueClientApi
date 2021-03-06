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
    /// LolQueueEligibilityCollectionsChampion
    /// </summary>
    [DataContract]
    public partial class LolQueueEligibilityCollectionsChampion :  IEquatable<LolQueueEligibilityCollectionsChampion>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolQueueEligibilityCollectionsChampion" /> class.
        /// </summary>
        /// <param name="DisabledQueues">DisabledQueues.</param>
        /// <param name="FreeToPlay">FreeToPlay.</param>
        /// <param name="Ownership">Ownership.</param>
        /// <param name="Purchased">Purchased.</param>
        /// <param name="RankedPlayEnabled">RankedPlayEnabled.</param>
        public LolQueueEligibilityCollectionsChampion(List<string> DisabledQueues = default(List<string>), bool? FreeToPlay = default(bool?), LolQueueEligibilityCollectionsOwnership Ownership = default(LolQueueEligibilityCollectionsOwnership), long? Purchased = default(long?), bool? RankedPlayEnabled = default(bool?))
        {
            this.DisabledQueues = DisabledQueues;
            this.FreeToPlay = FreeToPlay;
            this.Ownership = Ownership;
            this.Purchased = Purchased;
            this.RankedPlayEnabled = RankedPlayEnabled;
        }
        
        /// <summary>
        /// Gets or Sets DisabledQueues
        /// </summary>
        [DataMember(Name="disabledQueues", EmitDefaultValue=false)]
        public List<string> DisabledQueues { get; set; }

        /// <summary>
        /// Gets or Sets FreeToPlay
        /// </summary>
        [DataMember(Name="freeToPlay", EmitDefaultValue=false)]
        public bool? FreeToPlay { get; set; }

        /// <summary>
        /// Gets or Sets Ownership
        /// </summary>
        [DataMember(Name="ownership", EmitDefaultValue=false)]
        public LolQueueEligibilityCollectionsOwnership Ownership { get; set; }

        /// <summary>
        /// Gets or Sets Purchased
        /// </summary>
        [DataMember(Name="purchased", EmitDefaultValue=false)]
        public long? Purchased { get; set; }

        /// <summary>
        /// Gets or Sets RankedPlayEnabled
        /// </summary>
        [DataMember(Name="rankedPlayEnabled", EmitDefaultValue=false)]
        public bool? RankedPlayEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolQueueEligibilityCollectionsChampion {\n");
            sb.Append("  DisabledQueues: ").Append(DisabledQueues).Append("\n");
            sb.Append("  FreeToPlay: ").Append(FreeToPlay).Append("\n");
            sb.Append("  Ownership: ").Append(Ownership).Append("\n");
            sb.Append("  Purchased: ").Append(Purchased).Append("\n");
            sb.Append("  RankedPlayEnabled: ").Append(RankedPlayEnabled).Append("\n");
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
            return this.Equals(obj as LolQueueEligibilityCollectionsChampion);
        }

        /// <summary>
        /// Returns true if LolQueueEligibilityCollectionsChampion instances are equal
        /// </summary>
        /// <param name="other">Instance of LolQueueEligibilityCollectionsChampion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolQueueEligibilityCollectionsChampion other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DisabledQueues == other.DisabledQueues ||
                    this.DisabledQueues != null &&
                    this.DisabledQueues.SequenceEqual(other.DisabledQueues)
                ) && 
                (
                    this.FreeToPlay == other.FreeToPlay ||
                    this.FreeToPlay != null &&
                    this.FreeToPlay.Equals(other.FreeToPlay)
                ) && 
                (
                    this.Ownership == other.Ownership ||
                    this.Ownership != null &&
                    this.Ownership.Equals(other.Ownership)
                ) && 
                (
                    this.Purchased == other.Purchased ||
                    this.Purchased != null &&
                    this.Purchased.Equals(other.Purchased)
                ) && 
                (
                    this.RankedPlayEnabled == other.RankedPlayEnabled ||
                    this.RankedPlayEnabled != null &&
                    this.RankedPlayEnabled.Equals(other.RankedPlayEnabled)
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
                if (this.DisabledQueues != null)
                    hash = hash * 59 + this.DisabledQueues.GetHashCode();
                if (this.FreeToPlay != null)
                    hash = hash * 59 + this.FreeToPlay.GetHashCode();
                if (this.Ownership != null)
                    hash = hash * 59 + this.Ownership.GetHashCode();
                if (this.Purchased != null)
                    hash = hash * 59 + this.Purchased.GetHashCode();
                if (this.RankedPlayEnabled != null)
                    hash = hash * 59 + this.RankedPlayEnabled.GetHashCode();
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
