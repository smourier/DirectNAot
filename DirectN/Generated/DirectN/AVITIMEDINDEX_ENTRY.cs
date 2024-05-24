#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public partial struct AVITIMEDINDEX_ENTRY
{
    public uint dwOffset;
    public uint dwSize;
    public uint dwDuration;
}
