namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emr
[StructLayout(LayoutKind.Sequential)]
public partial struct EMR
{
    public ENHANCED_METAFILE_RECORD_TYPE iType;
    public uint nSize;
}
