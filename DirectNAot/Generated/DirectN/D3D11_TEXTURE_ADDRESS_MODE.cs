namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ne-d3d11-d3d11_texture_address_mode
public enum D3D11_TEXTURE_ADDRESS_MODE
{
    D3D11_TEXTURE_ADDRESS_WRAP = 1,
    D3D11_TEXTURE_ADDRESS_MIRROR = 2,
    D3D11_TEXTURE_ADDRESS_CLAMP = 3,
    D3D11_TEXTURE_ADDRESS_BORDER = 4,
    D3D11_TEXTURE_ADDRESS_MIRROR_ONCE = 5,
}
