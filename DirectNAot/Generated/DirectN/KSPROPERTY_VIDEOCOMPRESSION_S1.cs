#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_VIDEOCOMPRESSION_S1
{
    public KSIDENTIFIER Property;
    public uint StreamIndex;
    public int Value;
    public uint Flags;
}
