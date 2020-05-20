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
    /// ReferencePortfolioConstituent
    /// </summary>
    [DataContract]
    public partial class ReferencePortfolioConstituent :  IEquatable<ReferencePortfolioConstituent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferencePortfolioConstituent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReferencePortfolioConstituent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferencePortfolioConstituent" /> class.
        /// </summary>
        /// <param name="instrumentIdentifiers">Unique instrument identifiers.</param>
        /// <param name="instrumentUid">LUSID&#39;s internal unique instrument identifier, resolved from the instrument identifiers (required).</param>
        /// <param name="currency">currency (required).</param>
        /// <param name="properties">Properties associated with the constituent.</param>
        /// <param name="weight">weight (required).</param>
        /// <param name="floatingWeight">floatingWeight.</param>
        public ReferencePortfolioConstituent(Dictionary<string, string> instrumentIdentifiers = default(Dictionary<string, string>), string instrumentUid = default(string), string currency = default(string), Dictionary<string, PerpetualProperty> properties = default(Dictionary<string, PerpetualProperty>), decimal? weight = default(decimal?), decimal? floatingWeight = default(decimal?))
        {
            // to ensure "instrumentUid" is required (not null)
            if (instrumentUid == null)
            {
                throw new InvalidDataException("instrumentUid is a required property for ReferencePortfolioConstituent and cannot be null");
            }
            else
            {
                this.InstrumentUid = instrumentUid;
            }
            
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new InvalidDataException("currency is a required property for ReferencePortfolioConstituent and cannot be null");
            }
            else
            {
                this.Currency = currency;
            }
            
            // to ensure "weight" is required (not null)
            if (weight == null)
            {
                throw new InvalidDataException("weight is a required property for ReferencePortfolioConstituent and cannot be null");
            }
            else
            {
                this.Weight = weight;
            }
            
            this.InstrumentIdentifiers = instrumentIdentifiers;
            this.Properties = properties;
            this.FloatingWeight = floatingWeight;
        }
        
        /// <summary>
        /// Unique instrument identifiers
        /// </summary>
        /// <value>Unique instrument identifiers</value>
        [DataMember(Name="instrumentIdentifiers", EmitDefaultValue=false)]
        public Dictionary<string, string> InstrumentIdentifiers { get; set; }

        /// <summary>
        /// LUSID&#39;s internal unique instrument identifier, resolved from the instrument identifiers
        /// </summary>
        /// <value>LUSID&#39;s internal unique instrument identifier, resolved from the instrument identifiers</value>
        [DataMember(Name="instrumentUid", EmitDefaultValue=false)]
        public string InstrumentUid { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Properties associated with the constituent
        /// </summary>
        /// <value>Properties associated with the constituent</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Dictionary<string, PerpetualProperty> Properties { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name="weight", EmitDefaultValue=false)]
        public decimal? Weight { get; set; }

        /// <summary>
        /// Gets or Sets FloatingWeight
        /// </summary>
        [DataMember(Name="floatingWeight", EmitDefaultValue=false)]
        public decimal? FloatingWeight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReferencePortfolioConstituent {\n");
            sb.Append("  InstrumentIdentifiers: ").Append(InstrumentIdentifiers).Append("\n");
            sb.Append("  InstrumentUid: ").Append(InstrumentUid).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  FloatingWeight: ").Append(FloatingWeight).Append("\n");
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
            return this.Equals(input as ReferencePortfolioConstituent);
        }

        /// <summary>
        /// Returns true if ReferencePortfolioConstituent instances are equal
        /// </summary>
        /// <param name="input">Instance of ReferencePortfolioConstituent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReferencePortfolioConstituent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstrumentIdentifiers == input.InstrumentIdentifiers ||
                    this.InstrumentIdentifiers != null &&
                    input.InstrumentIdentifiers != null &&
                    this.InstrumentIdentifiers.SequenceEqual(input.InstrumentIdentifiers)
                ) && 
                (
                    this.InstrumentUid == input.InstrumentUid ||
                    (this.InstrumentUid != null &&
                    this.InstrumentUid.Equals(input.InstrumentUid))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
                ) && 
                (
                    this.FloatingWeight == input.FloatingWeight ||
                    (this.FloatingWeight != null &&
                    this.FloatingWeight.Equals(input.FloatingWeight))
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
                if (this.InstrumentIdentifiers != null)
                    hashCode = hashCode * 59 + this.InstrumentIdentifiers.GetHashCode();
                if (this.InstrumentUid != null)
                    hashCode = hashCode * 59 + this.InstrumentUid.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.FloatingWeight != null)
                    hashCode = hashCode * 59 + this.FloatingWeight.GetHashCode();
                return hashCode;
            }
        }
    }

}
