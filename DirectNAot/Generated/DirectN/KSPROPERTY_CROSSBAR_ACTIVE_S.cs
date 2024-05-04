#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_CROSSBAR_ACTIVE_S
{
    public KSIDENTIFIER Property;
    public uint IndexInputPin;
    public uint Active;
}
