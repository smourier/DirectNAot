#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nn-d3d11sdklayers-id3d11reftrackingoptions
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("193dacdf-0db2-4c05-a55c-ef06cac56fd9")]
public partial interface ID3D11RefTrackingOptions
{
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11reftrackingoptions-settrackingoptions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTrackingOptions(uint uOptions);
}
