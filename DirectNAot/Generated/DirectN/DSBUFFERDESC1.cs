#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DSBUFFERDESC1
{
    public uint dwSize;
    public uint dwFlags;
    public uint dwBufferBytes;
    public uint dwReserved;
    public nint lpwfxFormat;
}
