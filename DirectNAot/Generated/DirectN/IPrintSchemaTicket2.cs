namespace DirectN;

[GeneratedComInterface, Guid("2ec1f844-766a-47a1-91f4-2eeb6190f80c")]
public partial interface IPrintSchemaTicket2 : IPrintSchemaTicket
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetParameterInitializer(BSTR bstrName, BSTR bstrNamespaceUri, out IPrintSchemaParameterInitializer ppParameterInitializer);
}
