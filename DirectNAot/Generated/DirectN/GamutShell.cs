namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wcsplugin/ns-wcsplugin-gamutshell
[StructLayout(LayoutKind.Sequential)]
public partial struct GamutShell
{
    public float JMin;
    public float JMax;
    public uint cVertices;
    public uint cTriangles;
    public nint pVertices;
    public nint pTriangles;
}
