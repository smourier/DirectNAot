namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-ddsetstateininfo
[StructLayout(LayoutKind.Sequential)]
public partial struct DDSETSTATEININFO
{
    public nint lpSurfaceData;
    public nint lpVideoPortData;
}
