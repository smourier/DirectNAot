#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicbitmapencoder
[GeneratedComInterface, Guid("00000103-a8f2-4877-ba0a-fd2b6645fb94")]
public partial interface IWICBitmapEncoder
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapencoder-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream pIStream, WICBitmapEncoderCacheOption cacheOption);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapencoder-getcontainerformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetContainerFormat(out Guid pguidContainerFormat);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapencoder-getencoderinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEncoderInfo([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICBitmapEncoderInfo>))] out IWICBitmapEncoderInfo ppIEncoderInfo);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapencoder-setcolorcontexts
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetColorContexts(uint cCount, [In][MarshalUsing(CountElementName = nameof(cCount))] IWICColorContext[] ppIColorContext);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapencoder-setpalette
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPalette([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICPalette>))] IWICPalette pIPalette);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapencoder-setthumbnail
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetThumbnail([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICBitmapSource>))] IWICBitmapSource pIThumbnail);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapencoder-setpreview
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPreview([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICBitmapSource>))] IWICBitmapSource pIPreview);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapencoder-createnewframe
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateNewFrame([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICBitmapFrameEncode>))] out IWICBitmapFrameEncode ppIFrameEncode, ref IPropertyBag2 ppIEncoderOptions);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapencoder-commit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Commit();
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapencoder-getmetadataquerywriter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMetadataQueryWriter([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICMetadataQueryWriter>))] out IWICMetadataQueryWriter ppIMetadataQueryWriter);
}
