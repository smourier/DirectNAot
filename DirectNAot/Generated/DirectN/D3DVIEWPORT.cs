namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3DVIEWPORT
{
    public uint dwSize;
    public uint dwX;
    public uint dwY;
    public uint dwWidth;
    public uint dwHeight;
    public float dvScaleX;
    public float dvScaleY;
    public float dvMaxX;
    public float dvMaxY;
    public float dvMinZ;
    public float dvMaxZ;
}
