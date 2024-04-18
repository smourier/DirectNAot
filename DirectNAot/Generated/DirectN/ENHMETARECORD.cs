namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-enhmetarecord
[StructLayout(LayoutKind.Sequential)]
public partial struct ENHMETARECORD
{
    public ENHANCED_METAFILE_RECORD_TYPE iType;
    public uint nSize;
    public InlineArrayUInt321 dParm; // variable-length array placeholder
}
