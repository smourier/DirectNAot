#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct ACMDRVFORMATSUGGEST
{
    public uint cbStruct;
    public uint fdwSuggest;
    public nint pwfxSrc;
    public uint cbwfxSrc;
    public nint pwfxDst;
    public uint cbwfxDst;
}
