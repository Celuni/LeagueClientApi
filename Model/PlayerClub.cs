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
    /// PlayerClub
    /// </summary>
    [DataContract]
    public partial class PlayerClub :  IEquatable<PlayerClub>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerClub" /> class.
        /// </summary>
        /// <param name="Created">Created.</param>
        /// <param name="Description">Description.</param>
        /// <param name="IsClubTagEligible">IsClubTagEligible.</param>
        /// <param name="Jid">Jid.</param>
        /// <param name="Key">Key.</param>
        /// <param name="LastModified">LastModified.</param>
        /// <param name="Members">Members.</param>
        /// <param name="Motd">Motd.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Owner">Owner.</param>
        /// <param name="Permissions">Permissions.</param>
        /// <param name="Primary">Primary.</param>
        /// <param name="Role">Role.</param>
        /// <param name="Tag">Tag.</param>
        public PlayerClub(long? Created = default(long?), string Description = default(string), bool? IsClubTagEligible = default(bool?), string Jid = default(string), string Key = default(string), long? LastModified = default(long?), ClubMemberLists Members = default(ClubMemberLists), string Motd = default(string), string Name = default(string), ClubMember Owner = default(ClubMember), ClubPermissions Permissions = default(ClubPermissions), bool? Primary = default(bool?), ClubRole Role = default(ClubRole), string Tag = default(string))
        {
            this.Created = Created;
            this.Description = Description;
            this.IsClubTagEligible = IsClubTagEligible;
            this.Jid = Jid;
            this.Key = Key;
            this.LastModified = LastModified;
            this.Members = Members;
            this.Motd = Motd;
            this.Name = Name;
            this.Owner = Owner;
            this.Permissions = Permissions;
            this.Primary = Primary;
            this.Role = Role;
            this.Tag = Tag;
        }
        
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public long? Created { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets IsClubTagEligible
        /// </summary>
        [DataMember(Name="isClubTagEligible", EmitDefaultValue=false)]
        public bool? IsClubTagEligible { get; set; }

        /// <summary>
        /// Gets or Sets Jid
        /// </summary>
        [DataMember(Name="jid", EmitDefaultValue=false)]
        public string Jid { get; set; }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets LastModified
        /// </summary>
        [DataMember(Name="lastModified", EmitDefaultValue=false)]
        public long? LastModified { get; set; }

        /// <summary>
        /// Gets or Sets Members
        /// </summary>
        [DataMember(Name="members", EmitDefaultValue=false)]
        public ClubMemberLists Members { get; set; }

        /// <summary>
        /// Gets or Sets Motd
        /// </summary>
        [DataMember(Name="motd", EmitDefaultValue=false)]
        public string Motd { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public ClubMember Owner { get; set; }

        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public ClubPermissions Permissions { get; set; }

        /// <summary>
        /// Gets or Sets Primary
        /// </summary>
        [DataMember(Name="primary", EmitDefaultValue=false)]
        public bool? Primary { get; set; }

        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public ClubRole Role { get; set; }

        /// <summary>
        /// Gets or Sets Tag
        /// </summary>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public string Tag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlayerClub {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsClubTagEligible: ").Append(IsClubTagEligible).Append("\n");
            sb.Append("  Jid: ").Append(Jid).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  Motd: ").Append(Motd).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  Primary: ").Append(Primary).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
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
            return this.Equals(obj as PlayerClub);
        }

        /// <summary>
        /// Returns true if PlayerClub instances are equal
        /// </summary>
        /// <param name="other">Instance of PlayerClub to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlayerClub other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.IsClubTagEligible == other.IsClubTagEligible ||
                    this.IsClubTagEligible != null &&
                    this.IsClubTagEligible.Equals(other.IsClubTagEligible)
                ) && 
                (
                    this.Jid == other.Jid ||
                    this.Jid != null &&
                    this.Jid.Equals(other.Jid)
                ) && 
                (
                    this.Key == other.Key ||
                    this.Key != null &&
                    this.Key.Equals(other.Key)
                ) && 
                (
                    this.LastModified == other.LastModified ||
                    this.LastModified != null &&
                    this.LastModified.Equals(other.LastModified)
                ) && 
                (
                    this.Members == other.Members ||
                    this.Members != null &&
                    this.Members.Equals(other.Members)
                ) && 
                (
                    this.Motd == other.Motd ||
                    this.Motd != null &&
                    this.Motd.Equals(other.Motd)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Owner == other.Owner ||
                    this.Owner != null &&
                    this.Owner.Equals(other.Owner)
                ) && 
                (
                    this.Permissions == other.Permissions ||
                    this.Permissions != null &&
                    this.Permissions.Equals(other.Permissions)
                ) && 
                (
                    this.Primary == other.Primary ||
                    this.Primary != null &&
                    this.Primary.Equals(other.Primary)
                ) && 
                (
                    this.Role == other.Role ||
                    this.Role != null &&
                    this.Role.Equals(other.Role)
                ) && 
                (
                    this.Tag == other.Tag ||
                    this.Tag != null &&
                    this.Tag.Equals(other.Tag)
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
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.IsClubTagEligible != null)
                    hash = hash * 59 + this.IsClubTagEligible.GetHashCode();
                if (this.Jid != null)
                    hash = hash * 59 + this.Jid.GetHashCode();
                if (this.Key != null)
                    hash = hash * 59 + this.Key.GetHashCode();
                if (this.LastModified != null)
                    hash = hash * 59 + this.LastModified.GetHashCode();
                if (this.Members != null)
                    hash = hash * 59 + this.Members.GetHashCode();
                if (this.Motd != null)
                    hash = hash * 59 + this.Motd.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Owner != null)
                    hash = hash * 59 + this.Owner.GetHashCode();
                if (this.Permissions != null)
                    hash = hash * 59 + this.Permissions.GetHashCode();
                if (this.Primary != null)
                    hash = hash * 59 + this.Primary.GetHashCode();
                if (this.Role != null)
                    hash = hash * 59 + this.Role.GetHashCode();
                if (this.Tag != null)
                    hash = hash * 59 + this.Tag.GetHashCode();
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