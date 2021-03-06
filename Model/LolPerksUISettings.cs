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
    /// LolPerksUISettings
    /// </summary>
    [DataContract]
    public partial class LolPerksUISettings :  IEquatable<LolPerksUISettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolPerksUISettings" /> class.
        /// </summary>
        /// <param name="GridModeEnabled">GridModeEnabled.</param>
        /// <param name="ShowLongDescriptions">ShowLongDescriptions.</param>
        /// <param name="ShowPresetPages">ShowPresetPages.</param>
        public LolPerksUISettings(bool? GridModeEnabled = default(bool?), bool? ShowLongDescriptions = default(bool?), bool? ShowPresetPages = default(bool?))
        {
            this.GridModeEnabled = GridModeEnabled;
            this.ShowLongDescriptions = ShowLongDescriptions;
            this.ShowPresetPages = ShowPresetPages;
        }
        
        /// <summary>
        /// Gets or Sets GridModeEnabled
        /// </summary>
        [DataMember(Name="gridModeEnabled", EmitDefaultValue=false)]
        public bool? GridModeEnabled { get; set; }

        /// <summary>
        /// Gets or Sets ShowLongDescriptions
        /// </summary>
        [DataMember(Name="showLongDescriptions", EmitDefaultValue=false)]
        public bool? ShowLongDescriptions { get; set; }

        /// <summary>
        /// Gets or Sets ShowPresetPages
        /// </summary>
        [DataMember(Name="showPresetPages", EmitDefaultValue=false)]
        public bool? ShowPresetPages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolPerksUISettings {\n");
            sb.Append("  GridModeEnabled: ").Append(GridModeEnabled).Append("\n");
            sb.Append("  ShowLongDescriptions: ").Append(ShowLongDescriptions).Append("\n");
            sb.Append("  ShowPresetPages: ").Append(ShowPresetPages).Append("\n");
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
            return this.Equals(obj as LolPerksUISettings);
        }

        /// <summary>
        /// Returns true if LolPerksUISettings instances are equal
        /// </summary>
        /// <param name="other">Instance of LolPerksUISettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolPerksUISettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.GridModeEnabled == other.GridModeEnabled ||
                    this.GridModeEnabled != null &&
                    this.GridModeEnabled.Equals(other.GridModeEnabled)
                ) && 
                (
                    this.ShowLongDescriptions == other.ShowLongDescriptions ||
                    this.ShowLongDescriptions != null &&
                    this.ShowLongDescriptions.Equals(other.ShowLongDescriptions)
                ) && 
                (
                    this.ShowPresetPages == other.ShowPresetPages ||
                    this.ShowPresetPages != null &&
                    this.ShowPresetPages.Equals(other.ShowPresetPages)
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
                if (this.GridModeEnabled != null)
                    hash = hash * 59 + this.GridModeEnabled.GetHashCode();
                if (this.ShowLongDescriptions != null)
                    hash = hash * 59 + this.ShowLongDescriptions.GetHashCode();
                if (this.ShowPresetPages != null)
                    hash = hash * 59 + this.ShowPresetPages.GetHashCode();
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
