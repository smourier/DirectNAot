namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1bitmaprendertarget
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("2cd90695-12e2-11dc-9fed-001143a055f9")]
public partial interface ID2D1BitmapRenderTarget : ID2D1RenderTarget
{
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1bitmaprendertarget-getbitmap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBitmap(out ID2D1Bitmap bitmap);
}
