namespace DirectN;

[GeneratedComInterface, Guid("b58845f4-9970-4d87-a636-169fb82ed642")]
public partial interface IPrintSchemaCapabilities2 : IPrintSchemaCapabilities
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetParameterDefinition(BSTR bstrName, BSTR bstrNamespaceUri, out IPrintSchemaParameterDefinition ppParameterDefinition);
}
