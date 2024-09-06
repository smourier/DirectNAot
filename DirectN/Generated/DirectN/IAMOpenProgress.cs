#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamopenprogress
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("8e1c39a1-de53-11cf-aa63-0080c744528d")]
public partial interface IAMOpenProgress
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamopenprogress-queryprogress
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryProgress(out long pllTotal, out long pllCurrent);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamopenprogress-abortoperation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AbortOperation();
}
