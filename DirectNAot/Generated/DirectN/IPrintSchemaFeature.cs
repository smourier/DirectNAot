namespace DirectN;

[GeneratedComInterface, Guid("ef189461-5d62-4626-8e57-ff83583c4826")]
public partial interface IPrintSchemaFeature : IPrintSchemaDisplayableElement
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_SelectedOption(out IPrintSchemaOption ppOption);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT put_SelectedOption(IPrintSchemaOption pOption);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_SelectionType(out PrintSchemaSelectionType pSelectionType);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetOption(BSTR bstrName, BSTR bstrNamespaceUri, out IPrintSchemaOption ppOption);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_DisplayUI([MarshalAs(UnmanagedType.U4)] out bool pbShow);
}
