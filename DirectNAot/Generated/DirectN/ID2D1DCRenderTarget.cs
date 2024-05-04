namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1dcrendertarget
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("1c51bc64-de61-46fd-9899-63a5d8f03950")]
public partial interface ID2D1DCRenderTarget : ID2D1RenderTarget
{
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1dcrendertarget-binddc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BindDC(HDC hDC, in RECT pSubRect);
}
