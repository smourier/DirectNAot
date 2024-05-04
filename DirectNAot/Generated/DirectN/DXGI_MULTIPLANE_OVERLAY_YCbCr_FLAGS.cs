#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_3/ne-dxgi1_3-dxgi_multiplane_overlay_ycbcr_flags
public enum DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS
{
    DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAG_NOMINAL_RANGE = 1,
    DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAG_BT709 = 2,
    DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAG_xvYCC = 4,
}
