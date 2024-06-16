#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmprealestate/nn-wmprealestate-iwmprenderconfig
[GeneratedComInterface, Guid("959506c1-0314-4ec5-9e61-8528db5e5478")]
public partial interface IWMPRenderConfig
{
    // https://learn.microsoft.com/windows/win32/api/wmprealestate/nf-wmprealestate-iwmprenderconfig-put_inproconly
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_inProcOnly(BOOL fInProc);
    
    // https://learn.microsoft.com/windows/win32/api/wmprealestate/nf-wmprealestate-iwmprenderconfig-get_inproconly
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_inProcOnly(ref BOOL pfInProc);
}
