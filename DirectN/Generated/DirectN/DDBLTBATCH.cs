#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddraw/ns-ddraw-ddbltbatch
public partial struct DDBLTBATCH
{
    public nint lprDest;
    public nint lpDDSSrc;
    public nint lprSrc;
    public uint dwFlags;
    public nint lpDDBltFx;
}
