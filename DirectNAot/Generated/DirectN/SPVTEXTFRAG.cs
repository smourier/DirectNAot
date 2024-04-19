namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPVTEXTFRAG
{
    public nint pNext;
    public SPVSTATE State;
    public PWSTR pTextStart;
    public uint ulTextLen;
    public uint ulTextSrcOffset;
}
