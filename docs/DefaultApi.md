# IO.Swagger.Api.DefaultApi

All URIs are relative to *https://remesita.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RestV1UserLockupCodeCodeGet**](DefaultApi.md#restv1userlockupcodecodeget) | **GET** /rest/v1/user/lockup-code/{code} | Obtener datos de un cliente a partir de su codigo de cliente/referidos


<a name="restv1userlockupcodecodeget"></a>
# **RestV1UserLockupCodeCodeGet**
> void RestV1UserLockupCodeCodeGet (string code)

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
    public class RestV1UserLockupCodeCodeGetExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var code = code_example;  // string | 

            try
            {
                // Obtener datos de un cliente a partir de su codigo de cliente/referidos
                apiInstance.RestV1UserLockupCodeCodeGet(code);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.RestV1UserLockupCodeCodeGet: " + e.Message );
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

