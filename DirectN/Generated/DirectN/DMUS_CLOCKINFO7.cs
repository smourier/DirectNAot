#nullable enable
namespace DirectN;

public partial struct DMUS_CLOCKINFO7
{
    public uint dwSize;
    public DMUS_CLOCKTYPE ctType;
    public Guid guidClock;
    public InlineArraySystemChar_128 wszDescription;
}
