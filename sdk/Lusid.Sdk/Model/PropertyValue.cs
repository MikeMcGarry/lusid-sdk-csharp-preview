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
    /// The value of the property.
    /// </summary>
    [DataContract]
    public partial class PropertyValue :  IEquatable<PropertyValue>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyValue" /> class.
        /// </summary>
        /// <param name="labelValue">The text value of a property defined as having the &#39;Label&#39; type..</param>
        /// <param name="metricValue">metricValue.</param>
        public PropertyValue(string labelValue = default(string), MetricValue metricValue = default(MetricValue))
        {
            this.LabelValue = labelValue;
            this.MetricValue = metricValue;
        }
        
        /// <summary>
        /// The text value of a property defined as having the &#39;Label&#39; type.
        /// </summary>
        /// <value>The text value of a property defined as having the &#39;Label&#39; type.</value>
        [DataMember(Name="labelValue", EmitDefaultValue=false)]
        public string LabelValue { get; set; }

        /// <summary>
        /// Gets or Sets MetricValue
        /// </summary>
        [DataMember(Name="metricValue", EmitDefaultValue=false)]
        public MetricValue MetricValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropertyValue {\n");
            sb.Append("  LabelValue: ").Append(LabelValue).Append("\n");
            sb.Append("  MetricValue: ").Append(MetricValue).Append("\n");
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
            return this.Equals(input as PropertyValue);
        }

        /// <summary>
        /// Returns true if PropertyValue instances are equal
        /// </summary>
        /// <param name="input">Instance of PropertyValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertyValue input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LabelValue == input.LabelValue ||
                    (this.LabelValue != null &&
                    this.LabelValue.Equals(input.LabelValue))
                ) && 
                (
                    this.MetricValue == input.MetricValue ||
                    (this.MetricValue != null &&
                    this.MetricValue.Equals(input.MetricValue))
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
                if (this.LabelValue != null)
                    hashCode = hashCode * 59 + this.LabelValue.GetHashCode();
                if (this.MetricValue != null)
                    hashCode = hashCode * 59 + this.MetricValue.GetHashCode();
                return hashCode;
            }
        }
    }

}
