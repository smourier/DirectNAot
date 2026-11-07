#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("823aee5b-c932-4b15-b4c4-4a28e7c34dea")]
public partial interface ID3D12GraphicsCommandList11 : ID3D12GraphicsCommandList10
{
    [PreserveSig]
    void WaitBarrier(uint NumBarrierGroups, [In][MarshalUsing(CountElementName = nameof(NumBarrierGroups))] D3D12_BARRIER_GROUP[] pBarrierGroups, uint NumFences, [In][MarshalUsing(CountElementName = nameof(NumFences))] ID3D12Fence[] ppFences, [In][MarshalUsing(CountElementName = nameof(NumFences))] ulong[] pFenceValues);
    
    [PreserveSig]
    void SignalBarrier(uint NumBarrierGroups, [In][MarshalUsing(CountElementName = nameof(NumBarrierGroups))] D3D12_BARRIER_GROUP[] pBarrierGroups, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Fence>))] ID3D12Fence pFence, ulong FenceValue);
}
