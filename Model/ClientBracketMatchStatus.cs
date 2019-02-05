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
    /// Defines ClientBracketMatchStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ClientBracketMatchStatus
    {
        
        /// <summary>
        /// Enum UPCOMING for "UPCOMING"
        /// </summary>
        [EnumMember(Value = "UPCOMING")]
        UPCOMING,
        
        /// <summary>
        /// Enum STARTED for "STARTED"
        /// </summary>
        [EnumMember(Value = "STARTED")]
        STARTED,
        
        /// <summary>
        /// Enum COMPLETED for "COMPLETED"
        /// </summary>
        [EnumMember(Value = "COMPLETED")]
        COMPLETED
    }

}