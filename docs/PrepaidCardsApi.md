# IO.Swagger.Api.PrepaidCardsApi

All URIs are relative to *https://remesita.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RestV1CardNumberTogglePost**](PrepaidCardsApi.md#restv1cardnumbertogglepost) | **POST** /rest/v1/card/{number}/toggle | Bloquea o desbloquea una tarjeta
[**RestV1CardNumberTransactionsPgPgSizeGet**](PrepaidCardsApi.md#restv1cardnumbertransactionspgpgsizeget) | **GET** /rest/v1/card/{number}/transactions/{pg}/{pgSize} | Obtiene las transacciones de una tarjeta
[**RestV1CardTransferBetweenPost**](PrepaidCardsApi.md#restv1cardtransferbetweenpost) | **POST** /rest/v1/card/transfer-between | Transfiere saldo entre cuentas Remesita
[**RestV1CardsGet**](PrepaidCardsApi.md#restv1cardsget) | **GET** /rest/v1/cards | Obtiene la lista de tarjetas prepagadas


<a name="restv1cardnumbertogglepost"></a>
# **RestV1CardNumberTogglePost**
> InlineResponse2002 RestV1CardNumberTogglePost (string number)

Bloquea o desbloquea una tarjeta

Cambia el estado de bloqueo de una tarjeta específica

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RestV1CardNumberTogglePostExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PrepaidCardsApi();
            var number = number_example;  // string | Número de tarjeta

            try
            {
                // Bloquea o desbloquea una tarjeta
                InlineResponse2002 result = apiInstance.RestV1CardNumberTogglePost(number);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrepaidCardsApi.RestV1CardNumberTogglePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **number** | **string**| Número de tarjeta | 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="restv1cardnumbertransactionspgpgsizeget"></a>
# **RestV1CardNumberTransactionsPgPgSizeGet**
> InlineResponse2003 RestV1CardNumberTransactionsPgPgSizeGet (string number, int? pg, int? pgSize)

Obtiene las transacciones de una tarjeta

Recupera una lista paginada de transacciones para una tarjeta específica

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RestV1CardNumberTransactionsPgPgSizeGetExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PrepaidCardsApi();
            var number = number_example;  // string | Número de tarjeta
            var pg = 56;  // int? | Número de página
            var pgSize = 56;  // int? | Tamaño de página

            try
            {
                // Obtiene las transacciones de una tarjeta
                InlineResponse2003 result = apiInstance.RestV1CardNumberTransactionsPgPgSizeGet(number, pg, pgSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrepaidCardsApi.RestV1CardNumberTransactionsPgPgSizeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **number** | **string**| Número de tarjeta | 
 **pg** | **int?**| Número de página | 
 **pgSize** | **int?**| Tamaño de página | 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="restv1cardtransferbetweenpost"></a>
# **RestV1CardTransferBetweenPost**
> InlineResponse2001 RestV1CardTransferBetweenPost (Body body)

Transfiere saldo entre cuentas Remesita

Permite transferir saldo entre dos cuentas Remesita especificadas por los números de tarjeta Visa.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RestV1CardTransferBetweenPostExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PrepaidCardsApi();
            var body = new Body(); // Body | Detalles de la transferencia

            try
            {
                // Transfiere saldo entre cuentas Remesita
                InlineResponse2001 result = apiInstance.RestV1CardTransferBetweenPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrepaidCardsApi.RestV1CardTransferBetweenPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body**](Body.md)| Detalles de la transferencia | 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="restv1cardsget"></a>
# **RestV1CardsGet**
> InlineResponse2004 RestV1CardsGet ()

Obtiene la lista de tarjetas prepagadas

Devuelve una lista de todas las tarjetas prepagadas en el sistema

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RestV1CardsGetExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PrepaidCardsApi();

            try
            {
                // Obtiene la lista de tarjetas prepagadas
                InlineResponse2004 result = apiInstance.RestV1CardsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrepaidCardsApi.RestV1CardsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

