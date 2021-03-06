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
    /// PluginMetadataResource
    /// </summary>
    [DataContract]
    public partial class PluginMetadataResource :  IEquatable<PluginMetadataResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PluginMetadataResource" /> class.
        /// </summary>
        /// <param name="App">App.</param>
        /// <param name="Feature">Feature.</param>
        /// <param name="GlobalAssetBundles">GlobalAssetBundles.</param>
        /// <param name="HasBundledAssets">HasBundledAssets.</param>
        /// <param name="Implements">Implements.</param>
        /// <param name="PerLocaleAssetBundles">PerLocaleAssetBundles.</param>
        /// <param name="Subtype">Subtype.</param>
        /// <param name="Threading">Threading.</param>
        /// <param name="Type">Type.</param>
        public PluginMetadataResource(string App = default(string), string Feature = default(string), List<string> GlobalAssetBundles = default(List<string>), bool? HasBundledAssets = default(bool?), Dictionary<string, string> Implements = default(Dictionary<string, string>), Dictionary<string, Object> PerLocaleAssetBundles = default(Dictionary<string, Object>), string Subtype = default(string), PluginThreadingModel Threading = default(PluginThreadingModel), string Type = default(string))
        {
            this.App = App;
            this.Feature = Feature;
            this.GlobalAssetBundles = GlobalAssetBundles;
            this.HasBundledAssets = HasBundledAssets;
            this.Implements = Implements;
            this.PerLocaleAssetBundles = PerLocaleAssetBundles;
            this.Subtype = Subtype;
            this.Threading = Threading;
            this.Type = Type;
        }
        
        /// <summary>
        /// Gets or Sets App
        /// </summary>
        [DataMember(Name="app", EmitDefaultValue=false)]
        public string App { get; set; }

        /// <summary>
        /// Gets or Sets Feature
        /// </summary>
        [DataMember(Name="feature", EmitDefaultValue=false)]
        public string Feature { get; set; }

        /// <summary>
        /// Gets or Sets GlobalAssetBundles
        /// </summary>
        [DataMember(Name="globalAssetBundles", EmitDefaultValue=false)]
        public List<string> GlobalAssetBundles { get; set; }

        /// <summary>
        /// Gets or Sets HasBundledAssets
        /// </summary>
        [DataMember(Name="hasBundledAssets", EmitDefaultValue=false)]
        public bool? HasBundledAssets { get; set; }

        /// <summary>
        /// Gets or Sets Implements
        /// </summary>
        [DataMember(Name="implements", EmitDefaultValue=false)]
        public Dictionary<string, string> Implements { get; set; }

        /// <summary>
        /// Gets or Sets PerLocaleAssetBundles
        /// </summary>
        [DataMember(Name="perLocaleAssetBundles", EmitDefaultValue=false)]
        public Dictionary<string, Object> PerLocaleAssetBundles { get; set; }

        /// <summary>
        /// Gets or Sets Subtype
        /// </summary>
        [DataMember(Name="subtype", EmitDefaultValue=false)]
        public string Subtype { get; set; }

        /// <summary>
        /// Gets or Sets Threading
        /// </summary>
        [DataMember(Name="threading", EmitDefaultValue=false)]
        public PluginThreadingModel Threading { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PluginMetadataResource {\n");
            sb.Append("  App: ").Append(App).Append("\n");
            sb.Append("  Feature: ").Append(Feature).Append("\n");
            sb.Append("  GlobalAssetBundles: ").Append(GlobalAssetBundles).Append("\n");
            sb.Append("  HasBundledAssets: ").Append(HasBundledAssets).Append("\n");
            sb.Append("  Implements: ").Append(Implements).Append("\n");
            sb.Append("  PerLocaleAssetBundles: ").Append(PerLocaleAssetBundles).Append("\n");
            sb.Append("  Subtype: ").Append(Subtype).Append("\n");
            sb.Append("  Threading: ").Append(Threading).Append("\n");
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
            return this.Equals(obj as PluginMetadataResource);
        }

        /// <summary>
        /// Returns true if PluginMetadataResource instances are equal
        /// </summary>
        /// <param name="other">Instance of PluginMetadataResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PluginMetadataResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.App == other.App ||
                    this.App != null &&
                    this.App.Equals(other.App)
                ) && 
                (
                    this.Feature == other.Feature ||
                    this.Feature != null &&
                    this.Feature.Equals(other.Feature)
                ) && 
                (
                    this.GlobalAssetBundles == other.GlobalAssetBundles ||
                    this.GlobalAssetBundles != null &&
                    this.GlobalAssetBundles.SequenceEqual(other.GlobalAssetBundles)
                ) && 
                (
                    this.HasBundledAssets == other.HasBundledAssets ||
                    this.HasBundledAssets != null &&
                    this.HasBundledAssets.Equals(other.HasBundledAssets)
                ) && 
                (
                    this.Implements == other.Implements ||
                    this.Implements != null &&
                    this.Implements.SequenceEqual(other.Implements)
                ) && 
                (
                    this.PerLocaleAssetBundles == other.PerLocaleAssetBundles ||
                    this.PerLocaleAssetBundles != null &&
                    this.PerLocaleAssetBundles.SequenceEqual(other.PerLocaleAssetBundles)
                ) && 
                (
                    this.Subtype == other.Subtype ||
                    this.Subtype != null &&
                    this.Subtype.Equals(other.Subtype)
                ) && 
                (
                    this.Threading == other.Threading ||
                    this.Threading != null &&
                    this.Threading.Equals(other.Threading)
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
                if (this.App != null)
                    hash = hash * 59 + this.App.GetHashCode();
                if (this.Feature != null)
                    hash = hash * 59 + this.Feature.GetHashCode();
                if (this.GlobalAssetBundles != null)
                    hash = hash * 59 + this.GlobalAssetBundles.GetHashCode();
                if (this.HasBundledAssets != null)
                    hash = hash * 59 + this.HasBundledAssets.GetHashCode();
                if (this.Implements != null)
                    hash = hash * 59 + this.Implements.GetHashCode();
                if (this.PerLocaleAssetBundles != null)
                    hash = hash * 59 + this.PerLocaleAssetBundles.GetHashCode();
                if (this.Subtype != null)
                    hash = hash * 59 + this.Subtype.GetHashCode();
                if (this.Threading != null)
                    hash = hash * 59 + this.Threading.GetHashCode();
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
