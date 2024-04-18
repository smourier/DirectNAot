namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_query_data_so_statistics
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_QUERY_DATA_SO_STATISTICS
{
    public ulong NumPrimitivesWritten;
    public ulong PrimitivesStorageNeeded;
}
