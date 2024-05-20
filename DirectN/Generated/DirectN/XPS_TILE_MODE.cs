#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/ne-xpsobjectmodel-xps_tile_mode
public enum XPS_TILE_MODE
{
    XPS_TILE_MODE_NONE = 1,
    XPS_TILE_MODE_TILE = 2,
    XPS_TILE_MODE_FLIPX = 3,
    XPS_TILE_MODE_FLIPY = 4,
    XPS_TILE_MODE_FLIPXY = 5,
}
