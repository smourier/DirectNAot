#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nn-d3d12sdklayers-id3d12debug
[GeneratedComInterface, Guid("344488b7-6846-474b-b989-f027448245e0")]
public partial interface ID3D12Debug
{
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12debug-enabledebuglayer
    [PreserveSig]
    void EnableDebugLayer();
}
