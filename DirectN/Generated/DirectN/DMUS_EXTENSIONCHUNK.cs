#nullable enable
namespace DirectN;

public partial struct DMUS_EXTENSIONCHUNK
{
    public uint cbSize;
    public uint ulNextExtCkIdx;
    public uint ExtCkID;
    public InlineArrayByte_4 byExtCk;
}
