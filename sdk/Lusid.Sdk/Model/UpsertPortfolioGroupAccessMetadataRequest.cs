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
    /// UpsertPortfolioGroupAccessMetadataRequest
    /// </summary>
    [DataContract]
    public partial class UpsertPortfolioGroupAccessMetadataRequest :  IEquatable<UpsertPortfolioGroupAccessMetadataRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertPortfolioGroupAccessMetadataRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpsertPortfolioGroupAccessMetadataRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertPortfolioGroupAccessMetadataRequest" /> class.
        /// </summary>
        /// <param name="metadata">The access control metadata to assign to portfolio groups that match the identifier (required).</param>
        public UpsertPortfolioGroupAccessMetadataRequest(List<AccessMetadataValue> metadata = default(List<AccessMetadataValue>))
        {
            // to ensure "metadata" is required (not null)
            if (metadata == null)
            {
                throw new InvalidDataException("metadata is a required property for UpsertPortfolioGroupAccessMetadataRequest and cannot be null");
            }
            else
            {
                this.Metadata = metadata;
            }
            
        }
        
        /// <summary>
        /// The access control metadata to assign to portfolio groups that match the identifier
        /// </summary>
        /// <value>The access control metadata to assign to portfolio groups that match the identifier</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public List<AccessMetadataValue> Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpsertPortfolioGroupAccessMetadataRequest {\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(input as UpsertPortfolioGroupAccessMetadataRequest);
        }

        /// <summary>
        /// Returns true if UpsertPortfolioGroupAccessMetadataRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpsertPortfolioGroupAccessMetadataRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpsertPortfolioGroupAccessMetadataRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
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
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                return hashCode;
            }
        }
    }

}
