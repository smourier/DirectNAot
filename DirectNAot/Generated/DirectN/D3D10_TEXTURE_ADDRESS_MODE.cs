#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/ne-d3d10-d3d10_texture_address_mode
public enum D3D10_TEXTURE_ADDRESS_MODE
{
    D3D10_TEXTURE_ADDRESS_WRAP = 1,
    D3D10_TEXTURE_ADDRESS_MIRROR = 2,
    D3D10_TEXTURE_ADDRESS_CLAMP = 3,
    D3D10_TEXTURE_ADDRESS_BORDER = 4,
    D3D10_TEXTURE_ADDRESS_MIRROR_ONCE = 5,
}
