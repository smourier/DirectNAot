#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_miscellaneous2callbacks
public partial struct DD_MISCELLANEOUS2CALLBACKS
{
    public uint dwSize;
    public uint dwFlags;
    public nint AlphaBlt;
    public nint CreateSurfaceEx;
    public nint GetDriverState;
    public nint DestroyDDLocal;
}
