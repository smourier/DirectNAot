namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicbitmapdecoder
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("9edde9e7-8dee-47ea-99df-e6faf2ed44bf")]
public partial interface IWICBitmapDecoder
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapdecoder-querycapability
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT QueryCapability(IStream pIStream, out uint pdwCapability);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapdecoder-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Initialize(IStream pIStream, WICDecodeOptions cacheOptions);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapdecoder-getcontainerformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetContainerFormat(out Guid pguidContainerFormat);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapdecoder-getdecoderinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDecoderInfo(out IWICBitmapDecoderInfo ppIDecoderInfo);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapdecoder-copypalette
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CopyPalette(IWICPalette pIPalette);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapdecoder-getmetadataqueryreader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetMetadataQueryReader(out IWICMetadataQueryReader ppIMetadataQueryReader);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapdecoder-getpreview
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPreview(out IWICBitmapSource ppIBitmapSource);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapdecoder-getcolorcontexts
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetColorContexts(uint cCount, ref IWICColorContext ppIColorContexts, out uint pcActualCount);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapdecoder-getthumbnail
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetThumbnail(out IWICBitmapSource ppIThumbnail);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapdecoder-getframecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFrameCount(out uint pCount);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapdecoder-getframe
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFrame(uint index, out IWICBitmapFrameDecode ppIBitmapFrame);
}
