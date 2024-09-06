#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamoviesetup
[GeneratedComInterface, Guid("a3d8cec0-7e5a-11cf-bbc5-00805f6cef20")]
public partial interface IAMovieSetup
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamoviesetup-register
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Register();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamoviesetup-unregister
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unregister();
}
