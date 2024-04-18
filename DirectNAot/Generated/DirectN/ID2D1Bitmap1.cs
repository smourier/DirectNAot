namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_1/nn-d2d1_1-id2d1bitmap1
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("a898a84c-3873-4588-b08b-ebbf978df041")]
public partial interface ID2D1Bitmap1 : ID2D1Bitmap
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1bitmap1-getcolorcontext
    [PreserveSig]
    public void GetColorContext(out ID2D1ColorContext colorContext);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1bitmap1-getoptions
    [PreserveSig]
    public D2D1_BITMAP_OPTIONS GetOptions();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1bitmap1-getsurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetSurface(out IDXGISurface dxgiSurface);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1bitmap1-map
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Map(D2D1_MAP_OPTIONS options, out D2D1_MAPPED_RECT mappedRect);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1bitmap1-unmap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Unmap();
}
