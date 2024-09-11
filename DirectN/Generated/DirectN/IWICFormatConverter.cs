#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicformatconverter
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("00000301-a8f2-4877-ba0a-fd2b6645fb94")]
public partial interface IWICFormatConverter : IWICBitmapSource
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicformatconverter-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICBitmapSource>))] IWICBitmapSource pISource, in Guid dstFormat, WICBitmapDitherType dither, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICPalette>))] IWICPalette pIPalette, double alphaThresholdPercent, WICBitmapPaletteType paletteTranslate);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicformatconverter-canconvert
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CanConvert(in Guid srcPixelFormat, in Guid dstPixelFormat, out BOOL pfCanConvert);
}
