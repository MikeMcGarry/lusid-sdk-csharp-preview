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
    /// Specification for the parameters that define how to perform a reconciliation between two portfolios. This defines  the specification for one half of that request, namely how to find and perform an aggregation request on one of the portfolios.
    /// </summary>
    [DataContract]
    public partial class ValuationReconciliationRequest :  IEquatable<ValuationReconciliationRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValuationReconciliationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ValuationReconciliationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ValuationReconciliationRequest" /> class.
        /// </summary>
        /// <param name="portfolioId">portfolioId (required).</param>
        /// <param name="aggregation">aggregation (required).</param>
        public ValuationReconciliationRequest(ResourceId portfolioId = default(ResourceId), AggregationRequest aggregation = default(AggregationRequest))
        {
            // to ensure "portfolioId" is required (not null)
            if (portfolioId == null)
            {
                throw new InvalidDataException("portfolioId is a required property for ValuationReconciliationRequest and cannot be null");
            }
            else
            {
                this.PortfolioId = portfolioId;
            }
            
            // to ensure "aggregation" is required (not null)
            if (aggregation == null)
            {
                throw new InvalidDataException("aggregation is a required property for ValuationReconciliationRequest and cannot be null");
            }
            else
            {
                this.Aggregation = aggregation;
            }
            
        }
        
        /// <summary>
        /// Gets or Sets PortfolioId
        /// </summary>
        [DataMember(Name="portfolioId", EmitDefaultValue=false)]
        public ResourceId PortfolioId { get; set; }

        /// <summary>
        /// Gets or Sets Aggregation
        /// </summary>
        [DataMember(Name="aggregation", EmitDefaultValue=false)]
        public AggregationRequest Aggregation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValuationReconciliationRequest {\n");
            sb.Append("  PortfolioId: ").Append(PortfolioId).Append("\n");
            sb.Append("  Aggregation: ").Append(Aggregation).Append("\n");
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
            return this.Equals(input as ValuationReconciliationRequest);
        }

        /// <summary>
        /// Returns true if ValuationReconciliationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ValuationReconciliationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValuationReconciliationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PortfolioId == input.PortfolioId ||
                    (this.PortfolioId != null &&
                    this.PortfolioId.Equals(input.PortfolioId))
                ) && 
                (
                    this.Aggregation == input.Aggregation ||
                    (this.Aggregation != null &&
                    this.Aggregation.Equals(input.Aggregation))
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
                if (this.PortfolioId != null)
                    hashCode = hashCode * 59 + this.PortfolioId.GetHashCode();
                if (this.Aggregation != null)
                    hashCode = hashCode * 59 + this.Aggregation.GetHashCode();
                return hashCode;
            }
        }
    }

}
