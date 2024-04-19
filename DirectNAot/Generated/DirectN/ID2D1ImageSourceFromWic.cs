namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/nn-d2d1_3-id2d1imagesourcefromwic
[GeneratedComInterface, Guid("77395441-1c8f-4555-8683-f50dab0fe792")]
public partial interface ID2D1ImageSourceFromWic : ID2D1ImageSource
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1imagesourcefromwic-ensurecached(constd2d1_rect_u_)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnsureCached(nint/* nint */ rectangleToFill);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1imagesourcefromwic-trimcache(constd2d1_rect_u)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TrimCache(nint/* nint */ rectangleToPreserve);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1imagesourcefromwic-getsource
    [PreserveSig]
    void GetSource(out IWICBitmapSource wicBitmapSource);
}
