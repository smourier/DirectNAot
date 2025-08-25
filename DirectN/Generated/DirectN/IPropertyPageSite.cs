#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/nn-ocidl-ipropertypagesite
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("b196b28c-bab4-101a-b69c-00aa00341d07")]
public partial interface IPropertyPageSite
{
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipropertypagesite-onstatuschange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnStatusChange(uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipropertypagesite-getlocaleid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLocaleID(out uint pLocaleID);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipropertypagesite-getpagecontainer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPageContainer(out nint ppUnk);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipropertypagesite-translateaccelerator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TranslateAccelerator(in MSG pMsg);
}
