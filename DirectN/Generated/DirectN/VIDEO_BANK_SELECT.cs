#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VIDEO_BANK_SELECT
{
    public uint Length;
    public uint Size;
    public uint BankingFlags;
    public uint BankingType;
    public uint PlanarHCBankingType;
    public uint BitmapWidthInBytes;
    public uint BitmapSize;
    public uint Granularity;
    public uint PlanarHCGranularity;
    public uint CodeOffset;
    public uint PlanarHCBankCodeOffset;
    public uint PlanarHCEnableCodeOffset;
    public uint PlanarHCDisableCodeOffset;
}
