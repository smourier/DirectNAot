namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ne-d3d11-d3d11_map
public enum D3D11_MAP
{
    D3D11_MAP_READ = 1,
    D3D11_MAP_WRITE = 2,
    D3D11_MAP_READ_WRITE = 3,
    D3D11_MAP_WRITE_DISCARD = 4,
    D3D11_MAP_WRITE_NO_OVERWRITE = 5,
}
