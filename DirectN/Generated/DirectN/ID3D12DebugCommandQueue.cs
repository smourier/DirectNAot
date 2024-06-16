#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nn-d3d12sdklayers-id3d12debugcommandqueue
[GeneratedComInterface, Guid("09e0bf36-54ac-484f-8847-4baeeab6053a")]
public partial interface ID3D12DebugCommandQueue
{
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12debugcommandqueue-assertresourcestate
    [PreserveSig]
    BOOL AssertResourceState(ID3D12Resource pResource, uint Subresource, uint State);
}
