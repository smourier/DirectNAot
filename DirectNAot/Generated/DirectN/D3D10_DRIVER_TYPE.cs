namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10misc/ne-d3d10misc-d3d10_driver_type
public enum D3D10_DRIVER_TYPE
{
    D3D10_DRIVER_TYPE_HARDWARE = 0,
    D3D10_DRIVER_TYPE_REFERENCE = 1,
    D3D10_DRIVER_TYPE_NULL = 2,
    D3D10_DRIVER_TYPE_SOFTWARE = 3,
    D3D10_DRIVER_TYPE_WARP = 5,
}
