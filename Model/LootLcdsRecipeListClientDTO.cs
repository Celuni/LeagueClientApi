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
    /// LootLcdsRecipeListClientDTO
    /// </summary>
    [DataContract]
    public partial class LootLcdsRecipeListClientDTO :  IEquatable<LootLcdsRecipeListClientDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LootLcdsRecipeListClientDTO" /> class.
        /// </summary>
        /// <param name="LastUpdate">LastUpdate.</param>
        /// <param name="Recipes">Recipes.</param>
        public LootLcdsRecipeListClientDTO(long? LastUpdate = default(long?), List<LootLcdsRecipeClientDTO> Recipes = default(List<LootLcdsRecipeClientDTO>))
        {
            this.LastUpdate = LastUpdate;
            this.Recipes = Recipes;
        }
        
        /// <summary>
        /// Gets or Sets LastUpdate
        /// </summary>
        [DataMember(Name="lastUpdate", EmitDefaultValue=false)]
        public long? LastUpdate { get; set; }

        /// <summary>
        /// Gets or Sets Recipes
        /// </summary>
        [DataMember(Name="recipes", EmitDefaultValue=false)]
        public List<LootLcdsRecipeClientDTO> Recipes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LootLcdsRecipeListClientDTO {\n");
            sb.Append("  LastUpdate: ").Append(LastUpdate).Append("\n");
            sb.Append("  Recipes: ").Append(Recipes).Append("\n");
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
            return this.Equals(obj as LootLcdsRecipeListClientDTO);
        }

        /// <summary>
        /// Returns true if LootLcdsRecipeListClientDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of LootLcdsRecipeListClientDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LootLcdsRecipeListClientDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LastUpdate == other.LastUpdate ||
                    this.LastUpdate != null &&
                    this.LastUpdate.Equals(other.LastUpdate)
                ) && 
                (
                    this.Recipes == other.Recipes ||
                    this.Recipes != null &&
                    this.Recipes.SequenceEqual(other.Recipes)
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
                if (this.LastUpdate != null)
                    hash = hash * 59 + this.LastUpdate.GetHashCode();
                if (this.Recipes != null)
                    hash = hash * 59 + this.Recipes.GetHashCode();
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
