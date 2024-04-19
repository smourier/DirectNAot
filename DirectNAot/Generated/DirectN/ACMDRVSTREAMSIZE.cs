namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct ACMDRVSTREAMSIZE
{
    public uint cbStruct;
    public uint fdwSize;
    public uint cbSrcLength;
    public uint cbDstLength;
}
