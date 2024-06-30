#nullable enable
namespace DirectN;

public partial struct SPVTEXTFRAG
{
    public nint pNext;
    public SPVSTATE State;
    public PWSTR pTextStart;
    public uint ulTextLen;
    public uint ulTextSrcOffset;
}
