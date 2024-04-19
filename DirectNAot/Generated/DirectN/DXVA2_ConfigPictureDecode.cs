namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva2api/ns-dxva2api-dxva2_configpicturedecode
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA2_ConfigPictureDecode
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
