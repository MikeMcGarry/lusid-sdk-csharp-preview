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
    /// This request specifies a new Cut Label Definition
    /// </summary>
    [DataContract]
    public partial class UpdateCutLabelDefinitionRequest :  IEquatable<UpdateCutLabelDefinitionRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCutLabelDefinitionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateCutLabelDefinitionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCutLabelDefinitionRequest" /> class.
        /// </summary>
        /// <param name="displayName">displayName (required).</param>
        /// <param name="description">description.</param>
        /// <param name="cutLocalTime">cutLocalTime (required).</param>
        /// <param name="timeZone">timeZone (required).</param>
        public UpdateCutLabelDefinitionRequest(string displayName = default(string), string description = default(string), CutLocalTime cutLocalTime = default(CutLocalTime), string timeZone = default(string))
        {
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new InvalidDataException("displayName is a required property for UpdateCutLabelDefinitionRequest and cannot be null");
            }
            else
            {
                this.DisplayName = displayName;
            }
            
            // to ensure "cutLocalTime" is required (not null)
            if (cutLocalTime == null)
            {
                throw new InvalidDataException("cutLocalTime is a required property for UpdateCutLabelDefinitionRequest and cannot be null");
            }
            else
            {
                this.CutLocalTime = cutLocalTime;
            }
            
            // to ensure "timeZone" is required (not null)
            if (timeZone == null)
            {
                throw new InvalidDataException("timeZone is a required property for UpdateCutLabelDefinitionRequest and cannot be null");
            }
            else
            {
                this.TimeZone = timeZone;
            }
            
            this.Description = description;
        }
        
        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets CutLocalTime
        /// </summary>
        [DataMember(Name="cutLocalTime", EmitDefaultValue=false)]
        public CutLocalTime CutLocalTime { get; set; }

        /// <summary>
        /// Gets or Sets TimeZone
        /// </summary>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCutLabelDefinitionRequest {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CutLocalTime: ").Append(CutLocalTime).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
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
            return this.Equals(input as UpdateCutLabelDefinitionRequest);
        }

        /// <summary>
        /// Returns true if UpdateCutLabelDefinitionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateCutLabelDefinitionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateCutLabelDefinitionRequest input)
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
                    this.CutLocalTime == input.CutLocalTime ||
                    (this.CutLocalTime != null &&
                    this.CutLocalTime.Equals(input.CutLocalTime))
                ) && 
                (
                    this.TimeZone == input.TimeZone ||
                    (this.TimeZone != null &&
                    this.TimeZone.Equals(input.TimeZone))
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
                if (this.CutLocalTime != null)
                    hashCode = hashCode * 59 + this.CutLocalTime.GetHashCode();
                if (this.TimeZone != null)
                    hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                return hashCode;
            }
        }
    }

}
