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
    /// PatcherProductState
    /// </summary>
    [DataContract]
    public partial class PatcherProductState :  IEquatable<PatcherProductState>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatcherProductState" /> class.
        /// </summary>
        /// <param name="Action">Action.</param>
        /// <param name="Components">Components.</param>
        /// <param name="Id">Id.</param>
        /// <param name="IsCorrupted">IsCorrupted.</param>
        /// <param name="IsStopped">IsStopped.</param>
        /// <param name="IsUpToDate">IsUpToDate.</param>
        /// <param name="IsUpdateAvailable">IsUpdateAvailable.</param>
        /// <param name="PercentPatched">PercentPatched.</param>
        public PatcherProductState(PatcherComponentStateAction Action = default(PatcherComponentStateAction), List<PatcherComponentState> Components = default(List<PatcherComponentState>), string Id = default(string), bool? IsCorrupted = default(bool?), bool? IsStopped = default(bool?), bool? IsUpToDate = default(bool?), bool? IsUpdateAvailable = default(bool?), double? PercentPatched = default(double?))
        {
            this.Action = Action;
            this.Components = Components;
            this.Id = Id;
            this.IsCorrupted = IsCorrupted;
            this.IsStopped = IsStopped;
            this.IsUpToDate = IsUpToDate;
            this.IsUpdateAvailable = IsUpdateAvailable;
            this.PercentPatched = PercentPatched;
        }
        
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public PatcherComponentStateAction Action { get; set; }

        /// <summary>
        /// Gets or Sets Components
        /// </summary>
        [DataMember(Name="components", EmitDefaultValue=false)]
        public List<PatcherComponentState> Components { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets IsCorrupted
        /// </summary>
        [DataMember(Name="isCorrupted", EmitDefaultValue=false)]
        public bool? IsCorrupted { get; set; }

        /// <summary>
        /// Gets or Sets IsStopped
        /// </summary>
        [DataMember(Name="isStopped", EmitDefaultValue=false)]
        public bool? IsStopped { get; set; }

        /// <summary>
        /// Gets or Sets IsUpToDate
        /// </summary>
        [DataMember(Name="isUpToDate", EmitDefaultValue=false)]
        public bool? IsUpToDate { get; set; }

        /// <summary>
        /// Gets or Sets IsUpdateAvailable
        /// </summary>
        [DataMember(Name="isUpdateAvailable", EmitDefaultValue=false)]
        public bool? IsUpdateAvailable { get; set; }

        /// <summary>
        /// Gets or Sets PercentPatched
        /// </summary>
        [DataMember(Name="percentPatched", EmitDefaultValue=false)]
        public double? PercentPatched { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatcherProductState {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Components: ").Append(Components).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsCorrupted: ").Append(IsCorrupted).Append("\n");
            sb.Append("  IsStopped: ").Append(IsStopped).Append("\n");
            sb.Append("  IsUpToDate: ").Append(IsUpToDate).Append("\n");
            sb.Append("  IsUpdateAvailable: ").Append(IsUpdateAvailable).Append("\n");
            sb.Append("  PercentPatched: ").Append(PercentPatched).Append("\n");
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
            return this.Equals(obj as PatcherProductState);
        }

        /// <summary>
        /// Returns true if PatcherProductState instances are equal
        /// </summary>
        /// <param name="other">Instance of PatcherProductState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatcherProductState other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) && 
                (
                    this.Components == other.Components ||
                    this.Components != null &&
                    this.Components.SequenceEqual(other.Components)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IsCorrupted == other.IsCorrupted ||
                    this.IsCorrupted != null &&
                    this.IsCorrupted.Equals(other.IsCorrupted)
                ) && 
                (
                    this.IsStopped == other.IsStopped ||
                    this.IsStopped != null &&
                    this.IsStopped.Equals(other.IsStopped)
                ) && 
                (
                    this.IsUpToDate == other.IsUpToDate ||
                    this.IsUpToDate != null &&
                    this.IsUpToDate.Equals(other.IsUpToDate)
                ) && 
                (
                    this.IsUpdateAvailable == other.IsUpdateAvailable ||
                    this.IsUpdateAvailable != null &&
                    this.IsUpdateAvailable.Equals(other.IsUpdateAvailable)
                ) && 
                (
                    this.PercentPatched == other.PercentPatched ||
                    this.PercentPatched != null &&
                    this.PercentPatched.Equals(other.PercentPatched)
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
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
                if (this.Components != null)
                    hash = hash * 59 + this.Components.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.IsCorrupted != null)
                    hash = hash * 59 + this.IsCorrupted.GetHashCode();
                if (this.IsStopped != null)
                    hash = hash * 59 + this.IsStopped.GetHashCode();
                if (this.IsUpToDate != null)
                    hash = hash * 59 + this.IsUpToDate.GetHashCode();
                if (this.IsUpdateAvailable != null)
                    hash = hash * 59 + this.IsUpdateAvailable.GetHashCode();
                if (this.PercentPatched != null)
                    hash = hash * 59 + this.PercentPatched.GetHashCode();
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
