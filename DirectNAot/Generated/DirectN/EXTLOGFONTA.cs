namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-extlogfonta
[StructLayout(LayoutKind.Sequential)]
public partial struct EXTLOGFONTA
{
    public LOGFONTA elfLogFont;
    public InlineArrayByte64 elfFullName;
    public InlineArrayByte32 elfStyle;
    public uint elfVersion;
    public uint elfStyleSize;
    public uint elfMatch;
    public uint elfReserved;
    public InlineArrayByte4 elfVendorId;
    public uint elfCulture;
    public PANOSE elfPanose;
}
