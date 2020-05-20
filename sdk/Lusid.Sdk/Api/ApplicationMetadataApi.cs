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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp.Portable;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Lusid.Sdk.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IApplicationMetadataApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// [EARLY ACCESS] Download Excel Addin
        /// </summary>
        /// <remarks>
        /// Download the LUSID Excel Addin for Microsoft Excel. Not providing a specific value will return the latest version being returned
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">The requested version of the Excel plugin (optional)</param>
        /// <returns>FileResponse</returns>
        FileResponse GetExcelAddin (string version = null);

        /// <summary>
        /// [EARLY ACCESS] Download Excel Addin
        /// </summary>
        /// <remarks>
        /// Download the LUSID Excel Addin for Microsoft Excel. Not providing a specific value will return the latest version being returned
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">The requested version of the Excel plugin (optional)</param>
        /// <returns>ApiResponse of FileResponse</returns>
        ApiResponse<FileResponse> GetExcelAddinWithHttpInfo (string version = null);
        /// <summary>
        /// [EARLY ACCESS] Get LUSID versions
        /// </summary>
        /// <remarks>
        /// Get the semantic versions associated with LUSID and its ecosystem
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>VersionSummaryDto</returns>
        VersionSummaryDto GetLusidVersions ();

        /// <summary>
        /// [EARLY ACCESS] Get LUSID versions
        /// </summary>
        /// <remarks>
        /// Get the semantic versions associated with LUSID and its ecosystem
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of VersionSummaryDto</returns>
        ApiResponse<VersionSummaryDto> GetLusidVersionsWithHttpInfo ();
        /// <summary>
        /// [EARLY ACCESS] Get resources available for access control
        /// </summary>
        /// <remarks>
        /// Get the comprehensive set of resources that are available for access control
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Optional. Expression to filter the result set.               For example, to filter on the Application, use \&quot;application eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ResourceListOfAccessControlledResource</returns>
        ResourceListOfAccessControlledResource ListAccessControlledResources (string filter = null);

        /// <summary>
        /// [EARLY ACCESS] Get resources available for access control
        /// </summary>
        /// <remarks>
        /// Get the comprehensive set of resources that are available for access control
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Optional. Expression to filter the result set.               For example, to filter on the Application, use \&quot;application eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfAccessControlledResource</returns>
        ApiResponse<ResourceListOfAccessControlledResource> ListAccessControlledResourcesWithHttpInfo (string filter = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// [EARLY ACCESS] Download Excel Addin
        /// </summary>
        /// <remarks>
        /// Download the LUSID Excel Addin for Microsoft Excel. Not providing a specific value will return the latest version being returned
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">The requested version of the Excel plugin (optional)</param>
        /// <returns>Task of FileResponse</returns>
        System.Threading.Tasks.Task<FileResponse> GetExcelAddinAsync (string version = null);

        /// <summary>
        /// [EARLY ACCESS] Download Excel Addin
        /// </summary>
        /// <remarks>
        /// Download the LUSID Excel Addin for Microsoft Excel. Not providing a specific value will return the latest version being returned
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">The requested version of the Excel plugin (optional)</param>
        /// <returns>Task of ApiResponse (FileResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileResponse>> GetExcelAddinAsyncWithHttpInfo (string version = null);
        /// <summary>
        /// [EARLY ACCESS] Get LUSID versions
        /// </summary>
        /// <remarks>
        /// Get the semantic versions associated with LUSID and its ecosystem
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of VersionSummaryDto</returns>
        System.Threading.Tasks.Task<VersionSummaryDto> GetLusidVersionsAsync ();

        /// <summary>
        /// [EARLY ACCESS] Get LUSID versions
        /// </summary>
        /// <remarks>
        /// Get the semantic versions associated with LUSID and its ecosystem
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (VersionSummaryDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<VersionSummaryDto>> GetLusidVersionsAsyncWithHttpInfo ();
        /// <summary>
        /// [EARLY ACCESS] Get resources available for access control
        /// </summary>
        /// <remarks>
        /// Get the comprehensive set of resources that are available for access control
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Optional. Expression to filter the result set.               For example, to filter on the Application, use \&quot;application eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>Task of ResourceListOfAccessControlledResource</returns>
        System.Threading.Tasks.Task<ResourceListOfAccessControlledResource> ListAccessControlledResourcesAsync (string filter = null);

        /// <summary>
        /// [EARLY ACCESS] Get resources available for access control
        /// </summary>
        /// <remarks>
        /// Get the comprehensive set of resources that are available for access control
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Optional. Expression to filter the result set.               For example, to filter on the Application, use \&quot;application eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>Task of ApiResponse (ResourceListOfAccessControlledResource)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfAccessControlledResource>> ListAccessControlledResourcesAsyncWithHttpInfo (string filter = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ApplicationMetadataApi : IApplicationMetadataApi
    {
        private Lusid.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationMetadataApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ApplicationMetadataApi(String basePath)
        {
            this.Configuration = new Lusid.Sdk.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Lusid.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationMetadataApi"/> class
        /// </summary>
        /// <returns></returns>
        public ApplicationMetadataApi()
        {
            this.Configuration = Lusid.Sdk.Client.Configuration.Default;

            ExceptionFactory = Lusid.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationMetadataApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ApplicationMetadataApi(Lusid.Sdk.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Lusid.Sdk.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Lusid.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Lusid.Sdk.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Lusid.Sdk.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// [EARLY ACCESS] Download Excel Addin Download the LUSID Excel Addin for Microsoft Excel. Not providing a specific value will return the latest version being returned
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">The requested version of the Excel plugin (optional)</param>
        /// <returns>FileResponse</returns>
        public FileResponse GetExcelAddin (string version = null)
        {
             ApiResponse<FileResponse> localVarResponse = GetExcelAddinWithHttpInfo(version);
             return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] Download Excel Addin Download the LUSID Excel Addin for Microsoft Excel. Not providing a specific value will return the latest version being returned
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">The requested version of the Excel plugin (optional)</param>
        /// <returns>ApiResponse of FileResponse</returns>
        public ApiResponse< FileResponse > GetExcelAddinWithHttpInfo (string version = null)
        {

            var localVarPath = "./api/metadata/downloads/exceladdin";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (version != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "version", version)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetExcelAddin", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FileResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (FileResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FileResponse)));
        }

        /// <summary>
        /// [EARLY ACCESS] Download Excel Addin Download the LUSID Excel Addin for Microsoft Excel. Not providing a specific value will return the latest version being returned
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">The requested version of the Excel plugin (optional)</param>
        /// <returns>Task of FileResponse</returns>
        public async System.Threading.Tasks.Task<FileResponse> GetExcelAddinAsync (string version = null)
        {
             ApiResponse<FileResponse> localVarResponse = await GetExcelAddinAsyncWithHttpInfo(version);
             return localVarResponse.Data;

        }

        /// <summary>
        /// [EARLY ACCESS] Download Excel Addin Download the LUSID Excel Addin for Microsoft Excel. Not providing a specific value will return the latest version being returned
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">The requested version of the Excel plugin (optional)</param>
        /// <returns>Task of ApiResponse (FileResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileResponse>> GetExcelAddinAsyncWithHttpInfo (string version = null)
        {

            var localVarPath = "./api/metadata/downloads/exceladdin";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (version != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "version", version)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetExcelAddin", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FileResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (FileResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FileResponse)));
        }

        /// <summary>
        /// [EARLY ACCESS] Get LUSID versions Get the semantic versions associated with LUSID and its ecosystem
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>VersionSummaryDto</returns>
        public VersionSummaryDto GetLusidVersions ()
        {
             ApiResponse<VersionSummaryDto> localVarResponse = GetLusidVersionsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] Get LUSID versions Get the semantic versions associated with LUSID and its ecosystem
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of VersionSummaryDto</returns>
        public ApiResponse< VersionSummaryDto > GetLusidVersionsWithHttpInfo ()
        {

            var localVarPath = "./api/metadata/versions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetLusidVersions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VersionSummaryDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (VersionSummaryDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VersionSummaryDto)));
        }

        /// <summary>
        /// [EARLY ACCESS] Get LUSID versions Get the semantic versions associated with LUSID and its ecosystem
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of VersionSummaryDto</returns>
        public async System.Threading.Tasks.Task<VersionSummaryDto> GetLusidVersionsAsync ()
        {
             ApiResponse<VersionSummaryDto> localVarResponse = await GetLusidVersionsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// [EARLY ACCESS] Get LUSID versions Get the semantic versions associated with LUSID and its ecosystem
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (VersionSummaryDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VersionSummaryDto>> GetLusidVersionsAsyncWithHttpInfo ()
        {

            var localVarPath = "./api/metadata/versions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetLusidVersions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VersionSummaryDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (VersionSummaryDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VersionSummaryDto)));
        }

        /// <summary>
        /// [EARLY ACCESS] Get resources available for access control Get the comprehensive set of resources that are available for access control
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Optional. Expression to filter the result set.               For example, to filter on the Application, use \&quot;application eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ResourceListOfAccessControlledResource</returns>
        public ResourceListOfAccessControlledResource ListAccessControlledResources (string filter = null)
        {
             ApiResponse<ResourceListOfAccessControlledResource> localVarResponse = ListAccessControlledResourcesWithHttpInfo(filter);
             return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] Get resources available for access control Get the comprehensive set of resources that are available for access control
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Optional. Expression to filter the result set.               For example, to filter on the Application, use \&quot;application eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>ApiResponse of ResourceListOfAccessControlledResource</returns>
        public ApiResponse< ResourceListOfAccessControlledResource > ListAccessControlledResourcesWithHttpInfo (string filter = null)
        {

            var localVarPath = "./api/metadata/access/resources";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (filter != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "filter", filter)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListAccessControlledResources", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ResourceListOfAccessControlledResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (ResourceListOfAccessControlledResource) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResourceListOfAccessControlledResource)));
        }

        /// <summary>
        /// [EARLY ACCESS] Get resources available for access control Get the comprehensive set of resources that are available for access control
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Optional. Expression to filter the result set.               For example, to filter on the Application, use \&quot;application eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>Task of ResourceListOfAccessControlledResource</returns>
        public async System.Threading.Tasks.Task<ResourceListOfAccessControlledResource> ListAccessControlledResourcesAsync (string filter = null)
        {
             ApiResponse<ResourceListOfAccessControlledResource> localVarResponse = await ListAccessControlledResourcesAsyncWithHttpInfo(filter);
             return localVarResponse.Data;

        }

        /// <summary>
        /// [EARLY ACCESS] Get resources available for access control Get the comprehensive set of resources that are available for access control
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Optional. Expression to filter the result set.               For example, to filter on the Application, use \&quot;application eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)</param>
        /// <returns>Task of ApiResponse (ResourceListOfAccessControlledResource)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResourceListOfAccessControlledResource>> ListAccessControlledResourcesAsyncWithHttpInfo (string filter = null)
        {

            var localVarPath = "./api/metadata/access/resources";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (filter != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "filter", filter)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListAccessControlledResources", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ResourceListOfAccessControlledResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (ResourceListOfAccessControlledResource) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResourceListOfAccessControlledResource)));
        }

    }
}
