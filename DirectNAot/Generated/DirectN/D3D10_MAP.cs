namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/ne-d3d10-d3d10_map
public enum D3D10_MAP
{
    D3D10_MAP_READ = 1,
    D3D10_MAP_WRITE = 2,
    D3D10_MAP_READ_WRITE = 3,
    D3D10_MAP_WRITE_DISCARD = 4,
    D3D10_MAP_WRITE_NO_OVERWRITE = 5,
}
