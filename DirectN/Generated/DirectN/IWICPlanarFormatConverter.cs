#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicplanarformatconverter
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("bebee9cb-83b0-4dcc-8132-b0aaa55eac96")]
public partial interface IWICPlanarFormatConverter : IWICBitmapSource
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicplanarformatconverter-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize([In][MarshalUsing(CountElementName = nameof(cPlanes))] IWICBitmapSource[] ppPlanes, uint cPlanes, in Guid dstFormat, WICBitmapDitherType dither, IWICPalette pIPalette, double alphaThresholdPercent, WICBitmapPaletteType paletteTranslate);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicplanarformatconverter-canconvert
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CanConvert([In][MarshalUsing(CountElementName = nameof(cSrcPlanes))] Guid[] pSrcPixelFormats, uint cSrcPlanes, in Guid dstPixelFormat, [MarshalAs(UnmanagedType.U4)] out bool pfCanConvert);
}
