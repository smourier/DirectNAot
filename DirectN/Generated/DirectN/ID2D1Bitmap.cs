#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1bitmap
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("a2296057-ea42-4099-983b-539fb6505426")]
public partial interface ID2D1Bitmap : ID2D1Image
{
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1bitmap-getsize
    [PreserveSig]
    D2D_SIZE_F GetSize();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1bitmap-getpixelsize
    [PreserveSig]
    D2D_SIZE_U GetPixelSize();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1bitmap-getpixelformat
    [PreserveSig]
    D2D1_PIXEL_FORMAT GetPixelFormat();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1bitmap-getdpi
    [PreserveSig]
    void GetDpi(out float dpiX, out float dpiY);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1bitmap-copyfrombitmap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CopyFromBitmap(nint /* optional D2D_POINT_2U* */ destPoint, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Bitmap>))] ID2D1Bitmap bitmap, nint /* optional D2D_RECT_U* */ srcRect);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1bitmap-copyfromrendertarget
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CopyFromRenderTarget(nint /* optional D2D_POINT_2U* */ destPoint, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1RenderTarget>))] ID2D1RenderTarget renderTarget, nint /* optional D2D_RECT_U* */ srcRect);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1bitmap-copyfrommemory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CopyFromMemory(nint /* optional D2D_RECT_U* */ dstRect, nint srcData, uint pitch);
}
