#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_VIDEOCONTROL_CAPS_S
{
    public KSIDENTIFIER Property;
    public uint StreamIndex;
    public uint VideoControlCaps;
}
