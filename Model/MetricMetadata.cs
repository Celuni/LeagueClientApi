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
    /// MetricMetadata
    /// </summary>
    [DataContract]
    public partial class MetricMetadata :  IEquatable<MetricMetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetricMetadata" /> class.
        /// </summary>
        /// <param name="Alerts">Alerts.</param>
        /// <param name="Category">Category.</param>
        /// <param name="DataType">DataType.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Destination">Destination.</param>
        /// <param name="Info">Info.</param>
        /// <param name="Notify">Notify.</param>
        /// <param name="Period">Period.</param>
        /// <param name="PrettyName">PrettyName.</param>
        /// <param name="Priority">Priority.</param>
        /// <param name="SampleWindowMs">SampleWindowMs.</param>
        /// <param name="TransientAggregation">TransientAggregation.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Units">Units.</param>
        public MetricMetadata(List<MetricMetadataAlert> Alerts = default(List<MetricMetadataAlert>), string Category = default(string), MetricDataType DataType = default(MetricDataType), string Description = default(string), string Destination = default(string), string Info = default(string), MetricMetadataNotify Notify = default(MetricMetadataNotify), int? Period = default(int?), string PrettyName = default(string), MetricPriority Priority = default(MetricPriority), int? SampleWindowMs = default(int?), AggregationType TransientAggregation = default(AggregationType), MetricType Type = default(MetricType), string Units = default(string))
        {
            this.Alerts = Alerts;
            this.Category = Category;
            this.DataType = DataType;
            this.Description = Description;
            this.Destination = Destination;
            this.Info = Info;
            this.Notify = Notify;
            this.Period = Period;
            this.PrettyName = PrettyName;
            this.Priority = Priority;
            this.SampleWindowMs = SampleWindowMs;
            this.TransientAggregation = TransientAggregation;
            this.Type = Type;
            this.Units = Units;
        }
        
        /// <summary>
        /// Gets or Sets Alerts
        /// </summary>
        [DataMember(Name="alerts", EmitDefaultValue=false)]
        public List<MetricMetadataAlert> Alerts { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets DataType
        /// </summary>
        [DataMember(Name="data_type", EmitDefaultValue=false)]
        public MetricDataType DataType { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Destination
        /// </summary>
        [DataMember(Name="destination", EmitDefaultValue=false)]
        public string Destination { get; set; }

        /// <summary>
        /// Gets or Sets Info
        /// </summary>
        [DataMember(Name="info", EmitDefaultValue=false)]
        public string Info { get; set; }

        /// <summary>
        /// Gets or Sets Notify
        /// </summary>
        [DataMember(Name="notify", EmitDefaultValue=false)]
        public MetricMetadataNotify Notify { get; set; }

        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public int? Period { get; set; }

        /// <summary>
        /// Gets or Sets PrettyName
        /// </summary>
        [DataMember(Name="pretty_name", EmitDefaultValue=false)]
        public string PrettyName { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public MetricPriority Priority { get; set; }

        /// <summary>
        /// Gets or Sets SampleWindowMs
        /// </summary>
        [DataMember(Name="sample_window_ms", EmitDefaultValue=false)]
        public int? SampleWindowMs { get; set; }

        /// <summary>
        /// Gets or Sets TransientAggregation
        /// </summary>
        [DataMember(Name="transientAggregation", EmitDefaultValue=false)]
        public AggregationType TransientAggregation { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public MetricType Type { get; set; }

        /// <summary>
        /// Gets or Sets Units
        /// </summary>
        [DataMember(Name="units", EmitDefaultValue=false)]
        public string Units { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetricMetadata {\n");
            sb.Append("  Alerts: ").Append(Alerts).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
            sb.Append("  Notify: ").Append(Notify).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  PrettyName: ").Append(PrettyName).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  SampleWindowMs: ").Append(SampleWindowMs).Append("\n");
            sb.Append("  TransientAggregation: ").Append(TransientAggregation).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
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
            return this.Equals(obj as MetricMetadata);
        }

        /// <summary>
        /// Returns true if MetricMetadata instances are equal
        /// </summary>
        /// <param name="other">Instance of MetricMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetricMetadata other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Alerts == other.Alerts ||
                    this.Alerts != null &&
                    this.Alerts.SequenceEqual(other.Alerts)
                ) && 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) && 
                (
                    this.DataType == other.DataType ||
                    this.DataType != null &&
                    this.DataType.Equals(other.DataType)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Destination == other.Destination ||
                    this.Destination != null &&
                    this.Destination.Equals(other.Destination)
                ) && 
                (
                    this.Info == other.Info ||
                    this.Info != null &&
                    this.Info.Equals(other.Info)
                ) && 
                (
                    this.Notify == other.Notify ||
                    this.Notify != null &&
                    this.Notify.Equals(other.Notify)
                ) && 
                (
                    this.Period == other.Period ||
                    this.Period != null &&
                    this.Period.Equals(other.Period)
                ) && 
                (
                    this.PrettyName == other.PrettyName ||
                    this.PrettyName != null &&
                    this.PrettyName.Equals(other.PrettyName)
                ) && 
                (
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
                ) && 
                (
                    this.SampleWindowMs == other.SampleWindowMs ||
                    this.SampleWindowMs != null &&
                    this.SampleWindowMs.Equals(other.SampleWindowMs)
                ) && 
                (
                    this.TransientAggregation == other.TransientAggregation ||
                    this.TransientAggregation != null &&
                    this.TransientAggregation.Equals(other.TransientAggregation)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Units == other.Units ||
                    this.Units != null &&
                    this.Units.Equals(other.Units)
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
                if (this.Alerts != null)
                    hash = hash * 59 + this.Alerts.GetHashCode();
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                if (this.DataType != null)
                    hash = hash * 59 + this.DataType.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Destination != null)
                    hash = hash * 59 + this.Destination.GetHashCode();
                if (this.Info != null)
                    hash = hash * 59 + this.Info.GetHashCode();
                if (this.Notify != null)
                    hash = hash * 59 + this.Notify.GetHashCode();
                if (this.Period != null)
                    hash = hash * 59 + this.Period.GetHashCode();
                if (this.PrettyName != null)
                    hash = hash * 59 + this.PrettyName.GetHashCode();
                if (this.Priority != null)
                    hash = hash * 59 + this.Priority.GetHashCode();
                if (this.SampleWindowMs != null)
                    hash = hash * 59 + this.SampleWindowMs.GetHashCode();
                if (this.TransientAggregation != null)
                    hash = hash * 59 + this.TransientAggregation.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Units != null)
                    hash = hash * 59 + this.Units.GetHashCode();
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