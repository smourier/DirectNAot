namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_VIDEOCOMPRESSION_S
{
    public KSIDENTIFIER Property;
    public uint StreamIndex;
    public int Value;
}
