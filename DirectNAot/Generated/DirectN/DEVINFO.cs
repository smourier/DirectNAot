namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-devinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct DEVINFO
{
    public uint flGraphicsCaps;
    public LOGFONTW lfDefaultFont;
    public LOGFONTW lfAnsiVarFont;
    public LOGFONTW lfAnsiFixFont;
    public uint cFonts;
    public uint iDitherFormat;
    public ushort cxDither;
    public ushort cyDither;
    public HPALETTE hpalDefault;
    public uint flGraphicsCaps2;
}
