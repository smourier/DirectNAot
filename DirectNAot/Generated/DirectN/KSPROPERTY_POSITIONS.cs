namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_POSITIONS
{
    public long Current;
    public long Stop;
    public KS_SEEKING_FLAGS CurrentFlags;
    public KS_SEEKING_FLAGS StopFlags;
}
