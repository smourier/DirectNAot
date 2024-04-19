namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct AVIINDEXENTRY
{
    public uint ckid;
    public uint dwFlags;
    public uint dwChunkOffset;
    public uint dwChunkLength;
}
