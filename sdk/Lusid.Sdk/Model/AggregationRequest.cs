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
    /// Specification object for the parameters of an aggregation
    /// </summary>
    [DataContract]
    public partial class AggregationRequest :  IEquatable<AggregationRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AggregationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregationRequest" /> class.
        /// </summary>
        /// <param name="recipeId">recipeId.</param>
        /// <param name="inlineRecipe">inlineRecipe.</param>
        /// <param name="asAt">The asAt date to use.</param>
        /// <param name="effectiveFrom">If present, the EffectiveFrom and EffectiveAt dates are interpreted as a range of dates for which to perform a valuation.  In this case, valuation is calculated for the portfolio(s) for each date that is a business day in the given range..</param>
        /// <param name="effectiveAt">The market data time, i.e. the time to run the aggregation request effective of. (required).</param>
        /// <param name="metrics">The set of specifications for items to calculate or retrieve during the aggregation and present in the results.  This is logically equivalent to the set of operations in a Sql select statement  select [operation1(field1), operation2(field2), ... ] from results (required).</param>
        /// <param name="groupBy">The set of items by which to perform grouping. This primarily matters when one or more of the metric operators is a mapping  that reduces set size, e.g. sum or proportion. The group-by statement determines the set of keys by which to break the results out..</param>
        /// <param name="filters">A set of filters to use to reduce the data found in a request. Equivalent to the &#39;where ...&#39; part of a Sql select statement.  For example, filter a set of values within a given range or matching a particular value..</param>
        /// <param name="limit">limit the results to a particular number of values..</param>
        /// <param name="sort">A (possibly empty/null) set of specifications for how to order the results..</param>
        /// <param name="reportCcy">Three letter ISO currency string indicating what currency to report in for ReportCcy denominated queries.  If not present then the currency of the relevant portfolio will be used in its place where relevant..</param>
        public AggregationRequest(ResourceId recipeId = default(ResourceId), ConfigurationRecipe inlineRecipe = default(ConfigurationRecipe), DateTimeOffset? asAt = default(DateTimeOffset?), DateTimeOrCutLabel effectiveFrom = default(DateTimeOrCutLabel), DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), List<AggregateSpec> metrics = default(List<AggregateSpec>), List<string> groupBy = default(List<string>), List<PropertyFilter> filters = default(List<PropertyFilter>), int? limit = default(int?), List<OrderBySpec> sort = default(List<OrderBySpec>), string reportCcy = default(string))
        {
            // to ensure "effectiveAt" is required (not null)
            if (effectiveAt == null)
            {
                throw new InvalidDataException("effectiveAt is a required property for AggregationRequest and cannot be null");
            }
            else
            {
                this.EffectiveAt = effectiveAt;
            }
            
            // to ensure "metrics" is required (not null)
            if (metrics == null)
            {
                throw new InvalidDataException("metrics is a required property for AggregationRequest and cannot be null");
            }
            else
            {
                this.Metrics = metrics;
            }
            
            this.RecipeId = recipeId;
            this.InlineRecipe = inlineRecipe;
            this.AsAt = asAt;
            this.EffectiveFrom = effectiveFrom;
            this.GroupBy = groupBy;
            this.Filters = filters;
            this.Limit = limit;
            this.Sort = sort;
            this.ReportCcy = reportCcy;
        }
        
        /// <summary>
        /// Gets or Sets RecipeId
        /// </summary>
        [DataMember(Name="recipeId", EmitDefaultValue=false)]
        public ResourceId RecipeId { get; set; }

        /// <summary>
        /// Gets or Sets InlineRecipe
        /// </summary>
        [DataMember(Name="inlineRecipe", EmitDefaultValue=false)]
        public ConfigurationRecipe InlineRecipe { get; set; }

        /// <summary>
        /// The asAt date to use
        /// </summary>
        /// <value>The asAt date to use</value>
        [DataMember(Name="asAt", EmitDefaultValue=false)]
        public DateTimeOffset? AsAt { get; set; }

        /// <summary>
        /// If present, the EffectiveFrom and EffectiveAt dates are interpreted as a range of dates for which to perform a valuation.  In this case, valuation is calculated for the portfolio(s) for each date that is a business day in the given range.
        /// </summary>
        /// <value>If present, the EffectiveFrom and EffectiveAt dates are interpreted as a range of dates for which to perform a valuation.  In this case, valuation is calculated for the portfolio(s) for each date that is a business day in the given range.</value>
        [DataMember(Name="effectiveFrom", EmitDefaultValue=false)]
        public DateTimeOrCutLabel EffectiveFrom { get; set; }

        /// <summary>
        /// The market data time, i.e. the time to run the aggregation request effective of.
        /// </summary>
        /// <value>The market data time, i.e. the time to run the aggregation request effective of.</value>
        [DataMember(Name="effectiveAt", EmitDefaultValue=false)]
        public DateTimeOrCutLabel EffectiveAt { get; set; }

        /// <summary>
        /// The set of specifications for items to calculate or retrieve during the aggregation and present in the results.  This is logically equivalent to the set of operations in a Sql select statement  select [operation1(field1), operation2(field2), ... ] from results
        /// </summary>
        /// <value>The set of specifications for items to calculate or retrieve during the aggregation and present in the results.  This is logically equivalent to the set of operations in a Sql select statement  select [operation1(field1), operation2(field2), ... ] from results</value>
        [DataMember(Name="metrics", EmitDefaultValue=false)]
        public List<AggregateSpec> Metrics { get; set; }

        /// <summary>
        /// The set of items by which to perform grouping. This primarily matters when one or more of the metric operators is a mapping  that reduces set size, e.g. sum or proportion. The group-by statement determines the set of keys by which to break the results out.
        /// </summary>
        /// <value>The set of items by which to perform grouping. This primarily matters when one or more of the metric operators is a mapping  that reduces set size, e.g. sum or proportion. The group-by statement determines the set of keys by which to break the results out.</value>
        [DataMember(Name="groupBy", EmitDefaultValue=false)]
        public List<string> GroupBy { get; set; }

        /// <summary>
        /// A set of filters to use to reduce the data found in a request. Equivalent to the &#39;where ...&#39; part of a Sql select statement.  For example, filter a set of values within a given range or matching a particular value.
        /// </summary>
        /// <value>A set of filters to use to reduce the data found in a request. Equivalent to the &#39;where ...&#39; part of a Sql select statement.  For example, filter a set of values within a given range or matching a particular value.</value>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public List<PropertyFilter> Filters { get; set; }

        /// <summary>
        /// limit the results to a particular number of values.
        /// </summary>
        /// <value>limit the results to a particular number of values.</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// A (possibly empty/null) set of specifications for how to order the results.
        /// </summary>
        /// <value>A (possibly empty/null) set of specifications for how to order the results.</value>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public List<OrderBySpec> Sort { get; set; }

        /// <summary>
        /// Three letter ISO currency string indicating what currency to report in for ReportCcy denominated queries.  If not present then the currency of the relevant portfolio will be used in its place where relevant.
        /// </summary>
        /// <value>Three letter ISO currency string indicating what currency to report in for ReportCcy denominated queries.  If not present then the currency of the relevant portfolio will be used in its place where relevant.</value>
        [DataMember(Name="reportCcy", EmitDefaultValue=false)]
        public string ReportCcy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AggregationRequest {\n");
            sb.Append("  RecipeId: ").Append(RecipeId).Append("\n");
            sb.Append("  InlineRecipe: ").Append(InlineRecipe).Append("\n");
            sb.Append("  AsAt: ").Append(AsAt).Append("\n");
            sb.Append("  EffectiveFrom: ").Append(EffectiveFrom).Append("\n");
            sb.Append("  EffectiveAt: ").Append(EffectiveAt).Append("\n");
            sb.Append("  Metrics: ").Append(Metrics).Append("\n");
            sb.Append("  GroupBy: ").Append(GroupBy).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  ReportCcy: ").Append(ReportCcy).Append("\n");
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
            return this.Equals(input as AggregationRequest);
        }

        /// <summary>
        /// Returns true if AggregationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AggregationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AggregationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecipeId == input.RecipeId ||
                    (this.RecipeId != null &&
                    this.RecipeId.Equals(input.RecipeId))
                ) && 
                (
                    this.InlineRecipe == input.InlineRecipe ||
                    (this.InlineRecipe != null &&
                    this.InlineRecipe.Equals(input.InlineRecipe))
                ) && 
                (
                    this.AsAt == input.AsAt ||
                    (this.AsAt != null &&
                    this.AsAt.Equals(input.AsAt))
                ) && 
                (
                    this.EffectiveFrom == input.EffectiveFrom ||
                    (this.EffectiveFrom != null &&
                    this.EffectiveFrom.Equals(input.EffectiveFrom))
                ) && 
                (
                    this.EffectiveAt == input.EffectiveAt ||
                    (this.EffectiveAt != null &&
                    this.EffectiveAt.Equals(input.EffectiveAt))
                ) && 
                (
                    this.Metrics == input.Metrics ||
                    this.Metrics != null &&
                    input.Metrics != null &&
                    this.Metrics.SequenceEqual(input.Metrics)
                ) && 
                (
                    this.GroupBy == input.GroupBy ||
                    this.GroupBy != null &&
                    input.GroupBy != null &&
                    this.GroupBy.SequenceEqual(input.GroupBy)
                ) && 
                (
                    this.Filters == input.Filters ||
                    this.Filters != null &&
                    input.Filters != null &&
                    this.Filters.SequenceEqual(input.Filters)
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Sort == input.Sort ||
                    this.Sort != null &&
                    input.Sort != null &&
                    this.Sort.SequenceEqual(input.Sort)
                ) && 
                (
                    this.ReportCcy == input.ReportCcy ||
                    (this.ReportCcy != null &&
                    this.ReportCcy.Equals(input.ReportCcy))
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
                if (this.RecipeId != null)
                    hashCode = hashCode * 59 + this.RecipeId.GetHashCode();
                if (this.InlineRecipe != null)
                    hashCode = hashCode * 59 + this.InlineRecipe.GetHashCode();
                if (this.AsAt != null)
                    hashCode = hashCode * 59 + this.AsAt.GetHashCode();
                if (this.EffectiveFrom != null)
                    hashCode = hashCode * 59 + this.EffectiveFrom.GetHashCode();
                if (this.EffectiveAt != null)
                    hashCode = hashCode * 59 + this.EffectiveAt.GetHashCode();
                if (this.Metrics != null)
                    hashCode = hashCode * 59 + this.Metrics.GetHashCode();
                if (this.GroupBy != null)
                    hashCode = hashCode * 59 + this.GroupBy.GetHashCode();
                if (this.Filters != null)
                    hashCode = hashCode * 59 + this.Filters.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Sort != null)
                    hashCode = hashCode * 59 + this.Sort.GetHashCode();
                if (this.ReportCcy != null)
                    hashCode = hashCode * 59 + this.ReportCcy.GetHashCode();
                return hashCode;
            }
        }
    }

}
