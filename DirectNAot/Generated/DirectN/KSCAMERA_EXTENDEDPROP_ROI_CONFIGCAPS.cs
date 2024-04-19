namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSCAMERA_EXTENDEDPROP_ROI_CONFIGCAPS
{
    public uint ControlId;
    public uint MaxNumberOfROIs;
    public ulong Capability;
}
