#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("7013c015-d161-4b63-a08c-238552dd8acc")]
public partial interface ID3D12GraphicsCommandList10 : ID3D12GraphicsCommandList9
{
    [PreserveSig]
    void SetProgram(in D3D12_SET_PROGRAM_DESC pDesc);
    
    [PreserveSig]
    void DispatchGraph(in D3D12_DISPATCH_GRAPH_DESC pDesc);
}
