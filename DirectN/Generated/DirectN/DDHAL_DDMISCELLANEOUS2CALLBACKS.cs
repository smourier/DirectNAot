#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_DDMISCELLANEOUS2CALLBACKS
{
    public uint dwSize;
    public uint dwFlags;
    public nint Reserved;
    public nint CreateSurfaceEx;
    public nint GetDriverState;
    public nint DestroyDDLocal;
}
