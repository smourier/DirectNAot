#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSCAMERA_EXTENDEDPROP_ROI_ISPCONTROLHEADER
{
    public uint Size;
    public uint ControlCount;
    public ulong Reserved;
}
