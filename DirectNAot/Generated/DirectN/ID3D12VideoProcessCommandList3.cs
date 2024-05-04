#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/nn-d3d12video-id3d12videoprocesscommandlist3
[GeneratedComInterface, Guid("1a0a4ca4-9f08-40ce-9558-b411fd2666ff")]
public partial interface ID3D12VideoProcessCommandList3 : ID3D12VideoProcessCommandList2
{
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoprocesscommandlist3-barrier
    [PreserveSig]
    void Barrier(uint NumBarrierGroups, [MarshalUsing(CountElementName = nameof(NumBarrierGroups))] in D3D12_BARRIER_GROUP[] pBarrierGroups);
}
