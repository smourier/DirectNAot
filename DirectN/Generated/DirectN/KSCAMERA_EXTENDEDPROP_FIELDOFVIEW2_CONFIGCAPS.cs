#nullable enable
namespace DirectN;

public partial struct KSCAMERA_EXTENDEDPROP_FIELDOFVIEW2_CONFIGCAPS
{
    public ushort DefaultDiagonalFieldOfViewInDegrees;
    public ushort DiscreteFoVStopsCount;
    public InlineArrayUInt16_360 DiscreteFoVStops;
    public uint Reserved;
}
