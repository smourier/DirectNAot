#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DMUS_CLOCKINFO8
{
    public uint dwSize;
    public DMUS_CLOCKTYPE ctType;
    public Guid guidClock;
    public InlineArraySystemChar128 wszDescription;
    public uint dwFlags;
}
