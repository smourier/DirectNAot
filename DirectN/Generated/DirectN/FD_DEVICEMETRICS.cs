#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-fd_devicemetrics
[StructLayout(LayoutKind.Sequential)]
public partial struct FD_DEVICEMETRICS
{
    public uint flRealizedType;
    public POINTE pteBase;
    public POINTE pteSide;
    public int lD;
    public int fxMaxAscender;
    public int fxMaxDescender;
    public POINTL ptlUnderline1;
    public POINTL ptlStrikeOut;
    public POINTL ptlULThickness;
    public POINTL ptlSOThickness;
    public uint cxMax;
    public uint cyMax;
    public uint cjGlyphMax;
    public FD_XFORM fdxQuantized;
    public int lNonLinearExtLeading;
    public int lNonLinearIntLeading;
    public int lNonLinearMaxCharWidth;
    public int lNonLinearAvgCharWidth;
    public int lMinA;
    public int lMinC;
    public int lMinD;
    public InlineArrayInt32_1 alReserved; // variable-length array placeholder
}
