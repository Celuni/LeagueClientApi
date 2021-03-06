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
    /// LolLootLootItemGdsResource
    /// </summary>
    [DataContract]
    public partial class LolLootLootItemGdsResource :  IEquatable<LolLootLootItemGdsResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolLootLootItemGdsResource" /> class.
        /// </summary>
        /// <param name="AutoRedeem">AutoRedeem.</param>
        /// <param name="Description">Description.</param>
        /// <param name="EndDate">EndDate.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Image">Image.</param>
        /// <param name="LifetimeMax">LifetimeMax.</param>
        /// <param name="MappedStoreId">MappedStoreId.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Rarity">Rarity.</param>
        /// <param name="StartDate">StartDate.</param>
        /// <param name="Type">Type.</param>
        public LolLootLootItemGdsResource(bool? AutoRedeem = default(bool?), string Description = default(string), string EndDate = default(string), string Id = default(string), string Image = default(string), int? LifetimeMax = default(int?), int? MappedStoreId = default(int?), string Name = default(string), LolLootLootRarity Rarity = default(LolLootLootRarity), string StartDate = default(string), LolLootLootType Type = default(LolLootLootType))
        {
            this.AutoRedeem = AutoRedeem;
            this.Description = Description;
            this.EndDate = EndDate;
            this.Id = Id;
            this.Image = Image;
            this.LifetimeMax = LifetimeMax;
            this.MappedStoreId = MappedStoreId;
            this.Name = Name;
            this.Rarity = Rarity;
            this.StartDate = StartDate;
            this.Type = Type;
        }
        
        /// <summary>
        /// Gets or Sets AutoRedeem
        /// </summary>
        [DataMember(Name="autoRedeem", EmitDefaultValue=false)]
        public bool? AutoRedeem { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public string Image { get; set; }

        /// <summary>
        /// Gets or Sets LifetimeMax
        /// </summary>
        [DataMember(Name="lifetimeMax", EmitDefaultValue=false)]
        public int? LifetimeMax { get; set; }

        /// <summary>
        /// Gets or Sets MappedStoreId
        /// </summary>
        [DataMember(Name="mappedStoreId", EmitDefaultValue=false)]
        public int? MappedStoreId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Rarity
        /// </summary>
        [DataMember(Name="rarity", EmitDefaultValue=false)]
        public LolLootLootRarity Rarity { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public LolLootLootType Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolLootLootItemGdsResource {\n");
            sb.Append("  AutoRedeem: ").Append(AutoRedeem).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  LifetimeMax: ").Append(LifetimeMax).Append("\n");
            sb.Append("  MappedStoreId: ").Append(MappedStoreId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Rarity: ").Append(Rarity).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as LolLootLootItemGdsResource);
        }

        /// <summary>
        /// Returns true if LolLootLootItemGdsResource instances are equal
        /// </summary>
        /// <param name="other">Instance of LolLootLootItemGdsResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolLootLootItemGdsResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AutoRedeem == other.AutoRedeem ||
                    this.AutoRedeem != null &&
                    this.AutoRedeem.Equals(other.AutoRedeem)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Image == other.Image ||
                    this.Image != null &&
                    this.Image.Equals(other.Image)
                ) && 
                (
                    this.LifetimeMax == other.LifetimeMax ||
                    this.LifetimeMax != null &&
                    this.LifetimeMax.Equals(other.LifetimeMax)
                ) && 
                (
                    this.MappedStoreId == other.MappedStoreId ||
                    this.MappedStoreId != null &&
                    this.MappedStoreId.Equals(other.MappedStoreId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Rarity == other.Rarity ||
                    this.Rarity != null &&
                    this.Rarity.Equals(other.Rarity)
                ) && 
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.AutoRedeem != null)
                    hash = hash * 59 + this.AutoRedeem.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Image != null)
                    hash = hash * 59 + this.Image.GetHashCode();
                if (this.LifetimeMax != null)
                    hash = hash * 59 + this.LifetimeMax.GetHashCode();
                if (this.MappedStoreId != null)
                    hash = hash * 59 + this.MappedStoreId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Rarity != null)
                    hash = hash * 59 + this.Rarity.GetHashCode();
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
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
