#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public partial struct RIFFCHUNK
{
    public uint fcc;
    public uint cb;
}
