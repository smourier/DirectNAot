namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-extlogfontw
[StructLayout(LayoutKind.Sequential)]
public partial struct EXTLOGFONTW
{
    public LOGFONTW elfLogFont;
    public InlineArraySystemChar64 elfFullName;
    public InlineArraySystemChar32 elfStyle;
    public uint elfVersion;
    public uint elfStyleSize;
    public uint elfMatch;
    public uint elfReserved;
    public InlineArrayByte4 elfVendorId;
    public uint elfCulture;
    public PANOSE elfPanose;
}
