namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/nn-mfobjects-imfdxgibuffer
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("e7174cfa-1c9e-48b1-8866-626226bfc258")]
public partial interface IMFDXGIBuffer
{
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfdxgibuffer-getresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetResource(in Guid riid, out nint ppvObject);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfdxgibuffer-getsubresourceindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSubresourceIndex(out uint puSubresource);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfdxgibuffer-getunknown
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUnknown(in Guid guid, in Guid riid, out nint ppvObject);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfdxgibuffer-setunknown
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetUnknown(in Guid guid, nint pUnkData);
}
