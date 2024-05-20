#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/ns-dwrite-dwrite_cluster_metrics
[StructLayout(LayoutKind.Sequential)]
public partial struct DWRITE_CLUSTER_METRICS
{
    public float width;
    public ushort length;
    public ushort _bitfield;
}
