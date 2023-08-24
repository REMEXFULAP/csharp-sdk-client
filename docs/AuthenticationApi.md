# IO.Swagger.Api.AuthenticationApi

All URIs are relative to *https://remesita.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RestV1AuthPost**](AuthenticationApi.md#restv1authpost) | **POST** /rest/v1/auth | Autentica al usuario con api_key y api_secret


<a name="restv1authpost"></a>
# **RestV1AuthPost**
> InlineResponse2008 RestV1AuthPost (Body2 body)

Autentica al usuario con api_key y api_secret

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RestV1AuthPostExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticationApi();
            var body = new Body2(); // Body2 | JSON con api_key y api_secret

            try
            {
                // Autentica al usuario con api_key y api_secret
                InlineResponse2008 result = apiInstance.RestV1AuthPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.RestV1AuthPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body2**](Body2.md)| JSON con api_key y api_secret | 

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

