﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_feature_data_video_decoder_heap_size
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE
{
    public D3D12_VIDEO_DECODER_HEAP_DESC VideoDecoderHeapDesc;
    public ulong MemoryPoolL0Size;
    public ulong MemoryPoolL1Size;
}