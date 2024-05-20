#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/ne-d3d10-d3d10_resource_misc_flag
public enum D3D10_RESOURCE_MISC_FLAG
{
    D3D10_RESOURCE_MISC_GENERATE_MIPS = 1,
    D3D10_RESOURCE_MISC_SHARED = 2,
    D3D10_RESOURCE_MISC_TEXTURECUBE = 4,
    D3D10_RESOURCE_MISC_SHARED_KEYEDMUTEX = 16,
    D3D10_RESOURCE_MISC_GDI_COMPATIBLE = 32,
}
