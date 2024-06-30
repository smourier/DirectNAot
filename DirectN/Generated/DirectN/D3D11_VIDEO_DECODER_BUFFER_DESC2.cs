#nullable enable
namespace DirectN;

public partial struct D3D11_VIDEO_DECODER_BUFFER_DESC2
{
    public D3D11_VIDEO_DECODER_BUFFER_TYPE BufferType;
    public uint DataOffset;
    public uint DataSize;
    public nint pIV;
    public uint IVSize;
    public nint pSubSampleMappingBlock;
    public uint SubSampleMappingCount;
    public uint cBlocksStripeEncrypted;
    public uint cBlocksStripeClear;
}
