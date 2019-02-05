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
    /// LolLootCollectionsChampionSkinMinimal
    /// </summary>
    [DataContract]
    public partial class LolLootCollectionsChampionSkinMinimal :  IEquatable<LolLootCollectionsChampionSkinMinimal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolLootCollectionsChampionSkinMinimal" /> class.
        /// </summary>
        /// <param name="ChampionId">ChampionId.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Ownership">Ownership.</param>
        /// <param name="SplashPath">SplashPath.</param>
        /// <param name="TilePath">TilePath.</param>
        public LolLootCollectionsChampionSkinMinimal(int? ChampionId = default(int?), int? Id = default(int?), string Name = default(string), LolLootCollectionsOwnership Ownership = default(LolLootCollectionsOwnership), string SplashPath = default(string), string TilePath = default(string))
        {
            this.ChampionId = ChampionId;
            this.Id = Id;
            this.Name = Name;
            this.Ownership = Ownership;
            this.SplashPath = SplashPath;
            this.TilePath = TilePath;
        }
        
        /// <summary>
        /// Gets or Sets ChampionId
        /// </summary>
        [DataMember(Name="championId", EmitDefaultValue=false)]
        public int? ChampionId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Ownership
        /// </summary>
        [DataMember(Name="ownership", EmitDefaultValue=false)]
        public LolLootCollectionsOwnership Ownership { get; set; }

        /// <summary>
        /// Gets or Sets SplashPath
        /// </summary>
        [DataMember(Name="splashPath", EmitDefaultValue=false)]
        public string SplashPath { get; set; }

        /// <summary>
        /// Gets or Sets TilePath
        /// </summary>
        [DataMember(Name="tilePath", EmitDefaultValue=false)]
        public string TilePath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolLootCollectionsChampionSkinMinimal {\n");
            sb.Append("  ChampionId: ").Append(ChampionId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Ownership: ").Append(Ownership).Append("\n");
            sb.Append("  SplashPath: ").Append(SplashPath).Append("\n");
            sb.Append("  TilePath: ").Append(TilePath).Append("\n");
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
            return this.Equals(obj as LolLootCollectionsChampionSkinMinimal);
        }

        /// <summary>
        /// Returns true if LolLootCollectionsChampionSkinMinimal instances are equal
        /// </summary>
        /// <param name="other">Instance of LolLootCollectionsChampionSkinMinimal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolLootCollectionsChampionSkinMinimal other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ChampionId == other.ChampionId ||
                    this.ChampionId != null &&
                    this.ChampionId.Equals(other.ChampionId)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Ownership == other.Ownership ||
                    this.Ownership != null &&
                    this.Ownership.Equals(other.Ownership)
                ) && 
                (
                    this.SplashPath == other.SplashPath ||
                    this.SplashPath != null &&
                    this.SplashPath.Equals(other.SplashPath)
                ) && 
                (
                    this.TilePath == other.TilePath ||
                    this.TilePath != null &&
                    this.TilePath.Equals(other.TilePath)
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
                if (this.ChampionId != null)
                    hash = hash * 59 + this.ChampionId.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Ownership != null)
                    hash = hash * 59 + this.Ownership.GetHashCode();
                if (this.SplashPath != null)
                    hash = hash * 59 + this.SplashPath.GetHashCode();
                if (this.TilePath != null)
                    hash = hash * 59 + this.TilePath.GetHashCode();
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