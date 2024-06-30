#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-ddmocompbufferinfo
public partial struct DDMOCOMPBUFFERINFO
{
    public uint dwSize;
    public nint lpCompSurface;
    public uint dwDataOffset;
    public uint dwDataSize;
    public nint lpPrivate;
}
