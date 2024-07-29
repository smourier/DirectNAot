#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamcopycapturefileprogress
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("670d1d20-a068-11d0-b3f0-00aa003761c5")]
public partial interface IAMCopyCaptureFileProgress
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamcopycapturefileprogress-progress
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Progress(int iProgress);
}
