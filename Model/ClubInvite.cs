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
    /// ClubInvite
    /// </summary>
    [DataContract]
    public partial class ClubInvite :  IEquatable<ClubInvite>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClubInvite" /> class.
        /// </summary>
        /// <param name="ClubKey">ClubKey.</param>
        /// <param name="ClubName">ClubName.</param>
        /// <param name="InviteeAccountId">InviteeAccountId.</param>
        /// <param name="InviteeSummonerId">InviteeSummonerId.</param>
        /// <param name="InviterAccountId">InviterAccountId.</param>
        /// <param name="InviterSummonerId">InviterSummonerId.</param>
        /// <param name="InviterSummonerName">InviterSummonerName.</param>
        /// <param name="Status">Status.</param>
        public ClubInvite(string ClubKey = default(string), string ClubName = default(string), long? InviteeAccountId = default(long?), long? InviteeSummonerId = default(long?), long? InviterAccountId = default(long?), long? InviterSummonerId = default(long?), string InviterSummonerName = default(string), ClubInviteStatus Status = default(ClubInviteStatus))
        {
            this.ClubKey = ClubKey;
            this.ClubName = ClubName;
            this.InviteeAccountId = InviteeAccountId;
            this.InviteeSummonerId = InviteeSummonerId;
            this.InviterAccountId = InviterAccountId;
            this.InviterSummonerId = InviterSummonerId;
            this.InviterSummonerName = InviterSummonerName;
            this.Status = Status;
        }
        
        /// <summary>
        /// Gets or Sets ClubKey
        /// </summary>
        [DataMember(Name="clubKey", EmitDefaultValue=false)]
        public string ClubKey { get; set; }

        /// <summary>
        /// Gets or Sets ClubName
        /// </summary>
        [DataMember(Name="clubName", EmitDefaultValue=false)]
        public string ClubName { get; set; }

        /// <summary>
        /// Gets or Sets InviteeAccountId
        /// </summary>
        [DataMember(Name="inviteeAccountId", EmitDefaultValue=false)]
        public long? InviteeAccountId { get; set; }

        /// <summary>
        /// Gets or Sets InviteeSummonerId
        /// </summary>
        [DataMember(Name="inviteeSummonerId", EmitDefaultValue=false)]
        public long? InviteeSummonerId { get; set; }

        /// <summary>
        /// Gets or Sets InviterAccountId
        /// </summary>
        [DataMember(Name="inviterAccountId", EmitDefaultValue=false)]
        public long? InviterAccountId { get; set; }

        /// <summary>
        /// Gets or Sets InviterSummonerId
        /// </summary>
        [DataMember(Name="inviterSummonerId", EmitDefaultValue=false)]
        public long? InviterSummonerId { get; set; }

        /// <summary>
        /// Gets or Sets InviterSummonerName
        /// </summary>
        [DataMember(Name="inviterSummonerName", EmitDefaultValue=false)]
        public string InviterSummonerName { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public ClubInviteStatus Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClubInvite {\n");
            sb.Append("  ClubKey: ").Append(ClubKey).Append("\n");
            sb.Append("  ClubName: ").Append(ClubName).Append("\n");
            sb.Append("  InviteeAccountId: ").Append(InviteeAccountId).Append("\n");
            sb.Append("  InviteeSummonerId: ").Append(InviteeSummonerId).Append("\n");
            sb.Append("  InviterAccountId: ").Append(InviterAccountId).Append("\n");
            sb.Append("  InviterSummonerId: ").Append(InviterSummonerId).Append("\n");
            sb.Append("  InviterSummonerName: ").Append(InviterSummonerName).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(obj as ClubInvite);
        }

        /// <summary>
        /// Returns true if ClubInvite instances are equal
        /// </summary>
        /// <param name="other">Instance of ClubInvite to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClubInvite other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ClubKey == other.ClubKey ||
                    this.ClubKey != null &&
                    this.ClubKey.Equals(other.ClubKey)
                ) && 
                (
                    this.ClubName == other.ClubName ||
                    this.ClubName != null &&
                    this.ClubName.Equals(other.ClubName)
                ) && 
                (
                    this.InviteeAccountId == other.InviteeAccountId ||
                    this.InviteeAccountId != null &&
                    this.InviteeAccountId.Equals(other.InviteeAccountId)
                ) && 
                (
                    this.InviteeSummonerId == other.InviteeSummonerId ||
                    this.InviteeSummonerId != null &&
                    this.InviteeSummonerId.Equals(other.InviteeSummonerId)
                ) && 
                (
                    this.InviterAccountId == other.InviterAccountId ||
                    this.InviterAccountId != null &&
                    this.InviterAccountId.Equals(other.InviterAccountId)
                ) && 
                (
                    this.InviterSummonerId == other.InviterSummonerId ||
                    this.InviterSummonerId != null &&
                    this.InviterSummonerId.Equals(other.InviterSummonerId)
                ) && 
                (
                    this.InviterSummonerName == other.InviterSummonerName ||
                    this.InviterSummonerName != null &&
                    this.InviterSummonerName.Equals(other.InviterSummonerName)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                if (this.ClubKey != null)
                    hash = hash * 59 + this.ClubKey.GetHashCode();
                if (this.ClubName != null)
                    hash = hash * 59 + this.ClubName.GetHashCode();
                if (this.InviteeAccountId != null)
                    hash = hash * 59 + this.InviteeAccountId.GetHashCode();
                if (this.InviteeSummonerId != null)
                    hash = hash * 59 + this.InviteeSummonerId.GetHashCode();
                if (this.InviterAccountId != null)
                    hash = hash * 59 + this.InviterAccountId.GetHashCode();
                if (this.InviterSummonerId != null)
                    hash = hash * 59 + this.InviterSummonerId.GetHashCode();
                if (this.InviterSummonerName != null)
                    hash = hash * 59 + this.InviterSummonerName.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
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