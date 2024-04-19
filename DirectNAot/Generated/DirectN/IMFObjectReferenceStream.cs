namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfobjectreferencestream
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("09ef5be3-c8a7-469e-8b70-73bf25bb193f")]
public partial interface IMFObjectReferenceStream
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfobjectreferencestream-savereference
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SaveReference(in Guid riid, nint pUnk);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfobjectreferencestream-loadreference
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoadReference(in Guid riid, out nint ppv);
}
