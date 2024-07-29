#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicprogresscallback
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("4776f9cd-9517-45fa-bf24-e89c5ec5c60c")]
public partial interface IWICProgressCallback
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicprogresscallback-notify
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Notify(uint uFrameNum, WICProgressOperation operation, double dblProgress);
}
