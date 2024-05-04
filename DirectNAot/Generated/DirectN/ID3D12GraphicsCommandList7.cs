#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12graphicscommandlist7
[GeneratedComInterface, Guid("dd171223-8b61-4769-90e3-160ccde4e2c1")]
public partial interface ID3D12GraphicsCommandList7 : ID3D12GraphicsCommandList6
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist7-barrier
    [PreserveSig]
    void Barrier(uint NumBarrierGroups, [MarshalUsing(CountElementName = nameof(NumBarrierGroups))] in D3D12_BARRIER_GROUP[] pBarrierGroups);
}
