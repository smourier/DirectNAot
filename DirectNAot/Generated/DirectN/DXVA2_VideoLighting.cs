#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva2api/ne-dxva2api-dxva2_videolighting
public enum DXVA2_VideoLighting
{
    DXVA2_VideoLightingMask = 15,
    DXVA2_VideoLighting_Unknown = 0,
    DXVA2_VideoLighting_bright = 1,
    DXVA2_VideoLighting_office = 2,
    DXVA2_VideoLighting_dim = 3,
    DXVA2_VideoLighting_dark = 4,
}
