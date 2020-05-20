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
    /// Specification for the reconciliation request. Left and Right hand sides are constructed. Each consists of a valuation of a portfolio  using an aggregation request. The results of this can then be compared to each other. The difference, which is effectively a risk based  difference allows comparison of the effects of changing a recipe, valuation date, or (though it may or may not make logical sense) a portfolio.  For instance, one might look at the difference in risk caused by the addition of transaction to a portfolio, or through changing the valuation  methodology or system.
    /// </summary>
    [DataContract]
    public partial class ValuationsReconciliationRequest :  IEquatable<ValuationsReconciliationRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValuationsReconciliationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ValuationsReconciliationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ValuationsReconciliationRequest" /> class.
        /// </summary>
        /// <param name="left">left (required).</param>
        /// <param name="right">right (required).</param>
        /// <param name="instrumentPropertyKeys">Instrument properties to be included with any identified breaks. These properties will be in the effective and AsAt dates of the left portfolio (required).</param>
        public ValuationsReconciliationRequest(ValuationReconciliationRequest left = default(ValuationReconciliationRequest), ValuationReconciliationRequest right = default(ValuationReconciliationRequest), List<string> instrumentPropertyKeys = default(List<string>))
        {
            // to ensure "left" is required (not null)
            if (left == null)
            {
                throw new InvalidDataException("left is a required property for ValuationsReconciliationRequest and cannot be null");
            }
            else
            {
                this.Left = left;
            }
            
            // to ensure "right" is required (not null)
            if (right == null)
            {
                throw new InvalidDataException("right is a required property for ValuationsReconciliationRequest and cannot be null");
            }
            else
            {
                this.Right = right;
            }
            
            // to ensure "instrumentPropertyKeys" is required (not null)
            if (instrumentPropertyKeys == null)
            {
                throw new InvalidDataException("instrumentPropertyKeys is a required property for ValuationsReconciliationRequest and cannot be null");
            }
            else
            {
                this.InstrumentPropertyKeys = instrumentPropertyKeys;
            }
            
        }
        
        /// <summary>
        /// Gets or Sets Left
        /// </summary>
        [DataMember(Name="left", EmitDefaultValue=false)]
        public ValuationReconciliationRequest Left { get; set; }

        /// <summary>
        /// Gets or Sets Right
        /// </summary>
        [DataMember(Name="right", EmitDefaultValue=false)]
        public ValuationReconciliationRequest Right { get; set; }

        /// <summary>
        /// Instrument properties to be included with any identified breaks. These properties will be in the effective and AsAt dates of the left portfolio
        /// </summary>
        /// <value>Instrument properties to be included with any identified breaks. These properties will be in the effective and AsAt dates of the left portfolio</value>
        [DataMember(Name="instrumentPropertyKeys", EmitDefaultValue=false)]
        public List<string> InstrumentPropertyKeys { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValuationsReconciliationRequest {\n");
            sb.Append("  Left: ").Append(Left).Append("\n");
            sb.Append("  Right: ").Append(Right).Append("\n");
            sb.Append("  InstrumentPropertyKeys: ").Append(InstrumentPropertyKeys).Append("\n");
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
            return this.Equals(input as ValuationsReconciliationRequest);
        }

        /// <summary>
        /// Returns true if ValuationsReconciliationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ValuationsReconciliationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValuationsReconciliationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Left == input.Left ||
                    (this.Left != null &&
                    this.Left.Equals(input.Left))
                ) && 
                (
                    this.Right == input.Right ||
                    (this.Right != null &&
                    this.Right.Equals(input.Right))
                ) && 
                (
                    this.InstrumentPropertyKeys == input.InstrumentPropertyKeys ||
                    this.InstrumentPropertyKeys != null &&
                    input.InstrumentPropertyKeys != null &&
                    this.InstrumentPropertyKeys.SequenceEqual(input.InstrumentPropertyKeys)
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
                if (this.Left != null)
                    hashCode = hashCode * 59 + this.Left.GetHashCode();
                if (this.Right != null)
                    hashCode = hashCode * 59 + this.Right.GetHashCode();
                if (this.InstrumentPropertyKeys != null)
                    hashCode = hashCode * 59 + this.InstrumentPropertyKeys.GetHashCode();
                return hashCode;
            }
        }
    }

}
