# Lusid.Sdk.Api.ReconciliationsApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReconcileHoldings**](ReconciliationsApi.md#reconcileholdings) | **POST** /api/portfolios/$reconcileholdings | [EARLY ACCESS] Reconcile portfolio holdings
[**ReconcileHoldingsPreview**](ReconciliationsApi.md#reconcileholdingspreview) | **POST** /api/portfolios/preview/$reconcileholdings | [EXPERIMENTAL] Reconcile portfolio holdings with given tolerance
[**ReconcileInline**](ReconciliationsApi.md#reconcileinline) | **POST** /api/portfolios/$reconcileInline | [EXPERIMENTAL] Reconcile valuations performed on one or two sets of inline instruments using one or two configuration recipes.
[**ReconcileValuation**](ReconciliationsApi.md#reconcilevaluation) | **POST** /api/portfolios/$reconcileValuation | [EXPERIMENTAL] Reconcile valuations performed on one or two sets of holdings using one or two configuration recipes.



## ReconcileHoldings

> ResourceListOfReconciliationBreak ReconcileHoldings (List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, PortfoliosReconciliationRequest portfoliosReconciliationRequest = null)

[EARLY ACCESS] Reconcile portfolio holdings

Reconcile the holdings of two portfolios.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ReconcileHoldingsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReconciliationsApi(Configuration.Default);
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set.              For example, to filter on the left portfolio Code, use \"left.portfolioId.code eq 'string'\"              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var portfoliosReconciliationRequest = new PortfoliosReconciliationRequest(); // PortfoliosReconciliationRequest | The specifications of the inputs to the reconciliation (optional) 

            try
            {
                // [EARLY ACCESS] Reconcile portfolio holdings
                ResourceListOfReconciliationBreak result = apiInstance.ReconcileHoldings(sortBy, start, limit, filter, portfoliosReconciliationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ReconciliationsApi.ReconcileHoldings: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set.              For example, to filter on the left portfolio Code, use \&quot;left.portfolioId.code eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 
 **portfoliosReconciliationRequest** | [**PortfoliosReconciliationRequest**](PortfoliosReconciliationRequest.md)| The specifications of the inputs to the reconciliation | [optional] 

### Return type

[**ResourceListOfReconciliationBreak**](ResourceListOfReconciliationBreak.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested reconciliation |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReconcileHoldingsPreview

> ResourceListOfReconciliationBreak ReconcileHoldingsPreview (List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, PortfoliosReconciliationRequestPreview portfoliosReconciliationRequestPreview = null)

[EXPERIMENTAL] Reconcile portfolio holdings with given tolerance

Reconcile the holdings of two portfolios.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ReconcileHoldingsPreviewExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReconciliationsApi(Configuration.Default);
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set (optional) 
            var portfoliosReconciliationRequestPreview = new PortfoliosReconciliationRequestPreview(); // PortfoliosReconciliationRequestPreview | The specifications of the inputs to the reconciliation. This request can take tolerance for units and cost. (optional) 

            try
            {
                // [EXPERIMENTAL] Reconcile portfolio holdings with given tolerance
                ResourceListOfReconciliationBreak result = apiInstance.ReconcileHoldingsPreview(sortBy, start, limit, filter, portfoliosReconciliationRequestPreview);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ReconciliationsApi.ReconcileHoldingsPreview: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set | [optional] 
 **portfoliosReconciliationRequestPreview** | [**PortfoliosReconciliationRequestPreview**](PortfoliosReconciliationRequestPreview.md)| The specifications of the inputs to the reconciliation. This request can take tolerance for units and cost. | [optional] 

### Return type

[**ResourceListOfReconciliationBreak**](ResourceListOfReconciliationBreak.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested reconciliation |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReconcileInline

> ListAggregationReconciliation ReconcileInline (List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, InlineValuationsReconciliationRequest inlineValuationsReconciliationRequest = null)

[EXPERIMENTAL] Reconcile valuations performed on one or two sets of inline instruments using one or two configuration recipes.

Perform valuation of one or two set of inline instruments using different one or two configuration recipes. Produce a breakdown of the resulting differences in valuation.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ReconcileInlineExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReconciliationsApi(Configuration.Default);
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set.              For example, to filter on the left portfolio Code, use \"left.portfolioId.code eq 'string'\"              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var inlineValuationsReconciliationRequest = new InlineValuationsReconciliationRequest(); // InlineValuationsReconciliationRequest | The specifications of the inputs to the reconciliation (optional) 

            try
            {
                // [EXPERIMENTAL] Reconcile valuations performed on one or two sets of inline instruments using one or two configuration recipes.
                ListAggregationReconciliation result = apiInstance.ReconcileInline(sortBy, start, limit, filter, inlineValuationsReconciliationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ReconciliationsApi.ReconcileInline: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set.              For example, to filter on the left portfolio Code, use \&quot;left.portfolioId.code eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 
 **inlineValuationsReconciliationRequest** | [**InlineValuationsReconciliationRequest**](InlineValuationsReconciliationRequest.md)| The specifications of the inputs to the reconciliation | [optional] 

### Return type

[**ListAggregationReconciliation**](ListAggregationReconciliation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested reconciliation |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReconcileValuation

> ListAggregationReconciliation ReconcileValuation (List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, ValuationsReconciliationRequest valuationsReconciliationRequest = null)

[EXPERIMENTAL] Reconcile valuations performed on one or two sets of holdings using one or two configuration recipes.

Perform valuation of one or two set of holdings using different one or two configuration recipes. Produce a breakdown of the resulting differences in valuation.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ReconcileValuationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReconciliationsApi(Configuration.Default);
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set.               For example, to filter on the left portfolio Code, use \"left.portfolioId.code eq 'string'\"              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var valuationsReconciliationRequest = new ValuationsReconciliationRequest(); // ValuationsReconciliationRequest | The specifications of the inputs to the reconciliation (optional) 

            try
            {
                // [EXPERIMENTAL] Reconcile valuations performed on one or two sets of holdings using one or two configuration recipes.
                ListAggregationReconciliation result = apiInstance.ReconcileValuation(sortBy, start, limit, filter, valuationsReconciliationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ReconciliationsApi.ReconcileValuation: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set.               For example, to filter on the left portfolio Code, use \&quot;left.portfolioId.code eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 
 **valuationsReconciliationRequest** | [**ValuationsReconciliationRequest**](ValuationsReconciliationRequest.md)| The specifications of the inputs to the reconciliation | [optional] 

### Return type

[**ListAggregationReconciliation**](ListAggregationReconciliation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested reconciliation |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

