#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-xforml
[StructLayout(LayoutKind.Sequential)]
public partial struct XFORML
{
    public float eM11;
    public float eM12;
    public float eM21;
    public float eM22;
    public float eDx;
    public float eDy;
}
