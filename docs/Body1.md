# IO.Swagger.Model.Body1
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BusinessUnitId** | **string** | ID del negocio que está generando el link de pago | 
**Amount** | **decimal?** | Monto a pagar | 
**Concept** | **string** | Concepto de pago o comentario | 
**IpnUrl** | **string** | Dirección para recibir webhooks de notificaciones de pago en segundo plano | [optional] 
**SuccessUrl** | **string** | URL a donde redireccionar si el pago es satisfactorio | [optional] 
**CancelUrl** | **string** | URL a donde redireccionar si el pago es cancelado | [optional] 
**CustomId** | **string** | Identificador externo para trazabilidad | [optional] 
**PayerName** | **string** | Nombre del pagador (si se conoce) | [optional] 
**PayerPhone** | **string** | Teléfono del pagador (si se conoce) | [optional] 
**PayerEmail** | **string** | Email del pagador (si se conoce) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

