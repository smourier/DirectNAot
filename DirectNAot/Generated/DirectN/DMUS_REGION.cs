#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DMUS_REGION
{
    public RGNRANGE RangeKey;
    public RGNRANGE RangeVelocity;
    public ushort fusOptions;
    public ushort usKeyGroup;
    public uint ulRegionArtIdx;
    public uint ulNextRegionIdx;
    public uint ulFirstExtCkIdx;
    public WAVELINK WaveLink;
    public WSMPL WSMP;
    public InlineArrayWLOOP_1 WLOOP; // variable-length array placeholder
}
