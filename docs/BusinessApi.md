# IO.Swagger.Api.BusinessApi

All URIs are relative to *https://remesita.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RestV1BusinessGet**](BusinessApi.md#restv1businessget) | **GET** /rest/v1/business | Obtiene la lista de negocios registrados
[**RestV1PaymentLinkPost**](BusinessApi.md#restv1paymentlinkpost) | **POST** /rest/v1/payment-link | Genera un link de pago


<a name="restv1businessget"></a>
# **RestV1BusinessGet**
> List<InlineResponse200> RestV1BusinessGet ()

Obtiene la lista de negocios registrados

Devuelve una lista de todos los negocios registrados en remesita

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RestV1BusinessGetExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BusinessApi();

            try
            {
                // Obtiene la lista de negocios registrados
                List&lt;InlineResponse200&gt; result = apiInstance.RestV1BusinessGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessApi.RestV1BusinessGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<InlineResponse200>**](InlineResponse200.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="restv1paymentlinkpost"></a>
# **RestV1PaymentLinkPost**
> InlineResponse2007 RestV1PaymentLinkPost (Body1 body)

Genera un link de pago

Crea un link de pago basado en los detalles proporcionados

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RestV1PaymentLinkPostExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BusinessApi();
            var body = new Body1(); // Body1 | Detalles para generar el link de pago

            try
            {
                // Genera un link de pago
                InlineResponse2007 result = apiInstance.RestV1PaymentLinkPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessApi.RestV1PaymentLinkPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body1**](Body1.md)| Detalles para generar el link de pago | 

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

