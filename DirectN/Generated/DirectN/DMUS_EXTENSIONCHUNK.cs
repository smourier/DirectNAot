#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DMUS_EXTENSIONCHUNK
{
    public uint cbSize;
    public uint ulNextExtCkIdx;
    public uint ExtCkID;
    public InlineArrayByte_4 byExtCk;
}
