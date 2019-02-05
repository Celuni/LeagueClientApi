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
    /// LolPurchaseWidgetWallet
    /// </summary>
    [DataContract]
    public partial class LolPurchaseWidgetWallet :  IEquatable<LolPurchaseWidgetWallet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolPurchaseWidgetWallet" /> class.
        /// </summary>
        /// <param name="AccountId">AccountId.</param>
        /// <param name="Balances">Balances.</param>
        /// <param name="Version">Version.</param>
        public LolPurchaseWidgetWallet(long? AccountId = default(long?), List<LolPurchaseWidgetBalance> Balances = default(List<LolPurchaseWidgetBalance>), int? Version = default(int?))
        {
            this.AccountId = AccountId;
            this.Balances = Balances;
            this.Version = Version;
        }
        
        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public long? AccountId { get; set; }

        /// <summary>
        /// Gets or Sets Balances
        /// </summary>
        [DataMember(Name="balances", EmitDefaultValue=false)]
        public List<LolPurchaseWidgetBalance> Balances { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolPurchaseWidgetWallet {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Balances: ").Append(Balances).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(obj as LolPurchaseWidgetWallet);
        }

        /// <summary>
        /// Returns true if LolPurchaseWidgetWallet instances are equal
        /// </summary>
        /// <param name="other">Instance of LolPurchaseWidgetWallet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolPurchaseWidgetWallet other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) && 
                (
                    this.Balances == other.Balances ||
                    this.Balances != null &&
                    this.Balances.SequenceEqual(other.Balances)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                if (this.Balances != null)
                    hash = hash * 59 + this.Balances.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
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