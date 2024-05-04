#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("c3827890-e548-4cfa-96cf-5689a9370f80")]
public partial interface ID3D12GraphicsCommandList6 : ID3D12GraphicsCommandList5
{
    [PreserveSig]
    void DispatchMesh(uint ThreadGroupCountX, uint ThreadGroupCountY, uint ThreadGroupCountZ);
}
