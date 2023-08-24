# IO.Swagger.Api.ProfileApi

All URIs are relative to *https://remesita.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RestV1BalanceGet**](ProfileApi.md#restv1balanceget) | **GET** /rest/v1/balance | Obtiene datos de balance
[**RestV1UserLockupCodeCodePost**](ProfileApi.md#restv1userlockupcodecodepost) | **POST** /rest/v1/user/lockup-code/{code} | Obtener datos de un cliente a partir de su codigo de cliente/referidos


<a name="restv1balanceget"></a>
# **RestV1BalanceGet**
> InlineResponse2009 RestV1BalanceGet ()

Obtiene datos de balance

Devuelve el balance y otros detalles relacionados

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RestV1BalanceGetExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfileApi();

            try
            {
                // Obtiene datos de balance
                InlineResponse2009 result = apiInstance.RestV1BalanceGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfileApi.RestV1BalanceGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse2009**](InlineResponse2009.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="restv1userlockupcodecodepost"></a>
# **RestV1UserLockupCodeCodePost**
> void RestV1UserLockupCodeCodePost (string code)

Obtener datos de un cliente a partir de su codigo de cliente/referidos

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RestV1UserLockupCodeCodePostExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfileApi();
            var code = code_example;  // string | 

            try
            {
                // Obtener datos de un cliente a partir de su codigo de cliente/referidos
                apiInstance.RestV1UserLockupCodeCodePost(code);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfileApi.RestV1UserLockupCodeCodePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

