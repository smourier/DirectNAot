#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_DVDCOPY_REGION
{
    public byte Reserved;
    public byte RegionData;
    public InlineArrayByte2 Reserved2;
}
