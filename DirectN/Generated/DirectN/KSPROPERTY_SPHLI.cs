#nullable enable
namespace DirectN;

public partial struct KSPROPERTY_SPHLI
{
    public ushort HLISS;
    public ushort Reserved;
    public uint StartPTM;
    public uint EndPTM;
    public ushort StartX;
    public ushort StartY;
    public ushort StopX;
    public ushort StopY;
    public KS_COLCON ColCon;
}
