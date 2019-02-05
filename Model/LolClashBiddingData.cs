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
    /// LolClashBiddingData
    /// </summary>
    [DataContract]
    public partial class LolClashBiddingData :  IEquatable<LolClashBiddingData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolClashBiddingData" /> class.
        /// </summary>
        /// <param name="CurrentBid">CurrentBid.</param>
        /// <param name="CurrentPaid">CurrentPaid.</param>
        /// <param name="IncomingOffers">IncomingOffers.</param>
        public LolClashBiddingData(int? CurrentBid = default(int?), int? CurrentPaid = default(int?), List<LolClashTicketOffer> IncomingOffers = default(List<LolClashTicketOffer>))
        {
            this.CurrentBid = CurrentBid;
            this.CurrentPaid = CurrentPaid;
            this.IncomingOffers = IncomingOffers;
        }
        
        /// <summary>
        /// Gets or Sets CurrentBid
        /// </summary>
        [DataMember(Name="currentBid", EmitDefaultValue=false)]
        public int? CurrentBid { get; set; }

        /// <summary>
        /// Gets or Sets CurrentPaid
        /// </summary>
        [DataMember(Name="currentPaid", EmitDefaultValue=false)]
        public int? CurrentPaid { get; set; }

        /// <summary>
        /// Gets or Sets IncomingOffers
        /// </summary>
        [DataMember(Name="incomingOffers", EmitDefaultValue=false)]
        public List<LolClashTicketOffer> IncomingOffers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolClashBiddingData {\n");
            sb.Append("  CurrentBid: ").Append(CurrentBid).Append("\n");
            sb.Append("  CurrentPaid: ").Append(CurrentPaid).Append("\n");
            sb.Append("  IncomingOffers: ").Append(IncomingOffers).Append("\n");
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
            return this.Equals(obj as LolClashBiddingData);
        }

        /// <summary>
        /// Returns true if LolClashBiddingData instances are equal
        /// </summary>
        /// <param name="other">Instance of LolClashBiddingData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolClashBiddingData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CurrentBid == other.CurrentBid ||
                    this.CurrentBid != null &&
                    this.CurrentBid.Equals(other.CurrentBid)
                ) && 
                (
                    this.CurrentPaid == other.CurrentPaid ||
                    this.CurrentPaid != null &&
                    this.CurrentPaid.Equals(other.CurrentPaid)
                ) && 
                (
                    this.IncomingOffers == other.IncomingOffers ||
                    this.IncomingOffers != null &&
                    this.IncomingOffers.SequenceEqual(other.IncomingOffers)
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
                if (this.CurrentBid != null)
                    hash = hash * 59 + this.CurrentBid.GetHashCode();
                if (this.CurrentPaid != null)
                    hash = hash * 59 + this.CurrentPaid.GetHashCode();
                if (this.IncomingOffers != null)
                    hash = hash * 59 + this.IncomingOffers.GetHashCode();
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