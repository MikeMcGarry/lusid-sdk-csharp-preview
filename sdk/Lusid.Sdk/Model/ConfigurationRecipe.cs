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
    /// The Configuration or Calculation Recipe controls how LUSID processes a given request.  This can be used to change where market data used in pricing is loaded from and in what order, or which model is used to  price a given instrument as well as how aggregation will process the produced results.
    /// </summary>
    [DataContract]
    public partial class ConfigurationRecipe :  IEquatable<ConfigurationRecipe>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationRecipe" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConfigurationRecipe() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationRecipe" /> class.
        /// </summary>
        /// <param name="code">User given string name (code) to identify the recipe. (required).</param>
        /// <param name="market">market.</param>
        /// <param name="pricing">pricing.</param>
        /// <param name="aggregation">aggregation.</param>
        /// <param name="inheritedRecipes">A list of parent recipes (scope,code) that can be used to share functionality between recipes. For instance one might use common recipes to set up  pricing for individual asset classes, e.g. rates or credit, and then combine them into a single recipe to be used by an exotics desk in conjunction with  some overrides that it requires for models or other pricing options..</param>
        /// <param name="description">User can assign a description to understand more humanly the recipe..</param>
        public ConfigurationRecipe(string code = default(string), MarketContext market = default(MarketContext), PricingContext pricing = default(PricingContext), AggregationContext aggregation = default(AggregationContext), List<ResourceId> inheritedRecipes = default(List<ResourceId>), string description = default(string))
        {
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new InvalidDataException("code is a required property for ConfigurationRecipe and cannot be null");
            }
            else
            {
                this.Code = code;
            }
            
            this.Market = market;
            this.Pricing = pricing;
            this.Aggregation = aggregation;
            this.InheritedRecipes = inheritedRecipes;
            this.Description = description;
        }
        
        /// <summary>
        /// User given string name (code) to identify the recipe.
        /// </summary>
        /// <value>User given string name (code) to identify the recipe.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Market
        /// </summary>
        [DataMember(Name="market", EmitDefaultValue=false)]
        public MarketContext Market { get; set; }

        /// <summary>
        /// Gets or Sets Pricing
        /// </summary>
        [DataMember(Name="pricing", EmitDefaultValue=false)]
        public PricingContext Pricing { get; set; }

        /// <summary>
        /// Gets or Sets Aggregation
        /// </summary>
        [DataMember(Name="aggregation", EmitDefaultValue=false)]
        public AggregationContext Aggregation { get; set; }

        /// <summary>
        /// A list of parent recipes (scope,code) that can be used to share functionality between recipes. For instance one might use common recipes to set up  pricing for individual asset classes, e.g. rates or credit, and then combine them into a single recipe to be used by an exotics desk in conjunction with  some overrides that it requires for models or other pricing options.
        /// </summary>
        /// <value>A list of parent recipes (scope,code) that can be used to share functionality between recipes. For instance one might use common recipes to set up  pricing for individual asset classes, e.g. rates or credit, and then combine them into a single recipe to be used by an exotics desk in conjunction with  some overrides that it requires for models or other pricing options.</value>
        [DataMember(Name="inheritedRecipes", EmitDefaultValue=false)]
        public List<ResourceId> InheritedRecipes { get; set; }

        /// <summary>
        /// User can assign a description to understand more humanly the recipe.
        /// </summary>
        /// <value>User can assign a description to understand more humanly the recipe.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigurationRecipe {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Market: ").Append(Market).Append("\n");
            sb.Append("  Pricing: ").Append(Pricing).Append("\n");
            sb.Append("  Aggregation: ").Append(Aggregation).Append("\n");
            sb.Append("  InheritedRecipes: ").Append(InheritedRecipes).Append("\n");
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
            return this.Equals(input as ConfigurationRecipe);
        }

        /// <summary>
        /// Returns true if ConfigurationRecipe instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigurationRecipe to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigurationRecipe input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Market == input.Market ||
                    (this.Market != null &&
                    this.Market.Equals(input.Market))
                ) && 
                (
                    this.Pricing == input.Pricing ||
                    (this.Pricing != null &&
                    this.Pricing.Equals(input.Pricing))
                ) && 
                (
                    this.Aggregation == input.Aggregation ||
                    (this.Aggregation != null &&
                    this.Aggregation.Equals(input.Aggregation))
                ) && 
                (
                    this.InheritedRecipes == input.InheritedRecipes ||
                    this.InheritedRecipes != null &&
                    input.InheritedRecipes != null &&
                    this.InheritedRecipes.SequenceEqual(input.InheritedRecipes)
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Market != null)
                    hashCode = hashCode * 59 + this.Market.GetHashCode();
                if (this.Pricing != null)
                    hashCode = hashCode * 59 + this.Pricing.GetHashCode();
                if (this.Aggregation != null)
                    hashCode = hashCode * 59 + this.Aggregation.GetHashCode();
                if (this.InheritedRecipes != null)
                    hashCode = hashCode * 59 + this.InheritedRecipes.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }

}
