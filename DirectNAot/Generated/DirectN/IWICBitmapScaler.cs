#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicbitmapscaler
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("00000302-a8f2-4877-ba0a-fd2b6645fb94")]
public partial interface IWICBitmapScaler : IWICBitmapSource
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapscaler-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(IWICBitmapSource pISource, uint uiWidth, uint uiHeight, WICBitmapInterpolationMode mode);
}
