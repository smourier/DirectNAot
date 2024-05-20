#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSTOPOLOGY_ENDPOINTID
{
    public InlineArraySystemChar_260 TopologyName;
    public uint PinId;
}
