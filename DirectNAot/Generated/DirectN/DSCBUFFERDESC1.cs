namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DSCBUFFERDESC1
{
    public uint dwSize;
    public uint dwFlags;
    public uint dwBufferBytes;
    public uint dwReserved;
    public nint lpwfxFormat;
}
