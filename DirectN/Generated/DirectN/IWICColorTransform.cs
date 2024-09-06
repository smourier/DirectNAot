#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwiccolortransform
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("b66f034f-d0e2-40ab-b436-6de39e321a94")]
public partial interface IWICColorTransform : IWICBitmapSource
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwiccolortransform-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(IWICBitmapSource pIBitmapSource, IWICColorContext pIContextSource, IWICColorContext pIContextDest, in Guid pixelFmtDest);
}
