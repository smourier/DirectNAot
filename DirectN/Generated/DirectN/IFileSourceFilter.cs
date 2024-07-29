#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ifilesourcefilter
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56a868a6-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IFileSourceFilter
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ifilesourcefilter-load
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Load(PWSTR pszFileName, nint /* optional AM_MEDIA_TYPE* */ pmt);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ifilesourcefilter-getcurfile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurFile(out PWSTR ppszFileName, nint /* optional AM_MEDIA_TYPE* */ pmt);
}
