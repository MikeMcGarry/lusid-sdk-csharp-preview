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
    /// Stream
    /// </summary>
    [DataContract]
    public partial class Stream :  IEquatable<Stream>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Stream" /> class.
        /// </summary>
        /// <param name="position">position.</param>
        /// <param name="readTimeout">readTimeout.</param>
        /// <param name="writeTimeout">writeTimeout.</param>
        public Stream(long? position = default(long?), int? readTimeout = default(int?), int? writeTimeout = default(int?))
        {
            this.Position = position;
            this.ReadTimeout = readTimeout;
            this.WriteTimeout = writeTimeout;
        }
        
        /// <summary>
        /// Gets or Sets CanRead
        /// </summary>
        [DataMember(Name="canRead", EmitDefaultValue=false)]
        public bool? CanRead { get; private set; }

        /// <summary>
        /// Gets or Sets CanSeek
        /// </summary>
        [DataMember(Name="canSeek", EmitDefaultValue=false)]
        public bool? CanSeek { get; private set; }

        /// <summary>
        /// Gets or Sets CanTimeout
        /// </summary>
        [DataMember(Name="canTimeout", EmitDefaultValue=false)]
        public bool? CanTimeout { get; private set; }

        /// <summary>
        /// Gets or Sets CanWrite
        /// </summary>
        [DataMember(Name="canWrite", EmitDefaultValue=false)]
        public bool? CanWrite { get; private set; }

        /// <summary>
        /// Gets or Sets Length
        /// </summary>
        [DataMember(Name="length", EmitDefaultValue=false)]
        public long? Length { get; private set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public long? Position { get; set; }

        /// <summary>
        /// Gets or Sets ReadTimeout
        /// </summary>
        [DataMember(Name="readTimeout", EmitDefaultValue=false)]
        public int? ReadTimeout { get; set; }

        /// <summary>
        /// Gets or Sets WriteTimeout
        /// </summary>
        [DataMember(Name="writeTimeout", EmitDefaultValue=false)]
        public int? WriteTimeout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Stream {\n");
            sb.Append("  CanRead: ").Append(CanRead).Append("\n");
            sb.Append("  CanSeek: ").Append(CanSeek).Append("\n");
            sb.Append("  CanTimeout: ").Append(CanTimeout).Append("\n");
            sb.Append("  CanWrite: ").Append(CanWrite).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  ReadTimeout: ").Append(ReadTimeout).Append("\n");
            sb.Append("  WriteTimeout: ").Append(WriteTimeout).Append("\n");
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
            return this.Equals(input as Stream);
        }

        /// <summary>
        /// Returns true if Stream instances are equal
        /// </summary>
        /// <param name="input">Instance of Stream to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Stream input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CanRead == input.CanRead ||
                    (this.CanRead != null &&
                    this.CanRead.Equals(input.CanRead))
                ) && 
                (
                    this.CanSeek == input.CanSeek ||
                    (this.CanSeek != null &&
                    this.CanSeek.Equals(input.CanSeek))
                ) && 
                (
                    this.CanTimeout == input.CanTimeout ||
                    (this.CanTimeout != null &&
                    this.CanTimeout.Equals(input.CanTimeout))
                ) && 
                (
                    this.CanWrite == input.CanWrite ||
                    (this.CanWrite != null &&
                    this.CanWrite.Equals(input.CanWrite))
                ) && 
                (
                    this.Length == input.Length ||
                    (this.Length != null &&
                    this.Length.Equals(input.Length))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.ReadTimeout == input.ReadTimeout ||
                    (this.ReadTimeout != null &&
                    this.ReadTimeout.Equals(input.ReadTimeout))
                ) && 
                (
                    this.WriteTimeout == input.WriteTimeout ||
                    (this.WriteTimeout != null &&
                    this.WriteTimeout.Equals(input.WriteTimeout))
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
                if (this.CanRead != null)
                    hashCode = hashCode * 59 + this.CanRead.GetHashCode();
                if (this.CanSeek != null)
                    hashCode = hashCode * 59 + this.CanSeek.GetHashCode();
                if (this.CanTimeout != null)
                    hashCode = hashCode * 59 + this.CanTimeout.GetHashCode();
                if (this.CanWrite != null)
                    hashCode = hashCode * 59 + this.CanWrite.GetHashCode();
                if (this.Length != null)
                    hashCode = hashCode * 59 + this.Length.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.ReadTimeout != null)
                    hashCode = hashCode * 59 + this.ReadTimeout.GetHashCode();
                if (this.WriteTimeout != null)
                    hashCode = hashCode * 59 + this.WriteTimeout.GetHashCode();
                return hashCode;
            }
        }
    }

}
