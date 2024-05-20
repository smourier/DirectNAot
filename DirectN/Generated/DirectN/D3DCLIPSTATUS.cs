#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3DCLIPSTATUS
{
    public uint dwFlags;
    public uint dwStatus;
    public float minx;
    public float maxx;
    public float miny;
    public float maxy;
    public float minz;
    public float maxz;
}
