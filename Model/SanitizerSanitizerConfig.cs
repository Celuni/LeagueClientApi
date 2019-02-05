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
    /// SanitizerSanitizerConfig
    /// </summary>
    [DataContract]
    public partial class SanitizerSanitizerConfig :  IEquatable<SanitizerSanitizerConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SanitizerSanitizerConfig" /> class.
        /// </summary>
        /// <param name="Level0Filter">Level0Filter.</param>
        /// <param name="Level0Unfilter">Level0Unfilter.</param>
        /// <param name="Level1Filter">Level1Filter.</param>
        /// <param name="Level1Unfilter">Level1Unfilter.</param>
        /// <param name="Level2Filter">Level2Filter.</param>
        /// <param name="Level2Unfilter">Level2Unfilter.</param>
        /// <param name="Level3Filter">Level3Filter.</param>
        /// <param name="Level3Unfilter">Level3Unfilter.</param>
        public SanitizerSanitizerConfig(string Level0Filter = default(string), string Level0Unfilter = default(string), string Level1Filter = default(string), string Level1Unfilter = default(string), string Level2Filter = default(string), string Level2Unfilter = default(string), string Level3Filter = default(string), string Level3Unfilter = default(string))
        {
            this.Level0Filter = Level0Filter;
            this.Level0Unfilter = Level0Unfilter;
            this.Level1Filter = Level1Filter;
            this.Level1Unfilter = Level1Unfilter;
            this.Level2Filter = Level2Filter;
            this.Level2Unfilter = Level2Unfilter;
            this.Level3Filter = Level3Filter;
            this.Level3Unfilter = Level3Unfilter;
        }
        
        /// <summary>
        /// Gets or Sets Level0Filter
        /// </summary>
        [DataMember(Name="Level0Filter", EmitDefaultValue=false)]
        public string Level0Filter { get; set; }

        /// <summary>
        /// Gets or Sets Level0Unfilter
        /// </summary>
        [DataMember(Name="Level0Unfilter", EmitDefaultValue=false)]
        public string Level0Unfilter { get; set; }

        /// <summary>
        /// Gets or Sets Level1Filter
        /// </summary>
        [DataMember(Name="Level1Filter", EmitDefaultValue=false)]
        public string Level1Filter { get; set; }

        /// <summary>
        /// Gets or Sets Level1Unfilter
        /// </summary>
        [DataMember(Name="Level1Unfilter", EmitDefaultValue=false)]
        public string Level1Unfilter { get; set; }

        /// <summary>
        /// Gets or Sets Level2Filter
        /// </summary>
        [DataMember(Name="Level2Filter", EmitDefaultValue=false)]
        public string Level2Filter { get; set; }

        /// <summary>
        /// Gets or Sets Level2Unfilter
        /// </summary>
        [DataMember(Name="Level2Unfilter", EmitDefaultValue=false)]
        public string Level2Unfilter { get; set; }

        /// <summary>
        /// Gets or Sets Level3Filter
        /// </summary>
        [DataMember(Name="Level3Filter", EmitDefaultValue=false)]
        public string Level3Filter { get; set; }

        /// <summary>
        /// Gets or Sets Level3Unfilter
        /// </summary>
        [DataMember(Name="Level3Unfilter", EmitDefaultValue=false)]
        public string Level3Unfilter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SanitizerSanitizerConfig {\n");
            sb.Append("  Level0Filter: ").Append(Level0Filter).Append("\n");
            sb.Append("  Level0Unfilter: ").Append(Level0Unfilter).Append("\n");
            sb.Append("  Level1Filter: ").Append(Level1Filter).Append("\n");
            sb.Append("  Level1Unfilter: ").Append(Level1Unfilter).Append("\n");
            sb.Append("  Level2Filter: ").Append(Level2Filter).Append("\n");
            sb.Append("  Level2Unfilter: ").Append(Level2Unfilter).Append("\n");
            sb.Append("  Level3Filter: ").Append(Level3Filter).Append("\n");
            sb.Append("  Level3Unfilter: ").Append(Level3Unfilter).Append("\n");
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
            return this.Equals(obj as SanitizerSanitizerConfig);
        }

        /// <summary>
        /// Returns true if SanitizerSanitizerConfig instances are equal
        /// </summary>
        /// <param name="other">Instance of SanitizerSanitizerConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SanitizerSanitizerConfig other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Level0Filter == other.Level0Filter ||
                    this.Level0Filter != null &&
                    this.Level0Filter.Equals(other.Level0Filter)
                ) && 
                (
                    this.Level0Unfilter == other.Level0Unfilter ||
                    this.Level0Unfilter != null &&
                    this.Level0Unfilter.Equals(other.Level0Unfilter)
                ) && 
                (
                    this.Level1Filter == other.Level1Filter ||
                    this.Level1Filter != null &&
                    this.Level1Filter.Equals(other.Level1Filter)
                ) && 
                (
                    this.Level1Unfilter == other.Level1Unfilter ||
                    this.Level1Unfilter != null &&
                    this.Level1Unfilter.Equals(other.Level1Unfilter)
                ) && 
                (
                    this.Level2Filter == other.Level2Filter ||
                    this.Level2Filter != null &&
                    this.Level2Filter.Equals(other.Level2Filter)
                ) && 
                (
                    this.Level2Unfilter == other.Level2Unfilter ||
                    this.Level2Unfilter != null &&
                    this.Level2Unfilter.Equals(other.Level2Unfilter)
                ) && 
                (
                    this.Level3Filter == other.Level3Filter ||
                    this.Level3Filter != null &&
                    this.Level3Filter.Equals(other.Level3Filter)
                ) && 
                (
                    this.Level3Unfilter == other.Level3Unfilter ||
                    this.Level3Unfilter != null &&
                    this.Level3Unfilter.Equals(other.Level3Unfilter)
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
                if (this.Level0Filter != null)
                    hash = hash * 59 + this.Level0Filter.GetHashCode();
                if (this.Level0Unfilter != null)
                    hash = hash * 59 + this.Level0Unfilter.GetHashCode();
                if (this.Level1Filter != null)
                    hash = hash * 59 + this.Level1Filter.GetHashCode();
                if (this.Level1Unfilter != null)
                    hash = hash * 59 + this.Level1Unfilter.GetHashCode();
                if (this.Level2Filter != null)
                    hash = hash * 59 + this.Level2Filter.GetHashCode();
                if (this.Level2Unfilter != null)
                    hash = hash * 59 + this.Level2Unfilter.GetHashCode();
                if (this.Level3Filter != null)
                    hash = hash * 59 + this.Level3Filter.GetHashCode();
                if (this.Level3Unfilter != null)
                    hash = hash * 59 + this.Level3Unfilter.GetHashCode();
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