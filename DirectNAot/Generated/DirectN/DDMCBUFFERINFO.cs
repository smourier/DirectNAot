namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDMCBUFFERINFO
{
    public uint dwSize;
    public nint lpCompSurface;
    public uint dwDataOffset;
    public uint dwDataSize;
    public nint lpPrivate;
}
