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
    /// RecofrienderContactResource
    /// </summary>
    [DataContract]
    public partial class RecofrienderContactResource :  IEquatable<RecofrienderContactResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecofrienderContactResource" /> class.
        /// </summary>
        /// <param name="AccountId">AccountId.</param>
        /// <param name="Action">Action.</param>
        /// <param name="DisplayState">DisplayState.</param>
        /// <param name="FriendState">FriendState.</param>
        /// <param name="ImageUrl">ImageUrl.</param>
        /// <param name="Name">Name.</param>
        /// <param name="RecommendScore">RecommendScore.</param>
        /// <param name="Source">Source.</param>
        /// <param name="SummonerId">SummonerId.</param>
        public RecofrienderContactResource(long? AccountId = default(long?), string Action = default(string), string DisplayState = default(string), RecofrienderFriendState FriendState = default(RecofrienderFriendState), string ImageUrl = default(string), string Name = default(string), long? RecommendScore = default(long?), string Source = default(string), long? SummonerId = default(long?))
        {
            this.AccountId = AccountId;
            this.Action = Action;
            this.DisplayState = DisplayState;
            this.FriendState = FriendState;
            this.ImageUrl = ImageUrl;
            this.Name = Name;
            this.RecommendScore = RecommendScore;
            this.Source = Source;
            this.SummonerId = SummonerId;
        }
        
        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public long? AccountId { get; set; }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }

        /// <summary>
        /// Gets or Sets DisplayState
        /// </summary>
        [DataMember(Name="displayState", EmitDefaultValue=false)]
        public string DisplayState { get; set; }

        /// <summary>
        /// Gets or Sets FriendState
        /// </summary>
        [DataMember(Name="friendState", EmitDefaultValue=false)]
        public RecofrienderFriendState FriendState { get; set; }

        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name="imageUrl", EmitDefaultValue=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets RecommendScore
        /// </summary>
        [DataMember(Name="recommendScore", EmitDefaultValue=false)]
        public long? RecommendScore { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }

        /// <summary>
        /// Gets or Sets SummonerId
        /// </summary>
        [DataMember(Name="summonerId", EmitDefaultValue=false)]
        public long? SummonerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecofrienderContactResource {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  DisplayState: ").Append(DisplayState).Append("\n");
            sb.Append("  FriendState: ").Append(FriendState).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RecommendScore: ").Append(RecommendScore).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  SummonerId: ").Append(SummonerId).Append("\n");
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
            return this.Equals(obj as RecofrienderContactResource);
        }

        /// <summary>
        /// Returns true if RecofrienderContactResource instances are equal
        /// </summary>
        /// <param name="other">Instance of RecofrienderContactResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecofrienderContactResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) && 
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) && 
                (
                    this.DisplayState == other.DisplayState ||
                    this.DisplayState != null &&
                    this.DisplayState.Equals(other.DisplayState)
                ) && 
                (
                    this.FriendState == other.FriendState ||
                    this.FriendState != null &&
                    this.FriendState.Equals(other.FriendState)
                ) && 
                (
                    this.ImageUrl == other.ImageUrl ||
                    this.ImageUrl != null &&
                    this.ImageUrl.Equals(other.ImageUrl)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.RecommendScore == other.RecommendScore ||
                    this.RecommendScore != null &&
                    this.RecommendScore.Equals(other.RecommendScore)
                ) && 
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
                ) && 
                (
                    this.SummonerId == other.SummonerId ||
                    this.SummonerId != null &&
                    this.SummonerId.Equals(other.SummonerId)
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
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
                if (this.DisplayState != null)
                    hash = hash * 59 + this.DisplayState.GetHashCode();
                if (this.FriendState != null)
                    hash = hash * 59 + this.FriendState.GetHashCode();
                if (this.ImageUrl != null)
                    hash = hash * 59 + this.ImageUrl.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.RecommendScore != null)
                    hash = hash * 59 + this.RecommendScore.GetHashCode();
                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();
                if (this.SummonerId != null)
                    hash = hash * 59 + this.SummonerId.GetHashCode();
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