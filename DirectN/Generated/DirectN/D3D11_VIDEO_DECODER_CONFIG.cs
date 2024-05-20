#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_video_decoder_config
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_VIDEO_DECODER_CONFIG
{
    public Guid guidConfigBitstreamEncryption;
    public Guid guidConfigMBcontrolEncryption;
    public Guid guidConfigResidDiffEncryption;
    public uint ConfigBitstreamRaw;
    public uint ConfigMBcontrolRasterOrder;
    public uint ConfigResidDiffHost;
    public uint ConfigSpatialResid8;
    public uint ConfigResid8Subtraction;
    public uint ConfigSpatialHost8or9Clipping;
    public uint ConfigSpatialResidInterleaved;
    public uint ConfigIntraResidUnsigned;
    public uint ConfigResidDiffAccelerator;
    public uint ConfigHostInverseScan;
    public uint ConfigSpecificIDCT;
    public uint Config4GroupedCoefs;
    public ushort ConfigMinRenderTargetBuffCount;
    public ushort ConfigDecoderSpecific;
}
