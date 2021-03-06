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
    /// LolLobbyCollectionsChampion
    /// </summary>
    [DataContract]
    public partial class LolLobbyCollectionsChampion :  IEquatable<LolLobbyCollectionsChampion>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolLobbyCollectionsChampion" /> class.
        /// </summary>
        /// <param name="Active">Active.</param>
        /// <param name="BotEnabled">BotEnabled.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        public LolLobbyCollectionsChampion(bool? Active = default(bool?), bool? BotEnabled = default(bool?), int? Id = default(int?), string Name = default(string))
        {
            this.Active = Active;
            this.BotEnabled = BotEnabled;
            this.Id = Id;
            this.Name = Name;
        }
        
        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or Sets BotEnabled
        /// </summary>
        [DataMember(Name="botEnabled", EmitDefaultValue=false)]
        public bool? BotEnabled { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolLobbyCollectionsChampion {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  BotEnabled: ").Append(BotEnabled).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as LolLobbyCollectionsChampion);
        }

        /// <summary>
        /// Returns true if LolLobbyCollectionsChampion instances are equal
        /// </summary>
        /// <param name="other">Instance of LolLobbyCollectionsChampion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolLobbyCollectionsChampion other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) && 
                (
                    this.BotEnabled == other.BotEnabled ||
                    this.BotEnabled != null &&
                    this.BotEnabled.Equals(other.BotEnabled)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();
                if (this.BotEnabled != null)
                    hash = hash * 59 + this.BotEnabled.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
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
