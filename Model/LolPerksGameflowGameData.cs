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
    /// LolPerksGameflowGameData
    /// </summary>
    [DataContract]
    public partial class LolPerksGameflowGameData :  IEquatable<LolPerksGameflowGameData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolPerksGameflowGameData" /> class.
        /// </summary>
        /// <param name="IsCustomGame">IsCustomGame.</param>
        /// <param name="Queue">Queue.</param>
        public LolPerksGameflowGameData(bool? IsCustomGame = default(bool?), LolPerksQueue Queue = default(LolPerksQueue))
        {
            this.IsCustomGame = IsCustomGame;
            this.Queue = Queue;
        }
        
        /// <summary>
        /// Gets or Sets IsCustomGame
        /// </summary>
        [DataMember(Name="isCustomGame", EmitDefaultValue=false)]
        public bool? IsCustomGame { get; set; }

        /// <summary>
        /// Gets or Sets Queue
        /// </summary>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public LolPerksQueue Queue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolPerksGameflowGameData {\n");
            sb.Append("  IsCustomGame: ").Append(IsCustomGame).Append("\n");
            sb.Append("  Queue: ").Append(Queue).Append("\n");
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
            return this.Equals(obj as LolPerksGameflowGameData);
        }

        /// <summary>
        /// Returns true if LolPerksGameflowGameData instances are equal
        /// </summary>
        /// <param name="other">Instance of LolPerksGameflowGameData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolPerksGameflowGameData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IsCustomGame == other.IsCustomGame ||
                    this.IsCustomGame != null &&
                    this.IsCustomGame.Equals(other.IsCustomGame)
                ) && 
                (
                    this.Queue == other.Queue ||
                    this.Queue != null &&
                    this.Queue.Equals(other.Queue)
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
                if (this.IsCustomGame != null)
                    hash = hash * 59 + this.IsCustomGame.GetHashCode();
                if (this.Queue != null)
                    hash = hash * 59 + this.Queue.GetHashCode();
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
