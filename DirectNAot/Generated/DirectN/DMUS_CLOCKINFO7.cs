namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DMUS_CLOCKINFO7
{
    public uint dwSize;
    public DMUS_CLOCKTYPE ctType;
    public Guid guidClock;
    public InlineArraySystemChar128 wszDescription;
}
