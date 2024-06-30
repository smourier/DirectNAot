#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_callbacks
public partial struct DD_CALLBACKS
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
    public nint MapMemory;
}
