#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DD_MORECAPS
{
    public uint dwSize;
    public uint dwAlphaCaps;
    public uint dwSVBAlphaCaps;
    public uint dwVSBAlphaCaps;
    public uint dwSSBAlphaCaps;
    public uint dwFilterCaps;
    public uint dwSVBFilterCaps;
    public uint dwVSBFilterCaps;
    public uint dwSSBFilterCaps;
}
