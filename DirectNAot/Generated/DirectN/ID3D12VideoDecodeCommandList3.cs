#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/nn-d3d12video-id3d12videodecodecommandlist3
[GeneratedComInterface, Guid("2aee8c37-9562-42da-8abf-61efeb2e4513")]
public partial interface ID3D12VideoDecodeCommandList3 : ID3D12VideoDecodeCommandList2
{
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodecodecommandlist3-barrier
    [PreserveSig]
    void Barrier(uint NumBarrierGroups, [In][MarshalUsing(CountElementName = nameof(NumBarrierGroups))] D3D12_BARRIER_GROUP[] pBarrierGroups);
}
