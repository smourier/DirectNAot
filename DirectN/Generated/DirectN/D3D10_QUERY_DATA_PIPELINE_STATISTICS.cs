#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/ns-d3d10-d3d10_query_data_pipeline_statistics
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_QUERY_DATA_PIPELINE_STATISTICS
{
    public ulong IAVertices;
    public ulong IAPrimitives;
    public ulong VSInvocations;
    public ulong GSInvocations;
    public ulong GSPrimitives;
    public ulong CInvocations;
    public ulong CPrimitives;
    public ulong PSInvocations;
}
