#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-fd_xform
[StructLayout(LayoutKind.Sequential)]
public partial struct FD_XFORM
{
    public float eXX;
    public float eXY;
    public float eYX;
    public float eYY;
}
