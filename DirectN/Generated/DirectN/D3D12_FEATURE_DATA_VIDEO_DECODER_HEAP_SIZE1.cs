#nullable enable
namespace DirectN;

public partial struct D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE1
{
    public D3D12_VIDEO_DECODER_HEAP_DESC VideoDecoderHeapDesc;
    public BOOL Protected;
    public ulong MemoryPoolL0Size;
    public ulong MemoryPoolL1Size;
}
