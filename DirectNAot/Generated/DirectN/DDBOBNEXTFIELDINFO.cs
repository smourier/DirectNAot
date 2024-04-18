namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-ddbobnextfieldinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct DDBOBNEXTFIELDINFO
{
    public nint lpSurface;
}
