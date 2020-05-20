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
    /// UpdatePortfolioGroupRequest
    /// </summary>
    [DataContract]
    public partial class UpdatePortfolioGroupRequest :  IEquatable<UpdatePortfolioGroupRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePortfolioGroupRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdatePortfolioGroupRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePortfolioGroupRequest" /> class.
        /// </summary>
        /// <param name="displayName">The name of the portfolio group. (required).</param>
        /// <param name="description">A long form description of the portfolio group..</param>
        public UpdatePortfolioGroupRequest(string displayName = default(string), string description = default(string))
        {
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new InvalidDataException("displayName is a required property for UpdatePortfolioGroupRequest and cannot be null");
            }
            else
            {
                this.DisplayName = displayName;
            }
            
            this.Description = description;
        }
        
        /// <summary>
        /// The name of the portfolio group.
        /// </summary>
        /// <value>The name of the portfolio group.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// A long form description of the portfolio group.
        /// </summary>
        /// <value>A long form description of the portfolio group.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePortfolioGroupRequest {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as UpdatePortfolioGroupRequest);
        }

        /// <summary>
        /// Returns true if UpdatePortfolioGroupRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdatePortfolioGroupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdatePortfolioGroupRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }

}
