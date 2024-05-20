#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_CAMERACONTROL_S2
{
    public KSIDENTIFIER Property;
    public int Value1;
    public uint Flags;
    public uint Capabilities;
    public int Value2;
}
