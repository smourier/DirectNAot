#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-glyphpos
[StructLayout(LayoutKind.Sequential)]
public partial struct GLYPHPOS
{
    public uint hg;
    public nint pgdf;
    public POINTL ptl;
}
