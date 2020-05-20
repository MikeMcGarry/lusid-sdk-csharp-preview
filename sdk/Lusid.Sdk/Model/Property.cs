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
    /// Property
    /// </summary>
    [DataContract]
    public partial class Property :  IEquatable<Property>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Property" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Property() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Property" /> class.
        /// </summary>
        /// <param name="key">The key of the property. This takes the format {domain}/{scope}/{code} e.g. &#39;Instrument/system/Name&#39; or &#39;Transaction/strategy/quantsignal&#39;. (required).</param>
        /// <param name="value">value (required).</param>
        /// <param name="effectiveFrom">The effective datetime from which the property is valid..</param>
        public Property(string key = default(string), PropertyValue value = default(PropertyValue), DateTimeOffset? effectiveFrom = default(DateTimeOffset?))
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new InvalidDataException("key is a required property for Property and cannot be null");
            }
            else
            {
                this.Key = key;
            }
            
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new InvalidDataException("value is a required property for Property and cannot be null");
            }
            else
            {
                this.Value = value;
            }
            
            this.EffectiveFrom = effectiveFrom;
        }
        
        /// <summary>
        /// The key of the property. This takes the format {domain}/{scope}/{code} e.g. &#39;Instrument/system/Name&#39; or &#39;Transaction/strategy/quantsignal&#39;.
        /// </summary>
        /// <value>The key of the property. This takes the format {domain}/{scope}/{code} e.g. &#39;Instrument/system/Name&#39; or &#39;Transaction/strategy/quantsignal&#39;.</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public PropertyValue Value { get; set; }

        /// <summary>
        /// The effective datetime from which the property is valid.
        /// </summary>
        /// <value>The effective datetime from which the property is valid.</value>
        [DataMember(Name="effectiveFrom", EmitDefaultValue=false)]
        public DateTimeOffset? EffectiveFrom { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Property {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  EffectiveFrom: ").Append(EffectiveFrom).Append("\n");
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
            return this.Equals(input as Property);
        }

        /// <summary>
        /// Returns true if Property instances are equal
        /// </summary>
        /// <param name="input">Instance of Property to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Property input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.EffectiveFrom == input.EffectiveFrom ||
                    (this.EffectiveFrom != null &&
                    this.EffectiveFrom.Equals(input.EffectiveFrom))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.EffectiveFrom != null)
                    hashCode = hashCode * 59 + this.EffectiveFrom.GetHashCode();
                return hashCode;
            }
        }
    }

}
