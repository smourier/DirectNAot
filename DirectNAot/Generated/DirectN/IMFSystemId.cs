namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfsystemid
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("fff4af3a-1fc1-4ef9-a29b-d26c49e2f31a")]
public partial interface IMFSystemId
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsystemid-getdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetData(out uint size, out nint /* byte array */ data);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsystemid-setup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Setup(uint stage, uint cbIn, nint /* byte array */ pbIn, out uint pcbOut, out nint /* byte array */ ppbOut);
}
