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
    /// TicketOfferDTO
    /// </summary>
    [DataContract]
    public partial class TicketOfferDTO :  IEquatable<TicketOfferDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TicketOfferDTO" /> class.
        /// </summary>
        /// <param name="Count">Count.</param>
        /// <param name="OfferPlayerId">OfferPlayerId.</param>
        /// <param name="ReceivePlayerId">ReceivePlayerId.</param>
        /// <param name="TicketOfferState">TicketOfferState.</param>
        public TicketOfferDTO(int? Count = default(int?), long? OfferPlayerId = default(long?), long? ReceivePlayerId = default(long?), TicketOfferState TicketOfferState = default(TicketOfferState))
        {
            this.Count = Count;
            this.OfferPlayerId = OfferPlayerId;
            this.ReceivePlayerId = ReceivePlayerId;
            this.TicketOfferState = TicketOfferState;
        }
        
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }

        /// <summary>
        /// Gets or Sets OfferPlayerId
        /// </summary>
        [DataMember(Name="offerPlayerId", EmitDefaultValue=false)]
        public long? OfferPlayerId { get; set; }

        /// <summary>
        /// Gets or Sets ReceivePlayerId
        /// </summary>
        [DataMember(Name="receivePlayerId", EmitDefaultValue=false)]
        public long? ReceivePlayerId { get; set; }

        /// <summary>
        /// Gets or Sets TicketOfferState
        /// </summary>
        [DataMember(Name="ticketOfferState", EmitDefaultValue=false)]
        public TicketOfferState TicketOfferState { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TicketOfferDTO {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  OfferPlayerId: ").Append(OfferPlayerId).Append("\n");
            sb.Append("  ReceivePlayerId: ").Append(ReceivePlayerId).Append("\n");
            sb.Append("  TicketOfferState: ").Append(TicketOfferState).Append("\n");
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
            return this.Equals(obj as TicketOfferDTO);
        }

        /// <summary>
        /// Returns true if TicketOfferDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of TicketOfferDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TicketOfferDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) && 
                (
                    this.OfferPlayerId == other.OfferPlayerId ||
                    this.OfferPlayerId != null &&
                    this.OfferPlayerId.Equals(other.OfferPlayerId)
                ) && 
                (
                    this.ReceivePlayerId == other.ReceivePlayerId ||
                    this.ReceivePlayerId != null &&
                    this.ReceivePlayerId.Equals(other.ReceivePlayerId)
                ) && 
                (
                    this.TicketOfferState == other.TicketOfferState ||
                    this.TicketOfferState != null &&
                    this.TicketOfferState.Equals(other.TicketOfferState)
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
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                if (this.OfferPlayerId != null)
                    hash = hash * 59 + this.OfferPlayerId.GetHashCode();
                if (this.ReceivePlayerId != null)
                    hash = hash * 59 + this.ReceivePlayerId.GetHashCode();
                if (this.TicketOfferState != null)
                    hash = hash * 59 + this.TicketOfferState.GetHashCode();
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
