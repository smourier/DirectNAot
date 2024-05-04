#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSCAMERA_EXTENDEDPROP_PHOTOMODE
{
    public uint RequestedHistoryFrames;
    public uint MaxHistoryFrames;
    public uint SubMode;
    public uint Reserved;
}
