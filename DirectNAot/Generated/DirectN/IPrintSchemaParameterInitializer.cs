namespace DirectN;

[GeneratedComInterface, Guid("52027082-0b74-4648-9564-828cc6cb656c")]
public partial interface IPrintSchemaParameterInitializer : IPrintSchemaElement
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_Value(out VARIANT pVar);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT put_Value(in VARIANT pVar);
}
