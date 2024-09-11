#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("197d5e15-4d37-4d34-af78-724cd70fdb1f")]
public partial interface ID3D12DebugCommandList3 : ID3D12DebugCommandList2
{
    [PreserveSig]
    void AssertResourceAccess([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource>))] ID3D12Resource pResource, uint Subresource, D3D12_BARRIER_ACCESS Access);
    
    [PreserveSig]
    void AssertTextureLayout([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource>))] ID3D12Resource pResource, uint Subresource, D3D12_BARRIER_LAYOUT Layout);
}
