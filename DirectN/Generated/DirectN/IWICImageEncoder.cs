#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicimageencoder
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("04c75bf8-3ce1-473b-acc5-3cc4f5e94999")]
public partial interface IWICImageEncoder
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicimageencoder-writeframe
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WriteFrame(ID2D1Image pImage, IWICBitmapFrameEncode pFrameEncode, in WICImageParameters pImageParameters);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicimageencoder-writeframethumbnail
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WriteFrameThumbnail(ID2D1Image pImage, IWICBitmapFrameEncode pFrameEncode, in WICImageParameters pImageParameters);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicimageencoder-writethumbnail
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WriteThumbnail(ID2D1Image pImage, IWICBitmapEncoder pEncoder, in WICImageParameters pImageParameters);
}
