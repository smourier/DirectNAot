#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3DSTATUS
{
    public uint dwFlags;
    public uint dwStatus;
    public D3DRECT drExtent;
}
