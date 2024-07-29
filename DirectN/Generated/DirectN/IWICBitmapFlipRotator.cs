#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicbitmapfliprotator
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("5009834f-2d6a-41ce-9e1b-17c5aff7a782")]
public partial interface IWICBitmapFlipRotator : IWICBitmapSource
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapfliprotator-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(IWICBitmapSource pISource, WICBitmapTransformOptions options);
}
