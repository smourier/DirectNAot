#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct AVIEXTHEADER
{
    public uint fcc;
    public uint cb;
    public uint dwGrandFrames;
    public InlineArrayUInt32_61 dwFuture;
}
