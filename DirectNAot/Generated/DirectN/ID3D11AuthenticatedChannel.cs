namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/nn-d3d11-id3d11authenticatedchannel
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("3015a308-dcbd-47aa-a747-192486d14d4a")]
public partial interface ID3D11AuthenticatedChannel : ID3D11DeviceChild
{
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11authenticatedchannel-getcertificatesize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCertificateSize(out uint pCertificateSize);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11authenticatedchannel-getcertificate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCertificate(uint CertificateSize, nint /* byte array */ pCertificate);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11authenticatedchannel-getchannelhandle
    [PreserveSig]
    void GetChannelHandle(out HANDLE pChannelHandle);
}
