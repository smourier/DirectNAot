#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicbitmapclipper
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("e4fbcf03-223d-4e81-9333-d635556dd1b5")]
public partial interface IWICBitmapClipper : IWICBitmapSource
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapclipper-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(IWICBitmapSource pISource, in WICRect prc);
}
