namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BRIGHTNESS_NIT_RANGE
{
    public uint MinLevelInMillinit;
    public uint MaxLevelInMillinit;
    public uint StepSizeInMillinit;
}
