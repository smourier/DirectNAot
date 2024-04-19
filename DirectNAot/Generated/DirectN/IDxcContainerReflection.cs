namespace DirectN;

[GeneratedComInterface, Guid("d2c21b26-8350-4bdc-976a-331ce6f4c54c")]
public partial interface IDxcContainerReflection
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Load(IDxcBlob pContainer);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPartCount(out uint pResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPartKind(uint idx, out uint pResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPartContent(uint idx, out IDxcBlob ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindFirstPartKind(uint kind, out uint pResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPartReflection(uint idx, in Guid iid, out nint ppvObject);
}
