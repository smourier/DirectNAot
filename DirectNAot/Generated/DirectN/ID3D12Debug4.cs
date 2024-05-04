#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nn-d3d12sdklayers-id3d12debug4
[GeneratedComInterface, Guid("014b816e-9ec5-4a2f-a845-ffbe441ce13a")]
public partial interface ID3D12Debug4 : ID3D12Debug3
{
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12debug4-disabledebuglayer
    [PreserveSig]
    void DisableDebugLayer();
}
