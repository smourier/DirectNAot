#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1gdiinteroprendertarget
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("e0db51c3-6f77-4bae-b3d5-e47509b35838")]
public partial interface ID2D1GdiInteropRenderTarget
{
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1gdiinteroprendertarget-getdc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDC(D2D1_DC_INITIALIZE_MODE mode, out HDC hdc);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1gdiinteroprendertarget-releasedc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseDC(nint /* optional RECT* */ update);
}
