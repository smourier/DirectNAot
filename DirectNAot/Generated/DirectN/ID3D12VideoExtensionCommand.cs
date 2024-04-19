namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/nn-d3d12video-id3d12videoextensioncommand
[SupportedOSPlatform("windows10.0.19041")]
[GeneratedComInterface, Guid("554e41e8-ae8e-4a8c-b7d2-5b4f274a30e4")]
public partial interface ID3D12VideoExtensionCommand : ID3D12Pageable
{
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoextensioncommand-getdesc
    [PreserveSig]
    D3D12_VIDEO_EXTENSION_COMMAND_DESC GetDesc();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoextensioncommand-getprotectedresourcesession
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProtectedResourceSession(in Guid riid, nint/* nint */ ppProtectedSession);
}
