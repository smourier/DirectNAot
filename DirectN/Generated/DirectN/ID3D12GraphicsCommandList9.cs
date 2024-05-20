#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("34ed2808-ffe6-4c2b-b11a-cabd2b0c59e1")]
public partial interface ID3D12GraphicsCommandList9 : ID3D12GraphicsCommandList8
{
    [PreserveSig]
    void RSSetDepthBias(float DepthBias, float DepthBiasClamp, float SlopeScaledDepthBias);
    
    [PreserveSig]
    void IASetIndexBufferStripCutValue(D3D12_INDEX_BUFFER_STRIP_CUT_VALUE IBStripCutValue);
}
