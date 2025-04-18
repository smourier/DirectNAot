#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nn-d3d12sdklayers-id3d12debug6
[GeneratedComInterface, Guid("82a816d6-5d01-4157-97d0-4975463fd1ed")]
public partial interface ID3D12Debug6 : ID3D12Debug5
{
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12debug6-setforcelegacybarriervalidation
    [PreserveSig]
    void SetForceLegacyBarrierValidation(BOOL Enable);
}
