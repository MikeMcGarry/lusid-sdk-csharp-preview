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
    /// Allows a file (represented as a stream) to be returned from an Api call
    /// </summary>
    [DataContract]
    public partial class FileResponse :  IEquatable<FileResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileResponse" /> class.
        /// </summary>
        /// <param name="fileStream">fileStream.</param>
        public FileResponse(Stream fileStream = default(Stream))
        {
            this.FileStream = fileStream;
        }
        
        /// <summary>
        /// Gets or Sets FileStream
        /// </summary>
        [DataMember(Name="fileStream", EmitDefaultValue=false)]
        public Stream FileStream { get; set; }

        /// <summary>
        /// Gets or Sets ContentType
        /// </summary>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public string ContentType { get; private set; }

        /// <summary>
        /// Gets or Sets DownloadedFilename
        /// </summary>
        [DataMember(Name="downloadedFilename", EmitDefaultValue=false)]
        public string DownloadedFilename { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileResponse {\n");
            sb.Append("  FileStream: ").Append(FileStream).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  DownloadedFilename: ").Append(DownloadedFilename).Append("\n");
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
            return this.Equals(input as FileResponse);
        }

        /// <summary>
        /// Returns true if FileResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of FileResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileStream == input.FileStream ||
                    (this.FileStream != null &&
                    this.FileStream.Equals(input.FileStream))
                ) && 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.DownloadedFilename == input.DownloadedFilename ||
                    (this.DownloadedFilename != null &&
                    this.DownloadedFilename.Equals(input.DownloadedFilename))
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
                if (this.FileStream != null)
                    hashCode = hashCode * 59 + this.FileStream.GetHashCode();
                if (this.ContentType != null)
                    hashCode = hashCode * 59 + this.ContentType.GetHashCode();
                if (this.DownloadedFilename != null)
                    hashCode = hashCode * 59 + this.DownloadedFilename.GetHashCode();
                return hashCode;
            }
        }
    }

}
