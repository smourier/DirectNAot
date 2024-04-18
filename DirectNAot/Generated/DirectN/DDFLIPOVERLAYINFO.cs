namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-ddflipoverlayinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct DDFLIPOVERLAYINFO
{
    public nint lpCurrentSurface;
    public nint lpTargetSurface;
    public uint dwFlags;
}
