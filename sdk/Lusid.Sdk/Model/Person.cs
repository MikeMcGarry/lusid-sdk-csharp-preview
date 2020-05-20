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
    /// Person
    /// </summary>
    [DataContract]
    public partial class Person :  IEquatable<Person>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person" /> class.
        /// </summary>
        /// <param name="identifiers">Unique client-defined identifiers of the Person..</param>
        /// <param name="properties">A set of properties associated to the Person. There can be multiple properties associated with a property key..</param>
        /// <param name="version">version.</param>
        public Person(Dictionary<string, Property> identifiers = default(Dictionary<string, Property>), Dictionary<string, List<Property>> properties = default(Dictionary<string, List<Property>>), Version version = default(Version))
        {
            this.Identifiers = identifiers;
            this.Properties = properties;
            this.Version = version;
        }
        
        /// <summary>
        /// The specifc Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime.
        /// </summary>
        /// <value>The specifc Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime.</value>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; private set; }

        /// <summary>
        /// The unique LUSID Person Identifier (LUPID) of the Person.
        /// </summary>
        /// <value>The unique LUSID Person Identifier (LUPID) of the Person.</value>
        [DataMember(Name="lusidPersonId", EmitDefaultValue=false)]
        public string LusidPersonId { get; private set; }

        /// <summary>
        /// Unique client-defined identifiers of the Person.
        /// </summary>
        /// <value>Unique client-defined identifiers of the Person.</value>
        [DataMember(Name="identifiers", EmitDefaultValue=false)]
        public Dictionary<string, Property> Identifiers { get; set; }

        /// <summary>
        /// A set of properties associated to the Person. There can be multiple properties associated with a property key.
        /// </summary>
        /// <value>A set of properties associated to the Person. There can be multiple properties associated with a property key.</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Dictionary<string, List<Property>> Properties { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public Version Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Person {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  LusidPersonId: ").Append(LusidPersonId).Append("\n");
            sb.Append("  Identifiers: ").Append(Identifiers).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as Person);
        }

        /// <summary>
        /// Returns true if Person instances are equal
        /// </summary>
        /// <param name="input">Instance of Person to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Person input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.LusidPersonId == input.LusidPersonId ||
                    (this.LusidPersonId != null &&
                    this.LusidPersonId.Equals(input.LusidPersonId))
                ) && 
                (
                    this.Identifiers == input.Identifiers ||
                    this.Identifiers != null &&
                    input.Identifiers != null &&
                    this.Identifiers.SequenceEqual(input.Identifiers)
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.LusidPersonId != null)
                    hashCode = hashCode * 59 + this.LusidPersonId.GetHashCode();
                if (this.Identifiers != null)
                    hashCode = hashCode * 59 + this.Identifiers.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }
    }

}
