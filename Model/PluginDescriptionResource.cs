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
    /// PluginDescriptionResource
    /// </summary>
    [DataContract]
    public partial class PluginDescriptionResource :  IEquatable<PluginDescriptionResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PluginDescriptionResource" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="PluginDependencies">PluginDependencies.</param>
        /// <param name="RiotMeta">RiotMeta.</param>
        /// <param name="Version">Version.</param>
        public PluginDescriptionResource(string Name = default(string), Dictionary<string, string> PluginDependencies = default(Dictionary<string, string>), PluginMetadataResource RiotMeta = default(PluginMetadataResource), string Version = default(string))
        {
            this.Name = Name;
            this.PluginDependencies = PluginDependencies;
            this.RiotMeta = RiotMeta;
            this.Version = Version;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets PluginDependencies
        /// </summary>
        [DataMember(Name="pluginDependencies", EmitDefaultValue=false)]
        public Dictionary<string, string> PluginDependencies { get; set; }

        /// <summary>
        /// Gets or Sets RiotMeta
        /// </summary>
        [DataMember(Name="riotMeta", EmitDefaultValue=false)]
        public PluginMetadataResource RiotMeta { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PluginDescriptionResource {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PluginDependencies: ").Append(PluginDependencies).Append("\n");
            sb.Append("  RiotMeta: ").Append(RiotMeta).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(obj as PluginDescriptionResource);
        }

        /// <summary>
        /// Returns true if PluginDescriptionResource instances are equal
        /// </summary>
        /// <param name="other">Instance of PluginDescriptionResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PluginDescriptionResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.PluginDependencies == other.PluginDependencies ||
                    this.PluginDependencies != null &&
                    this.PluginDependencies.SequenceEqual(other.PluginDependencies)
                ) && 
                (
                    this.RiotMeta == other.RiotMeta ||
                    this.RiotMeta != null &&
                    this.RiotMeta.Equals(other.RiotMeta)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.PluginDependencies != null)
                    hash = hash * 59 + this.PluginDependencies.GetHashCode();
                if (this.RiotMeta != null)
                    hash = hash * 59 + this.RiotMeta.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
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
