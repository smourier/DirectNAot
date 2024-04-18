namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_authenticated_query_restricted_shared_resource_process_output
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_AUTHENTICATED_QUERY_RESTRICTED_SHARED_RESOURCE_PROCESS_OUTPUT
{
    public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;
    public uint ProcessIndex;
    public D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE ProcessIdentifier;
    public HANDLE ProcessHandle;
}
