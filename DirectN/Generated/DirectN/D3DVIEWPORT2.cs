#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3DVIEWPORT2
{
    public uint dwSize;
    public uint dwX;
    public uint dwY;
    public uint dwWidth;
    public uint dwHeight;
    public float dvClipX;
    public float dvClipY;
    public float dvClipWidth;
    public float dvClipHeight;
    public float dvMinZ;
    public float dvMaxZ;
}
