#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_surfacecallbacks
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_SURFACECALLBACKS
{
    public uint dwSize;
    public uint dwFlags;
    public nint DestroySurface;
    public nint Flip;
    public nint SetClipList;
    public nint Lock;
    public nint Unlock;
    public nint Blt;
    public nint SetColorKey;
    public nint AddAttachedSurface;
    public nint GetBltStatus;
    public nint GetFlipStatus;
    public nint UpdateOverlay;
    public nint SetOverlayPosition;
    public nint reserved4;
    public nint SetPalette;
}
