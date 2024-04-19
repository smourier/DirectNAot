namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSCAMERA_EXTENDEDPROP_ROI_CONFIGCAPSHEADER
{
    public uint Size;
    public uint ConfigCapCount;
    public ulong Reserved;
}
