#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_query_data_so_statistics
public partial struct D3D12_QUERY_DATA_SO_STATISTICS
{
    public ulong NumPrimitivesWritten;
    public ulong PrimitivesStorageNeeded;
}
