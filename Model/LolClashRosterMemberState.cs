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
    /// Defines LolClashRosterMemberState
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LolClashRosterMemberState
    {
        
        /// <summary>
        /// Enum PENDING for "PENDING"
        /// </summary>
        [EnumMember(Value = "PENDING")]
        PENDING,
        
        /// <summary>
        /// Enum NOTREADY for "NOT_READY"
        /// </summary>
        [EnumMember(Value = "NOT_READY")]
        NOTREADY,
        
        /// <summary>
        /// Enum FORCEDNOTREADY for "FORCED_NOT_READY"
        /// </summary>
        [EnumMember(Value = "FORCED_NOT_READY")]
        FORCEDNOTREADY,
        
        /// <summary>
        /// Enum READY for "READY"
        /// </summary>
        [EnumMember(Value = "READY")]
        READY
    }

}
