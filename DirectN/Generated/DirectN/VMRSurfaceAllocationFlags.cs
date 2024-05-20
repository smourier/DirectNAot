#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ne-strmif-vmrsurfaceallocationflags
public enum VMRSurfaceAllocationFlags
{
    AMAP_PIXELFORMAT_VALID = 1,
    AMAP_3D_TARGET = 2,
    AMAP_ALLOW_SYSMEM = 4,
    AMAP_FORCE_SYSMEM = 8,
    AMAP_DIRECTED_FLIP = 16,
    AMAP_DXVA_TARGET = 32,
}
