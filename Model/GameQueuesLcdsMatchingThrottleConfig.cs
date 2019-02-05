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
    /// GameQueuesLcdsMatchingThrottleConfig
    /// </summary>
    [DataContract]
    public partial class GameQueuesLcdsMatchingThrottleConfig :  IEquatable<GameQueuesLcdsMatchingThrottleConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameQueuesLcdsMatchingThrottleConfig" /> class.
        /// </summary>
        /// <param name="CacheName">CacheName.</param>
        /// <param name="Limit">Limit.</param>
        public GameQueuesLcdsMatchingThrottleConfig(string CacheName = default(string), long? Limit = default(long?))
        {
            this.CacheName = CacheName;
            this.Limit = Limit;
        }
        
        /// <summary>
        /// Gets or Sets CacheName
        /// </summary>
        [DataMember(Name="cacheName", EmitDefaultValue=false)]
        public string CacheName { get; set; }

        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GameQueuesLcdsMatchingThrottleConfig {\n");
            sb.Append("  CacheName: ").Append(CacheName).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
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
            return this.Equals(obj as GameQueuesLcdsMatchingThrottleConfig);
        }

        /// <summary>
        /// Returns true if GameQueuesLcdsMatchingThrottleConfig instances are equal
        /// </summary>
        /// <param name="other">Instance of GameQueuesLcdsMatchingThrottleConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GameQueuesLcdsMatchingThrottleConfig other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CacheName == other.CacheName ||
                    this.CacheName != null &&
                    this.CacheName.Equals(other.CacheName)
                ) && 
                (
                    this.Limit == other.Limit ||
                    this.Limit != null &&
                    this.Limit.Equals(other.Limit)
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
                if (this.CacheName != null)
                    hash = hash * 59 + this.CacheName.GetHashCode();
                if (this.Limit != null)
                    hash = hash * 59 + this.Limit.GetHashCode();
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