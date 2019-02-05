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
    /// LootLcdsRecipeSlotClientDTO
    /// </summary>
    [DataContract]
    public partial class LootLcdsRecipeSlotClientDTO :  IEquatable<LootLcdsRecipeSlotClientDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LootLcdsRecipeSlotClientDTO" /> class.
        /// </summary>
        /// <param name="QuantityExpression">QuantityExpression.</param>
        /// <param name="Query">Query.</param>
        /// <param name="SlotNumber">SlotNumber.</param>
        public LootLcdsRecipeSlotClientDTO(string QuantityExpression = default(string), string Query = default(string), int? SlotNumber = default(int?))
        {
            this.QuantityExpression = QuantityExpression;
            this.Query = Query;
            this.SlotNumber = SlotNumber;
        }
        
        /// <summary>
        /// Gets or Sets QuantityExpression
        /// </summary>
        [DataMember(Name="quantityExpression", EmitDefaultValue=false)]
        public string QuantityExpression { get; set; }

        /// <summary>
        /// Gets or Sets Query
        /// </summary>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public string Query { get; set; }

        /// <summary>
        /// Gets or Sets SlotNumber
        /// </summary>
        [DataMember(Name="slotNumber", EmitDefaultValue=false)]
        public int? SlotNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LootLcdsRecipeSlotClientDTO {\n");
            sb.Append("  QuantityExpression: ").Append(QuantityExpression).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  SlotNumber: ").Append(SlotNumber).Append("\n");
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
            return this.Equals(obj as LootLcdsRecipeSlotClientDTO);
        }

        /// <summary>
        /// Returns true if LootLcdsRecipeSlotClientDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of LootLcdsRecipeSlotClientDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LootLcdsRecipeSlotClientDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.QuantityExpression == other.QuantityExpression ||
                    this.QuantityExpression != null &&
                    this.QuantityExpression.Equals(other.QuantityExpression)
                ) && 
                (
                    this.Query == other.Query ||
                    this.Query != null &&
                    this.Query.Equals(other.Query)
                ) && 
                (
                    this.SlotNumber == other.SlotNumber ||
                    this.SlotNumber != null &&
                    this.SlotNumber.Equals(other.SlotNumber)
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
                if (this.QuantityExpression != null)
                    hash = hash * 59 + this.QuantityExpression.GetHashCode();
                if (this.Query != null)
                    hash = hash * 59 + this.Query.GetHashCode();
                if (this.SlotNumber != null)
                    hash = hash * 59 + this.SlotNumber.GetHashCode();
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