#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/nn-ocidl-iperpropertybrowsing
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("376bd3aa-3845-101b-84ed-08002b2ec713")]
public partial interface IPerPropertyBrowsing
{
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iperpropertybrowsing-getdisplaystring
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDisplayString(int dispID, out BSTR pBstr);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iperpropertybrowsing-mappropertytopage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MapPropertyToPage(int dispID, out Guid pClsid);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iperpropertybrowsing-getpredefinedstrings
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPredefinedStrings(int dispID, out CALPOLESTR pCaStringsOut, out CADWORD pCaCookiesOut);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iperpropertybrowsing-getpredefinedvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPredefinedValue(int dispID, uint dwCookie, out VARIANT pVarOut);
}
