namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-gdiinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct GDIINFO
{
    public uint ulVersion;
    public uint ulTechnology;
    public uint ulHorzSize;
    public uint ulVertSize;
    public uint ulHorzRes;
    public uint ulVertRes;
    public uint cBitsPixel;
    public uint cPlanes;
    public uint ulNumColors;
    public uint flRaster;
    public uint ulLogPixelsX;
    public uint ulLogPixelsY;
    public uint flTextCaps;
    public uint ulDACRed;
    public uint ulDACGreen;
    public uint ulDACBlue;
    public uint ulAspectX;
    public uint ulAspectY;
    public uint ulAspectXY;
    public int xStyleStep;
    public int yStyleStep;
    public int denStyleStep;
    public POINTL ptlPhysOffset;
    public FoundationSIZE szlPhysSize;
    public uint ulNumPalReg;
    public COLORINFO ciDevice;
    public uint ulDevicePelsDPI;
    public uint ulPrimaryOrder;
    public uint ulHTPatternSize;
    public uint ulHTOutputFormat;
    public uint flHTFlags;
    public uint ulVRefresh;
    public uint ulBltAlignment;
    public uint ulPanningHorzRes;
    public uint ulPanningVertRes;
    public uint xPanningAlignment;
    public uint yPanningAlignment;
    public uint cxHTPat;
    public uint cyHTPat;
    public nint pHTPatA;
    public nint pHTPatB;
    public nint pHTPatC;
    public uint flShadeBlend;
    public uint ulPhysicalPixelCharacteristics;
    public uint ulPhysicalPixelGamma;
}
