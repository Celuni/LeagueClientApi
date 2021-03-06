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
    /// LolFeaturedModesQueue
    /// </summary>
    [DataContract]
    public partial class LolFeaturedModesQueue :  IEquatable<LolFeaturedModesQueue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolFeaturedModesQueue" /> class.
        /// </summary>
        /// <param name="Category">Category.</param>
        /// <param name="GameMode">GameMode.</param>
        /// <param name="GameMutator">GameMutator.</param>
        /// <param name="Id">Id.</param>
        /// <param name="LastToggledOffTime">LastToggledOffTime.</param>
        /// <param name="LastToggledOnTime">LastToggledOnTime.</param>
        /// <param name="MapId">MapId.</param>
        /// <param name="Name">Name.</param>
        /// <param name="QueueAvailability">QueueAvailability.</param>
        public LolFeaturedModesQueue(LolFeaturedModesQueueGameCategory Category = default(LolFeaturedModesQueueGameCategory), string GameMode = default(string), string GameMutator = default(string), int? Id = default(int?), long? LastToggledOffTime = default(long?), long? LastToggledOnTime = default(long?), int? MapId = default(int?), string Name = default(string), LolFeaturedModesQueueAvailability QueueAvailability = default(LolFeaturedModesQueueAvailability))
        {
            this.Category = Category;
            this.GameMode = GameMode;
            this.GameMutator = GameMutator;
            this.Id = Id;
            this.LastToggledOffTime = LastToggledOffTime;
            this.LastToggledOnTime = LastToggledOnTime;
            this.MapId = MapId;
            this.Name = Name;
            this.QueueAvailability = QueueAvailability;
        }
        
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public LolFeaturedModesQueueGameCategory Category { get; set; }

        /// <summary>
        /// Gets or Sets GameMode
        /// </summary>
        [DataMember(Name="gameMode", EmitDefaultValue=false)]
        public string GameMode { get; set; }

        /// <summary>
        /// Gets or Sets GameMutator
        /// </summary>
        [DataMember(Name="gameMutator", EmitDefaultValue=false)]
        public string GameMutator { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets LastToggledOffTime
        /// </summary>
        [DataMember(Name="lastToggledOffTime", EmitDefaultValue=false)]
        public long? LastToggledOffTime { get; set; }

        /// <summary>
        /// Gets or Sets LastToggledOnTime
        /// </summary>
        [DataMember(Name="lastToggledOnTime", EmitDefaultValue=false)]
        public long? LastToggledOnTime { get; set; }

        /// <summary>
        /// Gets or Sets MapId
        /// </summary>
        [DataMember(Name="mapId", EmitDefaultValue=false)]
        public int? MapId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets QueueAvailability
        /// </summary>
        [DataMember(Name="queueAvailability", EmitDefaultValue=false)]
        public LolFeaturedModesQueueAvailability QueueAvailability { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolFeaturedModesQueue {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  GameMode: ").Append(GameMode).Append("\n");
            sb.Append("  GameMutator: ").Append(GameMutator).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastToggledOffTime: ").Append(LastToggledOffTime).Append("\n");
            sb.Append("  LastToggledOnTime: ").Append(LastToggledOnTime).Append("\n");
            sb.Append("  MapId: ").Append(MapId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  QueueAvailability: ").Append(QueueAvailability).Append("\n");
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
            return this.Equals(obj as LolFeaturedModesQueue);
        }

        /// <summary>
        /// Returns true if LolFeaturedModesQueue instances are equal
        /// </summary>
        /// <param name="other">Instance of LolFeaturedModesQueue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolFeaturedModesQueue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) && 
                (
                    this.GameMode == other.GameMode ||
                    this.GameMode != null &&
                    this.GameMode.Equals(other.GameMode)
                ) && 
                (
                    this.GameMutator == other.GameMutator ||
                    this.GameMutator != null &&
                    this.GameMutator.Equals(other.GameMutator)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LastToggledOffTime == other.LastToggledOffTime ||
                    this.LastToggledOffTime != null &&
                    this.LastToggledOffTime.Equals(other.LastToggledOffTime)
                ) && 
                (
                    this.LastToggledOnTime == other.LastToggledOnTime ||
                    this.LastToggledOnTime != null &&
                    this.LastToggledOnTime.Equals(other.LastToggledOnTime)
                ) && 
                (
                    this.MapId == other.MapId ||
                    this.MapId != null &&
                    this.MapId.Equals(other.MapId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.QueueAvailability == other.QueueAvailability ||
                    this.QueueAvailability != null &&
                    this.QueueAvailability.Equals(other.QueueAvailability)
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
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                if (this.GameMode != null)
                    hash = hash * 59 + this.GameMode.GetHashCode();
                if (this.GameMutator != null)
                    hash = hash * 59 + this.GameMutator.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.LastToggledOffTime != null)
                    hash = hash * 59 + this.LastToggledOffTime.GetHashCode();
                if (this.LastToggledOnTime != null)
                    hash = hash * 59 + this.LastToggledOnTime.GetHashCode();
                if (this.MapId != null)
                    hash = hash * 59 + this.MapId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.QueueAvailability != null)
                    hash = hash * 59 + this.QueueAvailability.GetHashCode();
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
