namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-polytexta
[StructLayout(LayoutKind.Sequential)]
public partial struct POLYTEXTA
{
    public int x;
    public int y;
    public uint n;
    public PSTR lpstr;
    public uint uiFlags;
    public FoundationRECT rcl;
    public nint pdx;
}
