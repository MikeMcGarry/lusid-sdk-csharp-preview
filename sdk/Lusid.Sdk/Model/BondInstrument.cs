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
    /// IL Bond Instrument; Lusid-ibor internal representation of a Bond instrument
    /// </summary>
    [DataContract]
    public partial class BondInstrument : LusidInstrument,  IEquatable<BondInstrument>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BondInstrument" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BondInstrument() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BondInstrument" /> class.
        /// </summary>
        /// <param name="startDate">startDate (required).</param>
        /// <param name="maturityDate">maturityDate (required).</param>
        /// <param name="domCcy">domCcy (required).</param>
        /// <param name="couponRate">simple coupon rate. (required).</param>
        /// <param name="principal">The face-value or principal for the bond at outset.              This might be reduced through its lifetime in the event of amortization or similar. (required).</param>
        /// <param name="flowConventions">flowConventions (required).</param>
        public BondInstrument(DateTimeOffset? startDate = default(DateTimeOffset?), DateTimeOffset? maturityDate = default(DateTimeOffset?), string domCcy = default(string), decimal? couponRate = default(decimal?), decimal? principal = default(decimal?), FlowConventions flowConventions = default(FlowConventions), InstrumentTypeEnum instrumentType = default(InstrumentTypeEnum)) : base(instrumentType)
        {
            // to ensure "startDate" is required (not null)
            if (startDate == null)
            {
                throw new InvalidDataException("startDate is a required property for BondInstrument and cannot be null");
            }
            else
            {
                this.StartDate = startDate;
            }
            
            // to ensure "maturityDate" is required (not null)
            if (maturityDate == null)
            {
                throw new InvalidDataException("maturityDate is a required property for BondInstrument and cannot be null");
            }
            else
            {
                this.MaturityDate = maturityDate;
            }
            
            // to ensure "domCcy" is required (not null)
            if (domCcy == null)
            {
                throw new InvalidDataException("domCcy is a required property for BondInstrument and cannot be null");
            }
            else
            {
                this.DomCcy = domCcy;
            }
            
            // to ensure "couponRate" is required (not null)
            if (couponRate == null)
            {
                throw new InvalidDataException("couponRate is a required property for BondInstrument and cannot be null");
            }
            else
            {
                this.CouponRate = couponRate;
            }
            
            // to ensure "principal" is required (not null)
            if (principal == null)
            {
                throw new InvalidDataException("principal is a required property for BondInstrument and cannot be null");
            }
            else
            {
                this.Principal = principal;
            }
            
            // to ensure "flowConventions" is required (not null)
            if (flowConventions == null)
            {
                throw new InvalidDataException("flowConventions is a required property for BondInstrument and cannot be null");
            }
            else
            {
                this.FlowConventions = flowConventions;
            }
            
        }
        
        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTimeOffset? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets MaturityDate
        /// </summary>
        [DataMember(Name="maturityDate", EmitDefaultValue=false)]
        public DateTimeOffset? MaturityDate { get; set; }

        /// <summary>
        /// Gets or Sets DomCcy
        /// </summary>
        [DataMember(Name="domCcy", EmitDefaultValue=false)]
        public string DomCcy { get; set; }

        /// <summary>
        /// simple coupon rate.
        /// </summary>
        /// <value>simple coupon rate.</value>
        [DataMember(Name="couponRate", EmitDefaultValue=false)]
        public decimal? CouponRate { get; set; }

        /// <summary>
        /// The face-value or principal for the bond at outset.              This might be reduced through its lifetime in the event of amortization or similar.
        /// </summary>
        /// <value>The face-value or principal for the bond at outset.              This might be reduced through its lifetime in the event of amortization or similar.</value>
        [DataMember(Name="principal", EmitDefaultValue=false)]
        public decimal? Principal { get; set; }

        /// <summary>
        /// Gets or Sets FlowConventions
        /// </summary>
        [DataMember(Name="flowConventions", EmitDefaultValue=false)]
        public FlowConventions FlowConventions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BondInstrument {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  MaturityDate: ").Append(MaturityDate).Append("\n");
            sb.Append("  DomCcy: ").Append(DomCcy).Append("\n");
            sb.Append("  CouponRate: ").Append(CouponRate).Append("\n");
            sb.Append("  Principal: ").Append(Principal).Append("\n");
            sb.Append("  FlowConventions: ").Append(FlowConventions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as BondInstrument);
        }

        /// <summary>
        /// Returns true if BondInstrument instances are equal
        /// </summary>
        /// <param name="input">Instance of BondInstrument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BondInstrument input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && base.Equals(input) && 
                (
                    this.MaturityDate == input.MaturityDate ||
                    (this.MaturityDate != null &&
                    this.MaturityDate.Equals(input.MaturityDate))
                ) && base.Equals(input) && 
                (
                    this.DomCcy == input.DomCcy ||
                    (this.DomCcy != null &&
                    this.DomCcy.Equals(input.DomCcy))
                ) && base.Equals(input) && 
                (
                    this.CouponRate == input.CouponRate ||
                    (this.CouponRate != null &&
                    this.CouponRate.Equals(input.CouponRate))
                ) && base.Equals(input) && 
                (
                    this.Principal == input.Principal ||
                    (this.Principal != null &&
                    this.Principal.Equals(input.Principal))
                ) && base.Equals(input) && 
                (
                    this.FlowConventions == input.FlowConventions ||
                    (this.FlowConventions != null &&
                    this.FlowConventions.Equals(input.FlowConventions))
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
                int hashCode = base.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.MaturityDate != null)
                    hashCode = hashCode * 59 + this.MaturityDate.GetHashCode();
                if (this.DomCcy != null)
                    hashCode = hashCode * 59 + this.DomCcy.GetHashCode();
                if (this.CouponRate != null)
                    hashCode = hashCode * 59 + this.CouponRate.GetHashCode();
                if (this.Principal != null)
                    hashCode = hashCode * 59 + this.Principal.GetHashCode();
                if (this.FlowConventions != null)
                    hashCode = hashCode * 59 + this.FlowConventions.GetHashCode();
                return hashCode;
            }
        }
    }

}
