#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_1/ns-d3d11_1-d3d11_video_decoder_buffer_desc1
public partial struct D3D11_VIDEO_DECODER_BUFFER_DESC1
{
    public D3D11_VIDEO_DECODER_BUFFER_TYPE BufferType;
    public uint DataOffset;
    public uint DataSize;
    public nint pIV;
    public uint IVSize;
    public nint pSubSampleMappingBlock;
    public uint SubSampleMappingCount;
}
