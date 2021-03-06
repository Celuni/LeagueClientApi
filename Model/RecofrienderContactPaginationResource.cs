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
    /// RecofrienderContactPaginationResource
    /// </summary>
    [DataContract]
    public partial class RecofrienderContactPaginationResource :  IEquatable<RecofrienderContactPaginationResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecofrienderContactPaginationResource" /> class.
        /// </summary>
        /// <param name="Cached">Cached.</param>
        /// <param name="Count">Count.</param>
        /// <param name="Limit">Limit.</param>
        /// <param name="More">More.</param>
        /// <param name="Start">Start.</param>
        /// <param name="Total">Total.</param>
        public RecofrienderContactPaginationResource(long? Cached = default(long?), long? Count = default(long?), long? Limit = default(long?), bool? More = default(bool?), long? Start = default(long?), long? Total = default(long?))
        {
            this.Cached = Cached;
            this.Count = Count;
            this.Limit = Limit;
            this.More = More;
            this.Start = Start;
            this.Total = Total;
        }
        
        /// <summary>
        /// Gets or Sets Cached
        /// </summary>
        [DataMember(Name="cached", EmitDefaultValue=false)]
        public long? Cached { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public long? Count { get; set; }

        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// Gets or Sets More
        /// </summary>
        [DataMember(Name="more", EmitDefaultValue=false)]
        public bool? More { get; set; }

        /// <summary>
        /// Gets or Sets Start
        /// </summary>
        [DataMember(Name="start", EmitDefaultValue=false)]
        public long? Start { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public long? Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecofrienderContactPaginationResource {\n");
            sb.Append("  Cached: ").Append(Cached).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  More: ").Append(More).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return this.Equals(obj as RecofrienderContactPaginationResource);
        }

        /// <summary>
        /// Returns true if RecofrienderContactPaginationResource instances are equal
        /// </summary>
        /// <param name="other">Instance of RecofrienderContactPaginationResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecofrienderContactPaginationResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Cached == other.Cached ||
                    this.Cached != null &&
                    this.Cached.Equals(other.Cached)
                ) && 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) && 
                (
                    this.Limit == other.Limit ||
                    this.Limit != null &&
                    this.Limit.Equals(other.Limit)
                ) && 
                (
                    this.More == other.More ||
                    this.More != null &&
                    this.More.Equals(other.More)
                ) && 
                (
                    this.Start == other.Start ||
                    this.Start != null &&
                    this.Start.Equals(other.Start)
                ) && 
                (
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
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
                if (this.Cached != null)
                    hash = hash * 59 + this.Cached.GetHashCode();
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                if (this.Limit != null)
                    hash = hash * 59 + this.Limit.GetHashCode();
                if (this.More != null)
                    hash = hash * 59 + this.More.GetHashCode();
                if (this.Start != null)
                    hash = hash * 59 + this.Start.GetHashCode();
                if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();
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
