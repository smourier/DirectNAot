#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE1
{
    public D3D12_VIDEO_DECODER_HEAP_DESC VideoDecoderHeapDesc;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool Protected;
    public ulong MemoryPoolL0Size;
    public ulong MemoryPoolL1Size;
}
