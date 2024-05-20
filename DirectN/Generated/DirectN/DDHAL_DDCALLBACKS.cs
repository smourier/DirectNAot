#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_DDCALLBACKS
{
    public uint dwSize;
    public uint dwFlags;
    public nint DestroyDriver;
    public nint CreateSurface;
    public nint SetColorKey;
    public nint SetMode;
    public nint WaitForVerticalBlank;
    public nint CanCreateSurface;
    public nint CreatePalette;
    public nint GetScanLine;
    public nint SetExclusiveMode;
    public nint FlipToGDISurface;
}
