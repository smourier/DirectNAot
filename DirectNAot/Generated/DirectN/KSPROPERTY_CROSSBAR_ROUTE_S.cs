#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_CROSSBAR_ROUTE_S
{
    public KSIDENTIFIER Property;
    public uint IndexInputPin;
    public uint IndexOutputPin;
    public uint CanRoute;
}
