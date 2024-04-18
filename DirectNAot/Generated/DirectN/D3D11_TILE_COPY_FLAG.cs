namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_2/ne-d3d11_2-d3d11_tile_copy_flag
public enum D3D11_TILE_COPY_FLAG
{
    D3D11_TILE_COPY_NO_OVERWRITE = 1,
    D3D11_TILE_COPY_LINEAR_BUFFER_TO_SWIZZLED_TILED_RESOURCE = 2,
    D3D11_TILE_COPY_SWIZZLED_TILED_RESOURCE_TO_LINEAR_BUFFER = 4,
}
