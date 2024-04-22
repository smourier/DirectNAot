namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-ttpolygonheader
[StructLayout(LayoutKind.Sequential)]
public partial struct TTPOLYGONHEADER
{
    public uint cb;
    public uint dwType;
    public POINTFX pfxStart;
}
