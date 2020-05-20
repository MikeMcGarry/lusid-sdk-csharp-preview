/* 
 * LUSID API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.10.1391
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = Lusid.Sdk.Client.OpenAPIDateConverter;

namespace Lusid.Sdk.Model
{
    /// <summary>
    /// ErrorDetail
    /// </summary>
    [DataContract]
    public partial class ErrorDetail :  IEquatable<ErrorDetail>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorDetail" /> class.
        /// </summary>
        /// <param name="id">The id of the failed item that this error relates to..</param>
        /// <param name="type">The type of failure that occurred..</param>
        /// <param name="detail">Description of the failure that occurred..</param>
        /// <param name="errorDetails">Information about the particular instance of the failure (supplied information depends on the type of failure)..</param>
        public ErrorDetail(string id = default(string), string type = default(string), string detail = default(string), List<Dictionary<string, string>> errorDetails = default(List<Dictionary<string, string>>))
        {
            this.Id = id;
            this.Type = type;
            this.Detail = detail;
            this.ErrorDetails = errorDetails;
        }
        
        /// <summary>
        /// The id of the failed item that this error relates to.
        /// </summary>
        /// <value>The id of the failed item that this error relates to.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The type of failure that occurred.
        /// </summary>
        /// <value>The type of failure that occurred.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Description of the failure that occurred.
        /// </summary>
        /// <value>Description of the failure that occurred.</value>
        [DataMember(Name="detail", EmitDefaultValue=false)]
        public string Detail { get; set; }

        /// <summary>
        /// Information about the particular instance of the failure (supplied information depends on the type of failure).
        /// </summary>
        /// <value>Information about the particular instance of the failure (supplied information depends on the type of failure).</value>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public List<Dictionary<string, string>> ErrorDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorDetail {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ErrorDetail);
        }

        /// <summary>
        /// Returns true if ErrorDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Detail == input.Detail ||
                    (this.Detail != null &&
                    this.Detail.Equals(input.Detail))
                ) && 
                (
                    this.ErrorDetails == input.ErrorDetails ||
                    this.ErrorDetails != null &&
                    input.ErrorDetails != null &&
                    this.ErrorDetails.SequenceEqual(input.ErrorDetails)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Detail != null)
                    hashCode = hashCode * 59 + this.Detail.GetHashCode();
                if (this.ErrorDetails != null)
                    hashCode = hashCode * 59 + this.ErrorDetails.GetHashCode();
                return hashCode;
            }
        }
    }

}
