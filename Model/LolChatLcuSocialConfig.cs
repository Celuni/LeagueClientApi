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
    /// LolChatLcuSocialConfig
    /// </summary>
    [DataContract]
    public partial class LolChatLcuSocialConfig :  IEquatable<LolChatLcuSocialConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolChatLcuSocialConfig" /> class.
        /// </summary>
        /// <param name="AggressiveScanning">AggressiveScanning.</param>
        /// <param name="ForceChatFilter">ForceChatFilter.</param>
        /// <param name="QueueJobGraceSeconds">QueueJobGraceSeconds.</param>
        /// <param name="SilenceChatWhileInGame">SilenceChatWhileInGame.</param>
        public LolChatLcuSocialConfig(bool? AggressiveScanning = default(bool?), bool? ForceChatFilter = default(bool?), long? QueueJobGraceSeconds = default(long?), bool? SilenceChatWhileInGame = default(bool?))
        {
            this.AggressiveScanning = AggressiveScanning;
            this.ForceChatFilter = ForceChatFilter;
            this.QueueJobGraceSeconds = QueueJobGraceSeconds;
            this.SilenceChatWhileInGame = SilenceChatWhileInGame;
        }
        
        /// <summary>
        /// Gets or Sets AggressiveScanning
        /// </summary>
        [DataMember(Name="AggressiveScanning", EmitDefaultValue=false)]
        public bool? AggressiveScanning { get; set; }

        /// <summary>
        /// Gets or Sets ForceChatFilter
        /// </summary>
        [DataMember(Name="ForceChatFilter", EmitDefaultValue=false)]
        public bool? ForceChatFilter { get; set; }

        /// <summary>
        /// Gets or Sets QueueJobGraceSeconds
        /// </summary>
        [DataMember(Name="QueueJobGraceSeconds", EmitDefaultValue=false)]
        public long? QueueJobGraceSeconds { get; set; }

        /// <summary>
        /// Gets or Sets SilenceChatWhileInGame
        /// </summary>
        [DataMember(Name="SilenceChatWhileInGame", EmitDefaultValue=false)]
        public bool? SilenceChatWhileInGame { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolChatLcuSocialConfig {\n");
            sb.Append("  AggressiveScanning: ").Append(AggressiveScanning).Append("\n");
            sb.Append("  ForceChatFilter: ").Append(ForceChatFilter).Append("\n");
            sb.Append("  QueueJobGraceSeconds: ").Append(QueueJobGraceSeconds).Append("\n");
            sb.Append("  SilenceChatWhileInGame: ").Append(SilenceChatWhileInGame).Append("\n");
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
            return this.Equals(obj as LolChatLcuSocialConfig);
        }

        /// <summary>
        /// Returns true if LolChatLcuSocialConfig instances are equal
        /// </summary>
        /// <param name="other">Instance of LolChatLcuSocialConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolChatLcuSocialConfig other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AggressiveScanning == other.AggressiveScanning ||
                    this.AggressiveScanning != null &&
                    this.AggressiveScanning.Equals(other.AggressiveScanning)
                ) && 
                (
                    this.ForceChatFilter == other.ForceChatFilter ||
                    this.ForceChatFilter != null &&
                    this.ForceChatFilter.Equals(other.ForceChatFilter)
                ) && 
                (
                    this.QueueJobGraceSeconds == other.QueueJobGraceSeconds ||
                    this.QueueJobGraceSeconds != null &&
                    this.QueueJobGraceSeconds.Equals(other.QueueJobGraceSeconds)
                ) && 
                (
                    this.SilenceChatWhileInGame == other.SilenceChatWhileInGame ||
                    this.SilenceChatWhileInGame != null &&
                    this.SilenceChatWhileInGame.Equals(other.SilenceChatWhileInGame)
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
                if (this.AggressiveScanning != null)
                    hash = hash * 59 + this.AggressiveScanning.GetHashCode();
                if (this.ForceChatFilter != null)
                    hash = hash * 59 + this.ForceChatFilter.GetHashCode();
                if (this.QueueJobGraceSeconds != null)
                    hash = hash * 59 + this.QueueJobGraceSeconds.GetHashCode();
                if (this.SilenceChatWhileInGame != null)
                    hash = hash * 59 + this.SilenceChatWhileInGame.GetHashCode();
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