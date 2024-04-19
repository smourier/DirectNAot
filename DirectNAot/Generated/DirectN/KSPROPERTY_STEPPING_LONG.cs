namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_STEPPING_LONG
{
    public uint SteppingDelta;
    public uint Reserved;
    public KSPROPERTY_BOUNDS_LONG Bounds;
}
