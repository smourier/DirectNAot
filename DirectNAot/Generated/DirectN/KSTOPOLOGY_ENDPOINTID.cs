namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSTOPOLOGY_ENDPOINTID
{
    public InlineArraySystemChar260 TopologyName;
    public uint PinId;
}
