#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_authenticated_configure_protection_input
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_AUTHENTICATED_CONFIGURE_PROTECTION_INPUT
{
    public D3D11_AUTHENTICATED_CONFIGURE_INPUT Parameters;
    public D3D11_AUTHENTICATED_PROTECTION_FLAGS Protections;
}
