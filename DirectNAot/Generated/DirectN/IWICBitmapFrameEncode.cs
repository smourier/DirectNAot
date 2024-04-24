namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicbitmapframeencode
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("00000105-a8f2-4877-ba0a-fd2b6645fb94")]
public partial interface IWICBitmapFrameEncode
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapframeencode-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(IPropertyBag2 pIEncoderOptions);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapframeencode-setsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSize(uint uiWidth, uint uiHeight);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapframeencode-setresolution
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetResolution(double dpiX, double dpiY);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapframeencode-setpixelformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPixelFormat(ref Guid pPixelFormat);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapframeencode-setcolorcontexts
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetColorContexts(uint cCount, [MarshalUsing(CountElementName = nameof(cCount))] in IWICColorContext[] ppIColorContext);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapframeencode-setpalette
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPalette(IWICPalette pIPalette);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapframeencode-setthumbnail
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetThumbnail(IWICBitmapSource pIThumbnail);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapframeencode-writepixels
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WritePixels(uint lineCount, uint cbStride, uint cbBufferSize, nint /* byte array */ pbPixels);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapframeencode-writesource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WriteSource(IWICBitmapSource pIBitmapSource, in WICRect prc);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapframeencode-commit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Commit();
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapframeencode-getmetadataquerywriter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMetadataQueryWriter(out IWICMetadataQueryWriter ppIMetadataQueryWriter);
}
