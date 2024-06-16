#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct WCS_DEVICE_MHC2_CAPABILITIES
{
    public uint Size;
    public BOOL SupportsMhc2;
    public uint RegammaLutEntryCount;
    public uint CscXyzMatrixRows;
    public uint CscXyzMatrixColumns;
}
