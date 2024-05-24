#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct ACMDRVSTREAMSIZE
{
    public uint cbStruct;
    public uint fdwSize;
    public uint cbSrcLength;
    public uint cbDstLength;
}
