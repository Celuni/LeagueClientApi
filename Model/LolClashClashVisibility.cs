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
    /// Defines LolClashClashVisibility
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LolClashClashVisibility
    {
        
        /// <summary>
        /// Enum Hidden for "Hidden"
        /// </summary>
        [EnumMember(Value = "Hidden")]
        Hidden,
        
        /// <summary>
        /// Enum DarkVisible for "DarkVisible"
        /// </summary>
        [EnumMember(Value = "DarkVisible")]
        DarkVisible,
        
        /// <summary>
        /// Enum Visible for "Visible"
        /// </summary>
        [EnumMember(Value = "Visible")]
        Visible
    }

}