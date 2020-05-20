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
    /// IL Swap Instrument; Lusid-ibor internal representation of a swap instrument                A swap is the exchange of two sets of cashflows, occurring at one or more dates in one or more currencies.  These may include a notional exchange at the start and, or, maturity of the trade. Depending upon the choice of  payment currency, payment frequency and so on they can be used to match sets of future obligations
    /// </summary>
    [DataContract]
    public partial class SwapInstrument : LusidInstrument,  IEquatable<SwapInstrument>
    {
        /// <summary>
        /// True notional exchange type.
        /// </summary>
        /// <value>True notional exchange type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NotionalExchangeTypeEnum
        {
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,

            /// <summary>
            /// Enum Initial for value: Initial
            /// </summary>
            [EnumMember(Value = "Initial")]
            Initial = 2,

            /// <summary>
            /// Enum Final for value: Final
            /// </summary>
            [EnumMember(Value = "Final")]
            Final = 3,

            /// <summary>
            /// Enum Both for value: Both
            /// </summary>
            [EnumMember(Value = "Both")]
            Both = 4

        }

        /// <summary>
        /// True notional exchange type.
        /// </summary>
        /// <value>True notional exchange type.</value>
        [DataMember(Name="notionalExchangeType", EmitDefaultValue=false)]
        public NotionalExchangeTypeEnum NotionalExchangeType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SwapInstrument" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SwapInstrument() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SwapInstrument" /> class.
        /// </summary>
        /// <param name="startDate">Starting date of the swap (required).</param>
        /// <param name="maturityDate">Maturity date of the swap (required).</param>
        /// <param name="legs">True if the swap is amortizing (required).</param>
        /// <param name="notional">The notional. (required).</param>
        /// <param name="isAmortizing">True if the swap is amortizing (required).</param>
        /// <param name="notionalExchangeType">True notional exchange type. (required).</param>
        public SwapInstrument(DateTimeOffset? startDate = default(DateTimeOffset?), DateTimeOffset? maturityDate = default(DateTimeOffset?), List<InstrumentLeg> legs = default(List<InstrumentLeg>), decimal? notional = default(decimal?), bool? isAmortizing = default(bool?), NotionalExchangeTypeEnum notionalExchangeType = default(NotionalExchangeTypeEnum), InstrumentTypeEnum instrumentType = default(InstrumentTypeEnum)) : base(instrumentType)
        {
            // to ensure "startDate" is required (not null)
            if (startDate == null)
            {
                throw new InvalidDataException("startDate is a required property for SwapInstrument and cannot be null");
            }
            else
            {
                this.StartDate = startDate;
            }
            
            // to ensure "maturityDate" is required (not null)
            if (maturityDate == null)
            {
                throw new InvalidDataException("maturityDate is a required property for SwapInstrument and cannot be null");
            }
            else
            {
                this.MaturityDate = maturityDate;
            }
            
            // to ensure "legs" is required (not null)
            if (legs == null)
            {
                throw new InvalidDataException("legs is a required property for SwapInstrument and cannot be null");
            }
            else
            {
                this.Legs = legs;
            }
            
            // to ensure "notional" is required (not null)
            if (notional == null)
            {
                throw new InvalidDataException("notional is a required property for SwapInstrument and cannot be null");
            }
            else
            {
                this.Notional = notional;
            }
            
            // to ensure "isAmortizing" is required (not null)
            if (isAmortizing == null)
            {
                throw new InvalidDataException("isAmortizing is a required property for SwapInstrument and cannot be null");
            }
            else
            {
                this.IsAmortizing = isAmortizing;
            }
            
            // to ensure "notionalExchangeType" is required (not null)
            if (notionalExchangeType == null)
            {
                throw new InvalidDataException("notionalExchangeType is a required property for SwapInstrument and cannot be null");
            }
            else
            {
                this.NotionalExchangeType = notionalExchangeType;
            }
            
        }
        
        /// <summary>
        /// Starting date of the swap
        /// </summary>
        /// <value>Starting date of the swap</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTimeOffset? StartDate { get; set; }

        /// <summary>
        /// Maturity date of the swap
        /// </summary>
        /// <value>Maturity date of the swap</value>
        [DataMember(Name="maturityDate", EmitDefaultValue=false)]
        public DateTimeOffset? MaturityDate { get; set; }

        /// <summary>
        /// True if the swap is amortizing
        /// </summary>
        /// <value>True if the swap is amortizing</value>
        [DataMember(Name="legs", EmitDefaultValue=false)]
        public List<InstrumentLeg> Legs { get; set; }

        /// <summary>
        /// The notional.
        /// </summary>
        /// <value>The notional.</value>
        [DataMember(Name="notional", EmitDefaultValue=false)]
        public decimal? Notional { get; set; }

        /// <summary>
        /// True if the swap is amortizing
        /// </summary>
        /// <value>True if the swap is amortizing</value>
        [DataMember(Name="isAmortizing", EmitDefaultValue=false)]
        public bool? IsAmortizing { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SwapInstrument {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  MaturityDate: ").Append(MaturityDate).Append("\n");
            sb.Append("  Legs: ").Append(Legs).Append("\n");
            sb.Append("  Notional: ").Append(Notional).Append("\n");
            sb.Append("  IsAmortizing: ").Append(IsAmortizing).Append("\n");
            sb.Append("  NotionalExchangeType: ").Append(NotionalExchangeType).Append("\n");
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
            return this.Equals(input as SwapInstrument);
        }

        /// <summary>
        /// Returns true if SwapInstrument instances are equal
        /// </summary>
        /// <param name="input">Instance of SwapInstrument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SwapInstrument input)
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
                    this.Legs == input.Legs ||
                    this.Legs != null &&
                    input.Legs != null &&
                    this.Legs.SequenceEqual(input.Legs)
                ) && base.Equals(input) && 
                (
                    this.Notional == input.Notional ||
                    (this.Notional != null &&
                    this.Notional.Equals(input.Notional))
                ) && base.Equals(input) && 
                (
                    this.IsAmortizing == input.IsAmortizing ||
                    (this.IsAmortizing != null &&
                    this.IsAmortizing.Equals(input.IsAmortizing))
                ) && base.Equals(input) && 
                (
                    this.NotionalExchangeType == input.NotionalExchangeType ||
                    (this.NotionalExchangeType != null &&
                    this.NotionalExchangeType.Equals(input.NotionalExchangeType))
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
                if (this.Legs != null)
                    hashCode = hashCode * 59 + this.Legs.GetHashCode();
                if (this.Notional != null)
                    hashCode = hashCode * 59 + this.Notional.GetHashCode();
                if (this.IsAmortizing != null)
                    hashCode = hashCode * 59 + this.IsAmortizing.GetHashCode();
                if (this.NotionalExchangeType != null)
                    hashCode = hashCode * 59 + this.NotionalExchangeType.GetHashCode();
                return hashCode;
            }
        }
    }

}
