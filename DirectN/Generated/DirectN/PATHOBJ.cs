#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-pathobj
[StructLayout(LayoutKind.Sequential)]
public partial struct PATHOBJ
{
    public uint fl;
    public uint cCurves;
}
