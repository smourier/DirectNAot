namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-gcp_resultsw
[StructLayout(LayoutKind.Sequential)]
public partial struct GCP_RESULTSW
{
    public uint lStructSize;
    public PWSTR lpOutString;
    public nint lpOrder;
    public nint lpDx;
    public nint lpCaretPos;
    public PSTR lpClass;
    public PWSTR lpGlyphs;
    public uint nGlyphs;
    public int nMaxFit;
}
