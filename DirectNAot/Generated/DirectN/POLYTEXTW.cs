namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-polytextw
[StructLayout(LayoutKind.Sequential)]
public partial struct POLYTEXTW
{
    public int x;
    public int y;
    public uint n;
    public PWSTR lpstr;
    public uint uiFlags;
    public FoundationRECT rcl;
    public nint pdx;
}
