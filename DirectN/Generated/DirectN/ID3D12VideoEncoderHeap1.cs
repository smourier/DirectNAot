#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("ea8f1968-4aa0-43a4-9d30-ba86ec84d4f9")]
public partial interface ID3D12VideoEncoderHeap1 : ID3D12VideoEncoderHeap
{
    [PreserveSig]
    uint GetPow2DownscaleFactor();
}
