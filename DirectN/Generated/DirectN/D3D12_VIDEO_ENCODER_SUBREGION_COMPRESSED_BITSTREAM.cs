#nullable enable
namespace DirectN;

public partial struct D3D12_VIDEO_ENCODER_SUBREGION_COMPRESSED_BITSTREAM
{
    public D3D12_VIDEO_ENCODER_SUBREGION_COMPRESSED_BITSTREAM_BUFFER_MODE BufferMode;
    public uint ExpectedSubregionCount;
    public nint pSubregionBitstreamsBaseOffsets;
    public nint ppSubregionBitstreams;
    public nint ppSubregionSizes;
    public nint ppSubregionOffsets;
    public nint ppSubregionFences;
    public nint pSubregionFenceValues;
}
