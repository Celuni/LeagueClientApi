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
    /// CraftLootRefTransactionDTO
    /// </summary>
    [DataContract]
    public partial class CraftLootRefTransactionDTO :  IEquatable<CraftLootRefTransactionDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CraftLootRefTransactionDTO" /> class.
        /// </summary>
        /// <param name="LootNameRefIds">LootNameRefIds.</param>
        /// <param name="RecipeName">RecipeName.</param>
        /// <param name="Repeat">Repeat.</param>
        public CraftLootRefTransactionDTO(List<LootNameRefId> LootNameRefIds = default(List<LootNameRefId>), string RecipeName = default(string), int? Repeat = default(int?))
        {
            this.LootNameRefIds = LootNameRefIds;
            this.RecipeName = RecipeName;
            this.Repeat = Repeat;
        }
        
        /// <summary>
        /// Gets or Sets LootNameRefIds
        /// </summary>
        [DataMember(Name="lootNameRefIds", EmitDefaultValue=false)]
        public List<LootNameRefId> LootNameRefIds { get; set; }

        /// <summary>
        /// Gets or Sets RecipeName
        /// </summary>
        [DataMember(Name="recipeName", EmitDefaultValue=false)]
        public string RecipeName { get; set; }

        /// <summary>
        /// Gets or Sets Repeat
        /// </summary>
        [DataMember(Name="repeat", EmitDefaultValue=false)]
        public int? Repeat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CraftLootRefTransactionDTO {\n");
            sb.Append("  LootNameRefIds: ").Append(LootNameRefIds).Append("\n");
            sb.Append("  RecipeName: ").Append(RecipeName).Append("\n");
            sb.Append("  Repeat: ").Append(Repeat).Append("\n");
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
            return this.Equals(obj as CraftLootRefTransactionDTO);
        }

        /// <summary>
        /// Returns true if CraftLootRefTransactionDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of CraftLootRefTransactionDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CraftLootRefTransactionDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LootNameRefIds == other.LootNameRefIds ||
                    this.LootNameRefIds != null &&
                    this.LootNameRefIds.SequenceEqual(other.LootNameRefIds)
                ) && 
                (
                    this.RecipeName == other.RecipeName ||
                    this.RecipeName != null &&
                    this.RecipeName.Equals(other.RecipeName)
                ) && 
                (
                    this.Repeat == other.Repeat ||
                    this.Repeat != null &&
                    this.Repeat.Equals(other.Repeat)
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
                if (this.LootNameRefIds != null)
                    hash = hash * 59 + this.LootNameRefIds.GetHashCode();
                if (this.RecipeName != null)
                    hash = hash * 59 + this.RecipeName.GetHashCode();
                if (this.Repeat != null)
                    hash = hash * 59 + this.Repeat.GetHashCode();
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
