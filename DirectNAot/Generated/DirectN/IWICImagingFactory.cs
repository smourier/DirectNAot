namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicimagingfactory
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("ec5ec8a9-c395-4314-9c77-54d7a935ff70")]
public partial interface IWICImagingFactory
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicimagingfactory-createdecoderfromfilename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDecoderFromFilename(PWSTR wzFilename, nint /* optional Guid* */ pguidVendor, GENERIC_ACCESS_RIGHTS dwDesiredAccess, WICDecodeOptions metadataOptions, out IWICBitmapDecoder ppIDecoder);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicimagingfactory-createdecoderfromstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDecoderFromStream(IStream pIStream, in Guid pguidVendor, WICDecodeOptions metadataOptions, out IWICBitmapDecoder ppIDecoder);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicimagingfactory-createdecoderfromfilehandle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDecoderFromFileHandle(nuint hFile, in Guid pguidVendor, WICDecodeOptions metadataOptions, out IWICBitmapDecoder ppIDecoder);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicimagingfactory-createcomponentinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateComponentInfo(in Guid clsidComponent, out IWICComponentInfo ppIInfo);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicimagingfactory-createdecoder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDecoder(in Guid guidContainerFormat, in Guid pguidVendor, out IWICBitmapDecoder ppIDecoder);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicimagingfactory-createencoder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateEncoder(in Guid guidContainerFormat, in Guid pguidVendor, out IWICBitmapEncoder ppIEncoder);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicimagingfactory-createpalette
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePalette(out IWICPalette ppIPalette);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicimagingfactory-createformatconverter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFormatConverter(out IWICFormatConverter ppIFormatConverter);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicimagingfactory-createbitmapscaler
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateBitmapScaler(out IWICBitmapScaler ppIBitmapScaler);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicimagingfactory-createbitmapclipper
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateBitmapClipper(out IWICBitmapClipper ppIBitmapClipper);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicimagingfactory-createbitmapfliprotator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateBitmapFlipRotator(out IWICBitmapFlipRotator ppIBitmapFlipRotator);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicimagingfactory-createstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateStream(out IWICStream ppIWICStream);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicimagingfactory-createcolorcontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateColorContext(out IWICColorContext ppIWICColorContext);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicimagingfactory-createcolortransformer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateColorTransformer(out IWICColorTransform ppIWICColorTransform);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicimagingfactory-createbitmap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateBitmap(uint uiWidth, uint uiHeight, in Guid pixelFormat, WICBitmapCreateCacheOption option, out IWICBitmap ppIBitmap);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicimagingfactory-createbitmapfromsource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateBitmapFromSource(IWICBitmapSource pIBitmapSource, WICBitmapCreateCacheOption option, out IWICBitmap ppIBitmap);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicimagingfactory-createbitmapfromsourcerect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateBitmapFromSourceRect(IWICBitmapSource pIBitmapSource, uint x, uint y, uint width, uint height, out IWICBitmap ppIBitmap);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicimagingfactory-createbitmapfrommemory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateBitmapFromMemory(uint uiWidth, uint uiHeight, in Guid pixelFormat, uint cbStride, uint cbBufferSize, nint /* byte array */ pbBuffer, out IWICBitmap ppIBitmap);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicimagingfactory-createbitmapfromhbitmap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateBitmapFromHBITMAP(HBITMAP hBitmap, HPALETTE hPalette, WICBitmapAlphaChannelOption options, out IWICBitmap ppIBitmap);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicimagingfactory-createbitmapfromhicon
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateBitmapFromHICON(HICON hIcon, out IWICBitmap ppIBitmap);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicimagingfactory-createcomponentenumerator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateComponentEnumerator(uint componentTypes, uint options, out IEnumUnknown ppIEnumUnknown);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicimagingfactory-createfastmetadataencoderfromdecoder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFastMetadataEncoderFromDecoder(IWICBitmapDecoder pIDecoder, out IWICFastMetadataEncoder ppIFastEncoder);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicimagingfactory-createfastmetadataencoderfromframedecode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFastMetadataEncoderFromFrameDecode(IWICBitmapFrameDecode pIFrameDecoder, out IWICFastMetadataEncoder ppIFastEncoder);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicimagingfactory-createquerywriter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateQueryWriter(in Guid guidMetadataFormat, in Guid pguidVendor, out IWICMetadataQueryWriter ppIQueryWriter);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicimagingfactory-createquerywriterfromreader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateQueryWriterFromReader(IWICMetadataQueryReader pIQueryReader, in Guid pguidVendor, out IWICMetadataQueryWriter ppIQueryWriter);
}
