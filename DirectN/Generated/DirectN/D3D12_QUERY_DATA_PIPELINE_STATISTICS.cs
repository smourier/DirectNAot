#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_query_data_pipeline_statistics
public partial struct D3D12_QUERY_DATA_PIPELINE_STATISTICS
{
    public ulong IAVertices;
    public ulong IAPrimitives;
    public ulong VSInvocations;
    public ulong GSInvocations;
    public ulong GSPrimitives;
    public ulong CInvocations;
    public ulong CPrimitives;
    public ulong PSInvocations;
    public ulong HSInvocations;
    public ulong DSInvocations;
    public ulong CSInvocations;
}
