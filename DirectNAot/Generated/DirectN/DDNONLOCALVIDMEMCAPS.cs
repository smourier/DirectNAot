#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDNONLOCALVIDMEMCAPS
{
    public uint dwSize;
    public uint dwNLVBCaps;
    public uint dwNLVBCaps2;
    public uint dwNLVBCKeyCaps;
    public uint dwNLVBFXCaps;
    public InlineArrayUInt328 dwNLVBRops;
}
