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
    /// LolPftPFTQuestionResponse
    /// </summary>
    [DataContract]
    public partial class LolPftPFTQuestionResponse :  IEquatable<LolPftPFTQuestionResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolPftPFTQuestionResponse" /> class.
        /// </summary>
        /// <param name="QuestionId">QuestionId.</param>
        /// <param name="ResponseData">ResponseData.</param>
        public LolPftPFTQuestionResponse(long? QuestionId = default(long?), Object ResponseData = default(Object))
        {
            this.QuestionId = QuestionId;
            this.ResponseData = ResponseData;
        }
        
        /// <summary>
        /// Gets or Sets QuestionId
        /// </summary>
        [DataMember(Name="questionId", EmitDefaultValue=false)]
        public long? QuestionId { get; set; }

        /// <summary>
        /// Gets or Sets ResponseData
        /// </summary>
        [DataMember(Name="responseData", EmitDefaultValue=false)]
        public Object ResponseData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolPftPFTQuestionResponse {\n");
            sb.Append("  QuestionId: ").Append(QuestionId).Append("\n");
            sb.Append("  ResponseData: ").Append(ResponseData).Append("\n");
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
            return this.Equals(obj as LolPftPFTQuestionResponse);
        }

        /// <summary>
        /// Returns true if LolPftPFTQuestionResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of LolPftPFTQuestionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolPftPFTQuestionResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.QuestionId == other.QuestionId ||
                    this.QuestionId != null &&
                    this.QuestionId.Equals(other.QuestionId)
                ) && 
                (
                    this.ResponseData == other.ResponseData ||
                    this.ResponseData != null &&
                    this.ResponseData.Equals(other.ResponseData)
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
                if (this.QuestionId != null)
                    hash = hash * 59 + this.QuestionId.GetHashCode();
                if (this.ResponseData != null)
                    hash = hash * 59 + this.ResponseData.GetHashCode();
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
