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
    /// CreateTransactionPortfolioRequest
    /// </summary>
    [DataContract]
    public partial class CreateTransactionPortfolioRequest :  IEquatable<CreateTransactionPortfolioRequest>
    {
        /// <summary>
        /// Determines the accounting treatment given to the transaction portfolio&#39;s tax lots.
        /// </summary>
        /// <value>Determines the accounting treatment given to the transaction portfolio&#39;s tax lots.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountingMethodEnum
        {
            /// <summary>
            /// Enum Default for value: Default
            /// </summary>
            [EnumMember(Value = "Default")]
            Default = 1,

            /// <summary>
            /// Enum AverageCost for value: AverageCost
            /// </summary>
            [EnumMember(Value = "AverageCost")]
            AverageCost = 2,

            /// <summary>
            /// Enum FirstInFirstOut for value: FirstInFirstOut
            /// </summary>
            [EnumMember(Value = "FirstInFirstOut")]
            FirstInFirstOut = 3,

            /// <summary>
            /// Enum LastInFirstOut for value: LastInFirstOut
            /// </summary>
            [EnumMember(Value = "LastInFirstOut")]
            LastInFirstOut = 4,

            /// <summary>
            /// Enum HighestCostFirst for value: HighestCostFirst
            /// </summary>
            [EnumMember(Value = "HighestCostFirst")]
            HighestCostFirst = 5,

            /// <summary>
            /// Enum LowestCostFirst for value: LowestCostFirst
            /// </summary>
            [EnumMember(Value = "LowestCostFirst")]
            LowestCostFirst = 6

        }

        /// <summary>
        /// Determines the accounting treatment given to the transaction portfolio&#39;s tax lots.
        /// </summary>
        /// <value>Determines the accounting treatment given to the transaction portfolio&#39;s tax lots.</value>
        [DataMember(Name="accountingMethod", EmitDefaultValue=false)]
        public AccountingMethodEnum? AccountingMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTransactionPortfolioRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateTransactionPortfolioRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTransactionPortfolioRequest" /> class.
        /// </summary>
        /// <param name="displayName">The name of the transaction portfolio. (required).</param>
        /// <param name="description">A long form description of the transaction portfolio..</param>
        /// <param name="code">The code that the transaction portfolio will be created with. Together with the scope this uniquely identifies the transaction portfolio. (required).</param>
        /// <param name="created">The effective datetime at which the transaction portfolio will be created. No transactions can be added to the transaction portfolio before this date. Defaults to the current LUSID system datetime if not specified..</param>
        /// <param name="baseCurrency">The base currency of the transaction portfolio. (required).</param>
        /// <param name="corporateActionSourceId">corporateActionSourceId.</param>
        /// <param name="accountingMethod">Determines the accounting treatment given to the transaction portfolio&#39;s tax lots..</param>
        /// <param name="subHoldingKeys">A set of unique transaction properties to group the transaction portfolio&#39;s holdings by. Each property must be from the &#39;Transaction&#39; domain and should be identified by its key which has the format {domain}/{scope}/{code}, e.g. &#39;Transaction/strategies/quantsignal&#39;..</param>
        /// <param name="properties">A set of unique portfolio properties to add to the transaction portfolio. Each property must be from the &#39;Portfolio&#39; domain and should be identified by its key which has the format {domain}/{scope}/{code}, e.g. &#39;Portfolio/Manager/Id&#39;. These properties must be pre-defined..</param>
        public CreateTransactionPortfolioRequest(string displayName = default(string), string description = default(string), string code = default(string), DateTimeOffset? created = default(DateTimeOffset?), string baseCurrency = default(string), ResourceId corporateActionSourceId = default(ResourceId), AccountingMethodEnum? accountingMethod = default(AccountingMethodEnum?), List<string> subHoldingKeys = default(List<string>), Dictionary<string, Property> properties = default(Dictionary<string, Property>))
        {
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new InvalidDataException("displayName is a required property for CreateTransactionPortfolioRequest and cannot be null");
            }
            else
            {
                this.DisplayName = displayName;
            }
            
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new InvalidDataException("code is a required property for CreateTransactionPortfolioRequest and cannot be null");
            }
            else
            {
                this.Code = code;
            }
            
            // to ensure "baseCurrency" is required (not null)
            if (baseCurrency == null)
            {
                throw new InvalidDataException("baseCurrency is a required property for CreateTransactionPortfolioRequest and cannot be null");
            }
            else
            {
                this.BaseCurrency = baseCurrency;
            }
            
            this.Description = description;
            this.Created = created;
            this.CorporateActionSourceId = corporateActionSourceId;
            this.AccountingMethod = accountingMethod;
            this.SubHoldingKeys = subHoldingKeys;
            this.Properties = properties;
        }
        
        /// <summary>
        /// The name of the transaction portfolio.
        /// </summary>
        /// <value>The name of the transaction portfolio.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// A long form description of the transaction portfolio.
        /// </summary>
        /// <value>A long form description of the transaction portfolio.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The code that the transaction portfolio will be created with. Together with the scope this uniquely identifies the transaction portfolio.
        /// </summary>
        /// <value>The code that the transaction portfolio will be created with. Together with the scope this uniquely identifies the transaction portfolio.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// The effective datetime at which the transaction portfolio will be created. No transactions can be added to the transaction portfolio before this date. Defaults to the current LUSID system datetime if not specified.
        /// </summary>
        /// <value>The effective datetime at which the transaction portfolio will be created. No transactions can be added to the transaction portfolio before this date. Defaults to the current LUSID system datetime if not specified.</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTimeOffset? Created { get; set; }

        /// <summary>
        /// The base currency of the transaction portfolio.
        /// </summary>
        /// <value>The base currency of the transaction portfolio.</value>
        [DataMember(Name="baseCurrency", EmitDefaultValue=false)]
        public string BaseCurrency { get; set; }

        /// <summary>
        /// Gets or Sets CorporateActionSourceId
        /// </summary>
        [DataMember(Name="corporateActionSourceId", EmitDefaultValue=false)]
        public ResourceId CorporateActionSourceId { get; set; }


        /// <summary>
        /// A set of unique transaction properties to group the transaction portfolio&#39;s holdings by. Each property must be from the &#39;Transaction&#39; domain and should be identified by its key which has the format {domain}/{scope}/{code}, e.g. &#39;Transaction/strategies/quantsignal&#39;.
        /// </summary>
        /// <value>A set of unique transaction properties to group the transaction portfolio&#39;s holdings by. Each property must be from the &#39;Transaction&#39; domain and should be identified by its key which has the format {domain}/{scope}/{code}, e.g. &#39;Transaction/strategies/quantsignal&#39;.</value>
        [DataMember(Name="subHoldingKeys", EmitDefaultValue=false)]
        public List<string> SubHoldingKeys { get; set; }

        /// <summary>
        /// A set of unique portfolio properties to add to the transaction portfolio. Each property must be from the &#39;Portfolio&#39; domain and should be identified by its key which has the format {domain}/{scope}/{code}, e.g. &#39;Portfolio/Manager/Id&#39;. These properties must be pre-defined.
        /// </summary>
        /// <value>A set of unique portfolio properties to add to the transaction portfolio. Each property must be from the &#39;Portfolio&#39; domain and should be identified by its key which has the format {domain}/{scope}/{code}, e.g. &#39;Portfolio/Manager/Id&#39;. These properties must be pre-defined.</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Dictionary<string, Property> Properties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTransactionPortfolioRequest {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  BaseCurrency: ").Append(BaseCurrency).Append("\n");
            sb.Append("  CorporateActionSourceId: ").Append(CorporateActionSourceId).Append("\n");
            sb.Append("  AccountingMethod: ").Append(AccountingMethod).Append("\n");
            sb.Append("  SubHoldingKeys: ").Append(SubHoldingKeys).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return this.Equals(input as CreateTransactionPortfolioRequest);
        }

        /// <summary>
        /// Returns true if CreateTransactionPortfolioRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateTransactionPortfolioRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateTransactionPortfolioRequest input)
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
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.BaseCurrency == input.BaseCurrency ||
                    (this.BaseCurrency != null &&
                    this.BaseCurrency.Equals(input.BaseCurrency))
                ) && 
                (
                    this.CorporateActionSourceId == input.CorporateActionSourceId ||
                    (this.CorporateActionSourceId != null &&
                    this.CorporateActionSourceId.Equals(input.CorporateActionSourceId))
                ) && 
                (
                    this.AccountingMethod == input.AccountingMethod ||
                    (this.AccountingMethod != null &&
                    this.AccountingMethod.Equals(input.AccountingMethod))
                ) && 
                (
                    this.SubHoldingKeys == input.SubHoldingKeys ||
                    this.SubHoldingKeys != null &&
                    input.SubHoldingKeys != null &&
                    this.SubHoldingKeys.SequenceEqual(input.SubHoldingKeys)
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.BaseCurrency != null)
                    hashCode = hashCode * 59 + this.BaseCurrency.GetHashCode();
                if (this.CorporateActionSourceId != null)
                    hashCode = hashCode * 59 + this.CorporateActionSourceId.GetHashCode();
                if (this.AccountingMethod != null)
                    hashCode = hashCode * 59 + this.AccountingMethod.GetHashCode();
                if (this.SubHoldingKeys != null)
                    hashCode = hashCode * 59 + this.SubHoldingKeys.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                return hashCode;
            }
        }
    }

}
