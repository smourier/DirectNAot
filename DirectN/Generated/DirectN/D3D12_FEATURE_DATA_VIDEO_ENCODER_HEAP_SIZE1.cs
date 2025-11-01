#nullable enable
namespace DirectN;

public partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_HEAP_SIZE1
{
    public D3D12_VIDEO_ENCODER_HEAP_DESC1 HeapDesc;
    public BOOL IsSupported;
    public ulong MemoryPoolL0Size;
    public ulong MemoryPoolL1Size;
}
