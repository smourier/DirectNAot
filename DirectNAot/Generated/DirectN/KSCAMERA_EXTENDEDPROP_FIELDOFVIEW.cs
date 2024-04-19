namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSCAMERA_EXTENDEDPROP_FIELDOFVIEW
{
    public uint NormalizedFocalLengthX;
    public uint NormalizedFocalLengthY;
    public uint Flag;
    public uint Reserved;
}
