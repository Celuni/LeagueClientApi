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
    /// MetricMetadataHipchatNotification
    /// </summary>
    [DataContract]
    public partial class MetricMetadataHipchatNotification :  IEquatable<MetricMetadataHipchatNotification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetricMetadataHipchatNotification" /> class.
        /// </summary>
        /// <param name="Roomid">Roomid.</param>
        /// <param name="Tags">Tags.</param>
        public MetricMetadataHipchatNotification(string Roomid = default(string), string Tags = default(string))
        {
            this.Roomid = Roomid;
            this.Tags = Tags;
        }
        
        /// <summary>
        /// Gets or Sets Roomid
        /// </summary>
        [DataMember(Name="roomid", EmitDefaultValue=false)]
        public string Roomid { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public string Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetricMetadataHipchatNotification {\n");
            sb.Append("  Roomid: ").Append(Roomid).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return this.Equals(obj as MetricMetadataHipchatNotification);
        }

        /// <summary>
        /// Returns true if MetricMetadataHipchatNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of MetricMetadataHipchatNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetricMetadataHipchatNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Roomid == other.Roomid ||
                    this.Roomid != null &&
                    this.Roomid.Equals(other.Roomid)
                ) && 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.Equals(other.Tags)
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
                if (this.Roomid != null)
                    hash = hash * 59 + this.Roomid.GetHashCode();
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
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