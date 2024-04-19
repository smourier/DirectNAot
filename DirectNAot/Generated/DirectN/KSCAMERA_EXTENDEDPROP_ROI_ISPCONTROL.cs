namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSCAMERA_EXTENDEDPROP_ROI_ISPCONTROL
{
    public uint ControlId;
    public uint ROICount;
    public uint Result;
    public uint Reserved;
}
