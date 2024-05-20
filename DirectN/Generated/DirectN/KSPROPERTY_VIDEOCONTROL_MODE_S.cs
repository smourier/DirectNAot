#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_VIDEOCONTROL_MODE_S
{
    public KSIDENTIFIER Property;
    public uint StreamIndex;
    public int Mode;
}
