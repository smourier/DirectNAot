#nullable enable
namespace DirectN;

public partial struct DSBUFFERDESC
{
    public uint dwSize;
    public uint dwFlags;
    public uint dwBufferBytes;
    public uint dwReserved;
    public nint lpwfxFormat;
    public Guid guid3DAlgorithm;
}
