#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/nn-d3d11-id3d11videodecoder
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("3c9c5b51-995d-48d1-9b8d-fa5caeded65c")]
public partial interface ID3D11VideoDecoder : ID3D11DeviceChild
{
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodecoder-getcreationparameters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCreationParameters(out D3D11_VIDEO_DECODER_DESC pVideoDesc, out D3D11_VIDEO_DECODER_CONFIG pConfig);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodecoder-getdriverhandle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDriverHandle(out HANDLE pDriverHandle);
}
