namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_1/nn-dwrite_1-idwritebitmaprendertarget1
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("791e8298-3ef3-4230-9880-c9bdecc42064")]
public partial interface IDWriteBitmapRenderTarget1 : IDWriteBitmapRenderTarget
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritebitmaprendertarget1-gettextantialiasmode
    [PreserveSig]
    DWRITE_TEXT_ANTIALIAS_MODE GetTextAntialiasMode();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritebitmaprendertarget1-settextantialiasmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTextAntialiasMode(DWRITE_TEXT_ANTIALIAS_MODE antialiasMode);
}
