#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3DVIEWPORT7
{
    public uint dwX;
    public uint dwY;
    public uint dwWidth;
    public uint dwHeight;
    public float dvMinZ;
    public float dvMaxZ;
}
