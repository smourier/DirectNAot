namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_feature_data_video_encoder_heap_size
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_HEAP_SIZE
{
    public D3D12_VIDEO_ENCODER_HEAP_DESC HeapDesc;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool IsSupported;
    public ulong MemoryPoolL0Size;
    public ulong MemoryPoolL1Size;
}
