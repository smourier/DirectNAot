namespace DirectN;

[GeneratedComInterface, Guid("66bb2f51-5844-4997-8d70-4b7cc221cf92")]
public partial interface IPrintSchemaOption : IPrintSchemaDisplayableElement
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_Selected([MarshalAs(UnmanagedType.U4)] out bool pbIsSelected);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_Constrained(out PrintSchemaConstrainedSetting pSetting);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPropertyValue(BSTR bstrName, BSTR bstrNamespaceUri, out nint ppXmlValueNode);
}
