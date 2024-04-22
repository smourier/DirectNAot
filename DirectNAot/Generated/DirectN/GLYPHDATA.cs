namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-glyphdata
[StructLayout(LayoutKind.Sequential)]
public partial struct GLYPHDATA
{
    public GLYPHDEF gdf;
    public uint hg;
    public int fxD;
    public int fxA;
    public int fxAB;
    public int fxInkTop;
    public int fxInkBottom;
    public RECTL rclInk;
    public POINTQF ptqD;
}
