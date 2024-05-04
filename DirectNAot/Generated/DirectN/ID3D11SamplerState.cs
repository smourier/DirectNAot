#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/nn-d3d11-id3d11samplerstate
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("da6fea51-564c-4487-9810-f0d0f9b4e3a5")]
public partial interface ID3D11SamplerState : ID3D11DeviceChild
{
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11samplerstate-getdesc
    [PreserveSig]
    void GetDesc(out D3D11_SAMPLER_DESC pDesc);
}
