#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_query_data_timestamp_disjoint
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_QUERY_DATA_TIMESTAMP_DISJOINT
{
    public ulong Frequency;
    public BOOL Disjoint;
}
