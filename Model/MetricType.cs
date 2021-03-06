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
    /// Defines MetricType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MetricType
    {
        
        /// <summary>
        /// Enum Unknown for "unknown"
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        
        /// <summary>
        /// Enum Percentage for "percentage"
        /// </summary>
        [EnumMember(Value = "percentage")]
        Percentage,
        
        /// <summary>
        /// Enum Count for "count"
        /// </summary>
        [EnumMember(Value = "count")]
        Count,
        
        /// <summary>
        /// Enum Duration for "duration"
        /// </summary>
        [EnumMember(Value = "duration")]
        Duration,
        
        /// <summary>
        /// Enum Rate for "rate"
        /// </summary>
        [EnumMember(Value = "rate")]
        Rate
    }

}
