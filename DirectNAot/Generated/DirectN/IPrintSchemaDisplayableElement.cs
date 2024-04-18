namespace DirectN;

[GeneratedComInterface, Guid("af45af49-d6aa-407d-bf87-3912236e9d94")]
public partial interface IPrintSchemaDisplayableElement : IPrintSchemaElement
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_DisplayName(out BSTR pbstrDisplayName);
}
