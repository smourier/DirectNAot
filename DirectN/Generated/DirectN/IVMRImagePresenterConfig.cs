#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ivmrimagepresenterconfig
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("9f3a1c85-8555-49ba-935f-be5b5b29d178")]
public partial interface IVMRImagePresenterConfig
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrimagepresenterconfig-setrenderingprefs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRenderingPrefs(uint dwRenderFlags);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrimagepresenterconfig-getrenderingprefs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRenderingPrefs(out uint dwRenderFlags);
}
