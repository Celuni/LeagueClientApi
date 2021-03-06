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
    /// LolStoreSummoner
    /// </summary>
    [DataContract]
    public partial class LolStoreSummoner :  IEquatable<LolStoreSummoner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolStoreSummoner" /> class.
        /// </summary>
        /// <param name="AcctId">AcctId.</param>
        /// <param name="SumId">SumId.</param>
        public LolStoreSummoner(long? AcctId = default(long?), long? SumId = default(long?))
        {
            this.AcctId = AcctId;
            this.SumId = SumId;
        }
        
        /// <summary>
        /// Gets or Sets AcctId
        /// </summary>
        [DataMember(Name="acctId", EmitDefaultValue=false)]
        public long? AcctId { get; set; }

        /// <summary>
        /// Gets or Sets SumId
        /// </summary>
        [DataMember(Name="sumId", EmitDefaultValue=false)]
        public long? SumId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolStoreSummoner {\n");
            sb.Append("  AcctId: ").Append(AcctId).Append("\n");
            sb.Append("  SumId: ").Append(SumId).Append("\n");
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
            return this.Equals(obj as LolStoreSummoner);
        }

        /// <summary>
        /// Returns true if LolStoreSummoner instances are equal
        /// </summary>
        /// <param name="other">Instance of LolStoreSummoner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolStoreSummoner other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AcctId == other.AcctId ||
                    this.AcctId != null &&
                    this.AcctId.Equals(other.AcctId)
                ) && 
                (
                    this.SumId == other.SumId ||
                    this.SumId != null &&
                    this.SumId.Equals(other.SumId)
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
                if (this.AcctId != null)
                    hash = hash * 59 + this.AcctId.GetHashCode();
                if (this.SumId != null)
                    hash = hash * 59 + this.SumId.GetHashCode();
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
