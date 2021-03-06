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
    /// LolItemSetsItemSet
    /// </summary>
    [DataContract]
    public partial class LolItemSetsItemSet :  IEquatable<LolItemSetsItemSet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolItemSetsItemSet" /> class.
        /// </summary>
        /// <param name="AssociatedChampions">AssociatedChampions.</param>
        /// <param name="AssociatedMaps">AssociatedMaps.</param>
        /// <param name="Blocks">Blocks.</param>
        /// <param name="Map">Map.</param>
        /// <param name="Mode">Mode.</param>
        /// <param name="PreferredItemSlots">PreferredItemSlots.</param>
        /// <param name="Sortrank">Sortrank.</param>
        /// <param name="StartedFrom">StartedFrom.</param>
        /// <param name="Title">Title.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Uid">Uid.</param>
        public LolItemSetsItemSet(List<int?> AssociatedChampions = default(List<int?>), List<int?> AssociatedMaps = default(List<int?>), List<LolItemSetsItemSetBlock> Blocks = default(List<LolItemSetsItemSetBlock>), string Map = default(string), string Mode = default(string), List<LolItemSetsPreferredItemSlot> PreferredItemSlots = default(List<LolItemSetsPreferredItemSlot>), int? Sortrank = default(int?), string StartedFrom = default(string), string Title = default(string), string Type = default(string), string Uid = default(string))
        {
            this.AssociatedChampions = AssociatedChampions;
            this.AssociatedMaps = AssociatedMaps;
            this.Blocks = Blocks;
            this.Map = Map;
            this.Mode = Mode;
            this.PreferredItemSlots = PreferredItemSlots;
            this.Sortrank = Sortrank;
            this.StartedFrom = StartedFrom;
            this.Title = Title;
            this.Type = Type;
            this.Uid = Uid;
        }
        
        /// <summary>
        /// Gets or Sets AssociatedChampions
        /// </summary>
        [DataMember(Name="associatedChampions", EmitDefaultValue=false)]
        public List<int?> AssociatedChampions { get; set; }

        /// <summary>
        /// Gets or Sets AssociatedMaps
        /// </summary>
        [DataMember(Name="associatedMaps", EmitDefaultValue=false)]
        public List<int?> AssociatedMaps { get; set; }

        /// <summary>
        /// Gets or Sets Blocks
        /// </summary>
        [DataMember(Name="blocks", EmitDefaultValue=false)]
        public List<LolItemSetsItemSetBlock> Blocks { get; set; }

        /// <summary>
        /// Gets or Sets Map
        /// </summary>
        [DataMember(Name="map", EmitDefaultValue=false)]
        public string Map { get; set; }

        /// <summary>
        /// Gets or Sets Mode
        /// </summary>
        [DataMember(Name="mode", EmitDefaultValue=false)]
        public string Mode { get; set; }

        /// <summary>
        /// Gets or Sets PreferredItemSlots
        /// </summary>
        [DataMember(Name="preferredItemSlots", EmitDefaultValue=false)]
        public List<LolItemSetsPreferredItemSlot> PreferredItemSlots { get; set; }

        /// <summary>
        /// Gets or Sets Sortrank
        /// </summary>
        [DataMember(Name="sortrank", EmitDefaultValue=false)]
        public int? Sortrank { get; set; }

        /// <summary>
        /// Gets or Sets StartedFrom
        /// </summary>
        [DataMember(Name="startedFrom", EmitDefaultValue=false)]
        public string StartedFrom { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Uid
        /// </summary>
        [DataMember(Name="uid", EmitDefaultValue=false)]
        public string Uid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolItemSetsItemSet {\n");
            sb.Append("  AssociatedChampions: ").Append(AssociatedChampions).Append("\n");
            sb.Append("  AssociatedMaps: ").Append(AssociatedMaps).Append("\n");
            sb.Append("  Blocks: ").Append(Blocks).Append("\n");
            sb.Append("  Map: ").Append(Map).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  PreferredItemSlots: ").Append(PreferredItemSlots).Append("\n");
            sb.Append("  Sortrank: ").Append(Sortrank).Append("\n");
            sb.Append("  StartedFrom: ").Append(StartedFrom).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
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
            return this.Equals(obj as LolItemSetsItemSet);
        }

        /// <summary>
        /// Returns true if LolItemSetsItemSet instances are equal
        /// </summary>
        /// <param name="other">Instance of LolItemSetsItemSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolItemSetsItemSet other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AssociatedChampions == other.AssociatedChampions ||
                    this.AssociatedChampions != null &&
                    this.AssociatedChampions.SequenceEqual(other.AssociatedChampions)
                ) && 
                (
                    this.AssociatedMaps == other.AssociatedMaps ||
                    this.AssociatedMaps != null &&
                    this.AssociatedMaps.SequenceEqual(other.AssociatedMaps)
                ) && 
                (
                    this.Blocks == other.Blocks ||
                    this.Blocks != null &&
                    this.Blocks.SequenceEqual(other.Blocks)
                ) && 
                (
                    this.Map == other.Map ||
                    this.Map != null &&
                    this.Map.Equals(other.Map)
                ) && 
                (
                    this.Mode == other.Mode ||
                    this.Mode != null &&
                    this.Mode.Equals(other.Mode)
                ) && 
                (
                    this.PreferredItemSlots == other.PreferredItemSlots ||
                    this.PreferredItemSlots != null &&
                    this.PreferredItemSlots.SequenceEqual(other.PreferredItemSlots)
                ) && 
                (
                    this.Sortrank == other.Sortrank ||
                    this.Sortrank != null &&
                    this.Sortrank.Equals(other.Sortrank)
                ) && 
                (
                    this.StartedFrom == other.StartedFrom ||
                    this.StartedFrom != null &&
                    this.StartedFrom.Equals(other.StartedFrom)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Uid == other.Uid ||
                    this.Uid != null &&
                    this.Uid.Equals(other.Uid)
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
                if (this.AssociatedChampions != null)
                    hash = hash * 59 + this.AssociatedChampions.GetHashCode();
                if (this.AssociatedMaps != null)
                    hash = hash * 59 + this.AssociatedMaps.GetHashCode();
                if (this.Blocks != null)
                    hash = hash * 59 + this.Blocks.GetHashCode();
                if (this.Map != null)
                    hash = hash * 59 + this.Map.GetHashCode();
                if (this.Mode != null)
                    hash = hash * 59 + this.Mode.GetHashCode();
                if (this.PreferredItemSlots != null)
                    hash = hash * 59 + this.PreferredItemSlots.GetHashCode();
                if (this.Sortrank != null)
                    hash = hash * 59 + this.Sortrank.GetHashCode();
                if (this.StartedFrom != null)
                    hash = hash * 59 + this.StartedFrom.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Uid != null)
                    hash = hash * 59 + this.Uid.GetHashCode();
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
