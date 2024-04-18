namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HEAPALIASINFO
{
    public uint dwRefCnt;
    public uint dwFlags;
    public uint dwNumHeaps;
    public nint lpAliases;
}
