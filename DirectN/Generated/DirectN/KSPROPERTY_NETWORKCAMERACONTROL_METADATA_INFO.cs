#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_NETWORKCAMERACONTROL_METADATA_INFO
{
    public uint MetadataItems;
    public uint Size;
    public BOOL PTZStatus;
    public BOOL Events;
    public BOOL Analytics;
    public BOOL Reserved;
}
