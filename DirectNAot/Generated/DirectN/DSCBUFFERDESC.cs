namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DSCBUFFERDESC
{
    public uint dwSize;
    public uint dwFlags;
    public uint dwBufferBytes;
    public uint dwReserved;
    public nint lpwfxFormat;
    public uint dwFXCount;
    public nint lpDSCFXDesc;
}
