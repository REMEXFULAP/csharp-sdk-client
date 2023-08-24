# IO.Swagger.Api.OperationsApi

All URIs are relative to *https://remesita.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RestV1OperationOrdersGet**](OperationsApi.md#restv1operationordersget) | **GET** /rest/v1/operation/orders | Obtiene una lista de órdenes
[**RestV1OperationP2pGet**](OperationsApi.md#restv1operationp2pget) | **GET** /rest/v1/operation/p2p | Obtiene una lista de operaciones P2P


<a name="restv1operationordersget"></a>
# **RestV1OperationOrdersGet**
> InlineResponse2005 RestV1OperationOrdersGet (int? pg = null, int? pgSize = null, DateTime? start = null, DateTime? end = null, string status = null)

Obtiene una lista de órdenes

Recupera una lista paginada de órdenes

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RestV1OperationOrdersGetExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OperationsApi();
            var pg = 56;  // int? | Número de página (optional)  (default to 1)
            var pgSize = 56;  // int? | Cantidad de elementos por página (optional)  (default to 25)
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Fecha de inicio en formato Y-m-d H:i:s (optional)  (default to 2023-01-01)
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | Fecha de finalización en formato Y-m-d H:i:s (optional)  (default to 2025-01-01)
            var status = status_example;  // string | Estado para filtrar (optional) 

            try
            {
                // Obtiene una lista de órdenes
                InlineResponse2005 result = apiInstance.RestV1OperationOrdersGet(pg, pgSize, start, end, status);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationsApi.RestV1OperationOrdersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pg** | **int?**| Número de página | [optional] [default to 1]
 **pgSize** | **int?**| Cantidad de elementos por página | [optional] [default to 25]
 **start** | **DateTime?**| Fecha de inicio en formato Y-m-d H:i:s | [optional] [default to 2023-01-01]
 **end** | **DateTime?**| Fecha de finalización en formato Y-m-d H:i:s | [optional] [default to 2025-01-01]
 **status** | **string**| Estado para filtrar | [optional] 

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="restv1operationp2pget"></a>
# **RestV1OperationP2pGet**
> InlineResponse2006 RestV1OperationP2pGet (int? pg = null, int? pgSize = null, DateTime? start = null, DateTime? end = null)

Obtiene una lista de operaciones P2P

Recupera una lista paginada de operaciones P2P

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RestV1OperationP2pGetExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OperationsApi();
            var pg = 56;  // int? | Número de página (optional)  (default to 1)
            var pgSize = 56;  // int? | Cantidad de elementos por página (optional)  (default to 25)
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Fecha de inicio en formato Y-m-d H:i:s (optional)  (default to 2022-01-01)
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | Fecha de finalización en formato Y-m-d H:i:s (optional)  (default to 2025-01-01)

            try
            {
                // Obtiene una lista de operaciones P2P
                InlineResponse2006 result = apiInstance.RestV1OperationP2pGet(pg, pgSize, start, end);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationsApi.RestV1OperationP2pGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pg** | **int?**| Número de página | [optional] [default to 1]
 **pgSize** | **int?**| Cantidad de elementos por página | [optional] [default to 25]
 **start** | **DateTime?**| Fecha de inicio en formato Y-m-d H:i:s | [optional] [default to 2022-01-01]
 **end** | **DateTime?**| Fecha de finalización en formato Y-m-d H:i:s | [optional] [default to 2025-01-01]

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

