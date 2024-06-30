#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_authenticated_configure_shared_resource_input
public partial struct D3D11_AUTHENTICATED_CONFIGURE_SHARED_RESOURCE_INPUT
{
    public D3D11_AUTHENTICATED_CONFIGURE_INPUT Parameters;
    public D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE ProcessType;
    public HANDLE ProcessHandle;
    public BOOL AllowAccess;
}
