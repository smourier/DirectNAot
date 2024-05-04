#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DMUS_WAVEDATA
{
    public uint cbSize;
    public InlineArrayByte4 byData;
}
