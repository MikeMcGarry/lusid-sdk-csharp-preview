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
    /// A list of output transactions.
    /// </summary>
    [DataContract]
    public partial class OutputTransaction :  IEquatable<OutputTransaction>
    {
        /// <summary>
        /// The status of the transaction.
        /// </summary>
        /// <value>The status of the transaction.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TransactionStatusEnum
        {
            /// <summary>
            /// Enum Active for value: Active
            /// </summary>
            [EnumMember(Value = "Active")]
            Active = 1,

            /// <summary>
            /// Enum Amended for value: Amended
            /// </summary>
            [EnumMember(Value = "Amended")]
            Amended = 2,

            /// <summary>
            /// Enum Cancelled for value: Cancelled
            /// </summary>
            [EnumMember(Value = "Cancelled")]
            Cancelled = 3

        }

        /// <summary>
        /// The status of the transaction.
        /// </summary>
        /// <value>The status of the transaction.</value>
        [DataMember(Name="transactionStatus", EmitDefaultValue=false)]
        public TransactionStatusEnum? TransactionStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OutputTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OutputTransaction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OutputTransaction" /> class.
        /// </summary>
        /// <param name="instrumentIdentifiers">The set of instrument identifiers that can be used to resolve the transaction to a unique instrument..</param>
        /// <param name="transactionPrice">transactionPrice.</param>
        /// <param name="totalConsideration">totalConsideration.</param>
        public OutputTransaction(Dictionary<string, string> instrumentIdentifiers = default(Dictionary<string, string>), TransactionPrice transactionPrice = default(TransactionPrice), CurrencyAndAmount totalConsideration = default(CurrencyAndAmount))
        {
            this.InstrumentIdentifiers = instrumentIdentifiers;
            this.TransactionPrice = transactionPrice;
            this.TotalConsideration = totalConsideration;
        }
        
        /// <summary>
        /// The unique identifier for the transaction.
        /// </summary>
        /// <value>The unique identifier for the transaction.</value>
        [DataMember(Name="transactionId", EmitDefaultValue=false)]
        public string TransactionId { get; private set; }

        /// <summary>
        /// The type of the transaction e.g. &#39;Buy&#39;, &#39;Sell&#39;. The transaction type should have been pre-configured via the System Configuration API endpoint.
        /// </summary>
        /// <value>The type of the transaction e.g. &#39;Buy&#39;, &#39;Sell&#39;. The transaction type should have been pre-configured via the System Configuration API endpoint.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; private set; }

        /// <summary>
        /// The description of the transaction. This only exists on transactions generated by LUSID e.g. a holdings adjustment transaction.
        /// </summary>
        /// <value>The description of the transaction. This only exists on transactions generated by LUSID e.g. a holdings adjustment transaction.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; private set; }

        /// <summary>
        /// The set of instrument identifiers that can be used to resolve the transaction to a unique instrument.
        /// </summary>
        /// <value>The set of instrument identifiers that can be used to resolve the transaction to a unique instrument.</value>
        [DataMember(Name="instrumentIdentifiers", EmitDefaultValue=false)]
        public Dictionary<string, string> InstrumentIdentifiers { get; set; }

        /// <summary>
        /// The unqiue Lusid Instrument Id (LUID) of the instrument that the transaction is in.
        /// </summary>
        /// <value>The unqiue Lusid Instrument Id (LUID) of the instrument that the transaction is in.</value>
        [DataMember(Name="instrumentUid", EmitDefaultValue=false)]
        public string InstrumentUid { get; private set; }

        /// <summary>
        /// The date of the transaction.
        /// </summary>
        /// <value>The date of the transaction.</value>
        [DataMember(Name="transactionDate", EmitDefaultValue=false)]
        public DateTimeOffset? TransactionDate { get; private set; }

        /// <summary>
        /// The settlement date of the transaction.
        /// </summary>
        /// <value>The settlement date of the transaction.</value>
        [DataMember(Name="settlementDate", EmitDefaultValue=false)]
        public DateTimeOffset? SettlementDate { get; private set; }

        /// <summary>
        /// The number of units transacted in the associated instrument.
        /// </summary>
        /// <value>The number of units transacted in the associated instrument.</value>
        [DataMember(Name="units", EmitDefaultValue=false)]
        public decimal? Units { get; private set; }

        /// <summary>
        /// The total value of the transaction in the transaction currency.
        /// </summary>
        /// <value>The total value of the transaction in the transaction currency.</value>
        [DataMember(Name="transactionAmount", EmitDefaultValue=false)]
        public decimal? TransactionAmount { get; private set; }

        /// <summary>
        /// Gets or Sets TransactionPrice
        /// </summary>
        [DataMember(Name="transactionPrice", EmitDefaultValue=false)]
        public TransactionPrice TransactionPrice { get; set; }

        /// <summary>
        /// Gets or Sets TotalConsideration
        /// </summary>
        [DataMember(Name="totalConsideration", EmitDefaultValue=false)]
        public CurrencyAndAmount TotalConsideration { get; set; }

        /// <summary>
        /// The exchange rate between the transaction and settlement currency. For example if the transaction currency is in USD and the settlement currency is in GBP this this the USD/GBP rate.
        /// </summary>
        /// <value>The exchange rate between the transaction and settlement currency. For example if the transaction currency is in USD and the settlement currency is in GBP this this the USD/GBP rate.</value>
        [DataMember(Name="exchangeRate", EmitDefaultValue=false)]
        public decimal? ExchangeRate { get; private set; }

        /// <summary>
        /// The exchange rate between the transaction and portfolio currency. For example if the transaction currency is in USD and the portfolio currency is in GBP this this the USD/GBP rate.
        /// </summary>
        /// <value>The exchange rate between the transaction and portfolio currency. For example if the transaction currency is in USD and the portfolio currency is in GBP this this the USD/GBP rate.</value>
        [DataMember(Name="transactionToPortfolioRate", EmitDefaultValue=false)]
        public decimal? TransactionToPortfolioRate { get; private set; }

        /// <summary>
        /// The transaction currency.
        /// </summary>
        /// <value>The transaction currency.</value>
        [DataMember(Name="transactionCurrency", EmitDefaultValue=false)]
        public string TransactionCurrency { get; private set; }

        /// <summary>
        /// Set of unique transaction properties and associated values to stored with the transaction. Each property will be from the &#39;Transaction&#39; domain.
        /// </summary>
        /// <value>Set of unique transaction properties and associated values to stored with the transaction. Each property will be from the &#39;Transaction&#39; domain.</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Dictionary<string, PerpetualProperty> Properties { get; private set; }

        /// <summary>
        /// The identifier for the counterparty of the transaction.
        /// </summary>
        /// <value>The identifier for the counterparty of the transaction.</value>
        [DataMember(Name="counterpartyId", EmitDefaultValue=false)]
        public string CounterpartyId { get; private set; }

        /// <summary>
        /// The source of the transaction. This is used to look up the appropriate transaction group set in the transaction type configuration.
        /// </summary>
        /// <value>The source of the transaction. This is used to look up the appropriate transaction group set in the transaction type configuration.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; private set; }


        /// <summary>
        /// The asAt datetime that the transaction was added to LUSID.
        /// </summary>
        /// <value>The asAt datetime that the transaction was added to LUSID.</value>
        [DataMember(Name="entryDateTime", EmitDefaultValue=false)]
        public DateTimeOffset? EntryDateTime { get; private set; }

        /// <summary>
        /// If the transaction has been cancelled, the asAt datetime that the transaction was cancelled.
        /// </summary>
        /// <value>If the transaction has been cancelled, the asAt datetime that the transaction was cancelled.</value>
        [DataMember(Name="cancelDateTime", EmitDefaultValue=false)]
        public DateTimeOffset? CancelDateTime { get; private set; }

        /// <summary>
        /// The collection of realised gains or losses resulting from relevant transactions e.g. a sale transaction. The cost used in calculating the realised gain or loss is determined by the accounting method defined when the transaction portfolio is created.
        /// </summary>
        /// <value>The collection of realised gains or losses resulting from relevant transactions e.g. a sale transaction. The cost used in calculating the realised gain or loss is determined by the accounting method defined when the transaction portfolio is created.</value>
        [DataMember(Name="realisedGainLoss", EmitDefaultValue=false)]
        public List<RealisedGainLoss> RealisedGainLoss { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutputTransaction {\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  InstrumentIdentifiers: ").Append(InstrumentIdentifiers).Append("\n");
            sb.Append("  InstrumentUid: ").Append(InstrumentUid).Append("\n");
            sb.Append("  TransactionDate: ").Append(TransactionDate).Append("\n");
            sb.Append("  SettlementDate: ").Append(SettlementDate).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  TransactionAmount: ").Append(TransactionAmount).Append("\n");
            sb.Append("  TransactionPrice: ").Append(TransactionPrice).Append("\n");
            sb.Append("  TotalConsideration: ").Append(TotalConsideration).Append("\n");
            sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
            sb.Append("  TransactionToPortfolioRate: ").Append(TransactionToPortfolioRate).Append("\n");
            sb.Append("  TransactionCurrency: ").Append(TransactionCurrency).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  CounterpartyId: ").Append(CounterpartyId).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  TransactionStatus: ").Append(TransactionStatus).Append("\n");
            sb.Append("  EntryDateTime: ").Append(EntryDateTime).Append("\n");
            sb.Append("  CancelDateTime: ").Append(CancelDateTime).Append("\n");
            sb.Append("  RealisedGainLoss: ").Append(RealisedGainLoss).Append("\n");
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
            return this.Equals(input as OutputTransaction);
        }

        /// <summary>
        /// Returns true if OutputTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of OutputTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutputTransaction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
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
                    this.TransactionDate == input.TransactionDate ||
                    (this.TransactionDate != null &&
                    this.TransactionDate.Equals(input.TransactionDate))
                ) && 
                (
                    this.SettlementDate == input.SettlementDate ||
                    (this.SettlementDate != null &&
                    this.SettlementDate.Equals(input.SettlementDate))
                ) && 
                (
                    this.Units == input.Units ||
                    (this.Units != null &&
                    this.Units.Equals(input.Units))
                ) && 
                (
                    this.TransactionAmount == input.TransactionAmount ||
                    (this.TransactionAmount != null &&
                    this.TransactionAmount.Equals(input.TransactionAmount))
                ) && 
                (
                    this.TransactionPrice == input.TransactionPrice ||
                    (this.TransactionPrice != null &&
                    this.TransactionPrice.Equals(input.TransactionPrice))
                ) && 
                (
                    this.TotalConsideration == input.TotalConsideration ||
                    (this.TotalConsideration != null &&
                    this.TotalConsideration.Equals(input.TotalConsideration))
                ) && 
                (
                    this.ExchangeRate == input.ExchangeRate ||
                    (this.ExchangeRate != null &&
                    this.ExchangeRate.Equals(input.ExchangeRate))
                ) && 
                (
                    this.TransactionToPortfolioRate == input.TransactionToPortfolioRate ||
                    (this.TransactionToPortfolioRate != null &&
                    this.TransactionToPortfolioRate.Equals(input.TransactionToPortfolioRate))
                ) && 
                (
                    this.TransactionCurrency == input.TransactionCurrency ||
                    (this.TransactionCurrency != null &&
                    this.TransactionCurrency.Equals(input.TransactionCurrency))
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.CounterpartyId == input.CounterpartyId ||
                    (this.CounterpartyId != null &&
                    this.CounterpartyId.Equals(input.CounterpartyId))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.TransactionStatus == input.TransactionStatus ||
                    (this.TransactionStatus != null &&
                    this.TransactionStatus.Equals(input.TransactionStatus))
                ) && 
                (
                    this.EntryDateTime == input.EntryDateTime ||
                    (this.EntryDateTime != null &&
                    this.EntryDateTime.Equals(input.EntryDateTime))
                ) && 
                (
                    this.CancelDateTime == input.CancelDateTime ||
                    (this.CancelDateTime != null &&
                    this.CancelDateTime.Equals(input.CancelDateTime))
                ) && 
                (
                    this.RealisedGainLoss == input.RealisedGainLoss ||
                    this.RealisedGainLoss != null &&
                    input.RealisedGainLoss != null &&
                    this.RealisedGainLoss.SequenceEqual(input.RealisedGainLoss)
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
                if (this.TransactionId != null)
                    hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.InstrumentIdentifiers != null)
                    hashCode = hashCode * 59 + this.InstrumentIdentifiers.GetHashCode();
                if (this.InstrumentUid != null)
                    hashCode = hashCode * 59 + this.InstrumentUid.GetHashCode();
                if (this.TransactionDate != null)
                    hashCode = hashCode * 59 + this.TransactionDate.GetHashCode();
                if (this.SettlementDate != null)
                    hashCode = hashCode * 59 + this.SettlementDate.GetHashCode();
                if (this.Units != null)
                    hashCode = hashCode * 59 + this.Units.GetHashCode();
                if (this.TransactionAmount != null)
                    hashCode = hashCode * 59 + this.TransactionAmount.GetHashCode();
                if (this.TransactionPrice != null)
                    hashCode = hashCode * 59 + this.TransactionPrice.GetHashCode();
                if (this.TotalConsideration != null)
                    hashCode = hashCode * 59 + this.TotalConsideration.GetHashCode();
                if (this.ExchangeRate != null)
                    hashCode = hashCode * 59 + this.ExchangeRate.GetHashCode();
                if (this.TransactionToPortfolioRate != null)
                    hashCode = hashCode * 59 + this.TransactionToPortfolioRate.GetHashCode();
                if (this.TransactionCurrency != null)
                    hashCode = hashCode * 59 + this.TransactionCurrency.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.CounterpartyId != null)
                    hashCode = hashCode * 59 + this.CounterpartyId.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.TransactionStatus != null)
                    hashCode = hashCode * 59 + this.TransactionStatus.GetHashCode();
                if (this.EntryDateTime != null)
                    hashCode = hashCode * 59 + this.EntryDateTime.GetHashCode();
                if (this.CancelDateTime != null)
                    hashCode = hashCode * 59 + this.CancelDateTime.GetHashCode();
                if (this.RealisedGainLoss != null)
                    hashCode = hashCode * 59 + this.RealisedGainLoss.GetHashCode();
                return hashCode;
            }
        }
    }

}
