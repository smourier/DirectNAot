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
    HRESULT Initialize([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICBitmapSource>))] IWICBitmapSource pIBitmapSource, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICColorContext>))] IWICColorContext pIContextSource, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICColorContext>))] IWICColorContext pIContextDest, in Guid pixelFmtDest);
}
