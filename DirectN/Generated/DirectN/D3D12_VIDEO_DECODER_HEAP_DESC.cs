﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_decoder_heap_desc
public partial struct D3D12_VIDEO_DECODER_HEAP_DESC
{
    public uint NodeMask;
    public D3D12_VIDEO_DECODE_CONFIGURATION Configuration;
    public uint DecodeWidth;
    public uint DecodeHeight;
    public DXGI_FORMAT Format;
    public DXGI_RATIONAL FrameRate;
    public uint BitRate;
    public uint MaxDecodePictureBufferCount;
}
