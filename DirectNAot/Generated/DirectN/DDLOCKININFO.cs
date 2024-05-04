#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-ddlockininfo
[StructLayout(LayoutKind.Sequential)]
public partial struct DDLOCKININFO
{
    public nint lpSurfaceData;
}
