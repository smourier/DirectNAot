#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicimagingfactory2
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("7b816b45-1996-4476-b132-de9e247c8af0")]
public partial interface IWICImagingFactory2 : IWICImagingFactory
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicimagingfactory2-createimageencoder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateImageEncoder(ID2D1Device pD2DDevice, out IWICImageEncoder ppWICImageEncoder);
}
