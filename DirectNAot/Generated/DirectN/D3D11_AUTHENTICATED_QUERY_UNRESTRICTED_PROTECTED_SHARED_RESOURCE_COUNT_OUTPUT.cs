namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_authenticated_query_unrestricted_protected_shared_resource_count_output
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_AUTHENTICATED_QUERY_UNRESTRICTED_PROTECTED_SHARED_RESOURCE_COUNT_OUTPUT
{
    public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;
    public uint UnrestrictedProtectedSharedResourceCount;
}
