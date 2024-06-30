#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-ddflipvideoportinfo
public partial struct DDFLIPVIDEOPORTINFO
{
    public nint lpVideoPortData;
    public nint lpCurrentSurface;
    public nint lpTargetSurface;
    public uint dwFlipVPFlags;
}
