#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ifilesinkfilter
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("a2104830-7c70-11cf-8bce-00aa00a3f1a6")]
public partial interface IFileSinkFilter
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ifilesinkfilter-setfilename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFileName(PWSTR pszFileName, nint /* optional AM_MEDIA_TYPE* */ pmt);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ifilesinkfilter-getcurfile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurFile(out PWSTR ppszFileName, out AM_MEDIA_TYPE pmt);
}
