#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ne-d3d11-d3d11_authenticated_channel_type
public enum D3D11_AUTHENTICATED_CHANNEL_TYPE
{
    D3D11_AUTHENTICATED_CHANNEL_D3D11 = 1,
    D3D11_AUTHENTICATED_CHANNEL_DRIVER_SOFTWARE = 2,
    D3D11_AUTHENTICATED_CHANNEL_DRIVER_HARDWARE = 3,
}
