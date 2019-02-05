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
    /// SanitizerSanitizeRequest
    /// </summary>
    [DataContract]
    public partial class SanitizerSanitizeRequest :  IEquatable<SanitizerSanitizeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SanitizerSanitizeRequest" /> class.
        /// </summary>
        /// <param name="AggressiveScan">AggressiveScan.</param>
        /// <param name="Level">Level.</param>
        /// <param name="RemoveDisallowedChars">RemoveDisallowedChars.</param>
        /// <param name="Text">Text.</param>
        /// <param name="Texts">Texts.</param>
        public SanitizerSanitizeRequest(bool? AggressiveScan = default(bool?), int? Level = default(int?), bool? RemoveDisallowedChars = default(bool?), string Text = default(string), List<string> Texts = default(List<string>))
        {
            this.AggressiveScan = AggressiveScan;
            this.Level = Level;
            this.RemoveDisallowedChars = RemoveDisallowedChars;
            this.Text = Text;
            this.Texts = Texts;
        }
        
        /// <summary>
        /// Gets or Sets AggressiveScan
        /// </summary>
        [DataMember(Name="aggressiveScan", EmitDefaultValue=false)]
        public bool? AggressiveScan { get; set; }

        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name="level", EmitDefaultValue=false)]
        public int? Level { get; set; }

        /// <summary>
        /// Gets or Sets RemoveDisallowedChars
        /// </summary>
        [DataMember(Name="removeDisallowedChars", EmitDefaultValue=false)]
        public bool? RemoveDisallowedChars { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets Texts
        /// </summary>
        [DataMember(Name="texts", EmitDefaultValue=false)]
        public List<string> Texts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SanitizerSanitizeRequest {\n");
            sb.Append("  AggressiveScan: ").Append(AggressiveScan).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  RemoveDisallowedChars: ").Append(RemoveDisallowedChars).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Texts: ").Append(Texts).Append("\n");
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
            return this.Equals(obj as SanitizerSanitizeRequest);
        }

        /// <summary>
        /// Returns true if SanitizerSanitizeRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SanitizerSanitizeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SanitizerSanitizeRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AggressiveScan == other.AggressiveScan ||
                    this.AggressiveScan != null &&
                    this.AggressiveScan.Equals(other.AggressiveScan)
                ) && 
                (
                    this.Level == other.Level ||
                    this.Level != null &&
                    this.Level.Equals(other.Level)
                ) && 
                (
                    this.RemoveDisallowedChars == other.RemoveDisallowedChars ||
                    this.RemoveDisallowedChars != null &&
                    this.RemoveDisallowedChars.Equals(other.RemoveDisallowedChars)
                ) && 
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) && 
                (
                    this.Texts == other.Texts ||
                    this.Texts != null &&
                    this.Texts.SequenceEqual(other.Texts)
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
                if (this.AggressiveScan != null)
                    hash = hash * 59 + this.AggressiveScan.GetHashCode();
                if (this.Level != null)
                    hash = hash * 59 + this.Level.GetHashCode();
                if (this.RemoveDisallowedChars != null)
                    hash = hash * 59 + this.RemoveDisallowedChars.GetHashCode();
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
                if (this.Texts != null)
                    hash = hash * 59 + this.Texts.GetHashCode();
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