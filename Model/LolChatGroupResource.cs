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
    /// LolChatGroupResource
    /// </summary>
    [DataContract]
    public partial class LolChatGroupResource :  IEquatable<LolChatGroupResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolChatGroupResource" /> class.
        /// </summary>
        /// <param name="Collapsed">Collapsed.</param>
        /// <param name="Id">Id.</param>
        /// <param name="IsMetaGroup">IsMetaGroup.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Priority">Priority.</param>
        public LolChatGroupResource(bool? Collapsed = default(bool?), int? Id = default(int?), bool? IsMetaGroup = default(bool?), string Name = default(string), int? Priority = default(int?))
        {
            this.Collapsed = Collapsed;
            this.Id = Id;
            this.IsMetaGroup = IsMetaGroup;
            this.Name = Name;
            this.Priority = Priority;
        }
        
        /// <summary>
        /// Gets or Sets Collapsed
        /// </summary>
        [DataMember(Name="collapsed", EmitDefaultValue=false)]
        public bool? Collapsed { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets IsMetaGroup
        /// </summary>
        [DataMember(Name="isMetaGroup", EmitDefaultValue=false)]
        public bool? IsMetaGroup { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolChatGroupResource {\n");
            sb.Append("  Collapsed: ").Append(Collapsed).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsMetaGroup: ").Append(IsMetaGroup).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
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
            return this.Equals(obj as LolChatGroupResource);
        }

        /// <summary>
        /// Returns true if LolChatGroupResource instances are equal
        /// </summary>
        /// <param name="other">Instance of LolChatGroupResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolChatGroupResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Collapsed == other.Collapsed ||
                    this.Collapsed != null &&
                    this.Collapsed.Equals(other.Collapsed)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IsMetaGroup == other.IsMetaGroup ||
                    this.IsMetaGroup != null &&
                    this.IsMetaGroup.Equals(other.IsMetaGroup)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
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
                if (this.Collapsed != null)
                    hash = hash * 59 + this.Collapsed.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.IsMetaGroup != null)
                    hash = hash * 59 + this.IsMetaGroup.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Priority != null)
                    hash = hash * 59 + this.Priority.GetHashCode();
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