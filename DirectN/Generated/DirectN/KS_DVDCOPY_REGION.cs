#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_DVDCOPY_REGION
{
    public byte Reserved;
    public byte RegionData;
    public InlineArrayByte_2 Reserved2;
}
