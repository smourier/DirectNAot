#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmpservices/nn-wmpservices-iwmpplugin
[GeneratedComInterface, Guid("f1392a70-024c-42bb-a998-73dfdfe7d5a7")]
public partial interface IWMPPlugin
{
    // https://learn.microsoft.com/windows/win32/api/wmpservices/nf-wmpservices-iwmpplugin-init
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Init(nuint dwPlaybackContext);
    
    // https://learn.microsoft.com/windows/win32/api/wmpservices/nf-wmpservices-iwmpplugin-shutdown
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Shutdown();
    
    // https://learn.microsoft.com/windows/win32/api/wmpservices/nf-wmpservices-iwmpplugin-getid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetID(ref Guid pGUID);
    
    // https://learn.microsoft.com/windows/win32/api/wmpservices/nf-wmpservices-iwmpplugin-getcaps
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCaps(ref uint pdwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/wmpservices/nf-wmpservices-iwmpplugin-advisewmpservices
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AdviseWMPServices(IWMPServices pWMPServices);
    
    // https://learn.microsoft.com/windows/win32/api/wmpservices/nf-wmpservices-iwmpplugin-unadvisewmpservices
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnAdviseWMPServices();
}
