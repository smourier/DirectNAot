#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ne-d3d11-d3d11_clear_flag
[Flags]
public enum D3D11_CLEAR_FLAG : uint
{
    D3D11_CLEAR_DEPTH = 1,
    D3D11_CLEAR_STENCIL = 2,
}
