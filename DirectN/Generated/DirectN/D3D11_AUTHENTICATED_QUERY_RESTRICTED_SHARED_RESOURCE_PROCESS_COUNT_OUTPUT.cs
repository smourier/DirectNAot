#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_authenticated_query_restricted_shared_resource_process_count_output
public partial struct D3D11_AUTHENTICATED_QUERY_RESTRICTED_SHARED_RESOURCE_PROCESS_COUNT_OUTPUT
{
    public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;
    public uint RestrictedSharedResourceProcessCount;
}
