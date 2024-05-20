#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA_ConfigPictureDecode
{
    public uint dwFunction;
    public InlineArrayUInt32_3 dwReservedBits;
    public Guid guidConfigBitstreamEncryption;
    public Guid guidConfigMBcontrolEncryption;
    public Guid guidConfigResidDiffEncryption;
    public byte bConfigBitstreamRaw;
    public byte bConfigMBcontrolRasterOrder;
    public byte bConfigResidDiffHost;
    public byte bConfigSpatialResid8;
    public byte bConfigResid8Subtraction;
    public byte bConfigSpatialHost8or9Clipping;
    public byte bConfigSpatialResidInterleaved;
    public byte bConfigIntraResidUnsigned;
    public byte bConfigResidDiffAccelerator;
    public byte bConfigHostInverseScan;
    public byte bConfigSpecificIDCT;
    public byte bConfig4GroupedCoefs;
}
