#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nn-d3d11sdklayers-id3d11refdefaulttrackingoptions
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("03916615-c644-418c-9bf4-75db5be63ca0")]
public partial interface ID3D11RefDefaultTrackingOptions
{
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11refdefaulttrackingoptions-settrackingoptions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTrackingOptions(uint ResourceTypeFlags, uint Options);
}
