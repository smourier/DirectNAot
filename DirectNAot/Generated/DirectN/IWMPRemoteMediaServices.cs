#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpremotemediaservices
[GeneratedComInterface, Guid("cbb92747-741f-44fe-ab5b-f1a48f3b2a59")]
public partial interface IWMPRemoteMediaServices
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpremotemediaservices-getservicetype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetServiceType(ref BSTR pbstrType);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpremotemediaservices-getapplicationname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetApplicationName(ref BSTR pbstrName);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpremotemediaservices-getscriptableobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetScriptableObject(ref BSTR pbstrName, out IDispatch ppDispatch);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpremotemediaservices-getcustomuimode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCustomUIMode(ref BSTR pbstrFile);
}
