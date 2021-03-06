/* 
 * LeagueClient
 *
 * 7.23.209.3517
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace LeagueClientApi.Model
{
    /// <summary>
    /// Defines TicketOfferState
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TicketOfferState
    {
        
        /// <summary>
        /// Enum ACTIVE for "ACTIVE"
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        ACTIVE,
        
        /// <summary>
        /// Enum ACCEPTED for "ACCEPTED"
        /// </summary>
        [EnumMember(Value = "ACCEPTED")]
        ACCEPTED,
        
        /// <summary>
        /// Enum REJECTED for "REJECTED"
        /// </summary>
        [EnumMember(Value = "REJECTED")]
        REJECTED,
        
        /// <summary>
        /// Enum REVOKED for "REVOKED"
        /// </summary>
        [EnumMember(Value = "REVOKED")]
        REVOKED
    }

}
