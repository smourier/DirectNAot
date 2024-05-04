#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DMUS_COPYRIGHT
{
    public uint cbSize;
    public InlineArrayByte4 byCopyright;
}
