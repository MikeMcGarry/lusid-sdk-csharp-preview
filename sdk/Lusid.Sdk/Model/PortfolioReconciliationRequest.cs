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
    /// PortfolioReconciliationRequest
    /// </summary>
    [DataContract]
    public partial class PortfolioReconciliationRequest :  IEquatable<PortfolioReconciliationRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioReconciliationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PortfolioReconciliationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioReconciliationRequest" /> class.
        /// </summary>
        /// <param name="portfolioId">portfolioId (required).</param>
        /// <param name="effectiveAt">The effective date of the portfolio (required).</param>
        /// <param name="asAt">Optional. The AsAt date of the portfolio.</param>
        public PortfolioReconciliationRequest(ResourceId portfolioId = default(ResourceId), DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            // to ensure "portfolioId" is required (not null)
            if (portfolioId == null)
            {
                throw new InvalidDataException("portfolioId is a required property for PortfolioReconciliationRequest and cannot be null");
            }
            else
            {
                this.PortfolioId = portfolioId;
            }
            
            // to ensure "effectiveAt" is required (not null)
            if (effectiveAt == null)
            {
                throw new InvalidDataException("effectiveAt is a required property for PortfolioReconciliationRequest and cannot be null");
            }
            else
            {
                this.EffectiveAt = effectiveAt;
            }
            
            this.AsAt = asAt;
        }
        
        /// <summary>
        /// Gets or Sets PortfolioId
        /// </summary>
        [DataMember(Name="portfolioId", EmitDefaultValue=false)]
        public ResourceId PortfolioId { get; set; }

        /// <summary>
        /// The effective date of the portfolio
        /// </summary>
        /// <value>The effective date of the portfolio</value>
        [DataMember(Name="effectiveAt", EmitDefaultValue=false)]
        public DateTimeOrCutLabel EffectiveAt { get; set; }

        /// <summary>
        /// Optional. The AsAt date of the portfolio
        /// </summary>
        /// <value>Optional. The AsAt date of the portfolio</value>
        [DataMember(Name="asAt", EmitDefaultValue=false)]
        public DateTimeOffset? AsAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PortfolioReconciliationRequest {\n");
            sb.Append("  PortfolioId: ").Append(PortfolioId).Append("\n");
            sb.Append("  EffectiveAt: ").Append(EffectiveAt).Append("\n");
            sb.Append("  AsAt: ").Append(AsAt).Append("\n");
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
            return this.Equals(input as PortfolioReconciliationRequest);
        }

        /// <summary>
        /// Returns true if PortfolioReconciliationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PortfolioReconciliationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PortfolioReconciliationRequest input)
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
                    this.EffectiveAt == input.EffectiveAt ||
                    (this.EffectiveAt != null &&
                    this.EffectiveAt.Equals(input.EffectiveAt))
                ) && 
                (
                    this.AsAt == input.AsAt ||
                    (this.AsAt != null &&
                    this.AsAt.Equals(input.AsAt))
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
                if (this.EffectiveAt != null)
                    hashCode = hashCode * 59 + this.EffectiveAt.GetHashCode();
                if (this.AsAt != null)
                    hashCode = hashCode * 59 + this.AsAt.GetHashCode();
                return hashCode;
            }
        }
    }

}
