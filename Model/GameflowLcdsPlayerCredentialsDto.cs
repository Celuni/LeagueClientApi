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
    /// GameflowLcdsPlayerCredentialsDto
    /// </summary>
    [DataContract]
    public partial class GameflowLcdsPlayerCredentialsDto :  IEquatable<GameflowLcdsPlayerCredentialsDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameflowLcdsPlayerCredentialsDto" /> class.
        /// </summary>
        /// <param name="EncryptionKey">EncryptionKey.</param>
        /// <param name="GameId">GameId.</param>
        /// <param name="Observer">Observer.</param>
        /// <param name="ObserverEncryptionKey">ObserverEncryptionKey.</param>
        /// <param name="ObserverServerIp">ObserverServerIp.</param>
        /// <param name="ObserverServerPort">ObserverServerPort.</param>
        /// <param name="ServerIp">ServerIp.</param>
        /// <param name="ServerPort">ServerPort.</param>
        /// <param name="SummonerId">SummonerId.</param>
        public GameflowLcdsPlayerCredentialsDto(string EncryptionKey = default(string), long? GameId = default(long?), bool? Observer = default(bool?), string ObserverEncryptionKey = default(string), string ObserverServerIp = default(string), int? ObserverServerPort = default(int?), string ServerIp = default(string), int? ServerPort = default(int?), long? SummonerId = default(long?))
        {
            this.EncryptionKey = EncryptionKey;
            this.GameId = GameId;
            this.Observer = Observer;
            this.ObserverEncryptionKey = ObserverEncryptionKey;
            this.ObserverServerIp = ObserverServerIp;
            this.ObserverServerPort = ObserverServerPort;
            this.ServerIp = ServerIp;
            this.ServerPort = ServerPort;
            this.SummonerId = SummonerId;
        }
        
        /// <summary>
        /// Gets or Sets EncryptionKey
        /// </summary>
        [DataMember(Name="encryptionKey", EmitDefaultValue=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// Gets or Sets GameId
        /// </summary>
        [DataMember(Name="gameId", EmitDefaultValue=false)]
        public long? GameId { get; set; }

        /// <summary>
        /// Gets or Sets Observer
        /// </summary>
        [DataMember(Name="observer", EmitDefaultValue=false)]
        public bool? Observer { get; set; }

        /// <summary>
        /// Gets or Sets ObserverEncryptionKey
        /// </summary>
        [DataMember(Name="observerEncryptionKey", EmitDefaultValue=false)]
        public string ObserverEncryptionKey { get; set; }

        /// <summary>
        /// Gets or Sets ObserverServerIp
        /// </summary>
        [DataMember(Name="observerServerIp", EmitDefaultValue=false)]
        public string ObserverServerIp { get; set; }

        /// <summary>
        /// Gets or Sets ObserverServerPort
        /// </summary>
        [DataMember(Name="observerServerPort", EmitDefaultValue=false)]
        public int? ObserverServerPort { get; set; }

        /// <summary>
        /// Gets or Sets ServerIp
        /// </summary>
        [DataMember(Name="serverIp", EmitDefaultValue=false)]
        public string ServerIp { get; set; }

        /// <summary>
        /// Gets or Sets ServerPort
        /// </summary>
        [DataMember(Name="serverPort", EmitDefaultValue=false)]
        public int? ServerPort { get; set; }

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
            sb.Append("class GameflowLcdsPlayerCredentialsDto {\n");
            sb.Append("  EncryptionKey: ").Append(EncryptionKey).Append("\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  Observer: ").Append(Observer).Append("\n");
            sb.Append("  ObserverEncryptionKey: ").Append(ObserverEncryptionKey).Append("\n");
            sb.Append("  ObserverServerIp: ").Append(ObserverServerIp).Append("\n");
            sb.Append("  ObserverServerPort: ").Append(ObserverServerPort).Append("\n");
            sb.Append("  ServerIp: ").Append(ServerIp).Append("\n");
            sb.Append("  ServerPort: ").Append(ServerPort).Append("\n");
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
            return this.Equals(obj as GameflowLcdsPlayerCredentialsDto);
        }

        /// <summary>
        /// Returns true if GameflowLcdsPlayerCredentialsDto instances are equal
        /// </summary>
        /// <param name="other">Instance of GameflowLcdsPlayerCredentialsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GameflowLcdsPlayerCredentialsDto other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EncryptionKey == other.EncryptionKey ||
                    this.EncryptionKey != null &&
                    this.EncryptionKey.Equals(other.EncryptionKey)
                ) && 
                (
                    this.GameId == other.GameId ||
                    this.GameId != null &&
                    this.GameId.Equals(other.GameId)
                ) && 
                (
                    this.Observer == other.Observer ||
                    this.Observer != null &&
                    this.Observer.Equals(other.Observer)
                ) && 
                (
                    this.ObserverEncryptionKey == other.ObserverEncryptionKey ||
                    this.ObserverEncryptionKey != null &&
                    this.ObserverEncryptionKey.Equals(other.ObserverEncryptionKey)
                ) && 
                (
                    this.ObserverServerIp == other.ObserverServerIp ||
                    this.ObserverServerIp != null &&
                    this.ObserverServerIp.Equals(other.ObserverServerIp)
                ) && 
                (
                    this.ObserverServerPort == other.ObserverServerPort ||
                    this.ObserverServerPort != null &&
                    this.ObserverServerPort.Equals(other.ObserverServerPort)
                ) && 
                (
                    this.ServerIp == other.ServerIp ||
                    this.ServerIp != null &&
                    this.ServerIp.Equals(other.ServerIp)
                ) && 
                (
                    this.ServerPort == other.ServerPort ||
                    this.ServerPort != null &&
                    this.ServerPort.Equals(other.ServerPort)
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
                if (this.EncryptionKey != null)
                    hash = hash * 59 + this.EncryptionKey.GetHashCode();
                if (this.GameId != null)
                    hash = hash * 59 + this.GameId.GetHashCode();
                if (this.Observer != null)
                    hash = hash * 59 + this.Observer.GetHashCode();
                if (this.ObserverEncryptionKey != null)
                    hash = hash * 59 + this.ObserverEncryptionKey.GetHashCode();
                if (this.ObserverServerIp != null)
                    hash = hash * 59 + this.ObserverServerIp.GetHashCode();
                if (this.ObserverServerPort != null)
                    hash = hash * 59 + this.ObserverServerPort.GetHashCode();
                if (this.ServerIp != null)
                    hash = hash * 59 + this.ServerIp.GetHashCode();
                if (this.ServerPort != null)
                    hash = hash * 59 + this.ServerPort.GetHashCode();
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