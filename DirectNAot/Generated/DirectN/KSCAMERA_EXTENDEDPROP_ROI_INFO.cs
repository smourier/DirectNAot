namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSCAMERA_EXTENDEDPROP_ROI_INFO
{
    public RECT Region;
    public ulong Flags;
    public int Weight;
    public int RegionOfInterestType;
}
