#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-ddflipoverlayinfo
public partial struct DDFLIPOVERLAYINFO
{
    public nint lpCurrentSurface;
    public nint lpTargetSurface;
    public uint dwFlags;
}
